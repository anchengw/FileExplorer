using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileExplorer
{
    public partial class FormAttributes : Form
    {
        public FormAttributes(string path)
        {
            InitializeComponent();
            if (Directory.Exists(path))
            {                
                DirectoryInfo dir = new DirectoryInfo(path);
                this.FileName = dir.Name;
                this.FileType = "文件夹";
                this.FileLocation = (dir.Parent != null) ? dir.Parent.FullName : null;
                this.FileCreationTime = dir.CreationTime.ToString();
                this.FileLastWriteTime = dir.LastAccessTimeUtc.ToString();
                this.FileLastAccessTime = dir.LastAccessTimeUtc.ToString();
                //this.FileLength = dir.
                
            }
            else if (File.Exists(path))
            {
                FileInfo file = new FileInfo(path);
                this.FileName = file.Name;
                this.FileType = file.Extension;
                this.FileLocation = (file.DirectoryName != null) ? file.DirectoryName : null;
                this.FileCreationTime = file.CreationTime.ToString();
                this.FileLastWriteTime = file.LastAccessTimeUtc.ToString();
                this.FileLastAccessTime = file.LastAccessTimeUtc.ToString();
                this.FileLength = file.Length.ToString() + " 字节";
            }
            this.Show();
 
        }

        public string FileName
        {
            get { return textBox1.Text;}
            set { textBox1.Text = value; }
        }

        public string FileType
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string FileLocation
        {
            get { return  textBox3.Text;}
            set { textBox3.Text = value; }
        }

        public string FileLength
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        public string FileCreationTime
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }

        public string FileLastWriteTime
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }

        public string FileLastAccessTime
        {
            get { return textBox7.Text; }
            set { textBox7.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
