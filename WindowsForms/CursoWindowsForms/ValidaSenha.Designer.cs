
namespace CursoWindowsForms
{
    partial class F_ValidaSenha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ValidaSenha));
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_VerSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Senha
            // 
            this.tb_Senha.Font = new System.Drawing.Font("Arial", 8.25F);
            this.tb_Senha.Location = new System.Drawing.Point(12, 45);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.PasswordChar = '*';
            this.tb_Senha.Size = new System.Drawing.Size(218, 20);
            this.tb_Senha.TabIndex = 0;
            this.tb_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Senha_KeyDown);
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lb_Resultado.Location = new System.Drawing.Point(12, 90);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lb_Resultado.TabIndex = 1;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(245, 42);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(111, 23);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Limpa";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_VerSenha
            // 
            this.btn_VerSenha.Location = new System.Drawing.Point(245, 71);
            this.btn_VerSenha.Name = "btn_VerSenha";
            this.btn_VerSenha.Size = new System.Drawing.Size(111, 23);
            this.btn_VerSenha.TabIndex = 3;
            this.btn_VerSenha.Text = "Ver Senha";
            this.btn_VerSenha.UseVisualStyleBackColor = true;
            this.btn_VerSenha.Click += new System.EventHandler(this.btn_VerSenha_Click);
            // 
            // F_ValidaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.btn_VerSenha);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.tb_Senha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_ValidaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.Label lb_Resultado;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_VerSenha;
    }
}