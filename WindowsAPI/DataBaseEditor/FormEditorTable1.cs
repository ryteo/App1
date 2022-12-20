using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseLib;
using WindowsAPI;
using static System.Windows.Forms.DataFormats;

namespace WindowsFormsApp1.DataBaseEditor
{
    public partial class FormEditorTable1 : Form
    {
        public FormEditorTable1()
        {
            InitializeComponent();


        }
        
        
        public bool flagDelete = false;
        
        private void Table1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
           
            switch (tea._tableNAME)
            {
                case "main":
                    dataGridView1.DataSource = manager.GetDataTable(tea._tableName);
                    break;
                case "post":
                    dataGridView1.DataSource = manager.GetDataTable(tea._tablename1);
                    break;
                case "subjects":
                    dataGridView1.DataSource = manager.GetDataTable(tea._tablename2);
                    break;
                case "teachers":
                    dataGridView1.DataSource = manager.GetDataTable(tea._tablename3);
                    break;
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (flagDelete)
            {
                string[] args = new string[5];
                args[0] = textBox1.Text;
                args[1] = textBox2.Text;
                args[2] = textBox3.Text;
                args[3] = textBox4.Text;
                args[4] = textBox5.Text;



                DataBaseCommadsManager manager = new DataBaseCommadsManager();
                switch (tea._tableNAME)
                {
                    case "main":
                        manager.insertmain(args, tea._tableName);
                        break;
                    case "post":
                        manager.insertpost(args, tea._tablename1);
                        break;
                    case "subjects":
                        manager.insertsubjects(args, tea._tablename2);
                        break;
                    case "teachers":
                        manager.insertteachers(args, tea._tablename3);
                        break;
                }

                switch (tea._tableNAME)
                {
                    case "main":
                        dataGridView1.DataSource = manager.GetDataTable(tea._tableName);
                        break;
                    case "post":
                        dataGridView1.DataSource = manager.GetDataTable(tea._tablename1);
                        break;
                    case "subjects":
                        dataGridView1.DataSource = manager.GetDataTable(tea._tablename2);
                        break;
                    case "teachers":
                        dataGridView1.DataSource = manager.GetDataTable(tea._tablename3);
                        break;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Включить режим редактирования?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
                flagDelete = true;
                dataGridView1.ReadOnly = false;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                   "Выключить режим редактирования?",
                   "Подтверждение",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                flagDelete = false;
                dataGridView1.ReadOnly = true;
            }
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (flagDelete)
            {
                string[] args = new string[5];
                args[0] = textBox1.Text;
                args[1] = textBox2.Text;
                args[2] = textBox3.Text;
                args[3] = textBox4.Text;
                args[4] = textBox5.Text;

                DataBaseCommadsManager manager = new DataBaseCommadsManager();
                switch (tea._tableNAME)
                {
                    case "main":
                        manager.deletemain(args, tea._tableName);
                        break;
                    case "post":
                        manager.deletepost(args, tea._tablename1);
                        break;
                    case "subjects":
                        manager.deletesubjects(args, tea._tablename2);
                        break;
                    case "teachers":
                        manager.deleteteachers(args, tea._tablename3);
                        break;
                }
                switch (tea._tableNAME)
                {
                    case "main":
                        dataGridView1.DataSource = manager.GetDataTable(tea._tableName);
                        break;
                    case "post":
                        dataGridView1.DataSource = manager.GetDataTable(tea._tablename1);
                        break;
                    case "subjects":
                        dataGridView1.DataSource = manager.GetDataTable(tea._tablename2);
                        break;
                    case "teachers":
                        dataGridView1.DataSource = manager.GetDataTable(tea._tablename3);
                        break;
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            string[] args = new string[5];
            args[0] = textBox1.Text;
            args[1] = textBox2.Text;
            args[2] = textBox3.Text;
            args[3] = textBox4.Text;
            args[4] = textBox5.Text;


            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            switch (tea._tableNAME)
            {
                case "main":
                    manager.Updatemain(args, tea._tableName);
                    break;
                case "post":
                    manager.Updatepost(args, tea._tablename1);
                    break;
                case "teachers":
                    manager.Updatesubjects(args, tea._tablename2);
                    break;
                case "subjects":
                    manager.Updateteachers(args, tea._tablename3);
                    break;
            }
            switch (tea._tableNAME)
            {
                case "main":
                    dataGridView1.DataSource = manager.GetDataTable(tea._tableName);
                    break;
                case "post":
                    dataGridView1.DataSource = manager.GetDataTable(tea._tablename1);
                    break;
                case "subjects":
                    dataGridView1.DataSource = manager.GetDataTable(tea._tablename2);
                    break;
                case "teachers":
                    dataGridView1.DataSource = manager.GetDataTable(tea._tablename3);
                    break;
            }
            Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
