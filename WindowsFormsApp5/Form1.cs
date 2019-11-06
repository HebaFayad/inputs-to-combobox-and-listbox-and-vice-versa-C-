using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (txtFname.Text != "" && txtLname.Text != "") { 
            lisFName.Items.Add(txtFname.Text);
            lisLName.Items.Add(txtLname.Text);
            txtFname.Text = "";
            txtLname.Text = "";

                lblLB1Count.Text = lisFName.Items.Count.ToString();
                lblLB2Count.Text = lisLName.Items.Count.ToString();

            }
            else
            {
                MessageBox.Show("please check if thier is an empty box");
            }
        }

        private void lisFName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lisLName.SelectedIndex = lisFName.SelectedIndex;
        }

        private void lisLName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lisFName.SelectedIndex = lisLName.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = lisFName.SelectedIndex;
            lisFName.Items.RemoveAt(i);
            lisLName.Items.RemoveAt(i);

            lblLB1Count.Text = lisFName.Items.Count.ToString();
            lblLB2Count.Text = lisLName.Items.Count.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lisFName.Items.Clear();
            lisLName.Items.Clear();

            lblLB1Count.Text = lisFName.Items.Count.ToString();
            lblLB2Count.Text = lisLName.Items.Count.ToString();

        }

        private void comFName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comLName.SelectedIndex = comFName.SelectedIndex;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comFName.Items.Add(lisFName.SelectedItem);
            comLName.Items.Add(lisLName.SelectedItem);

            int i = lisFName.SelectedIndex;
            lisFName.Items.RemoveAt(i);
            lisLName.Items.RemoveAt(i);

            lblLB1Count.Text = lisFName.Items.Count.ToString();
            lblLB2Count.Text = lisLName.Items.Count.ToString();

            comFName.SelectedIndex = 0;
            comLName.SelectedIndex = 0;

            lblCFName.Text = comFName.Items.Count.ToString();
            lblCLName.Text = comLName.Items.Count.ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void z(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            foreach (var item in lisFName.Items)
            { comFName.Items.Add(item); }

            lisFName.Items.Clear();

            foreach (var tems in lisLName.Items)
            { comLName.Items.Add(tems); }

            lisLName.Items.Clear();

            lblLB1Count.Text = lisFName.Items.Count.ToString();
            lblLB2Count.Text = lisLName.Items.Count.ToString();

            lblCFName.Text = comFName.Items.Count.ToString();
            lblCLName.Text = comLName.Items.Count.ToString();



        }

        private void first_SelectedIndexChanged(object sender, EventArgs e)
        {
            last.SelectedIndex = first.SelectedIndex;
        }

        private void comLName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comFName.SelectedIndex = comLName.SelectedIndex;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            first.Items.Add(comFName.SelectedItem);
            last.Items.Add(comLName.SelectedItem);
            for (int i = 0; i < first.Items.Count; i++)
            {
                var A = first.Items[i].ToString();
                
                    var B = last.Items[i].ToString();
                    fullname.Items.Add(A + "   " + B);
                
            }





            int a = comFName.SelectedIndex;
            comFName.Items.RemoveAt(a);
            comLName.Items.RemoveAt(a);

            label10.Text = first.Items.Count.ToString();
            label11.Text = last.Items.Count.ToString();

            lblCFName.Text = comFName.Items.Count.ToString();
            lblCLName.Text = comLName.Items.Count.ToString();

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var firstName = first.Items;
            var lastName = last.Items;
            fullname.Items.Clear();
            
            foreach (var com1 in comFName.Items)
            { firstName.Add(com1); }

            comFName.Items.Clear();

            foreach (var com2 in comLName.Items)
            { lastName.Add(com2);  }
         

            for (int i = 0; i < first.Items.Count; i++)
            {
                var A = first.Items[i].ToString();
                
                    var B = last.Items[i].ToString();
                    fullname.Items.Add(A + "   " + B);
                
            }

            comLName.Items.Clear();

            lblCFName.Text = comFName.Items.Count.ToString();
            lblCLName.Text = comLName.Items.Count.ToString();

            label10.Text = first.Items.Count.ToString();
            label11.Text = last.Items.Count.ToString();


           
            





        }

        private void remCBtn_Click(object sender, EventArgs e)
        {
            int b = comFName.SelectedIndex;
            comFName.Items.RemoveAt(b);
           comLName.Items.RemoveAt(b);

            lblCFName.Text = comFName.Items.Count.ToString();
            lblCLName.Text = comLName.Items.Count.ToString();
        }

        private void remACBtn_Click(object sender, EventArgs e)
        {
            comFName.Items.Clear();
           comLName.Items.Clear();

            lblCFName.Text = comFName.Items.Count.ToString();
            lblCLName.Text = comLName.Items.Count.ToString();
        }

        private void last_SelectedIndexChanged(object sender, EventArgs e)
        {
            first.SelectedIndex = last.SelectedIndex;
        }

        private void fullname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
