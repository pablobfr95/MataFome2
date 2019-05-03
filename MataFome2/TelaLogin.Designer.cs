namespace MataFome2
{
    partial class TelaLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuariotxt = new MetroFramework.Controls.MetroTextBox();
            this.senhatxt = new MetroFramework.Controls.MetroTextBox();
            this.loginButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MataFome2.Properties.Resources.mata_fome_petisco;
            this.pictureBox1.Location = new System.Drawing.Point(10, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usuariotxt
            // 
            // 
            // 
            // 
            this.usuariotxt.CustomButton.Image = null;
            this.usuariotxt.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.usuariotxt.CustomButton.Name = "";
            this.usuariotxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usuariotxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usuariotxt.CustomButton.TabIndex = 1;
            this.usuariotxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usuariotxt.CustomButton.UseSelectable = true;
            this.usuariotxt.CustomButton.Visible = false;
            this.usuariotxt.Lines = new string[0];
            this.usuariotxt.Location = new System.Drawing.Point(37, 245);
            this.usuariotxt.MaxLength = 20;
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.PasswordChar = '\0';
            this.usuariotxt.PromptText = "Usuário:";
            this.usuariotxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usuariotxt.SelectedText = "";
            this.usuariotxt.SelectionLength = 0;
            this.usuariotxt.SelectionStart = 0;
            this.usuariotxt.ShortcutsEnabled = true;
            this.usuariotxt.Size = new System.Drawing.Size(262, 23);
            this.usuariotxt.TabIndex = 1;
            this.usuariotxt.UseSelectable = true;
            this.usuariotxt.WaterMark = "Usuário:";
            this.usuariotxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usuariotxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.usuariotxt.Click += new System.EventHandler(this.usuariotxt_Click);
            // 
            // senhatxt
            // 
            // 
            // 
            // 
            this.senhatxt.CustomButton.Image = null;
            this.senhatxt.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.senhatxt.CustomButton.Name = "";
            this.senhatxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.senhatxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.senhatxt.CustomButton.TabIndex = 1;
            this.senhatxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.senhatxt.CustomButton.UseSelectable = true;
            this.senhatxt.CustomButton.Visible = false;
            this.senhatxt.Lines = new string[0];
            this.senhatxt.Location = new System.Drawing.Point(37, 288);
            this.senhatxt.MaxLength = 30;
            this.senhatxt.Name = "senhatxt";
            this.senhatxt.PasswordChar = '●';
            this.senhatxt.PromptText = "Senha:";
            this.senhatxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.senhatxt.SelectedText = "";
            this.senhatxt.SelectionLength = 0;
            this.senhatxt.SelectionStart = 0;
            this.senhatxt.ShortcutsEnabled = true;
            this.senhatxt.Size = new System.Drawing.Size(262, 23);
            this.senhatxt.TabIndex = 2;
            this.senhatxt.UseSelectable = true;
            this.senhatxt.UseSystemPasswordChar = true;
            this.senhatxt.WaterMark = "Senha:";
            this.senhatxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.senhatxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.senhatxt.Click += new System.EventHandler(this.senhatxt_Click);
            this.senhatxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.senhatxt_KeyPress);
            // 
            // loginButton1
            // 
            this.loginButton1.Location = new System.Drawing.Point(54, 344);
            this.loginButton1.Name = "loginButton1";
            this.loginButton1.Size = new System.Drawing.Size(212, 60);
            this.loginButton1.TabIndex = 3;
            this.loginButton1.Text = "LOGIN";
            this.loginButton1.UseSelectable = true;
            this.loginButton1.Click += new System.EventHandler(this.loginButton1_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.loginButton1);
            this.Controls.Add(this.senhatxt);
            this.Controls.Add(this.usuariotxt);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLogin";
            this.Text = "TelaLogin";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox usuariotxt;
        private MetroFramework.Controls.MetroTextBox senhatxt;
        private MetroFramework.Controls.MetroButton loginButton1;
    }
}