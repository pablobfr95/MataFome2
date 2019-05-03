namespace MataFome2
{
    partial class TelaMotoqueiro
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
            this.cadmotobtn = new System.Windows.Forms.Button();
            this.motoevendabtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadmotobtn
            // 
            this.cadmotobtn.Location = new System.Drawing.Point(12, 21);
            this.cadmotobtn.Name = "cadmotobtn";
            this.cadmotobtn.Size = new System.Drawing.Size(283, 47);
            this.cadmotobtn.TabIndex = 0;
            this.cadmotobtn.Text = "CADASTRAR MOTOQUEIRO";
            this.cadmotobtn.UseVisualStyleBackColor = true;
            this.cadmotobtn.Click += new System.EventHandler(this.cadmotobtn_Click);
            // 
            // motoevendabtn
            // 
            this.motoevendabtn.Location = new System.Drawing.Point(12, 74);
            this.motoevendabtn.Name = "motoevendabtn";
            this.motoevendabtn.Size = new System.Drawing.Size(283, 47);
            this.motoevendabtn.TabIndex = 1;
            this.motoevendabtn.Text = "ASSOCIAR MOTOQUEIRO / VENDA";
            this.motoevendabtn.UseVisualStyleBackColor = true;
            this.motoevendabtn.Click += new System.EventHandler(this.motoevendabtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "RELATÓRIO MOTOQUEIRO / DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaMotoqueiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.motoevendabtn);
            this.Controls.Add(this.cadmotobtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 344);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(325, 344);
            this.Name = "TelaMotoqueiro";
            this.Text = "Motoqueiro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadmotobtn;
        private System.Windows.Forms.Button motoevendabtn;
        private System.Windows.Forms.Button button1;
    }
}