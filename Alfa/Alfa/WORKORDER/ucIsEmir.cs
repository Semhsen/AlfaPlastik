using System;
using System.Drawing;
using System.Windows.Forms;
using Alfa.BusinessLayer;
using Alfa.Entities.Models;

namespace Alfa.WORKORDER
{
    public partial class ucIsEmir : UserControl
    {
        ManagerWL_REQUEST managerWL_REQUEST = new ManagerWL_REQUEST();
        ManagerUser managerUser = new ManagerUser();
        ManagerWL_PLAN managerWL_PLAN = new ManagerWL_PLAN();
        ManagerWRKORD managerWRKORD = new ManagerWRKORD();
        NoString ns = new NoString();
        public ucIsEmir()
        {
            InitializeComponent();
        }
        #region TALEP AŞAMASI LOAD KISMI
        private void ucIsEmir_Load(object sender, EventArgs e)
        {   //KULLANICILARIN ID'LERİNDEN İSİMLERİNİ LİSTELER.
            comboBox1.DataSource = managerUser.List();
            comboBox1.DisplayMember = "NAME";
            comboBox1.ValueMember = "USERS_ID";
            comboBox1.Text = null;
            //DATETİMEPİCKERİN FORMATI DEĞİŞİR
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd.MM.yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            comboBox1.SelectedIndex = -1;
            label7.Visible = false;
            //button_Geri.Visible = false;
            //button_ileri.Visible = false;


            
        }
        #endregion

        #region PLANLAMA AŞAMASINA GİTME KISMI
        private void button_ileri_Click(object sender, EventArgs e) //UCEMİR2'YE GİTMEYİ SAĞLAR.
        {
            ucIsEmir2 uc2 = new ucIsEmir2();
            uc2.BringToFront();
            //if (!IsEmriEkle.Instance.panel2.Controls.Contains(ucIsEmir2.Instance))
            //{
            //    IsEmriEkle.Instance.panel2.Controls.Add(ucIsEmir2.Instance);
            //    ucIsEmir2.Instance.Dock = DockStyle.Fill;
            //    ucIsEmir2.Instance.BringToFront();
            //}
            //else
            //    ucIsEmir2.Instance.BringToFront();
            ////ucIsEmir2.Instance.textBox_tarih.Text = dateTimePicker2.Value.ToLongDateString();
            ////ucIsEmir2.Instance.richTextBox_TalepNot.Text = richTextBox_not.Text;
        }

        #endregion

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }

        private void comboBox_Öncelik_KeyPress(object sender, KeyPressEventArgs e)
        {
            ns.IntOrStringNo(e);
        }
    }
}

