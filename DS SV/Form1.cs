using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DS_SV
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //sqlconnection conn = new sqlconnection("data source=admin;initial catalog=dh10c8;integrated security=true");
        QLNV nhanvien;
        Modify modify;
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getAllSv();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi :" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            string name = this.textBox2.Text;
            DateTime date = this.Date.Value;
            string address = this.textBox4.Text;
            string lop = this.textBox5.Text;
            string DTB = this.textBox6.Text;
            nhanvien = new QLNV(id, name, date, address, lop, DTB);
            if(modify.insert(nhanvien))
            {
                dataGridView1.DataSource=modify.getAllSv();
            }
            else
            {
                MessageBox.Show("Lỗi :" + "k thể vào đc ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}
