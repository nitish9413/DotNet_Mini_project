using System.Data;
using System.Net.Http;
using WindowsFormsApp15;

namespace ise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Show();
            userControl11.BringToFront();
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* Form1 frm1 = new Form1();
             frm1.Hide();
             Form2 frm2 = new Form2();
             frm2.Show();
              frm2.BringToFront();*/
            userControl11.Hide();
            userControl21.Show();
            userControl31.Hide();
            userControl21.BringToFront();
            panel4.Visible = true;
            panel3.Visible = false;
            panel5.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form1 frm1 = new Form1();
            //frm1.Hide();
            //Form3 frm3 = new Form3();
           // frm3.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Class1 css1 = new Class1();
            //DataTable dt = new DataTable();
            //dt = css1.Display_data();
            //dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frn1 = new Form1();
            Application.Exit();
            /*Form2 frn2 = new Form2();
            frn2.Close();*/
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl31.BringToFront();
            panel4.Visible = false;
            panel3.Visible = false;
            panel5.Visible = true;
        }
    }
}