
namespace CursoWindowsForms
{
    partial class F_HelloWorld
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_ModificaLabel = new System.Windows.Forms.Button();
            this.tb_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lb_Titulo.Location = new System.Drawing.Point(30, 30);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(213, 19);
            this.lb_Titulo.TabIndex = 0;
            this.lb_Titulo.Text = "Visual Studio .NET Version";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(250, 265);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(150, 23);
            this.btn_Sair.TabIndex = 1;
            this.btn_Sair.Text = "Fechar a aplicação";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_ModificaLabel
            // 
            this.btn_ModificaLabel.Location = new System.Drawing.Point(34, 52);
            this.btn_ModificaLabel.Name = "btn_ModificaLabel";
            this.btn_ModificaLabel.Size = new System.Drawing.Size(209, 23);
            this.btn_ModificaLabel.TabIndex = 2;
            this.btn_ModificaLabel.Text = "Modifica Texto do Label";
            this.btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.btn_ModificaLabel.Click += new System.EventHandler(this.btn_ModificaLabel_Click);
            // 
            // tb_ConteudoLabel
            // 
            this.tb_ConteudoLabel.Location = new System.Drawing.Point(34, 81);
            this.tb_ConteudoLabel.Name = "tb_ConteudoLabel";
            this.tb_ConteudoLabel.Size = new System.Drawing.Size(311, 20);
            this.tb_ConteudoLabel.TabIndex = 3;
            // 
            // F_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 300);
            this.Controls.Add(this.tb_ConteudoLabel);
            this.Controls.Add(this.btn_ModificaLabel);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lb_Titulo);
            this.Name = "F_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_ModificaLabel;
        private System.Windows.Forms.TextBox tb_ConteudoLabel;
    }
}

