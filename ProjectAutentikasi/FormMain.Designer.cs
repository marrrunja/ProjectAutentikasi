namespace ProjectAutentikasi
{
    partial class FormMain
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
            btnDataBuku = new Button();
            SuspendLayout();
            // 
            // btnDataBuku
            // 
            btnDataBuku.Location = new Point(78, 41);
            btnDataBuku.Name = "btnDataBuku";
            btnDataBuku.Size = new Size(162, 53);
            btnDataBuku.TabIndex = 0;
            btnDataBuku.Text = "Data buku";
            btnDataBuku.UseVisualStyleBackColor = true;
            btnDataBuku.Click += btnDataBuku_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDataBuku);
            Name = "FormMain";
            Text = "Menu Utama";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDataBuku;
    }
}