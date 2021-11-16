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
    public partial class F_DemonstracaoKey : Form
    {
        public F_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void tb_Input_KeyDown(object sender, KeyEventArgs e)
        {
            tb_Msg.AppendText("\r\n" + "Pressionei a tecla: " + e.KeyCode + "\r\n");
            tb_Msg.AppendText("\t" + "Código da tecla: " + ((int)e.KeyCode) + "\r\n");
            tb_Msg.AppendText("\r\n" + "Nome da tecla: " + e.KeyData + "\r\n");
            lb_Lower.Text = e.KeyCode.ToString().ToLower();
            lb_Upper.Text = e.KeyCode.ToString().ToUpper();

            tb_Msg.Text = "";
            tb_Input.Text = "";
            lb_Lower.Text = "";
            lb_Upper.Text = "";
        }
    }
}
