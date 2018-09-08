using SmartOrder.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartOrder
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Personnel p = new Personnel();
            bool result = p.PersonnelEntryControl(txtPassword.Text, General.pId);
            if (result)
            {
                PersonnelMovement pm = new PersonnelMovement();
                pm.Personnelid = General.pId;
                pm.Operation = "Entry was made";
                pm.Date = DateTime.Now;
                pm.PersonnelActivionSave(pm);
                this.Hide();
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
            }
            else
            {
                MessageBox.Show("Your password is incorrect", "Warning !!!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            Personnel p = new Personnel();
            p.GetPersonnel(cmbUsername);
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personnel p = (Personnel)cmbUsername.SelectedItem;
            General.pId = p.Personnelid;
            General.pDutyId = p.PersonnelDutyId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?","Warning !!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
