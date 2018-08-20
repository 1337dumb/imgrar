using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace imgrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string str_image_ext= ".jpg";
        public static string str_archive_ext = ".rar";

        private void btn_image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd_image = new OpenFileDialog())
            {
                ofd_image.Title = "imgrar - open image file";
                ofd_image.Filter = "image files|*.jpg;*.jpeg;*.png|*.jpg;*.jpeg;*.png|*.jpg;*.jpeg;*.png";
                ofd_image.FilterIndex = 2;
                ofd_image.RestoreDirectory = true;

                if (ofd_image.ShowDialog() == DialogResult.OK)
                {
                    txt_image.Text = ofd_image.FileName;
                    str_image_ext = Path.GetExtension(txt_image.Text);
                }
            }
        }

        private void btn_archive_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notice: Password protecting the archive makes it more secure.", "imgrar");

            using (OpenFileDialog ofd_archive = new OpenFileDialog())
            {
                ofd_archive.Title = "imgrar - open archive file";
                ofd_archive.Filter = "archive files|*.zip;*.rar|*.zip;*.rar|*.zip;*.rar";
                ofd_archive.FilterIndex = 2;
                ofd_archive.RestoreDirectory = true;

                if (ofd_archive.ShowDialog() == DialogResult.OK)
                {
                    txt_archive.Text = ofd_archive.FileName;
                    str_archive_ext = Path.GetExtension(txt_archive.Text);
                }
            }
        }

        
        public string str_random()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_";
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btn_manipulate_Click(object sender, EventArgs e)
        {
            if (!(File.Exists(txt_image.Text))
                ||!(File.Exists(txt_archive.Text))
                ||!(txt_archive.Text.Length > 0) 
                ||!(txt_image.Text.Length > 0))
                return;

            string str_folder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string str_destname = str_random();
            string str_destpath = str_folder + "\\" + str_destname;
            string str_tempimage = str_random() + str_image_ext;
            string str_temparchive = str_random() + str_archive_ext;

            str_destname += "_manipulated" + str_image_ext;

            File.Copy(txt_image.Text, str_folder + "\\" + str_tempimage);
            File.Copy(txt_archive.Text, str_folder + "\\" + str_temparchive);

            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false
            };

            process.StartInfo = startInfo;
            process.Start();

            process.StandardInput.WriteLine("cd " + str_folder);
            process.StandardInput.WriteLine("copy /b " + str_tempimage + "+" + str_temparchive + " " + str_destname);
            process.StandardInput.WriteLine("clear");
            System.Threading.Thread.Sleep(100);
            process.StandardInput.WriteLine("del " + str_tempimage);
            process.StandardInput.WriteLine("del " + str_temparchive); // ghetto delete c0z we Livin in da h00d, not realy but im gay *cowboy emoji*
            process.StandardInput.WriteLine("clear");
            System.Threading.Thread.Sleep(100);
            process.StandardInput.WriteLine("exit");

            System.Threading.Thread.Sleep(20);


        }
    }
}
