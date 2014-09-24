﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Forms
{
    public partial class Home : Form
    {
        string user_type;
        public Home()
        {
            InitializeComponent();
            DateTime dateTime = DateTime.UtcNow.Date;
            label1.Text = DateTime.Now.ToString("MM/dd/yyyy" +"  | |  " + "hh:mm tt");

            button1.Hide();
            button2.Hide();
            button3.Hide();
            label2.Hide();
           

            //List<String> admins = new List<String>();
            //List<String> employees = new List<String>();

            //data admin_name = new data();
            //admin_name.add(admins, "Karan");
            //admin_name.add(admins, "Max");
            //admin_name.add(admins, "Jeff");

            //data emp_name = new data();
            //emp_name.add(employees, "Kobe");
            //emp_name.add(employees, "Jordan");
            //emp_name.add(employees, "Iverson");
            //emp_name.add(employees, "Magic");

            
            
            string[] users = new string[] { "Karan", "Michelle", "Max", "Jeff" , "Ranier" , "Augustin", "Kobe", "Jordan", "Iverson", "Magic"};

            var source0 = new AutoCompleteStringCollection();
            source0.AddRange(users);
            comboBox1.Items.AddRange(users);
            comboBox1.AutoCompleteCustomSource = source0;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
 
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Expense_Data_Entry form2 = new Expense_Data_Entry();
            form2.ShowDialog();
           // this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;
            if (comboBox1.Text != "")
            {
                label2.Show();

                if (comboBox1.Text == "Karan" || comboBox1.Text == "Michelle")
                    user_type = "admin";
                else
                    user_type = "emp";
            }
            
            if (user_type == "admin")
            {
                comboBox1.Hide();
                button4.Hide();
                button1.Show();
                button2.Show();
                button3.Show();
            }
            else if (user_type == "emp")
            {
                comboBox1.Hide();
                button4.Hide();
                button2.Show();
                button3.Show();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Expense_Reports form3 = new Expense_Reports();
            form3.ShowDialog();
           // this.Hide();
        }
        }   
 }