using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            button2.Click += (sender, e) => { SubMenuTimer.Start();
                ProductManagement ProductmanagementControl = new ProductManagement();
                ProductmanagementControl.Dock = DockStyle.Fill;
                panel2.AutoScroll = true;
                panel2.Controls.Clear();
                panel2.Controls.Add(ProductmanagementControl);
            };
            BurgerIcon.Click += (sender, e) => MenuTimer.Start();
        }

        
        bool SubmenuExpand = false, menuExpand = false;
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubMenuTimer_Tick(object sender, EventArgs e)
        {
            if (SubmenuExpand == false)
            {
                flowLayoutPanel1.Height += 10;
                if (flowLayoutPanel1.Height >= 135)
                {
                    SubMenuTimer.Stop();
                    SubmenuExpand = true;
                }
            }
            else { 
                flowLayoutPanel1.Height -= 10;
                if (flowLayoutPanel1.Height <= 48) {
                    SubMenuTimer.Stop();
                    SubmenuExpand = false;
                }
            }
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flowLayoutPanel2.Width += 10;
                if (flowLayoutPanel2.Width >= 245)
                {
                    MenuTimer.Stop();
                    menuExpand = true;
                }
            }

            else
            {
                flowLayoutPanel2.Width -= 10;
                if (flowLayoutPanel2.Width <= 60)
                {
                    MenuTimer.Stop();
                    menuExpand = false;
                }
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void BurgerIcon_Click(object sender, EventArgs e)
        {

        }

        
    }
}
