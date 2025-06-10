namespace ProjectAutentikasi
{
    partial class FormDataBuku
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnReload = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnSimpan = new Button();
            filterCari = new ComboBox();
            groupBox3 = new GroupBox();
            textBoxCari = new TextBox();
            btnCari = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            labelPage = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(640, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(767, 264);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 252);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(406, 31);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 195);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 6;
            label4.Text = "Tahun Terbit";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(406, 31);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 150);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 4;
            label3.Text = "Penerbit";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(406, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 105);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 2;
            label2.Text = "Penulis";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(406, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 51);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 0;
            label1.Text = "Judul";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnReload);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnHapus);
            groupBox2.Controls.Add(btnSimpan);
            groupBox2.Location = new Point(33, 487);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(585, 199);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aksi";
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.GrayText;
            btnReload.ForeColor = SystemColors.Control;
            btnReload.Location = new Point(432, 55);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(127, 47);
            btnReload.TabIndex = 4;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GrayText;
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(24, 136);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(535, 47);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.GrayText;
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(290, 55);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(127, 47);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = SystemColors.GrayText;
            btnHapus.ForeColor = SystemColors.Control;
            btnHapus.Location = new Point(157, 55);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(127, 47);
            btnHapus.TabIndex = 1;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = SystemColors.GrayText;
            btnSimpan.ForeColor = SystemColors.Control;
            btnSimpan.Location = new Point(24, 55);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(127, 47);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // filterCari
            // 
            filterCari.FormattingEnabled = true;
            filterCari.Items.AddRange(new object[] { "Judul", "Penulis", "Penerbit", "Tahun Terbit" });
            filterCari.Location = new Point(6, 35);
            filterCari.Name = "filterCari";
            filterCari.Size = new Size(182, 33);
            filterCari.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxCari);
            groupBox3.Controls.Add(btnCari);
            groupBox3.Controls.Add(filterCari);
            groupBox3.Location = new Point(36, 282);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(582, 199);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filter";
            // 
            // textBoxCari
            // 
            textBoxCari.Location = new Point(194, 35);
            textBoxCari.Name = "textBoxCari";
            textBoxCari.Size = new Size(382, 31);
            textBoxCari.TabIndex = 8;
            // 
            // btnCari
            // 
            btnCari.BackColor = SystemColors.GrayText;
            btnCari.ForeColor = SystemColors.Control;
            btnCari.Location = new Point(6, 134);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(570, 47);
            btnCari.TabIndex = 5;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(653, 317);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(195, 52);
            btnPrev.TabIndex = 5;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(863, 317);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(195, 52);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // labelPage
            // 
            labelPage.AutoSize = true;
            labelPage.Location = new Point(1212, 331);
            labelPage.Name = "labelPage";
            labelPage.Size = new Size(147, 25);
            labelPage.TabIndex = 8;
            labelPage.Text = "Halaman 1 dari 2";
            // 
            // FormDataBuku
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 677);
            Controls.Add(labelPage);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "FormDataBuku";
            Text = ".";
            Load += FormDataBuku_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnSimpan;
        private Button btnClear;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnReload;
        private ComboBox filterCari;
        private GroupBox groupBox3;
        private TextBox textBoxCari;
        private Button btnCari;
        private Button btnNext;
        private Button btnPrev;
        private Label labelPage;
    }
}