using P1;
using P1.APIStatic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.ImageList myImageList = new ImageList();
        private API a;
        private Detalii Selected;


        public Form1()
        {
            InitializeComponent();
            listView1.SmallImageList = myImageList;
            a = new API();
            List<Detalii> l = a.getAllDetalii();
            for(int i = 0; i<l.Count; i++)
            {
                listView1.Items.Add(new ListViewItem { ImageIndex = i, Text = l[i].Path, Tag = l[i].Path });
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = true,
                ValidateNames = true,
                Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|MP3|*.mp3|MP4|.*mp4"
            };
            FileInfo fi;

            myImageList.ImageSize = new Size(50, 50);
            int count = 1;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Clear();
                foreach(string fileName in ofd.FileNames)
                {
                    fi = new FileInfo(fileName);
                    using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                    {
                        myImageList.Images.Add(Image.FromStream(stream));

                    }

                    listView1.LargeImageList = myImageList;
                    listView1.Items.Add(new ListViewItem { ImageIndex = count, Text = fi.FullName, Tag = fi.FullName });
                    count++;
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Detalii d = new Detalii();
            d.Path = textPath.Text;
            d.Data = DateTime.Now;
            d.Locatie = textLocatie.Text;
            d.Eveniment = textEveniment.Text;
            d.Persoane = textPersoane.Text;
            d.Peisaje = textPeisaje.Text;

            a.addDetalii(d);
            a.Save();
    
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                var path = item.Text;

                Selected = a.getDetails(path);
                if (Selected != null)
                {
                    textPath.Text = Selected.Path;
                    textEveniment.Text = Selected.Eveniment;
                    textPersoane.Text = Selected.Persoane;
                    textPeisaje.Text = Selected.Peisaje;
                    textLocatie.Text = Selected.Locatie;
                }
                
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Selected.Path = textPath.Text.ToString();
            Selected.Eveniment = textEveniment.Text;
            Selected.Persoane = textPersoane.Text;
            Selected.Peisaje = textPeisaje.Text;
            Selected.Locatie = textLocatie.Text.ToString();
            
            a.Save();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            textPath.Text = listView1.SelectedItems[0].SubItems[0].Text;
        
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Selected.Deleted = true;

            a.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textEveniment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
