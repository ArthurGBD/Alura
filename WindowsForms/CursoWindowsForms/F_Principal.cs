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
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void btn_DemonstracaoKey_Click(object sender, EventArgs e)
        {
            F_DemonstracaoKey f = new F_DemonstracaoKey();
            f.ShowDialog(); 
        }

        private void btn_HelloWorld_Click(object sender, EventArgs e)
        {
            F_HelloWorld f = new F_HelloWorld();
            f.ShowDialog();
        }

        private void btn_Mascara_Click(object sender, EventArgs e)
        {
            F_Mascara f = new F_Mascara();
            f.ShowDialog();
        }

        private void btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            F_ValidaCPF f = new F_ValidaCPF();
            f.ShowDialog();
        }

        private void btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            F_ValidaCPF2 f = new F_ValidaCPF2();
            f.ShowDialog();
        }

        private void btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            F_ValidaSenha f = new F_ValidaSenha();
            f.ShowDialog();
        }
    }
}
