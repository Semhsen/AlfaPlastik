using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alfa.BusinessLayer;

namespace Alfa.WORKORDER
{
    public partial class ucIsEmirDuzen1 : UserControl
    {
        ManagerUser managerUser = new ManagerUser();
        NoString ns = new NoString();
        
        public ucIsEmirDuzen1()
        {
            InitializeComponent();
        }

       
        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.DataSource = managerUser.List();
            comboBox1.DisplayMember = "NAME";
            comboBox1.ValueMember = "USERS_ID";
        }

        private void button_ileri_Click(object sender, EventArgs e)
        {
        //    if (!IsEmriDuzenle.Instance.panel2.Controls.Contains(ucIsEmirDuzen2.Instance))
        //    {
        //        IsEmriDuzenle.Instance.panel2.Controls.Add(ucIsEmirDuzen2.Instance);
        //        ucIsEmirDuzen2.Instance.Dock = DockStyle.Fill;
        //        ucIsEmirDuzen2.Instance.BringToFront();
              
        //    }
        //    else
        //        ucIsEmirDuzen2.Instance.BringToFront();
        //    IsEmriDuzenle.Instance.PlanDuzen();
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }
    }
}
