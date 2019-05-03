namespace MataFome2
{
    partial class TelaCadUsu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nivel2checkBox2 = new System.Windows.Forms.CheckBox();
            this.nivel1checkBox1 = new System.Windows.Forms.CheckBox();
            this.confsenhatxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.senhatxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelAcessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mataFomeDataSet1 = new MataFome2.MataFomeDataSet1();
            this.usuariosTableAdapter = new MataFome2.MataFomeDataSet1TableAdapters.UsuariosTableAdapter();
            this.salvarbutton1 = new System.Windows.Forms.Button();
            this.attbutton2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.confsenhatxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.senhatxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nometxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuários:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nivel2checkBox2);
            this.groupBox2.Controls.Add(this.nivel1checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(9, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nivel de Usuário";
            // 
            // nivel2checkBox2
            // 
            this.nivel2checkBox2.AutoSize = true;
            this.nivel2checkBox2.Location = new System.Drawing.Point(144, 23);
            this.nivel2checkBox2.Name = "nivel2checkBox2";
            this.nivel2checkBox2.Size = new System.Drawing.Size(138, 21);
            this.nivel2checkBox2.TabIndex = 1;
            this.nivel2checkBox2.Text = "2 - Administrador";
            this.nivel2checkBox2.UseVisualStyleBackColor = true;
            this.nivel2checkBox2.CheckedChanged += new System.EventHandler(this.nivel2checkBox2_CheckedChanged);
            // 
            // nivel1checkBox1
            // 
            this.nivel1checkBox1.AutoSize = true;
            this.nivel1checkBox1.Location = new System.Drawing.Point(6, 23);
            this.nivel1checkBox1.Name = "nivel1checkBox1";
            this.nivel1checkBox1.Size = new System.Drawing.Size(113, 21);
            this.nivel1checkBox1.TabIndex = 0;
            this.nivel1checkBox1.Text = "1 - Vendedor";
            this.nivel1checkBox1.UseVisualStyleBackColor = true;
            this.nivel1checkBox1.CheckedChanged += new System.EventHandler(this.nivel1checkBox1_CheckedChanged);
            // 
            // confsenhatxt
            // 
            this.confsenhatxt.Location = new System.Drawing.Point(130, 89);
            this.confsenhatxt.Name = "confsenhatxt";
            this.confsenhatxt.Size = new System.Drawing.Size(190, 22);
            this.confsenhatxt.TabIndex = 5;
            this.confsenhatxt.UseSystemPasswordChar = true;
            this.confsenhatxt.TextChanged += new System.EventHandler(this.confsenhatxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar Senha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // senhatxt
            // 
            this.senhatxt.Location = new System.Drawing.Point(61, 59);
            this.senhatxt.Name = "senhatxt";
            this.senhatxt.Size = new System.Drawing.Size(190, 22);
            this.senhatxt.TabIndex = 3;
            this.senhatxt.UseSystemPasswordChar = true;
            this.senhatxt.TextChanged += new System.EventHandler(this.senhatxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // nometxt
            // 
            this.nometxt.Location = new System.Drawing.Point(61, 31);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(190, 22);
            this.nometxt.TabIndex = 1;
            this.nometxt.TextChanged += new System.EventHandler(this.nometxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.nivelAcessoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(367, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivelAcessoDataGridViewTextBoxColumn
            // 
            this.nivelAcessoDataGridViewTextBoxColumn.DataPropertyName = "NivelAcesso";
            this.nivelAcessoDataGridViewTextBoxColumn.HeaderText = "NivelAcesso";
            this.nivelAcessoDataGridViewTextBoxColumn.Name = "nivelAcessoDataGridViewTextBoxColumn";
            this.nivelAcessoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.mataFomeDataSet1;
            // 
            // mataFomeDataSet1
            // 
            this.mataFomeDataSet1.DataSetName = "MataFomeDataSet1";
            this.mataFomeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // salvarbutton1
            // 
            this.salvarbutton1.Location = new System.Drawing.Point(27, 371);
            this.salvarbutton1.Name = "salvarbutton1";
            this.salvarbutton1.Size = new System.Drawing.Size(138, 50);
            this.salvarbutton1.TabIndex = 2;
            this.salvarbutton1.Text = "SALVAR";
            this.salvarbutton1.UseVisualStyleBackColor = true;
            this.salvarbutton1.Click += new System.EventHandler(this.salvarbutton1_Click);
            // 
            // attbutton2
            // 
            this.attbutton2.Location = new System.Drawing.Point(208, 371);
            this.attbutton2.Name = "attbutton2";
            this.attbutton2.Size = new System.Drawing.Size(138, 50);
            this.attbutton2.TabIndex = 3;
            this.attbutton2.Text = "ATUALIZAR";
            this.attbutton2.UseVisualStyleBackColor = true;
            this.attbutton2.Click += new System.EventHandler(this.attbutton2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "* CAMPOS OBRIGATÓRIOS";
            // 
            // TelaCadUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.attbutton2);
            this.Controls.Add(this.salvarbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadUsu";
            this.Text = "Cadastrar Usuário";
            this.Load += new System.EventHandler(this.TelaCadUsu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox confsenhatxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senhatxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox nivel2checkBox2;
        private System.Windows.Forms.CheckBox nivel1checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MataFomeDataSet1 mataFomeDataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private MataFomeDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelAcessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button salvarbutton1;
        private System.Windows.Forms.Button attbutton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
    }
}