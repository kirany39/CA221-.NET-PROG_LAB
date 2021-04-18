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

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        string str, dateStr = "", districtStr = "", stateStr = "";
        string imgFileName = "";
        private object openFileDialog1;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        //Date of Birth button selection event
        private void button1_Click(object sender, EventArgs e)
        {

        }
        // Ok button event handler
        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs;
            try
            {
                getElectorDetails();
                fs = new FileStream("ElectorDetails.txt", FileMode.Append);
                fs.Write(ASCIIEncoding.ASCII.GetBytes(str), 0, str.Length);
                fs.Flush();
                fs.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Cancel button event handler
        private void button3_Click(object sender, EventArgs e)
        {
            str = "";
            this.Close();
        }
        //Photo selection button
        private void button4_Click(object sender, EventArgs e)
        {
            //get image file name using file open file dialog box
            
            
            pictureBox1.Image = Image.FromFile(imgFileName);
        }
        //get elector details from the form
        private void getElectorDetails()
        {
            // card no
            str += textBox1.Text;
            str += '\n';
            //elector name
            str += textBox2.Text;
            str += '\n';
            //father's name
            str += textBox3.Text;
            str += '\n';
            //sex
            if (radioButton1.Checked == true) str += "male";
            else if (radioButton2.Checked == true) str += "female";
            str += '\n';
            //date of birth - (as string from Date Time Picker)            
            string datestr = "";
            datestr += dateTimePicker1.Value.Day.ToString();
            datestr += "/";
            datestr += dateTimePicker1.Value.Month.ToString();
            datestr += "/";
            datestr += dateTimePicker1.Value.Year.ToString();
            str += datestr;
            str += '\n';
            //get address
            //door no
            str += textBox4.Text;
            str += '\n';
            //street
            str += textBox5.Text;
            str += '\n';
            //village/md/town
            str += textBox6.Text;
            str += '\n';
            //district - (from combo box)
            str += districtStr;
            str += '\n';
            // state - (from combo box)
            str += stateStr;
            str += '\n';
            //photo image filename
            str += imgFileName;
            MessageBox.Show(str);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            districtStr = (string)comboBox1.SelectedItem;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            stateStr = (string)comboBox2.SelectedItem;
            if (stateStr.Equals("GUNTUR"))
            {
                //change the district combo box values to karnataka state districts
                ComboBox.ObjectCollection cob;
                cob = comboBox1.Items;
                cob.Clear();
                comboBox1.Text = "";
                cob.Add("COIMBATORE");
                cob.Add("TIRUPATHI");
                comboBox1.SelectedItem = "COIMBATORE";
                districtStr = (string)comboBox1.SelectedItem;

            }
        }
    }

}
© 2021 GitHub, Inc.
