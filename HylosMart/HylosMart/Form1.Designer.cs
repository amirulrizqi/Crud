namespace HylosMart
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.btnBaru = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataHylos = new HylosMart.dataHylos();
            this.hylosdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hylosdataTableAdapter = new HylosMart.dataHylosTableAdapters.hylosdataTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hylosdataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hylosData = new HylosMart.hylosData();
            this.hylosdataTableAdapter1 = new HylosMart.hylosDataTableAdapters.hylosdataTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHylos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hylosdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hylosdataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hylosData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga Barang";
            // 
            // tbKode
            // 
            this.tbKode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hylosdataBindingSource1, "Kode", true));
            this.tbKode.Location = new System.Drawing.Point(82, 12);
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(209, 20);
            this.tbKode.TabIndex = 4;
            // 
            // tbNama
            // 
            this.tbNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hylosdataBindingSource1, "Nama", true));
            this.tbNama.Location = new System.Drawing.Point(82, 49);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(209, 20);
            this.tbNama.TabIndex = 5;
            // 
            // tbStock
            // 
            this.tbStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hylosdataBindingSource1, "Stock", true));
            this.tbStock.Location = new System.Drawing.Point(82, 85);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(209, 20);
            this.tbStock.TabIndex = 6;
            // 
            // tbHarga
            // 
            this.tbHarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hylosdataBindingSource1, "Harga", true));
            this.tbHarga.Location = new System.Drawing.Point(82, 120);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(209, 20);
            this.tbHarga.TabIndex = 7;
            // 
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(328, 65);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBaru.Size = new System.Drawing.Size(75, 23);
            this.btnBaru.TabIndex = 8;
            this.btnBaru.Text = "Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(328, 102);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(328, 138);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(328, 173);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 11;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.kodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hylosdataBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(32, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 217);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hylos Mart";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataHylos
            // 
            this.dataHylos.DataSetName = "dataHylos";
            this.dataHylos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hylosdataBindingSource
            // 
            this.hylosdataBindingSource.DataMember = "hylosdata";
            this.hylosdataBindingSource.DataSource = this.dataHylos;
            // 
            // hylosdataTableAdapter
            // 
            this.hylosdataTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 150;
            // 
            // kodeDataGridViewTextBoxColumn
            // 
            this.kodeDataGridViewTextBoxColumn.DataPropertyName = "Kode";
            this.kodeDataGridViewTextBoxColumn.HeaderText = "Kode";
            this.kodeDataGridViewTextBoxColumn.Name = "kodeDataGridViewTextBoxColumn";
            this.kodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // hylosdataBindingSource1
            // 
            this.hylosdataBindingSource1.DataMember = "hylosdata";
            this.hylosdataBindingSource1.DataSource = this.hylosData;
            // 
            // hylosData
            // 
            this.hylosData.DataSetName = "hylosData";
            this.hylosData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hylosdataTableAdapter1
            // 
            this.hylosdataTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbNama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbKode);
            this.panel1.Controls.Add(this.tbStock);
            this.panel1.Controls.Add(this.tbHarga);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 153);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBaru);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHylos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hylosdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hylosdataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hylosData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private dataHylos dataHylos;
        private System.Windows.Forms.BindingSource hylosdataBindingSource;
        private dataHylosTableAdapters.hylosdataTableAdapter hylosdataTableAdapter;
        private hylosData hylosData;
        private System.Windows.Forms.BindingSource hylosdataBindingSource1;
        private hylosDataTableAdapters.hylosdataTableAdapter hylosdataTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}

