namespace MataFome2
{
    partial class TelaCadastroFormaPagamento
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
            this.nomeformatextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mataFomeDataSet1 = new MataFome2.MataFomeDataSet1();
            this.formaPagamentosTableAdapter = new MataFome2.MataFomeDataSet1TableAdapters.FormaPagamentosTableAdapter();
            this.salvarbutton1 = new System.Windows.Forms.Button();
            this.attbutton2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nomeformatextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Pagamento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nomeformatextBox1
            // 
            this.nomeformatextBox1.Location = new System.Drawing.Point(61, 26);
            this.nomeformatextBox1.Name = "nomeformatextBox1";
            this.nomeformatextBox1.Size = new System.Drawing.Size(294, 22);
            this.nomeformatextBox1.TabIndex = 1;
            this.nomeformatextBox1.TextChanged += new System.EventHandler(this.nomeformatextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
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
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.formaPagamentosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(402, 155);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaPagamentosBindingSource
            // 
            this.formaPagamentosBindingSource.DataMember = "FormaPagamentos";
            this.formaPagamentosBindingSource.DataSource = this.mataFomeDataSet1;
            // 
            // mataFomeDataSet1
            // 
            this.mataFomeDataSet1.DataSetName = "MataFomeDataSet1";
            this.mataFomeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formaPagamentosTableAdapter
            // 
            this.formaPagamentosTableAdapter.ClearBeforeFill = true;
            // 
            // salvarbutton1
            // 
            this.salvarbutton1.Location = new System.Drawing.Point(12, 288);
            this.salvarbutton1.Name = "salvarbutton1";
            this.salvarbutton1.Size = new System.Drawing.Size(160, 54);
            this.salvarbutton1.TabIndex = 2;
            this.salvarbutton1.Text = "SALVAR";
            this.salvarbutton1.UseVisualStyleBackColor = true;
            this.salvarbutton1.Click += new System.EventHandler(this.salvarbutton1_Click);
            // 
            // attbutton2
            // 
            this.attbutton2.Location = new System.Drawing.Point(254, 288);
            this.attbutton2.Name = "attbutton2";
            this.attbutton2.Size = new System.Drawing.Size(160, 54);
            this.attbutton2.TabIndex = 3;
            this.attbutton2.Text = "ATUALIZAR";
            this.attbutton2.UseVisualStyleBackColor = true;
            this.attbutton2.Click += new System.EventHandler(this.attbutton2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "* CAMPOS OBRIGATÓRIOS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "*";
            // 
            // TelaCadastroFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 354);
            this.Controls.Add(this.attbutton2);
            this.Controls.Add(this.salvarbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroFormaPagamento";
            this.Text = "Cadastrar Forma de Pagamento";
            this.Load += new System.EventHandler(this.TelaCadastroFormaPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nomeformatextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MataFomeDataSet1 mataFomeDataSet1;
        private System.Windows.Forms.BindingSource formaPagamentosBindingSource;
        private MataFomeDataSet1TableAdapters.FormaPagamentosTableAdapter formaPagamentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button salvarbutton1;
        private System.Windows.Forms.Button attbutton2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
    }
}