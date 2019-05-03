namespace MataFome2
{
    partial class TelaClientes
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
            this.clientesdgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contadorVendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mataFomeDataSet5att = new MataFome2.MataFomeDataSet5att();
            this.clientesTableAdapter = new MataFome2.MataFomeDataSet5attTableAdapters.ClientesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clientelb = new System.Windows.Forms.Label();
            this.enderecolb = new System.Windows.Forms.Label();
            this.totalpedidoslb = new System.Windows.Forms.Label();
            this.telcilentelb = new System.Windows.Forms.Label();
            this.totalgastolb = new System.Windows.Forms.Label();
            this.pontosfdlb = new System.Windows.Forms.Label();
            this.ultimopedidolb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bairrolb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cidadelb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet5att)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesdgv
            // 
            this.clientesdgv.AllowUserToAddRows = false;
            this.clientesdgv.AllowUserToDeleteRows = false;
            this.clientesdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientesdgv.AutoGenerateColumns = false;
            this.clientesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.contadorVendasDataGridViewTextBoxColumn,
            this.totalGastoDataGridViewTextBoxColumn});
            this.clientesdgv.DataSource = this.clientesBindingSource;
            this.clientesdgv.Location = new System.Drawing.Point(12, 240);
            this.clientesdgv.Name = "clientesdgv";
            this.clientesdgv.ReadOnly = true;
            this.clientesdgv.RowTemplate.Height = 24;
            this.clientesdgv.Size = new System.Drawing.Size(774, 356);
            this.clientesdgv.TabIndex = 0;
            this.clientesdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesdgv_CellClick);
            this.clientesdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesdgv_CellContentClick);
            this.clientesdgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesdgv_CellContentDoubleClick);
            this.clientesdgv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clientesdgv_ColumnHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contadorVendasDataGridViewTextBoxColumn
            // 
            this.contadorVendasDataGridViewTextBoxColumn.DataPropertyName = "ContadorVendas";
            this.contadorVendasDataGridViewTextBoxColumn.HeaderText = "Pedidos";
            this.contadorVendasDataGridViewTextBoxColumn.Name = "contadorVendasDataGridViewTextBoxColumn";
            this.contadorVendasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalGastoDataGridViewTextBoxColumn
            // 
            this.totalGastoDataGridViewTextBoxColumn.DataPropertyName = "TotalGasto";
            this.totalGastoDataGridViewTextBoxColumn.HeaderText = "Total Gasto";
            this.totalGastoDataGridViewTextBoxColumn.Name = "totalGastoDataGridViewTextBoxColumn";
            this.totalGastoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.mataFomeDataSet5att;
            // 
            // mataFomeDataSet5att
            // 
            this.mataFomeDataSet5att.DataSetName = "MataFomeDataSet5att";
            this.mataFomeDataSet5att.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total de Pedidos:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Gasto:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pontos de Fidelidade:";
            // 
            // clientelb
            // 
            this.clientelb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientelb.AutoSize = true;
            this.clientelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientelb.Location = new System.Drawing.Point(121, 30);
            this.clientelb.Name = "clientelb";
            this.clientelb.Size = new System.Drawing.Size(19, 25);
            this.clientelb.TabIndex = 7;
            this.clientelb.Text = "-";
            this.clientelb.Click += new System.EventHandler(this.clientelb_Click);
            // 
            // enderecolb
            // 
            this.enderecolb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enderecolb.AutoSize = true;
            this.enderecolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecolb.Location = new System.Drawing.Point(142, 70);
            this.enderecolb.Name = "enderecolb";
            this.enderecolb.Size = new System.Drawing.Size(19, 25);
            this.enderecolb.TabIndex = 8;
            this.enderecolb.Text = "-";
            this.enderecolb.Click += new System.EventHandler(this.enderecolb_Click);
            // 
            // totalpedidoslb
            // 
            this.totalpedidoslb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalpedidoslb.AutoSize = true;
            this.totalpedidoslb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpedidoslb.Location = new System.Drawing.Point(198, 148);
            this.totalpedidoslb.Name = "totalpedidoslb";
            this.totalpedidoslb.Size = new System.Drawing.Size(19, 25);
            this.totalpedidoslb.TabIndex = 9;
            this.totalpedidoslb.Text = "-";
            this.totalpedidoslb.Click += new System.EventHandler(this.totalpedidoslb_Click);
            // 
            // telcilentelb
            // 
            this.telcilentelb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telcilentelb.AutoSize = true;
            this.telcilentelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telcilentelb.Location = new System.Drawing.Point(589, 30);
            this.telcilentelb.Name = "telcilentelb";
            this.telcilentelb.Size = new System.Drawing.Size(19, 25);
            this.telcilentelb.TabIndex = 10;
            this.telcilentelb.Text = "-";
            this.telcilentelb.Click += new System.EventHandler(this.telcilentelb_Click);
            // 
            // totalgastolb
            // 
            this.totalgastolb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalgastolb.AutoSize = true;
            this.totalgastolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalgastolb.Location = new System.Drawing.Point(614, 148);
            this.totalgastolb.Name = "totalgastolb";
            this.totalgastolb.Size = new System.Drawing.Size(19, 25);
            this.totalgastolb.TabIndex = 11;
            this.totalgastolb.Text = "-";
            this.totalgastolb.Click += new System.EventHandler(this.totalgastolb_Click);
            // 
            // pontosfdlb
            // 
            this.pontosfdlb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pontosfdlb.AutoSize = true;
            this.pontosfdlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontosfdlb.Location = new System.Drawing.Point(232, 191);
            this.pontosfdlb.Name = "pontosfdlb";
            this.pontosfdlb.Size = new System.Drawing.Size(19, 25);
            this.pontosfdlb.TabIndex = 12;
            this.pontosfdlb.Text = "-";
            this.pontosfdlb.Click += new System.EventHandler(this.pontosfdlb_Click);
            // 
            // ultimopedidolb
            // 
            this.ultimopedidolb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultimopedidolb.AutoSize = true;
            this.ultimopedidolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimopedidolb.Location = new System.Drawing.Point(631, 191);
            this.ultimopedidolb.Name = "ultimopedidolb";
            this.ultimopedidolb.Size = new System.Drawing.Size(19, 25);
            this.ultimopedidolb.TabIndex = 14;
            this.ultimopedidolb.Text = "-";
            this.ultimopedidolb.Click += new System.EventHandler(this.ultimopedidolb_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(489, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Último pedido:";
            // 
            // bairrolb
            // 
            this.bairrolb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bairrolb.AutoSize = true;
            this.bairrolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairrolb.Location = new System.Drawing.Point(97, 111);
            this.bairrolb.Name = "bairrolb";
            this.bairrolb.Size = new System.Drawing.Size(19, 25);
            this.bairrolb.TabIndex = 16;
            this.bairrolb.Text = "-";
            this.bairrolb.Click += new System.EventHandler(this.bairrolb_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Bairro:";
            // 
            // cidadelb
            // 
            this.cidadelb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cidadelb.AutoSize = true;
            this.cidadelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadelb.Location = new System.Drawing.Point(456, 111);
            this.cidadelb.Name = "cidadelb";
            this.cidadelb.Size = new System.Drawing.Size(19, 25);
            this.cidadelb.TabIndex = 18;
            this.cidadelb.Text = "-";
            this.cidadelb.Click += new System.EventHandler(this.cidadelb_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(369, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cidade:";
            // 
            // TelaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 608);
            this.Controls.Add(this.cidadelb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bairrolb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ultimopedidolb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pontosfdlb);
            this.Controls.Add(this.totalgastolb);
            this.Controls.Add(this.telcilentelb);
            this.Controls.Add(this.totalpedidoslb);
            this.Controls.Add(this.enderecolb);
            this.Controls.Add(this.clientelb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientesdgv);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 655);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 655);
            this.Name = "TelaClientes";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.TelaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet5att)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientesdgv;
        private MataFomeDataSet5att mataFomeDataSet5att;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private MataFomeDataSet5attTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contadorVendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label clientelb;
        private System.Windows.Forms.Label enderecolb;
        private System.Windows.Forms.Label totalpedidoslb;
        private System.Windows.Forms.Label telcilentelb;
        private System.Windows.Forms.Label totalgastolb;
        private System.Windows.Forms.Label pontosfdlb;
        private System.Windows.Forms.Label ultimopedidolb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label bairrolb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cidadelb;
        private System.Windows.Forms.Label label10;
    }
}