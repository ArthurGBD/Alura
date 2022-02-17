using ByteBank.Core.Model;
using ByteBank.Core.Repository;
using ByteBank.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ByteBank.View
{
    public partial class MainWindow : Window
    {
        private readonly ContaClienteRepository r_Repositorio;
        private readonly ContaClienteService r_Servico;

        public MainWindow()
        {
            InitializeComponent();

            r_Repositorio = new ContaClienteRepository();
            r_Servico = new ContaClienteService();
        }

        private async void BtnProcessar_Click(object sender, RoutedEventArgs e)
        {
            //var taskSchedulerUI = TaskScheduler.FromCurrentSynchronizationContext();
            BtnProcessar.IsEnabled = false;

            var contas = r_Repositorio.GetContaClientes();


            AtualizarView(new List<string>(), TimeSpan.Zero);

            var inicio = DateTime.Now;

            var resultado = await ConsolidarContas(contas);

            var fim = DateTime.Now;
            AtualizarView(resultado, fim - inicio);
            BtnProcessar.IsEnabled = true;

            Task.Factory.StartNew(() =>
{
                var context = TaskScheduler.FromCurrentSynchronizationContext();
                Task.Factory.StartNew(() => CalculaRaiz(100))
.ContinueWith(t => btnCalcular.IsEnabled = true, context);
                 });
        }

        private async Task<string[]> ConsolidarContas(IEnumerable<ContaCliente> contas)
        {
            var resultado = new List<string>();

            var tasks = contas.Select(conta =>
               Task.Factory.StartNew(() => r_Servico.ConsolidarMovimentacao(conta)));
            
            return await Task.WhenAll(tasks);
        }

        private void AtualizarView(IEnumerable<String> result, TimeSpan elapsedTime)
        {
            var tempoDecorrido = $"{ elapsedTime.Seconds }.{ elapsedTime.Milliseconds} segundos!";
            var mensagem = $"Processamento de {result.Count()} clientes em {tempoDecorrido}";

            LstResultados.ItemsSource = result;
            TxtTempo.Text = mensagem;
        }
    }
}

/*


            //var contasQuantidadePorThread = contas.Count() / 4;

            //var contas_parte1 = contas.Take(contasQuantidadePorThread);
            //var contas_parte2 = contas.Skip(contasQuantidadePorThread).Take(contasQuantidadePorThread);
            //var contas_parte3 = contas.Skip(contasQuantidadePorThread*2).Take(contasQuantidadePorThread);
            //var contas_parte4 = contas.Skip(contasQuantidadePorThread*3);

            //Thread thread_parte1 = new Thread(() =>
            //{
            //    foreach (var conta in contas_parte1)
            //    {
            //        var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
            //        resultado.Add(resultadoProcessamento);
            //    }
            //});
            //Thread thread_parte2 = new Thread(() =>
            //{
            //    foreach (var conta in contas_parte2)
            //    {
            //        var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
            //        resultado.Add(resultadoProcessamento);
            //    }
            //});
            //Thread thread_parte3 = new Thread(() =>
            //{
            //    foreach (var conta in contas_parte3)
            //    {
            //        var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
            //        resultado.Add(resultadoProcessamento);
            //    }
            //});
            //Thread thread_parte4 = new Thread(() =>
            //{
            //    foreach (var conta in contas_parte4)
            //    {
            //        var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
            //        resultado.Add(resultadoProcessamento);
            //    }
            //});

            //thread_parte1.Start();
            //thread_parte2.Start();
            //thread_parte3.Start();
            //thread_parte4.Start();

            //while (thread_parte1.IsAlive || thread_parte2.IsAlive
            //    || thread_parte3.IsAlive || thread_parte4.IsAlive )
            //{
            //    Thread.Sleep(250);
            //    //Não vou fazer nada
            //} 

 */
