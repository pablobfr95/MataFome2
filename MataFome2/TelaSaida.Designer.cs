namespace MataFome2
{
    partial class TelaSaida
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
            this.descricaotxt = new System.Windows.Forms.TextBox();
            this.valortxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idsaidalb = new System.Windows.Forms.Label();
            this.datasaidalb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mataFomeDataSet7att = new MataFome2.MataFomeDataSet7att();
            this.saidasTableAdapter = new MataFome2.MataFomeDataSet7attTableAdapters.SaidasTableAdapter();
            this.salvarbtn = new System.Windows.Forms.Button();
            this.localizarbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.datainiciodtp = new System.Windows.Forms.DateTimePicker();
            this.datafinaldtp = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet7att)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // descricaotxt
            // 
            this.descricaotxt.Location = new System.Drawing.Point(123, 30);
            this.descricaotxt.Name = "descricaotxt";
            this.descricaotxt.Size = new System.Drawing.Size(415, 22);
            this.descricaotxt.TabIndex = 1;
            // 
            // valortxt
            // 
            this.valortxt.Location = new System.Drawing.Point(638, 29);
            this.valortxt.MaxLength = 10;
            this.valortxt.Name = "valortxt";
            this.valortxt.Size = new System.Drawing.Size(83, 22);
            this.valortxt.TabIndex = 3;
            this.valortxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valortxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // idsaidalb
            // 
            this.idsaidalb.AutoSize = true;
            this.idsaidalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idsaidalb.Location = new System.Drawing.Point(46, 69);
            this.idsaidalb.Name = "idsaidalb";
            this.idsaidalb.Size = new System.Drawing.Size(19, 25);
            this.idsaidalb.TabIndex = 5;
            this.idsaidalb.Text = "-";
            this.idsaidalb.Click += new System.EventHandler(this.idsaidalb_Click);
            // 
            // datasaidalb
            // 
            this.datasaidalb.AutoSize = true;
            this.datasaidalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datasaidalb.Location = new System.Drawing.Point(224, 69);
            this.datasaidalb.Name = "datasaidalb";
            this.datasaidalb.Size = new System.Drawing.Size(19, 25);
            this.datasaidalb.TabIndex = 7;
            this.datasaidalb.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.datasaidaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.saidasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 216);
            this.dataGridView1.TabIndex = 8;
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
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datasaidaDataGridViewTextBoxColumn
            // 
            this.datasaidaDataGridViewTextBoxColumn.DataPropertyName = "Datasaida";
            this.datasaidaDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datasaidaDataGridViewTextBoxColumn.Name = "datasaidaDataGridViewTextBoxColumn";
            this.datasaidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saidasBindingSource
            // 
            this.saidasBindingSource.DataMember = "Saidas";
            this.saidasBindingSource.DataSource = this.mataFomeDataSet7att;
            // 
            // mataFomeDataSet7att
            // 
            this.mataFomeDataSet7att.DataSetName = "MataFomeDataSet7att";
            this.mataFomeDataSet7att.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saidasTableAdapter
            // 
            this.saidasTableAdapter.ClearBeforeFill = true;
            // 
            // salvarbtn
            // 
            this.salvarbtn.Location = new System.Drawing.Point(632, 430);
            this.salvarbtn.Name = "salvarbtn";
            this.salvarbtn.Size = new System.Drawing.Size(132, 40);
            this.salvarbtn.TabIndex = 9;
            this.salvarbtn.Text = "SALVAR";
            this.salvarbtn.UseVisualStyleBackColor = true;
            this.salvarbtn.Click += new System.EventHandler(this.salvarbtn_Click);
            // 
            // localizarbtn
            // 
            this.localizarbtn.Location = new System.Drawing.Point(488, 149);
            this.localizarbtn.Name = "localizarbtn";
            this.localizarbtn.Size = new System.Drawing.Size(132, 40);
            this.localizarbtn.TabIndex = 10;
            this.localizarbtn.Text = "LOCALIZAR";
            this.localizarbtn.UseVisualStyleBackColor = true;
            this.localizarbtn.Click += new System.EventHandler(this.localizarbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Data Inicio:";
            // 
            // datainiciodtp
            // 
            this.datainiciodtp.Location = new System.Drawing.Point(127, 140);
            this.datainiciodtp.Name = "datainiciodtp";
            this.datainiciodtp.Size = new System.Drawing.Size(303, 22);
            this.datainiciodtp.TabIndex = 12;
            this.datainiciodtp.ValueChanged += new System.EventHandler(this.datainiciodtp_ValueChanged);
            // 
            // datafinaldtp
            // 
            this.datafinaldtp.Location = new System.Drawing.Point(127, 180);
            this.datafinaldtp.Name = "datafinaldtp";
            this.datafinaldtp.Size = new System.Drawing.Size(303, 22);
            this.datafinaldtp.TabIndex = 14;
            this.datafinaldtp.ValueChanged += new System.EventHandler(this.datafinaldtp_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Data Final:";
            // 
            // TelaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 474);
            this.Controls.Add(this.datafinaldtp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datainiciodtp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.localizarbtn);
            this.Controls.Add(this.salvarbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datasaidalb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idsaidalb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valortxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descricaotxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(794, 521);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(794, 521);
            this.Name = "TelaSaida";
            this.Text = "Saída";
            this.Load += new System.EventHandler(this.TelaSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet7att)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descricaotxt;
        private System.Windows.Forms.TextBox valortxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idsaidalb;
        private System.Windows.Forms.Label datasaidalb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MataFomeDataSet7att mataFomeDataSet7att;
        private System.Windows.Forms.BindingSource saidasBindingSource;
        private MataFomeDataSet7attTableAdapters.SaidasTableAdapter saidasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button salvarbtn;
        private System.Windows.Forms.Button localizarbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datainiciodtp;
        private System.Windows.Forms.DateTimePicker datafinaldtp;
        private System.Windows.Forms.Label label8;
    }
}