using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class F_ValidaCPF2 : Form
    {
        public F_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            msk_CPF.Text = "";
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {

            string vConteudo;
            vConteudo = msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();

            if (vConteudo == "")
            {
                MessageBox.Show("Você deve digitar um CPF", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF deve possuir 11 digitos", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        bool validaCPF = false;
                        validaCPF = Cls_Uteis.Valida(msk_CPF.Text);

                        if (validaCPF == true)
                        {
                            MessageBox.Show("CPF VÁLIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("CPF INVÁLIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
