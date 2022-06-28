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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idm = Convert.ToInt32(id.Text);
            Class1 csd = new Class1();
            int no = csd.deleteAsset(idm);
            
            if (no > 0)
            {
                MessageBox.Show("Asset Deleted");


            }
            else
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }
    }
}
