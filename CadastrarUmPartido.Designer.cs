namespace TrabalhoPOO
{
    partial class CadastrarUmPartido
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
            this.btnVer = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnZona = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnPartido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Black;
            this.btnVer.Location = new System.Drawing.Point(20, 51);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(181, 34);
            this.btnVer.TabIndex = 0;
            this.btnVer.Text = "Vereador";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPre.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.Black;
            this.btnPre.Location = new System.Drawing.Point(253, 51);
            this.btnPre.Margin = new System.Windows.Forms.Padding(4);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(181, 34);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "Prefeito";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnZona
            // 
            this.btnZona.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZona.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZona.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZona.ForeColor = System.Drawing.Color.Black;
            this.btnZona.Location = new System.Drawing.Point(20, 124);
            this.btnZona.Margin = new System.Windows.Forms.Padding(4);
            this.btnZona.Name = "btnZona";
            this.btnZona.Size = new System.Drawing.Size(181, 34);
            this.btnZona.TabIndex = 2;
            this.btnZona.Text = "Zona";
            this.btnZona.UseVisualStyleBackColor = false;
            this.btnZona.Click += new System.EventHandler(this.btnZona_Click);
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSec.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSec.ForeColor = System.Drawing.Color.Black;
            this.btnSec.Location = new System.Drawing.Point(253, 124);
            this.btnSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(181, 34);
            this.btnSec.TabIndex = 3;
            this.btnSec.Text = "Seção";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPartido
            // 
            this.btnPartido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPartido.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartido.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartido.ForeColor = System.Drawing.Color.Black;
            this.btnPartido.Location = new System.Drawing.Point(132, 196);
            this.btnPartido.Margin = new System.Windows.Forms.Padding(4);
            this.btnPartido.Name = "btnPartido";
            this.btnPartido.Size = new System.Drawing.Size(181, 34);
            this.btnPartido.TabIndex = 4;
            this.btnPartido.Text = "Partido";
            this.btnPartido.UseVisualStyleBackColor = false;
            this.btnPartido.Click += new System.EventHandler(this.btnPartido_Click);
            // 
            // CadastrarUmPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 281);
            this.Controls.Add(this.btnPartido);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnZona);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnVer);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastrarUmPartido";
            this.Text = "Cadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnZona;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnPartido;
    }
}