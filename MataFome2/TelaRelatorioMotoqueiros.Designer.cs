namespace MataFome2
{
    partial class TelaRelatorioMotoqueiros
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MataFomeDataSet6Att = new MataFome2.MataFomeDataSet6Att();
            this.label1 = new System.Windows.Forms.Label();
            this.datainiciodtp = new System.Windows.Forms.DateTimePicker();
            this.datafimdtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.localizarbtn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new MataFome2.MataFomeDataSet6AttTableAdapters.DataTable1TableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.motocbb = new System.Windows.Forms.ComboBox();
            this.motoqueirosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoqueirosTableAdapter = new MataFome2.MataFomeDataSet6AttTableAdapters.MotoqueirosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MataFomeDataSet6Att)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoqueirosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.MataFomeDataSet6Att;
            // 
            // MataFomeDataSet6Att
            // 
            this.MataFomeDataSet6Att.DataSetName = "MataFomeDataSet6Att";
            this.MataFomeDataSet6Att.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Ínicio:";
            // 
            // datainiciodtp
            // 
            this.datainiciodtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datainiciodtp.Location = new System.Drawing.Point(149, 25);
            this.datainiciodtp.Name = "datainiciodtp";
            this.datainiciodtp.Size = new System.Drawing.Size(345, 24);
            this.datainiciodtp.TabIndex = 1;
            this.datainiciodtp.ValueChanged += new System.EventHandler(this.datainiciodtp_ValueChanged);
            // 
            // datafimdtp
            // 
            this.datafimdtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datafimdtp.Location = new System.Drawing.Point(711, 23);
            this.datafimdtp.Name = "datafimdtp";
            this.datafimdtp.Size = new System.Drawing.Size(364, 24);
            this.datafimdtp.TabIndex = 3;
            this.datafimdtp.ValueChanged += new System.EventHandler(this.datafimdtp_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Fim:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // localizarbtn
            // 
            this.localizarbtn.Location = new System.Drawing.Point(908, 63);
            this.localizarbtn.Name = "localizarbtn";
            this.localizarbtn.Size = new System.Drawing.Size(167, 48);
            this.localizarbtn.TabIndex = 4;
            this.localizarbtn.Text = "LOCALIZAR";
            this.localizarbtn.UseVisualStyleBackColor = true;
            this.localizarbtn.Click += new System.EventHandler(this.localizarbtn_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MataFome2.Relatorios.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1062, 538);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Motoqueiro:";
            // 
            // motocbb
            // 
            this.motocbb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.motoqueirosBindingSource, "Id", true));
            this.motocbb.DataSource = this.motoqueirosBindingSource;
            this.motocbb.DisplayMember = "Nome";
            this.motocbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motocbb.FormattingEnabled = true;
            this.motocbb.Location = new System.Drawing.Point(160, 69);
            this.motocbb.Name = "motocbb";
            this.motocbb.Size = new System.Drawing.Size(265, 33);
            this.motocbb.TabIndex = 7;
            this.motocbb.ValueMember = "Id";
            this.motocbb.SelectedIndexChanged += new System.EventHandler(this.motocbb_SelectedIndexChanged);
            // 
            // motoqueirosBindingSource
            // 
            this.motoqueirosBindingSource.DataMember = "Motoqueiros";
            this.motoqueirosBindingSource.DataSource = this.MataFomeDataSet6Att;
            // 
            // motoqueirosTableAdapter
            // 
            this.motoqueirosTableAdapter.ClearBeforeFill = true;
            // 
            // TelaRelatorioMotoqueiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 673);
            this.Controls.Add(this.motocbb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.localizarbtn);
            this.Controls.Add(this.datafimdtp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datainiciodtp);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1104, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1104, 720);
            this.Name = "TelaRelatorioMotoqueiros";
            this.Text = "Relatório Motoqueiro";
            this.Load += new System.EventHandler(this.TelaRelatorioMotoqueiros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MataFomeDataSet6Att)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoqueirosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datainiciodtp;
        private System.Windows.Forms.DateTimePicker datafimdtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button localizarbtn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private MataFomeDataSet6Att MataFomeDataSet6Att;
        private MataFomeDataSet6AttTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox motocbb;
        private System.Windows.Forms.BindingSource motoqueirosBindingSource;
        private MataFomeDataSet6AttTableAdapters.MotoqueirosTableAdapter motoqueirosTableAdapter;
    }
}