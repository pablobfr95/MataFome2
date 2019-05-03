namespace MataFome2
{
    partial class TelaTrocarPontos
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
            this.clientecbb = new System.Windows.Forms.ComboBox();
            this.mataFomeDataSet4 = new MataFome2.MataFomeDataSet4();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new MataFome2.MataFomeDataSet4TableAdapters.ClientesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeclientetxt = new System.Windows.Forms.TextBox();
            this.telclientetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pontostxtcliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonetxtachado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.produtofidelidadecbb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.produtosFidelidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosFidelidadesTableAdapter = new MataFome2.MataFomeDataSet4TableAdapters.ProdutosFidelidadesTableAdapter();
            this.Trocarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosFidelidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // clientecbb
            // 
            this.clientecbb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientesBindingSource, "Id", true));
            this.clientecbb.DataSource = this.clientesBindingSource;
            this.clientecbb.DisplayMember = "NomeCliente";
            this.clientecbb.FormattingEnabled = true;
            this.clientecbb.Location = new System.Drawing.Point(126, 59);
            this.clientecbb.Name = "clientecbb";
            this.clientecbb.Size = new System.Drawing.Size(358, 24);
            this.clientecbb.TabIndex = 1;
            this.clientecbb.ValueMember = "Id";
            this.clientecbb.SelectedIndexChanged += new System.EventHandler(this.clientecbb_SelectedIndexChanged);
            // 
            // mataFomeDataSet4
            // 
            this.mataFomeDataSet4.DataSetName = "MataFomeDataSet4";
            this.mataFomeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.mataFomeDataSet4;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Cliente:";
            // 
            // nomeclientetxt
            // 
            this.nomeclientetxt.Location = new System.Drawing.Point(185, 38);
            this.nomeclientetxt.Name = "nomeclientetxt";
            this.nomeclientetxt.Size = new System.Drawing.Size(403, 22);
            this.nomeclientetxt.TabIndex = 3;
            this.nomeclientetxt.TextChanged += new System.EventHandler(this.nomeclientetxt_TextChanged);
            // 
            // telclientetxt
            // 
            this.telclientetxt.Location = new System.Drawing.Point(147, 27);
            this.telclientetxt.MaxLength = 9;
            this.telclientetxt.Name = "telclientetxt";
            this.telclientetxt.Size = new System.Drawing.Size(174, 22);
            this.telclientetxt.TabIndex = 5;
            this.telclientetxt.TextChanged += new System.EventHandler(this.telclientetxt_TextChanged);
            this.telclientetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telclientetxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // pontostxtcliente
            // 
            this.pontostxtcliente.Location = new System.Drawing.Point(403, 79);
            this.pontostxtcliente.Name = "pontostxtcliente";
            this.pontostxtcliente.Size = new System.Drawing.Size(53, 22);
            this.pontostxtcliente.TabIndex = 7;
            this.pontostxtcliente.TextChanged += new System.EventHandler(this.pontostxtcliente_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pontos:";
            // 
            // telefonetxtachado
            // 
            this.telefonetxtachado.Location = new System.Drawing.Point(105, 79);
            this.telefonetxtachado.Name = "telefonetxtachado";
            this.telefonetxtachado.Size = new System.Drawing.Size(174, 22);
            this.telefonetxtachado.TabIndex = 9;
            this.telefonetxtachado.TextChanged += new System.EventHandler(this.telefonetxtachado_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telefonetxtachado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pontostxtcliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nomeclientetxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 156);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // produtofidelidadecbb
            // 
            this.produtofidelidadecbb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtosFidelidadesBindingSource, "Id", true));
            this.produtofidelidadecbb.DataSource = this.produtosFidelidadesBindingSource;
            this.produtofidelidadecbb.DisplayMember = "DescricaoProduto";
            this.produtofidelidadecbb.FormattingEnabled = true;
            this.produtofidelidadecbb.Location = new System.Drawing.Point(131, 264);
            this.produtofidelidadecbb.Name = "produtofidelidadecbb";
            this.produtofidelidadecbb.Size = new System.Drawing.Size(491, 24);
            this.produtofidelidadecbb.TabIndex = 12;
            this.produtofidelidadecbb.ValueMember = "Id";
            this.produtofidelidadecbb.SelectedIndexChanged += new System.EventHandler(this.produtofidelidadecbb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Produto:";
            // 
            // produtosFidelidadesBindingSource
            // 
            this.produtosFidelidadesBindingSource.DataMember = "ProdutosFidelidades";
            this.produtosFidelidadesBindingSource.DataSource = this.mataFomeDataSet4;
            // 
            // produtosFidelidadesTableAdapter
            // 
            this.produtosFidelidadesTableAdapter.ClearBeforeFill = true;
            // 
            // Trocarbutton
            // 
            this.Trocarbutton.Location = new System.Drawing.Point(455, 311);
            this.Trocarbutton.Name = "Trocarbutton";
            this.Trocarbutton.Size = new System.Drawing.Size(167, 45);
            this.Trocarbutton.TabIndex = 13;
            this.Trocarbutton.Text = "Trocar";
            this.Trocarbutton.UseVisualStyleBackColor = true;
            this.Trocarbutton.Click += new System.EventHandler(this.Trocarbutton_Click);
            // 
            // TelaTrocarPontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 375);
            this.Controls.Add(this.Trocarbutton);
            this.Controls.Add(this.produtofidelidadecbb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.telclientetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientecbb);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaTrocarPontos";
            this.Text = "TelaTrocarPontos";
            this.Load += new System.EventHandler(this.TelaTrocarPontos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mataFomeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosFidelidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientecbb;
        private MataFomeDataSet4 mataFomeDataSet4;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private MataFomeDataSet4TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeclientetxt;
        private System.Windows.Forms.TextBox telclientetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pontostxtcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefonetxtachado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox produtofidelidadecbb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource produtosFidelidadesBindingSource;
        private MataFomeDataSet4TableAdapters.ProdutosFidelidadesTableAdapter produtosFidelidadesTableAdapter;
        private System.Windows.Forms.Button Trocarbutton;
    }
}