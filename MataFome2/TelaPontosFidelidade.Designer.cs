namespace MataFome2
{
    partial class TelaPontosFidelidade
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
            this.qtdepontostxt = new System.Windows.Forms.TextBox();
            this.descricaoprodutotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.produtosFidelidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosFidelidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salvarbutton1 = new System.Windows.Forms.Button();
            this.attbuton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosFidelidadesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mataFomeDataSet4 = new MataFome2.MataFomeDataSet4();
            this.produtosFidelidadesTableAdapter = new MataFome2.MataFomeDataSet4TableAdapters.ProdutosFidelidadesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosFidelidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosFidelidadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosFidelidadesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qtdepontostxt);
            this.groupBox1.Controls.Add(this.descricaoprodutotxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto Fidelidade";
            // 
            // qtdepontostxt
            // 
            this.qtdepontostxt.Location = new System.Drawing.Point(259, 73);
            this.qtdepontostxt.MaxLength = 3;
            this.qtdepontostxt.Name = "qtdepontostxt";
            this.qtdepontostxt.Size = new System.Drawing.Size(50, 22);
            this.qtdepontostxt.TabIndex = 3;
            this.qtdepontostxt.TextChanged += new System.EventHandler(this.qtdepontostxt_TextChanged);
            this.qtdepontostxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtdepontostxt_KeyPress);
            // 
            // descricaoprodutotxt
            // 
            this.descricaoprodutotxt.Location = new System.Drawing.Point(96, 27);
            this.descricaoprodutotxt.Name = "descricaoprodutotxt";
            this.descricaoprodutotxt.Size = new System.Drawing.Size(391, 22);
            this.descricaoprodutotxt.TabIndex = 2;
            this.descricaoprodutotxt.TextChanged += new System.EventHandler(this.descricaoprodutotxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de Pontos Necessários:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // produtosFidelidadesBindingSource
            // 
            this.produtosFidelidadesBindingSource.DataMember = "ProdutosFidelidades";
            // 
            // produtosFidelidadesBindingSource1
            // 
            this.produtosFidelidadesBindingSource1.DataMember = "ProdutosFidelidades";
            // 
            // salvarbutton1
            // 
            this.salvarbutton1.Location = new System.Drawing.Point(312, 297);
            this.salvarbutton1.Name = "salvarbutton1";
            this.salvarbutton1.Size = new System.Drawing.Size(132, 49);
            this.salvarbutton1.TabIndex = 2;
            this.salvarbutton1.Text = "SALVAR";
            this.salvarbutton1.UseVisualStyleBackColor = true;
            this.salvarbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // attbuton
            // 
            this.attbuton.Location = new System.Drawing.Point(459, 297);
            this.attbuton.Name = "attbuton";
            this.attbuton.Size = new System.Drawing.Size(132, 49);
            this.attbuton.TabIndex = 3;
            this.attbuton.Text = "ATUALIZAR";
            this.attbuton.UseVisualStyleBackColor = true;
            this.attbuton.Click += new System.EventHandler(this.attbuton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.produtosFidelidadesBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DescricaoProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "QtdePontos";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pontos";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // produtosFidelidadesBindingSource2
            // 
            this.produtosFidelidadesBindingSource2.DataMember = "ProdutosFidelidades";
            this.produtosFidelidadesBindingSource2.DataSource = this.mataFomeDataSet4;
            // 
            // mataFomeDataSet4
            // 
            this.mataFomeDataSet4.DataSetName = "MataFomeDataSet4";
            this.mataFomeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosFidelidadesTableAdapter
            // 
            this.produtosFidelidadesTableAdapter.ClearBeforeFill = true;
            // 
            // TelaPontosFidelidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 358);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.attbuton);
            this.Controls.Add(this.salvarbutton1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPontosFidelidade";
            this.Text = "TelaPontosFidelidade";
            this.Load += new System.EventHandler(this.TelaPontosFidelidade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosFidelidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosFidelidadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosFidelidadesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox qtdepontostxt;
        private System.Windows.Forms.TextBox descricaoprodutotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
       
        private System.Windows.Forms.BindingSource produtosFidelidadesBindingSource;
        private System.Windows.Forms.BindingSource produtosFidelidadesBindingSource1;
        private System.Windows.Forms.Button salvarbutton1;
        private System.Windows.Forms.Button attbuton;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdePontosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MataFomeDataSet4 mataFomeDataSet4;
        private System.Windows.Forms.BindingSource produtosFidelidadesBindingSource2;
        private MataFomeDataSet4TableAdapters.ProdutosFidelidadesTableAdapter produtosFidelidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}