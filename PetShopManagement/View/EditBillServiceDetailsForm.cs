using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopManagement.View
{   
    public partial class EditBillServiceDetailsForm : Form
    {
        public string ServiceName { get; set; }
        public string ServicePrice { get; set; }
        public ListView ListViewBill { get; set; }
        public EditBillServiceDetailsForm()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            textBox1.Text = ServiceName; 
            textBox2.Text = ServicePrice;

            
            listView1 = ListViewBill;
        }
    }
}
