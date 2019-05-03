namespace MataFome2
{
    partial class TelaOperadorCaixa
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomeusuariolabel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valoroperadorlabel4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataoperadorlabel6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.localizarbutton1 = new System.Windows.Forms.Button();
            this.operadorcomboBox1 = new System.Windows.Forms.ComboBox();
            this.mataFomeDataSet2 = new MataFome2.MataFomeDataSet2();
            this.operadorCaixasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operadorCaixasTableAdapter = new MataFome2.MataFomeDataSet2TableAdapters.OperadorCaixasTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.imprimirbutton2 = new System.Windows.Forms.Button();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new MataFome2.MataFomeDataSet2TableAdapters.UsuariosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operadorCaixasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataoperadorlabel6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.valoroperadorlabel4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nomeusuariolabel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operador de Caixa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Usuário:";
            // 
            // nomeusuariolabel2
            // 
            this.nomeusuariolabel2.AutoSize = true;
            this.nomeusuariolabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeusuariolabel2.Location = new System.Drawing.Point(154, 30);
            this.nomeusuariolabel2.Name = "nomeusuariolabel2";
            this.nomeusuariolabel2.Size = new System.Drawing.Size(19, 25);
            this.nomeusuariolabel2.TabIndex = 1;
            this.nomeusuariolabel2.Text = "-";
            this.nomeusuariolabel2.Click += new System.EventHandler(this.nomeusuariolabel2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Venda:";
            // 
            // valoroperadorlabel4
            // 
            this.valoroperadorlabel4.AutoSize = true;
            this.valoroperadorlabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valoroperadorlabel4.Location = new System.Drawing.Point(88, 68);
            this.valoroperadorlabel4.Name = "valoroperadorlabel4";
            this.valoroperadorlabel4.Size = new System.Drawing.Size(54, 25);
            this.valoroperadorlabel4.TabIndex = 3;
            this.valoroperadorlabel4.Text = "R$: -";
            this.valoroperadorlabel4.Click += new System.EventHandler(this.valoroperadorlabel4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data:";
            // 
            // dataoperadorlabel6
            // 
            this.dataoperadorlabel6.AutoSize = true;
            this.dataoperadorlabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataoperadorlabel6.Location = new System.Drawing.Point(302, 68);
            this.dataoperadorlabel6.Name = "dataoperadorlabel6";
            this.dataoperadorlabel6.Size = new System.Drawing.Size(19, 25);
            this.dataoperadorlabel6.TabIndex = 5;
            this.dataoperadorlabel6.Text = "-";
            this.dataoperadorlabel6.Click += new System.EventHandler(this.dataoperadorlabel6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Operador:";
            // 
            // localizarbutton1
            // 
            this.localizarbutton1.Location = new System.Drawing.Point(363, 20);
            this.localizarbutton1.Name = "localizarbutton1";
            this.localizarbutton1.Size = new System.Drawing.Size(113, 66);
            this.localizarbutton1.TabIndex = 3;
            this.localizarbutton1.Text = "Localizar";
            this.localizarbutton1.UseVisualStyleBackColor = true;
            this.localizarbutton1.Click += new System.EventHandler(this.localizarbutton1_Click);
            // 
            // operadorcomboBox1
            // 
            this.operadorcomboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuariosBindingSource, "Id", true));
            this.operadorcomboBox1.DataSource = this.usuariosBindingSource;
            this.operadorcomboBox1.DisplayMember = "Login";
            this.operadorcomboBox1.FormattingEnabled = true;
            this.operadorcomboBox1.Location = new System.Drawing.Point(119, 69);
            this.operadorcomboBox1.Name = "operadorcomboBox1";
            this.operadorcomboBox1.Size = new System.Drawing.Size(214, 24);
            this.operadorcomboBox1.TabIndex = 4;
            this.operadorcomboBox1.ValueMember = "Id";
            this.operadorcomboBox1.SelectedIndexChanged += new System.EventHandler(this.operadorcomboBox1_SelectedIndexChanged);
            // 
            // mataFomeDataSet2
            // 
            this.mataFomeDataSet2.DataSetName = "MataFomeDataSet2";
            this.mataFomeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operadorCaixasBindingSource
            // 
            this.operadorCaixasBindingSource.DataMember = "OperadorCaixas";
            this.operadorCaixasBindingSource.DataSource = this.mataFomeDataSet2;
            // 
            // operadorCaixasTableAdapter
            // 
            this.operadorCaixasTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // imprimirbutton2
            // 
            this.imprimirbutton2.Location = new System.Drawing.Point(328, 246);
            this.imprimirbutton2.Name = "imprimirbutton2";
            this.imprimirbutton2.Size = new System.Drawing.Size(149, 57);
            this.imprimirbutton2.TabIndex = 7;
            this.imprimirbutton2.Text = "Imprimir";
            this.imprimirbutton2.UseVisualStyleBackColor = true;
            this.imprimirbutton2.Click += new System.EventHandler(this.imprimirbutton2_Click);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.mataFomeDataSet2;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // TelaOperadorCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 314);
            this.Controls.Add(this.imprimirbutton2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.operadorcomboBox1);
            this.Controls.Add(this.localizarbutton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaOperadorCaixa";
            this.Text = "TelaOperadorCaixa";
            this.Load += new System.EventHandler(this.TelaOperadorCaixa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operadorCaixasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dataoperadorlabel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label valoroperadorlabel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nomeusuariolabel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button localizarbutton1;
        private System.Windows.Forms.ComboBox operadorcomboBox1;
        private MataFomeDataSet2 mataFomeDataSet2;
        private System.Windows.Forms.BindingSource operadorCaixasBindingSource;
        private MataFomeDataSet2TableAdapters.OperadorCaixasTableAdapter operadorCaixasTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button imprimirbutton2;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private MataFomeDataSet2TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}