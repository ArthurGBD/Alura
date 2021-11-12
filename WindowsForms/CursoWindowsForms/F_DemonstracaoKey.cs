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
            tb_Msg.AppendText("\r\n");
        }
    }
}
