using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15;

namespace ise1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        /*public static void NumberOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }*/

       


        private void button3_Click(object sender, EventArgs e)
        {


            if (id.Text != null && name.Text != null && price.Text != null && amount.Text != null)
            {

                

                int idm = Convert.ToInt32(id.Text);

                //String pricecheck = price.Text;
                int pricem = Convert.ToInt32(price.Text);
                int amountm = Convert.ToInt32(amount.Text);

                /*char[] chars = pricecheck.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    int x = Convert.ToInt32(chars[i]);
                    if (x >= 48 && x < 58)
                    {
                        label1.Text = "";
                    }
                    else
                    {
                        label1.Text = "Numbers only";
                    }
                }*/

                
                    Class1 cs = new Class1();

                    int no = cs.adddata(idm, name.Text, pricem, amountm);
                    if (no > 0)
                    {
                        MessageBox.Show("Data added");
                        id.Clear();
                        name.Clear();
                        price.Clear();
                        amount.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Errors");
                    }
                

                //to call used this
               
            }
            else
            {
                MessageBox.Show("No null value accepted");
            }

           
        }

        /*private bool NumberOnly(TextBox id)
        {
            throw new NotImplementedException();
        }*/

        private void id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void id_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.Handled ==char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(label6, "Allows only numerical values");
                label6.Text = "Allows only numerical values";
            }
            else
            {
                errorProvider1.SetError(label6, "");
                label6.Text = "";
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled ==char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(label8, "Allows only numerical values");
                label8.Text = "Allows only numerical values";
            }
            else
            {
                errorProvider1.SetError(label8, "");
                label8.Text = "";
            }
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled ==char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(label1, "Allows only numerical values");
                label1.Text = "Allows only numerical values";
            }
            else
            {
                errorProvider1.SetError(label1, "");
                label1.Text = "";
            }
        }
    }
}
