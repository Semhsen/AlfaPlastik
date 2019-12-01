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
    public partial class ucIsEmirDuzen3 : UserControl
    {
        ManagerWL_PLAN managerWL_PLAN = new ManagerWL_PLAN();
        ManagerOPERATION managerOPERATION = new ManagerOPERATION();
        ManagerUser managerUser = new ManagerUser();
        ManagerV_WRKORD_GRID managerV_WRKORD_GRID = new ManagerV_WRKORD_GRID();
        public ucIsEmirDuzen3()
        {
            InitializeComponent();

           
        
    }

       
}
}
