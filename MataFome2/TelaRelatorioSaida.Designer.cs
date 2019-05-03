namespace MataFome2
{
    partial class TelaRelatorioSaida
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Saidas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MataFomeDataSet7att = new MataFome2.MataFomeDataSet7att();
            this.SaidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaidasTableAdapter = new MataFome2.MataFomeDataSet7attTableAdapters.SaidasTableAdapter();
            this.Saidas1TableAdapter = new MataFome2.MataFomeDataSet7attTableAdapters.Saidas1TableAdapter();
            this.localizarbutton = new System.Windows.Forms.Button();
            this.datafinaldtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datainiciodtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Saidas1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MataFomeDataSet7att)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaidasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Saidas1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MataFome2.Relatorios.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1039, 568);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Saidas1BindingSource
            // 
            this.Saidas1BindingSource.DataMember = "Saidas1";
            this.Saidas1BindingSource.DataSource = this.MataFomeDataSet7att;
            // 
            // MataFomeDataSet7att
            // 
            this.MataFomeDataSet7att.DataSetName = "MataFomeDataSet7att";
            this.MataFomeDataSet7att.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaidasBindingSource
            // 
            this.SaidasBindingSource.DataMember = "Saidas";
            this.SaidasBindingSource.DataSource = this.MataFomeDataSet7att;
            // 
            // SaidasTableAdapter
            // 
            this.SaidasTableAdapter.ClearBeforeFill = true;
            // 
            // Saidas1TableAdapter
            // 
            this.Saidas1TableAdapter.ClearBeforeFill = true;
            // 
            // localizarbutton
            // 
            this.localizarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.localizarbutton.Location = new System.Drawing.Point(907, 9);
            this.localizarbutton.Name = "localizarbutton";
            this.localizarbutton.Size = new System.Drawing.Size(145, 37);
            this.localizarbutton.TabIndex = 10;
            this.localizarbutton.Text = "LOCALIZAR";
            this.localizarbutton.UseVisualStyleBackColor = true;
            this.localizarbutton.Click += new System.EventHandler(this.localizarbutton_Click);
            // 
            // datafinaldtp
            // 
            this.datafinaldtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datafinaldtp.Location = new System.Drawing.Point(607, 14);
            this.datafinaldtp.Name = "datafinaldtp";
            this.datafinaldtp.Size = new System.Drawing.Size(271, 22);
            this.datafinaldtp.TabIndex = 9;
            this.datafinaldtp.ValueChanged += new System.EventHandler(this.datafinaldtp_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Final:";
            // 
            // datainiciodtp
            // 
            this.datainiciodtp.Location = new System.Drawing.Point(160, 14);
            this.datainiciodtp.Name = "datainiciodtp";
            this.datainiciodtp.Size = new System.Drawing.Size(271, 22);
            this.datainiciodtp.TabIndex = 7;
            this.datainiciodtp.ValueChanged += new System.EventHandler(this.datainiciodtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Inicio:";
            // 
            // TelaRelatorioSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 645);
            this.Controls.Add(this.localizarbutton);
            this.Controls.Add(this.datafinaldtp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datainiciodtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1081, 692);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1081, 692);
            this.Name = "TelaRelatorioSaida";
            this.Text = "Relatório Saidas";
            this.Load += new System.EventHandler(this.TelaRelatorioSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Saidas1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MataFomeDataSet7att)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaidasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource SaidasBindingSource;
        private MataFomeDataSet7att MataFomeDataSet7att;
        private MataFomeDataSet7attTableAdapters.SaidasTableAdapter SaidasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Saidas1BindingSource;
        private MataFomeDataSet7attTableAdapters.Saidas1TableAdapter Saidas1TableAdapter;
        private System.Windows.Forms.Button localizarbutton;
        private System.Windows.Forms.DateTimePicker datafinaldtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datainiciodtp;
        private System.Windows.Forms.Label label1;
    }
}