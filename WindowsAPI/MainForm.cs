using DataBaseLib;
using WindowsFormsApp1.DataBaseEditor;

namespace WindowsAPI
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEditorTable1 table1 = new FormEditorTable1();
            table1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(tea._tableName);
            tea._tableNAME = tea._tableName;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(tea._tablename1);
            tea._tableNAME = tea._tablename1;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(tea._tablename2);
            tea._tableNAME = tea._tablename2;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(tea._tablename3);
            tea._tableNAME = tea._tablename3;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;


            dataGridView1.ReadOnly = true;
        }
    }
    public static class tea
    {
        public static string _tableName = "main";
        public static string _tablename1 = "post";
        public static string _tablename2 = "subjects";
        public static string _tablename3 = "teachers";

        public static string _tableNAME = string.Empty;
    }
}