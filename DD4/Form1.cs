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

namespace DD4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        //public void DragDropAll(DragEventArgs e)
        //{
        //    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

        //    for (int i = 0; i < files.Count(); i++)
        //    {
        //        listBox1.Items.Add(files[i]);

        //        FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

        //        renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + "onurbaba" + "_" + i + renamedFile.Extension);
        //    }
        //    listBox1.Items.Clear();
        //}

        
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox3.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
               !textBox1.Enabled &&
               !textBox2.Enabled
               )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            textBox3.Enabled = true;
            textBox4.Visible = true;
            textBox4.Enabled = true;
            textBox5.Visible = true;
            textBox5.Enabled = true;
            textBox6.Visible = true;
            textBox6.Enabled = true;
            textBox7.Visible = true;
            textBox7.Enabled = true;
            textBox8.Visible = true;
            textBox8.Enabled = true;
            textBox9.Visible = true;
            textBox9.Enabled = true;
            textBox10.Visible = true;
            textBox10.Enabled = true;
            textBox11.Visible = true;
            textBox11.Enabled = true;
            textBox12.Visible = true;
            textBox12.Enabled = true;
            textBox13.Visible = true;
            textBox13.Enabled = true;
            textBox14.Visible = true;
            textBox14.Enabled = true;
            textBox15.Visible = true;
            textBox15.Enabled = true;
            textBox16.Visible = true;
            textBox16.Enabled = true;
            textBox17.Visible = true;
            textBox17.Enabled = true;
            textBox18.Visible = true;
            textBox18.Enabled = true;
            textBox19.Visible = true;
            textBox19.Enabled = true;
            textBox20.Visible = true;
            textBox20.Enabled = true;
            textBox21.Visible = true;
            textBox21.Enabled = true;


            //foreach (Control item in Controls)
            //{
            //    if (item is Panel)
            //    {
            //        if (item is textBox)
            //        {
            //            (item as TextBox).Visible = false;
            //            (item as TextBox).Enabled = false;
            //        }
            //    }
            //}

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            textBox3.Enabled = false;
            textBox4.Visible = false;
            textBox4.Enabled = false;
            textBox5.Visible = false;
            textBox5.Enabled = false;
            textBox6.Visible = false;
            textBox6.Enabled = false;
            textBox7.Visible = false;
            textBox7.Enabled = false;
            textBox8.Visible = false;
            textBox8.Enabled = false;
            textBox9.Visible = false;
            textBox9.Enabled = false;
            textBox10.Visible = false;
            textBox10.Enabled = false;
            textBox11.Visible = false;
            textBox11.Enabled = false;
            textBox12.Visible = false;
            textBox12.Enabled = false;
            textBox13.Visible = false;
            textBox13.Enabled = false;
            textBox14.Visible = false;
            textBox14.Enabled = false;
            textBox15.Visible = false;
            textBox15.Enabled = false;
            textBox16.Visible = false;
            textBox16.Enabled = false;
            textBox17.Visible = false;
            textBox17.Enabled = false;
            textBox18.Visible = false;
            textBox18.Enabled = false;
            textBox19.Visible = false;
            textBox19.Enabled = false;
            textBox20.Visible = false;
            textBox20.Enabled = false;
            textBox21.Visible = false;
            textBox21.Enabled = false;

            label1.Text = textBox3.Text;
            label2.Text = textBox4.Text;
            label3.Text = textBox5.Text;
            label4.Text = textBox6.Text;
            label5.Text = textBox7.Text;
            label6.Text = textBox8.Text;
            label7.Text = textBox9.Text;
            label8.Text = textBox10.Text;
            label9.Text = textBox11.Text;
            label10.Text = textBox12.Text;
            label11.Text = textBox13.Text;
            label12.Text = textBox14.Text;
            label13.Text = textBox15.Text;
            label14.Text = textBox16.Text;
            label15.Text = textBox17.Text;
            label16.Text = textBox18.Text;
            label17.Text = textBox21.Text;
            label18.Text = textBox20.Text;
            label19.Text = textBox19.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox4.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
               !textBox1.Enabled &&
               !textBox2.Enabled
               )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel3_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox5.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
               !textBox1.Enabled &&
               !textBox2.Enabled 
               )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel4_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox6.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
               !textBox1.Enabled &&
               !textBox2.Enabled
               )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel8_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox7.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
               !textBox1.Enabled &&
               !textBox2.Enabled 
               )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel7_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox8.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
               !textBox1.Enabled &&
               !textBox2.Enabled 
               )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel6_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox9.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
               !textBox1.Enabled &&
               !textBox2.Enabled 
               )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel5_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox10.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
                !textBox1.Enabled &&
                !textBox2.Enabled
                )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel9_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox11.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
                !textBox1.Enabled &&
                !textBox2.Enabled 
                )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel10_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox12.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
               !textBox1.Enabled &&
               !textBox2.Enabled
               )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel11_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox13.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel11_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
                  !textBox1.Enabled &&
                  !textBox2.Enabled
                  )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel12_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox14.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel12_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
                 !textBox1.Enabled &&
                 !textBox2.Enabled
                 )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel13_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox15.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel13_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
                 !textBox1.Enabled &&
                 !textBox2.Enabled 
                 )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel14_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox16.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel14_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
                 !textBox1.Enabled &&
                 !textBox2.Enabled 
                 )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel15_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox17.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel15_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
                 !textBox1.Enabled &&
                 !textBox2.Enabled 
                 )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel16_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox18.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel16_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
                 !textBox1.Enabled &&
                 !textBox2.Enabled
                 )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel17_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox19.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel17_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
                  !textBox1.Enabled &&
                  !textBox2.Enabled 
                  )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel18_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox20.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel18_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
                 !textBox1.Enabled &&
                 !textBox2.Enabled
                 )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }

        private void panel19_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < files.Count(); i++)
            {
                listBox1.Items.Add(files[i]);

                FileInfo renamedFile = new FileInfo((string)listBox1.Items[i]);

                renamedFile.MoveTo(renamedFile.Directory.FullName + "\\" + textBox1.Text + "_" + textBox2.Text + "_" + textBox21.Text + "_" + i + renamedFile.Extension);
            }
            listBox1.Items.Clear();
        }

        private void panel19_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true &&
                 !textBox1.Enabled &&
                 !textBox2.Enabled
                 )
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                MessageBox.Show("Lütfen TextBox'ları kilitleyin! Yada doldurun!");
            }
        }
    }
}
