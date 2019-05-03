namespace MataFome2
{
    partial class TelaRelatoriodias
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MataFomeDataSet4 = new MataFome2.MataFomeDataSet4();
            this.DataTable1TableAdapter = new MataFome2.MataFomeDataSet4TableAdapters.DataTable1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.datainiciodtp = new System.Windows.Forms.DateTimePicker();
            this.datafinaldtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.localizarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MataFomeDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MataFome2.Relatorios.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1031, 377);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.MataFomeDataSet4;
            // 
            // MataFomeDataSet4
            // 
            this.MataFomeDataSet4.DataSetName = "MataFomeDataSet4";
            this.MataFomeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicio:";
            // 
            // datainiciodtp
            // 
            this.datainiciodtp.Location = new System.Drawing.Point(160, 28);
            this.datainiciodtp.Name = "datainiciodtp";
            this.datainiciodtp.Size = new System.Drawing.Size(271, 22);
            this.datainiciodtp.TabIndex = 2;
            this.datainiciodtp.ValueChanged += new System.EventHandler(this.datainiciodtp_ValueChanged);
            // 
            // datafinaldtp
            // 
            this.datafinaldtp.Location = new System.Drawing.Point(598, 28);
            this.datafinaldtp.Name = "datafinaldtp";
            this.datafinaldtp.Size = new System.Drawing.Size(271, 22);
            this.datafinaldtp.TabIndex = 4;
            this.datafinaldtp.ValueChanged += new System.EventHandler(this.datafinaldtp_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final:";
            // 
            // localizarbutton
            // 
            this.localizarbutton.Location = new System.Drawing.Point(898, 23);
            this.localizarbutton.Name = "localizarbutton";
            this.localizarbutton.Size = new System.Drawing.Size(145, 37);
            this.localizarbutton.TabIndex = 5;
            this.localizarbutton.Text = "LOCALIZAR";
            this.localizarbutton.UseVisualStyleBackColor = true;
            this.localizarbutton.Click += new System.EventHandler(this.localizarbutton_Click);
            // 
            // TelaRelatoriodias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 481);
            this.Controls.Add(this.localizarbutton);
            this.Controls.Add(this.datafinaldtp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datainiciodtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TelaRelatoriodias";
            this.Text = "TelaRelatoriodias";
            this.Load += new System.EventHandler(this.TelaRelatoriodias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MataFomeDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private MataFomeDataSet4 MataFomeDataSet4;
        private MataFomeDataSet4TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datainiciodtp;
        private System.Windows.Forms.DateTimePicker datafinaldtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button localizarbutton;
    }
}