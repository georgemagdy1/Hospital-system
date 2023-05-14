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
    public partial class displayForm : Form
    {
        
       

        public displayForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainForm().Show();

        }

        private void patientTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void displayForm_Load(object sender, EventArgs e)
        {

        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.Open(info.filename, FileMode.Open, FileAccess.Read));
           // info.rec_count = 0;
            int num_of_records = (int)br.BaseStream.Length / info.rec_size;
            if(num_of_records > 0)
            for(int i =0; i < num_of_records; i++)
            {
                                         //  NumOfRecLabel.Text = num_of_records.ToString();
                                         // FileSizeLabel.Text = br.BaseStream.Length.ToString();

                br.BaseStream.Seek(info.rec_count, SeekOrigin.Begin); // Move to Specific Position in a File
                
                displayTxtBox.Text +="Code : "+ br.ReadInt32().ToString()+"\t"; // Read ID and display it in the ID text Box
                displayTxtBox.Text +="Name : "+ br.ReadString()+"/t"; // Read Name
                displayTxtBox.Text +="Phone Num : "+ br.ReadString()+"\t"; // Read Tel
                displayTxtBox.Text +=" age : "+ br.ReadString() + "\t"+"\n"; // Read age


                    info.rec_count += info.rec_size; // Move to the next Record 

            }
            else MessageBox.Show("Empty File");
            



           br.Close(); 
        }
        private void patientTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
                {

                }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }
    

