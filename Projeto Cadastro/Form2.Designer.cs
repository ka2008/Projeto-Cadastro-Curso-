
namespace Projeto_Cadastro
{
    partial class Frm_Resultado
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
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Resultado2 = new System.Windows.Forms.Label();
            this.Lbl_Confirmacao_de_Dados2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Voltar.Location = new System.Drawing.Point(407, 17);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(88, 23);
            this.Btn_Voltar.TabIndex = 47;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_Resultado2
            // 
            this.Lbl_Resultado2.AutoSize = true;
            this.Lbl_Resultado2.Font = new System.Drawing.Font("Meiryo", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado2.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Resultado2.Location = new System.Drawing.Point(239, 46);
            this.Lbl_Resultado2.Name = "Lbl_Resultado2";
            this.Lbl_Resultado2.Size = new System.Drawing.Size(65, 17);
            this.Lbl_Resultado2.TabIndex = 46;
            this.Lbl_Resultado2.Text = "Resultado";
            this.Lbl_Resultado2.Click += new System.EventHandler(this.Lbl_Resultado_Click);
            // 
            // Lbl_Confirmacao_de_Dados2
            // 
            this.Lbl_Confirmacao_de_Dados2.AutoSize = true;
            this.Lbl_Confirmacao_de_Dados2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Confirmacao_de_Dados2.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Confirmacao_de_Dados2.Location = new System.Drawing.Point(240, 23);
            this.Lbl_Confirmacao_de_Dados2.Name = "Lbl_Confirmacao_de_Dados2";
            this.Lbl_Confirmacao_de_Dados2.Size = new System.Drawing.Size(152, 12);
            this.Lbl_Confirmacao_de_Dados2.TabIndex = 45;
            this.Lbl_Confirmacao_de_Dados2.Text = "Confirmação dos Dados";
            // 
            // Frm_Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Resultado2);
            this.Controls.Add(this.Lbl_Confirmacao_de_Dados2);
            this.Name = "Frm_Resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Resultado_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Resultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Btn_Voltar;
        public System.Windows.Forms.Label Lbl_Resultado2;
        public System.Windows.Forms.Label Lbl_Confirmacao_de_Dados2;
    }
}