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
using Alfa.Entities.Models;

namespace Alfa.WORKORDER
{
    public partial class ucIsEmirDuzen2 : UserControl
    {
        ManagerWL_PLAN managerWL_PLAN = new ManagerWL_PLAN();
        ManagerOPERATION managerOPERATION = new ManagerOPERATION();
        ManagerUser managerUser = new ManagerUser();
        NoString ns = new NoString();
        UcEmirGor uc = new UcEmirGor();
        ManagerV_WRKORD_GRID managerV_WRKORD_GRID = new ManagerV_WRKORD_GRID();
        public ucIsEmirDuzen2()
        {
            InitializeComponent();
        }

        private void ucIsEmirDuzen2_Load(object sender, EventArgs e)
        {

            this.oPERATIONTableAdapter.Fill(this.alfaPlastikDataSet2.OPERATION);
        
        }

      
        private void comboBox_BakımPersonel_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_BakımPersonel.DataSource = managerUser.List();
            comboBox_BakımPersonel.DisplayMember = "NAME";
            comboBox_BakımPersonel.ValueMember = "USERS_ID";
        }

        private void comboBox_BakımPersonel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }

        private void textBox_saat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.StringNo(e);
        }

       
    }
}
