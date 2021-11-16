
namespace CursoWindowsForms
{
    partial class F_DemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_DemonstracaoKey));
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.tb_Msg = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lb_Minus = new System.Windows.Forms.Label();
            this.lb_Maius = new System.Windows.Forms.Label();
            this.lb_Upper = new System.Windows.Forms.Label();
            this.lb_Lower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(8, 8);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(100, 20);
            this.tb_Input.TabIndex = 0;
            this.tb_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Input_KeyDown);
            // 
            // tb_Msg
            // 
            this.tb_Msg.Location = new System.Drawing.Point(8, 40);
            this.tb_Msg.Multiline = true;
            this.tb_Msg.Name = "tb_Msg";
            this.tb_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Msg.Size = new System.Drawing.Size(304, 232);
            this.tb_Msg.TabIndex = 1;
            this.tb_Msg.TabStop = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(328, 8);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 28);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Limpa";
            this.btn_Reset.UseVisualStyleBackColor = true;
            // 
            // lb_Minus
            // 
            this.lb_Minus.AutoSize = true;
            this.lb_Minus.Location = new System.Drawing.Point(320, 104);
            this.lb_Minus.Name = "lb_Minus";
            this.lb_Minus.Size = new System.Drawing.Size(38, 13);
            this.lb_Minus.TabIndex = 3;
            this.lb_Minus.Text = "Minus.";
            // 
            // lb_Maius
            // 
            this.lb_Maius.AutoSize = true;
            this.lb_Maius.Location = new System.Drawing.Point(320, 56);
            this.lb_Maius.Name = "lb_Maius";
            this.lb_Maius.Size = new System.Drawing.Size(38, 13);
            this.lb_Maius.TabIndex = 4;
            this.lb_Maius.Text = "Maius.";
            // 
            // lb_Upper
            // 
            this.lb_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Upper.Location = new System.Drawing.Point(368, 56);
            this.lb_Upper.Name = "lb_Upper";
            this.lb_Upper.Size = new System.Drawing.Size(32, 23);
            this.lb_Upper.TabIndex = 5;
            // 
            // lb_Lower
            // 
            this.lb_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Lower.Location = new System.Drawing.Point(368, 104);
            this.lb_Lower.Name = "lb_Lower";
            this.lb_Lower.Size = new System.Drawing.Size(32, 23);
            this.lb_Lower.TabIndex = 6;
            // 
            // F_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 286);
            this.Controls.Add(this.lb_Lower);
            this.Controls.Add(this.lb_Upper);
            this.Controls.Add(this.lb_Maius);
            this.Controls.Add(this.lb_Minus);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.tb_Msg);
            this.Controls.Add(this.tb_Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_DemonstracaoKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DemonstracaoKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.TextBox tb_Msg;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lb_Minus;
        private System.Windows.Forms.Label lb_Maius;
        private System.Windows.Forms.Label lb_Upper;
        private System.Windows.Forms.Label lb_Lower;
    }
}