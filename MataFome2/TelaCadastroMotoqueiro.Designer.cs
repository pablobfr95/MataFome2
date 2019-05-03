namespace MataFome2
{
    partial class TelaCadastroMotoqueiro
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
            this.nometxt = new System.Windows.Forms.TextBox();
            this.telefonetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entregatxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalrecebidolb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mataFomeDataSet6Att = new MataFome2.MataFomeDataSet6Att();
            this.motoqueirosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoqueirosTableAdapter = new MataFome2.MataFomeDataSet6AttTableAdapters.MotoqueirosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalRecebidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salvarbtn = new System.Windows.Forms.Button();
            this.atualizarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet6Att)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoqueirosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // nometxt
            // 
            this.nometxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nometxt.Location = new System.Drawing.Point(107, 82);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(269, 30);
            this.nometxt.TabIndex = 1;
            this.nometxt.TextChanged += new System.EventHandler(this.nometxt_TextChanged);
            this.nometxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nometxt_KeyPress);
            // 
            // telefonetxt
            // 
            this.telefonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonetxt.Location = new System.Drawing.Point(134, 29);
            this.telefonetxt.MaxLength = 9;
            this.telefonetxt.Name = "telefonetxt";
            this.telefonetxt.Size = new System.Drawing.Size(242, 30);
            this.telefonetxt.TabIndex = 3;
            this.telefonetxt.TextChanged += new System.EventHandler(this.telefonetxt_TextChanged);
            this.telefonetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonetxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // entregatxt
            // 
            this.entregatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregatxt.Location = new System.Drawing.Point(634, 29);
            this.entregatxt.MaxLength = 5;
            this.entregatxt.Name = "entregatxt";
            this.entregatxt.Size = new System.Drawing.Size(65, 30);
            this.entregatxt.TabIndex = 5;
            this.entregatxt.TextChanged += new System.EventHandler(this.entregatxt_TextChanged);
            this.entregatxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entregatxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor por Entrega:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Total Recebido:";
            // 
            // totalrecebidolb
            // 
            this.totalrecebidolb.AutoSize = true;
            this.totalrecebidolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalrecebidolb.Location = new System.Drawing.Point(678, 81);
            this.totalrecebidolb.Name = "totalrecebidolb";
            this.totalrecebidolb.Size = new System.Drawing.Size(21, 29);
            this.totalrecebidolb.TabIndex = 7;
            this.totalrecebidolb.Text = "-";
            this.totalrecebidolb.Click += new System.EventHandler(this.totalrecebidolb_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.valorTotalRecebidoDataGridViewTextBoxColumn,
            this.valorEntregaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.motoqueirosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(771, 228);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mataFomeDataSet6Att
            // 
            this.mataFomeDataSet6Att.DataSetName = "MataFomeDataSet6Att";
            this.mataFomeDataSet6Att.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motoqueirosBindingSource
            // 
            this.motoqueirosBindingSource.DataMember = "Motoqueiros";
            this.motoqueirosBindingSource.DataSource = this.mataFomeDataSet6Att;
            // 
            // motoqueirosTableAdapter
            // 
            this.motoqueirosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalRecebidoDataGridViewTextBoxColumn
            // 
            this.valorTotalRecebidoDataGridViewTextBoxColumn.DataPropertyName = "ValorTotalRecebido";
            this.valorTotalRecebidoDataGridViewTextBoxColumn.HeaderText = "Valor Total Recebido";
            this.valorTotalRecebidoDataGridViewTextBoxColumn.Name = "valorTotalRecebidoDataGridViewTextBoxColumn";
            this.valorTotalRecebidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorEntregaDataGridViewTextBoxColumn
            // 
            this.valorEntregaDataGridViewTextBoxColumn.DataPropertyName = "ValorEntrega";
            this.valorEntregaDataGridViewTextBoxColumn.HeaderText = "Valor por Entrega";
            this.valorEntregaDataGridViewTextBoxColumn.Name = "valorEntregaDataGridViewTextBoxColumn";
            this.valorEntregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salvarbtn
            // 
            this.salvarbtn.Location = new System.Drawing.Point(527, 389);
            this.salvarbtn.Name = "salvarbtn";
            this.salvarbtn.Size = new System.Drawing.Size(117, 49);
            this.salvarbtn.TabIndex = 9;
            this.salvarbtn.Text = "SALVAR";
            this.salvarbtn.UseVisualStyleBackColor = true;
            this.salvarbtn.Click += new System.EventHandler(this.salvarbtn_Click);
            // 
            // atualizarbtn
            // 
            this.atualizarbtn.Location = new System.Drawing.Point(661, 389);
            this.atualizarbtn.Name = "atualizarbtn";
            this.atualizarbtn.Size = new System.Drawing.Size(117, 49);
            this.atualizarbtn.TabIndex = 10;
            this.atualizarbtn.Text = "ATUALIZAR";
            this.atualizarbtn.UseVisualStyleBackColor = true;
            this.atualizarbtn.Click += new System.EventHandler(this.atualizarbtn_Click);
            // 
            // TelaCadastroMotoqueiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atualizarbtn);
            this.Controls.Add(this.salvarbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalrecebidolb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.entregatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telefonetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nometxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "TelaCadastroMotoqueiro";
            this.Text = "Cadastrar Motoqueiro";
            this.Load += new System.EventHandler(this.TelaCadastroMotoqueiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet6Att)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoqueirosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.TextBox telefonetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entregatxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalrecebidolb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MataFomeDataSet6Att mataFomeDataSet6Att;
        private System.Windows.Forms.BindingSource motoqueirosBindingSource;
        private MataFomeDataSet6AttTableAdapters.MotoqueirosTableAdapter motoqueirosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalRecebidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button salvarbtn;
        private System.Windows.Forms.Button atualizarbtn;
    }
}