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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fileOrgProj
{
    public partial class searchBtn : Form
    {
        public searchBtn()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainForm().Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            info.rec_count =0;
            FileStream ff = new FileStream(info.filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(ff);
            BinaryWriter bw = new BinaryWriter(ff);

            int num_of_records = (int)bw.BaseStream.Length / info.rec_size;

            if (num_of_records > 0) // If The file Not Empty
            {
                bw.BaseStream.Seek(0, SeekOrigin.Begin); // Move to Beginning of file
              
                for (int i = 0; i < (int)bw.BaseStream.Length; i+=info.rec_size)
                {
                    bw.BaseStream.Seek(i, SeekOrigin.Begin); // Move to Specific Position in a File
                    int id = br.ReadInt32(); // Read ID
                    if (id == Convert.ToInt32(idTxtBox.Text)) // If ID Matches
                    {
                        //
                        //bw.Seek(-4, SeekOrigin.Current); // Move Back 4 Bytes
                        bw.Write(nameTxtBox.Text); // Write Name 
                        bw.Write(phoneTxtBox.Text); // Write Tel
                        bw.Write(ageTxtBox.Text); // Write Gender
                        break;
                    }
                    else
                    {
                      
                    }
                }
            }
            else MessageBox.Show("Empty File");
            bw.Close();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            info.rec_count = 0;
            FileStream ff = new FileStream(info.filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(ff);
            BinaryWriter bw = new BinaryWriter(ff);

            int num_of_records = (int)bw.BaseStream.Length / info.rec_size;

            if (num_of_records > 0) // If The file Not Empty
            {
                bw.BaseStream.Seek(0, SeekOrigin.Begin); // Move to Beginning of file

                for (int i = 0; i < (int)bw.BaseStream.Length; i += info.rec_size)
                {
                    bw.BaseStream.Seek(i, SeekOrigin.Begin); // Move to Specific Position in a File
                    int id = br.ReadInt32(); // Read ID
                    if (id == Convert.ToInt32(idTxtBox.Text)) // If ID Matches
                    {
                        //
                        //bw.Seek(-4, SeekOrigin.Current); // Move Back 4 Bytes
                        bw.Write(nameTxtBox.Text); // Write Name 
                        bw.Write(phoneTxtBox.Text); // Write Tel
                        bw.Write(ageTxtBox.Text); // Write Gender
                        break;
                    }
                    else
                    {

                    }
                }
            }
            else MessageBox.Show("Empty File");
            bw.Close();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new mainForm().Show();
        }
    }
    }
}

        
