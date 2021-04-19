using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp17
{
 public partial class Form1 : Form
 {
 public Form1()
 {
 InitializeComponent();
 }
 private void button1_Click(object sender, EventArgs e)
 {
 string st;
 Random r = new Random();
 int genRand = r.Next(10000, 50000);
 string s = comboBox1.SelectedItem.ToString();
 st = "Name: " + textBox1.Text + "\n";
 st = st + "College: " + s + "\n";
 st = st +"Your ID: "+ s+genRand.ToString();
 MessageBox.Show(st);
 }
 }
