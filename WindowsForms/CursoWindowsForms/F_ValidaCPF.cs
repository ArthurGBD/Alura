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
    public partial class F_ValidaCPF : Form
    {
        public F_ValidaCPF()
        {
            InitializeComponent();
        }
            
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lb_Resultado.Text = "";
            msk_CPF.Text = "";
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCPF = false;
            validaCPF = Cls_Uteis.Valida(msk_CPF.Text);

            if (validaCPF == true)
            {
                lb_Resultado.Text = "CPF VÁLIDO";
                lb_Resultado.ForeColor = Color.Green;
            }

            else
            {
                lb_Resultado.Text = "CPF INVÁLIDO";
                lb_Resultado.ForeColor = Color.Red;
            }
        }
    }
}
