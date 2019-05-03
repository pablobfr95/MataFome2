namespace MataFome2
{
    partial class TelaPedidos
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
            this.pedidosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operadorCaixaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mataFomeDataSet1 = new MataFome2.MataFomeDataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.operadorlbtxt = new System.Windows.Forms.Label();
            this.obslbtxt = new System.Windows.Forms.Label();
            this.formapaglbtxt = new System.Windows.Forms.Label();
            this.produtosdataGridView2 = new System.Windows.Forms.DataGridView();
            this.clientelbtxt = new System.Windows.Forms.Label();
            this.idlbtxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.situacaocbb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vendaTableAdapter = new MataFome2.MataFomeDataSet1TableAdapters.VendaTableAdapter();
            this.produtoVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoVendasTableAdapter = new MataFome2.MataFomeDataSet1TableAdapters.ProdutoVendasTableAdapter();
            this.salvarbutton = new System.Windows.Forms.Button();
            this.situacao2cbb2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.localizarbutton1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ontemsimcheckBox1 = new System.Windows.Forms.CheckBox();
            this.ontemnaocheckBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosdataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pedidosdataGridView1
            // 
            this.pedidosdataGridView1.AllowUserToAddRows = false;
            this.pedidosdataGridView1.AllowUserToDeleteRows = false;
            this.pedidosdataGridView1.AutoGenerateColumns = false;
            this.pedidosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidosdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.clienteIdDataGridViewTextBoxColumn,
            this.formaPagamentoIdDataGridViewTextBoxColumn,
            this.observacaoVendaDataGridViewTextBoxColumn,
            this.operadorCaixaIdDataGridViewTextBoxColumn});
            this.pedidosdataGridView1.DataSource = this.vendaBindingSource;
            this.pedidosdataGridView1.Location = new System.Drawing.Point(12, 334);
            this.pedidosdataGridView1.Name = "pedidosdataGridView1";
            this.pedidosdataGridView1.ReadOnly = true;
            this.pedidosdataGridView1.RowTemplate.Height = 24;
            this.pedidosdataGridView1.Size = new System.Drawing.Size(1070, 202);
            this.pedidosdataGridView1.TabIndex = 0;
            this.pedidosdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pedidosdataGridView1_CellClick);
            this.pedidosdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pedidosdataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            this.clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            this.clienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaPagamentoIdDataGridViewTextBoxColumn
            // 
            this.formaPagamentoIdDataGridViewTextBoxColumn.DataPropertyName = "FormaPagamentoId";
            this.formaPagamentoIdDataGridViewTextBoxColumn.HeaderText = "FormaPagamentoId";
            this.formaPagamentoIdDataGridViewTextBoxColumn.Name = "formaPagamentoIdDataGridViewTextBoxColumn";
            this.formaPagamentoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.formaPagamentoIdDataGridViewTextBoxColumn.Width = 160;
            // 
            // observacaoVendaDataGridViewTextBoxColumn
            // 
            this.observacaoVendaDataGridViewTextBoxColumn.DataPropertyName = "ObservacaoVenda";
            this.observacaoVendaDataGridViewTextBoxColumn.HeaderText = "ObservacaoVenda";
            this.observacaoVendaDataGridViewTextBoxColumn.Name = "observacaoVendaDataGridViewTextBoxColumn";
            this.observacaoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoVendaDataGridViewTextBoxColumn.Width = 150;
            // 
            // operadorCaixaIdDataGridViewTextBoxColumn
            // 
            this.operadorCaixaIdDataGridViewTextBoxColumn.DataPropertyName = "OperadorCaixaId";
            this.operadorCaixaIdDataGridViewTextBoxColumn.HeaderText = "OperadorCaixaId";
            this.operadorCaixaIdDataGridViewTextBoxColumn.Name = "operadorCaixaIdDataGridViewTextBoxColumn";
            this.operadorCaixaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.operadorCaixaIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.mataFomeDataSet1;
            // 
            // mataFomeDataSet1
            // 
            this.mataFomeDataSet1.DataSetName = "MataFomeDataSet1";
            this.mataFomeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.operadorlbtxt);
            this.groupBox1.Controls.Add(this.obslbtxt);
            this.groupBox1.Controls.Add(this.formapaglbtxt);
            this.groupBox1.Controls.Add(this.produtosdataGridView2);
            this.groupBox1.Controls.Add(this.clientelbtxt);
            this.groupBox1.Controls.Add(this.idlbtxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.situacaocbb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(322, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "-";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(252, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Valor:";
            // 
            // operadorlbtxt
            // 
            this.operadorlbtxt.AutoSize = true;
            this.operadorlbtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operadorlbtxt.Location = new System.Drawing.Point(112, 186);
            this.operadorlbtxt.Name = "operadorlbtxt";
            this.operadorlbtxt.Size = new System.Drawing.Size(19, 25);
            this.operadorlbtxt.TabIndex = 16;
            this.operadorlbtxt.Text = "-";
            this.operadorlbtxt.Click += new System.EventHandler(this.operadorlbtxt_Click);
            // 
            // obslbtxt
            // 
            this.obslbtxt.AutoSize = true;
            this.obslbtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obslbtxt.Location = new System.Drawing.Point(130, 147);
            this.obslbtxt.Name = "obslbtxt";
            this.obslbtxt.Size = new System.Drawing.Size(19, 25);
            this.obslbtxt.TabIndex = 15;
            this.obslbtxt.Text = "-";
            this.obslbtxt.Click += new System.EventHandler(this.obslbtxt_Click);
            // 
            // formapaglbtxt
            // 
            this.formapaglbtxt.AutoSize = true;
            this.formapaglbtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formapaglbtxt.Location = new System.Drawing.Point(218, 72);
            this.formapaglbtxt.Name = "formapaglbtxt";
            this.formapaglbtxt.Size = new System.Drawing.Size(19, 25);
            this.formapaglbtxt.TabIndex = 14;
            this.formapaglbtxt.Text = "-";
            this.formapaglbtxt.Click += new System.EventHandler(this.formapaglbtxt_Click);
            // 
            // produtosdataGridView2
            // 
            this.produtosdataGridView2.AllowUserToAddRows = false;
            this.produtosdataGridView2.AllowUserToDeleteRows = false;
            this.produtosdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosdataGridView2.Location = new System.Drawing.Point(604, 21);
            this.produtosdataGridView2.Name = "produtosdataGridView2";
            this.produtosdataGridView2.ReadOnly = true;
            this.produtosdataGridView2.RowTemplate.Height = 24;
            this.produtosdataGridView2.Size = new System.Drawing.Size(444, 173);
            this.produtosdataGridView2.TabIndex = 13;
            this.produtosdataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtosdataGridView2_CellContentClick);
            // 
            // clientelbtxt
            // 
            this.clientelbtxt.AutoSize = true;
            this.clientelbtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientelbtxt.Location = new System.Drawing.Point(215, 29);
            this.clientelbtxt.Name = "clientelbtxt";
            this.clientelbtxt.Size = new System.Drawing.Size(19, 25);
            this.clientelbtxt.TabIndex = 12;
            this.clientelbtxt.Text = "-";
            this.clientelbtxt.Click += new System.EventHandler(this.clientelbtxt_Click);
            // 
            // idlbtxt
            // 
            this.idlbtxt.AutoSize = true;
            this.idlbtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbtxt.Location = new System.Drawing.Point(49, 28);
            this.idlbtxt.Name = "idlbtxt";
            this.idlbtxt.Size = new System.Drawing.Size(19, 25);
            this.idlbtxt.TabIndex = 11;
            this.idlbtxt.Text = "-";
            this.idlbtxt.Click += new System.EventHandler(this.idlbtxt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Operador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Observação:";
            // 
            // situacaocbb
            // 
            this.situacaocbb.FormattingEnabled = true;
            this.situacaocbb.Location = new System.Drawing.Point(107, 110);
            this.situacaocbb.Name = "situacaocbb";
            this.situacaocbb.Size = new System.Drawing.Size(301, 24);
            this.situacaocbb.TabIndex = 9;
            this.situacaocbb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Situação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produtos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // produtoVendasBindingSource
            // 
            this.produtoVendasBindingSource.DataMember = "ProdutoVendas";
            this.produtoVendasBindingSource.DataSource = this.mataFomeDataSet1;
            // 
            // produtoVendasTableAdapter
            // 
            this.produtoVendasTableAdapter.ClearBeforeFill = true;
            // 
            // salvarbutton
            // 
            this.salvarbutton.Location = new System.Drawing.Point(908, 542);
            this.salvarbutton.Name = "salvarbutton";
            this.salvarbutton.Size = new System.Drawing.Size(158, 36);
            this.salvarbutton.TabIndex = 2;
            this.salvarbutton.Text = "SALVAR";
            this.salvarbutton.UseVisualStyleBackColor = true;
            this.salvarbutton.Click += new System.EventHandler(this.salvarbutton_Click);
            // 
            // situacao2cbb2
            // 
            this.situacao2cbb2.FormattingEnabled = true;
            this.situacao2cbb2.Location = new System.Drawing.Point(370, 22);
            this.situacao2cbb2.Name = "situacao2cbb2";
            this.situacao2cbb2.Size = new System.Drawing.Size(328, 24);
            this.situacao2cbb2.TabIndex = 11;
            this.situacao2cbb2.SelectedIndexChanged += new System.EventHandler(this.situacao2cbb2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(269, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Situação:";
            // 
            // localizarbutton1
            // 
            this.localizarbutton1.Location = new System.Drawing.Point(748, 15);
            this.localizarbutton1.Name = "localizarbutton1";
            this.localizarbutton1.Size = new System.Drawing.Size(186, 37);
            this.localizarbutton1.TabIndex = 12;
            this.localizarbutton1.Text = "LOCALIZAR";
            this.localizarbutton1.UseVisualStyleBackColor = true;
            this.localizarbutton1.Click += new System.EventHandler(this.localizarbutton1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Dia Anterior ?";
            // 
            // ontemsimcheckBox1
            // 
            this.ontemsimcheckBox1.AutoSize = true;
            this.ontemsimcheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ontemsimcheckBox1.Location = new System.Drawing.Point(172, 44);
            this.ontemsimcheckBox1.Name = "ontemsimcheckBox1";
            this.ontemsimcheckBox1.Size = new System.Drawing.Size(64, 28);
            this.ontemsimcheckBox1.TabIndex = 14;
            this.ontemsimcheckBox1.Text = "SIM";
            this.ontemsimcheckBox1.UseVisualStyleBackColor = true;
            this.ontemsimcheckBox1.CheckedChanged += new System.EventHandler(this.ontemsimcheckBox1_CheckedChanged);
            // 
            // ontemnaocheckBox2
            // 
            this.ontemnaocheckBox2.AutoSize = true;
            this.ontemnaocheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ontemnaocheckBox2.Location = new System.Drawing.Point(172, 11);
            this.ontemnaocheckBox2.Name = "ontemnaocheckBox2";
            this.ontemnaocheckBox2.Size = new System.Drawing.Size(74, 28);
            this.ontemnaocheckBox2.TabIndex = 15;
            this.ontemnaocheckBox2.Text = "NÃO";
            this.ontemnaocheckBox2.UseVisualStyleBackColor = true;
            this.ontemnaocheckBox2.CheckedChanged += new System.EventHandler(this.ontemnaocheckBox2_CheckedChanged);
            // 
            // TelaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 590);
            this.Controls.Add(this.ontemnaocheckBox2);
            this.Controls.Add(this.ontemsimcheckBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.localizarbutton1);
            this.Controls.Add(this.situacao2cbb2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.salvarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pedidosdataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPedidos";
            this.Text = "Tela de Pedidos";
            this.Load += new System.EventHandler(this.TelaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidosdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosdataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pedidosdataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox situacaocbb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label formapaglbtxt;
        private System.Windows.Forms.DataGridView produtosdataGridView2;
        private System.Windows.Forms.Label clientelbtxt;
        private System.Windows.Forms.Label idlbtxt;
        private System.Windows.Forms.Label label7;
        private MataFomeDataSet1 mataFomeDataSet1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private MataFomeDataSet1TableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.BindingSource produtoVendasBindingSource;
        private MataFomeDataSet1TableAdapters.ProdutoVendasTableAdapter produtoVendasTableAdapter;
        private System.Windows.Forms.Label operadorlbtxt;
        private System.Windows.Forms.Label obslbtxt;
        private System.Windows.Forms.Button salvarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operadorCaixaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox situacao2cbb2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button localizarbutton1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ontemsimcheckBox1;
        private System.Windows.Forms.CheckBox ontemnaocheckBox2;
    }
}