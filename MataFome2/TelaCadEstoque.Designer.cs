namespace MataFome2
{
    partial class TelaCadEstoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.nometextbox1 = new System.Windows.Forms.TextBox();
            this.qtdetextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.medidacbb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.salvarbtn = new System.Windows.Forms.Button();
            this.produtosestoquesdataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoquesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mataFomeDataSet3Atualizado = new MataFome2.MataFomeDataSet3Atualizado();
            this.estoquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoquesTableAdapter = new MataFome2.MataFomeDataSet3AtualizadoTableAdapters.EstoquesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosestoquesdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet3Atualizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nometextbox1
            // 
            this.nometextbox1.Location = new System.Drawing.Point(135, 34);
            this.nometextbox1.Name = "nometextbox1";
            this.nometextbox1.Size = new System.Drawing.Size(447, 22);
            this.nometextbox1.TabIndex = 1;
            this.nometextbox1.TextChanged += new System.EventHandler(this.nometextbox1_TextChanged);
            // 
            // qtdetextbox
            // 
            this.qtdetextbox.Location = new System.Drawing.Point(98, 72);
            this.qtdetextbox.MaxLength = 10;
            this.qtdetextbox.Name = "qtdetextbox";
            this.qtdetextbox.Size = new System.Drawing.Size(67, 22);
            this.qtdetextbox.TabIndex = 3;
            this.qtdetextbox.TextChanged += new System.EventHandler(this.qtdetextbox_TextChanged);
            this.qtdetextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtdetextbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medida:";
            // 
            // medidacbb
            // 
            this.medidacbb.FormattingEnabled = true;
            this.medidacbb.Location = new System.Drawing.Point(389, 69);
            this.medidacbb.Name = "medidacbb";
            this.medidacbb.Size = new System.Drawing.Size(121, 24);
            this.medidacbb.TabIndex = 5;
            this.medidacbb.SelectedIndexChanged += new System.EventHandler(this.medidacbb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.medidacbb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nometextbox1);
            this.groupBox1.Controls.Add(this.qtdetextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 133);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "* CAMPOS OBRIGATÓRIOS";
            // 
            // salvarbtn
            // 
            this.salvarbtn.Location = new System.Drawing.Point(515, 149);
            this.salvarbtn.Name = "salvarbtn";
            this.salvarbtn.Size = new System.Drawing.Size(133, 46);
            this.salvarbtn.TabIndex = 7;
            this.salvarbtn.Text = "SALVAR";
            this.salvarbtn.UseVisualStyleBackColor = true;
            this.salvarbtn.Click += new System.EventHandler(this.salvarbtn_Click);
            // 
            // produtosestoquesdataGridView1
            // 
            this.produtosestoquesdataGridView1.AllowUserToAddRows = false;
            this.produtosestoquesdataGridView1.AllowUserToDeleteRows = false;
            this.produtosestoquesdataGridView1.AutoGenerateColumns = false;
            this.produtosestoquesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosestoquesdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.produtosestoquesdataGridView1.DataSource = this.estoquesBindingSource1;
            this.produtosestoquesdataGridView1.Location = new System.Drawing.Point(12, 239);
            this.produtosestoquesdataGridView1.Name = "produtosestoquesdataGridView1";
            this.produtosestoquesdataGridView1.ReadOnly = true;
            this.produtosestoquesdataGridView1.RowTemplate.Height = 24;
            this.produtosestoquesdataGridView1.Size = new System.Drawing.Size(636, 159);
            this.produtosestoquesdataGridView1.TabIndex = 8;
            this.produtosestoquesdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtosestoquesdataGridView1_CellClick);
            this.produtosestoquesdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtosestoquesdataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn4.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // estoquesBindingSource1
            // 
            this.estoquesBindingSource1.DataMember = "Estoques";
            this.estoquesBindingSource1.DataSource = this.mataFomeDataSet3Atualizado;
            // 
            // mataFomeDataSet3Atualizado
            // 
            this.mataFomeDataSet3Atualizado.DataSetName = "MataFomeDataSet3Atualizado";
            this.mataFomeDataSet3Atualizado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoquesBindingSource
            // 
            this.estoquesBindingSource.DataMember = "Estoques";
            // 
            // estoquesTableAdapter
            // 
            this.estoquesTableAdapter.ClearBeforeFill = true;
            // 
            // TelaCadEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 416);
            this.Controls.Add(this.produtosestoquesdataGridView1);
            this.Controls.Add(this.salvarbtn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadEstoque";
            this.Text = "TelaCadEstoque";
            this.Load += new System.EventHandler(this.TelaCadEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosestoquesdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet3Atualizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nometextbox1;
        private System.Windows.Forms.TextBox qtdetextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox medidacbb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button salvarbtn;
        private System.Windows.Forms.DataGridView produtosestoquesdataGridView1;
        private System.Windows.Forms.BindingSource estoquesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balancoIdDataGridViewTextBoxColumn;
        private MataFomeDataSet3Atualizado mataFomeDataSet3Atualizado;
        private System.Windows.Forms.BindingSource estoquesBindingSource1;
        private MataFomeDataSet3AtualizadoTableAdapters.EstoquesTableAdapter estoquesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
    }
}