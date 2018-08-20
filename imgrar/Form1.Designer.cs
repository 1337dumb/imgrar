namespace imgrar
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
            this.txt_image = new System.Windows.Forms.TextBox();
            this.txt_archive = new System.Windows.Forms.TextBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.btn_archive = new System.Windows.Forms.Button();
            this.lbl_image = new System.Windows.Forms.Label();
            this.lbl_archive = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_manipulate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_image
            // 
            this.txt_image.Location = new System.Drawing.Point(80, 37);
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(111, 20);
            this.txt_image.TabIndex = 0;
            this.txt_image.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_archive
            // 
            this.txt_archive.Location = new System.Drawing.Point(80, 63);
            this.txt_archive.Name = "txt_archive";
            this.txt_archive.Size = new System.Drawing.Size(111, 20);
            this.txt_archive.TabIndex = 1;
            this.txt_archive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_image
            // 
            this.btn_image.Location = new System.Drawing.Point(197, 35);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(75, 23);
            this.btn_image.TabIndex = 2;
            this.btn_image.Text = "open";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // btn_archive
            // 
            this.btn_archive.Location = new System.Drawing.Point(197, 61);
            this.btn_archive.Name = "btn_archive";
            this.btn_archive.Size = new System.Drawing.Size(75, 23);
            this.btn_archive.TabIndex = 3;
            this.btn_archive.Text = "open";
            this.btn_archive.UseVisualStyleBackColor = true;
            this.btn_archive.Click += new System.EventHandler(this.btn_archive_Click);
            // 
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.Location = new System.Drawing.Point(12, 40);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(51, 13);
            this.lbl_image.TabIndex = 4;
            this.lbl_image.Text = "image file";
            // 
            // lbl_archive
            // 
            this.lbl_archive.AutoSize = true;
            this.lbl_archive.Location = new System.Drawing.Point(12, 66);
            this.lbl_archive.Name = "lbl_archive";
            this.lbl_archive.Size = new System.Drawing.Size(58, 13);
            this.lbl_archive.TabIndex = 5;
            this.lbl_archive.Text = "archive file";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(57, 20);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "imgrar";
            // 
            // btn_manipulate
            // 
            this.btn_manipulate.Location = new System.Drawing.Point(12, 90);
            this.btn_manipulate.Name = "btn_manipulate";
            this.btn_manipulate.Size = new System.Drawing.Size(260, 23);
            this.btn_manipulate.TabIndex = 7;
            this.btn_manipulate.Text = "manipulate file";
            this.btn_manipulate.UseVisualStyleBackColor = true;
            this.btn_manipulate.Click += new System.EventHandler(this.btn_manipulate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.btn_manipulate);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_archive);
            this.Controls.Add(this.lbl_image);
            this.Controls.Add(this.btn_archive);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.txt_archive);
            this.Controls.Add(this.txt_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "imgrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.TextBox txt_archive;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Button btn_archive;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.Label lbl_archive;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_manipulate;
    }
}

