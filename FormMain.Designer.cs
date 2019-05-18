namespace TrabalhoPOO
{
    partial class FormMain
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
            this.btnCadastros = new System.Windows.Forms.Button();
            this.btnVotacao = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastros.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.Black;
            this.btnCadastros.Location = new System.Drawing.Point(100, 46);
            this.btnCadastros.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(181, 34);
            this.btnCadastros.TabIndex = 5;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.btnPartido_Click);
            // 
            // btnVotacao
            // 
            this.btnVotacao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVotacao.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotacao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotacao.ForeColor = System.Drawing.Color.Black;
            this.btnVotacao.Location = new System.Drawing.Point(97, 119);
            this.btnVotacao.Margin = new System.Windows.Forms.Padding(4);
            this.btnVotacao.Name = "btnVotacao";
            this.btnVotacao.Size = new System.Drawing.Size(181, 34);
            this.btnVotacao.TabIndex = 6;
            this.btnVotacao.Text = "Votação";
            this.btnVotacao.UseVisualStyleBackColor = false;
            this.btnVotacao.Click += new System.EventHandler(this.btnVotacao_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(100, 196);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(181, 34);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 273);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnVotacao);
            this.Controls.Add(this.btnCadastros);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Button btnVotacao;
        private System.Windows.Forms.Button btnFechar;
    }
}