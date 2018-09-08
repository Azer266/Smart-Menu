using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartOrder.Classes;

namespace SmartOrder
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?", "Warning !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm frm = new MenuForm();
            this.Close();
            frm.Show();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            Personnel p = new Personnel();
            PersonnelDuty pd = new PersonnelDuty();
            string duty = pd.GetByPersonnelDuty(General.pDutyId);

            if (duty=="Patron")
            {
                p.GetPersonnel(cmbPersonnels);
                pd.GetByPersonnelsDuty(cmbPersonnelDuties);
                p.GetPersonnelsInfo(LVPersonnel);
                btnPAdd.Enabled = true;
                btnPSave.Enabled = false;
                //btnUpdate.Enabled = false;
                //btnPUpdate.Enabled = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                txtPPassword.ReadOnly = true;
                txtPRPassword.ReadOnly = true;
                lblPosition.Text = "Position: Patron / Authority is unlimited / User: " + p.GetPersonnelName(General.pId);
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                lblPosition.Text = "Position: Patron / Authority is limited / User: " + p.GetPersonnelName(General.pId);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim() != "" && txtRNewPassword.Text.Trim() != "")
            {
                if (txtNewPassword.Text == txtRNewPassword.Text)
                {
                    if (txtPersonnelid.Text != "")
                    {
                        Personnel p = new Personnel();
                        bool result = p.SetPasswordChange(Convert.ToInt32(txtPersonnelid.Text), txtNewPassword.Text);
                        if (result)
                        {
                            MessageBox.Show("The password change has been successful.");
                        }
                        else
                        {
                            MessageBox.Show("Password change failed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select Personnel");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords must be the same!");
                }
            }
            else
            {
                MessageBox.Show("Fill in the empty spaces!");
            }
        }

        private void cmbPersonnelDuties_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonnelDuty pd = (PersonnelDuty)cmbPersonnelDuties.SelectedItem;
            txtPDutyId.Text = Convert.ToString(pd.Id);
        }

        private void cmbPersonnels_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            Personnel p = (Personnel)cmbPersonnels.SelectedItem;
            txtPersonnelid.Text = Convert.ToString(p.Personnelid);
        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            btnPAdd.Enabled = false;
            btnPSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnPUpdate.Enabled = false;
            txtPPassword.ReadOnly = false;
            txtPRPassword.ReadOnly = false;
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            if (LVPersonnel.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete it?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Personnel p = new Personnel();
                    bool result = p.DeletePersonnel(Convert.ToInt32(LVPersonnel.SelectedItems[0].SubItems[0].Text));
                    if (result)
                    {
                        MessageBox.Show("The personnel delete has been successful.");
                        p.GetPersonnelsInfo(LVPersonnel);
                    }
                    else
                    {
                        MessageBox.Show("Personnel delete failed!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select personnel from table!");
            }
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            if (txtPName.Text.Trim() != "" && txtPSurname.Text.Trim() != "" && txtPPassword.Text.Trim() != "" && txtPRPassword.Text.Trim() != "" && txtPDutyId.Text.Trim() != "")
            {
                if ((txtPPassword.Text.Trim() == txtPRPassword.Text.Trim()) && (txtPPassword.Text.Trim().Length > 5 && txtPRPassword.Text.Trim().Length > 5))
                {
                    Personnel p = new Personnel();
                    p.PersonnelName = txtPName.Text.Trim();
                    p.PersonnelSurname = txtPSurname.Text.Trim();
                    p.PersonnelPassword = txtPPassword.Text;
                    p.PersonnelDutyId = Convert.ToInt32(txtPDutyId.Text);
                    bool result = p.AddPersonnel(p);
                    if (result)
                    {
                        p.GetPersonnelsInfo(LVPersonnel);
                        MessageBox.Show("The personnel add has been successful.");
                    }
                    else
                    {
                        MessageBox.Show("Personnel add failed.");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords must be the same!");
                }
            }
            else
            {
                MessageBox.Show("Fill in the empty spaces!");
            }
        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            if (LVPersonnel.SelectedItems.Count > 0)
            {
                if (txtPId.Text.Trim() != "" && txtPName.Text.Trim() != "" && txtPSurname.Text.Trim() != "" && txtPDutyId.Text.Trim() != "")
                {
                    Personnel p = new Personnel();
                    p.Personnelid = Convert.ToInt32(txtPId.Text);
                    p.PersonnelDutyId = Convert.ToInt32(txtPDutyId.Text);
                    p.PersonnelName = txtPName.Text.Trim();
                    p.PersonnelSurname = txtPSurname.Text.Trim();
                    bool result = p.UpdatePersonnel(p);
                    if (result)
                    {
                        MessageBox.Show("The personnel update has been successful.");
                        p.GetPersonnelsInfo(LVPersonnel);
                    }
                    else
                    {
                        MessageBox.Show("Personnel update failed.");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the empty spaces!");
                }
            }
            else
            {
                MessageBox.Show("Select personnel from table");
            }
        }

        private void btnPasswordUpdate_Click(object sender, EventArgs e)
        {
            if (txtNPassword.Text.Trim() != "" && txtRNPassword.Text.Trim() != "")
            {
                if (txtNewPassword.Text == txtRNewPassword.Text)
                {
                    if (General.pId != 0)
                    {
                        Personnel p = new Personnel();
                        bool result = p.SetPasswordChange(General.pId, txtNPassword.Text);
                        if (result)
                        {
                            MessageBox.Show("The password change has been successful.");
                        }
                        else
                        {
                            MessageBox.Show("Password change failed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select Personnel");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords must be the same!");
                }
            }
            else
            {
                MessageBox.Show("Fill in the empty spaces!");
            }
        }

        private void LVPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVPersonnel.SelectedItems.Count > 0)
            {
                btnPDelete.Enabled = true;
                btnPUpdate.Enabled = true;
                txtPId.Text = LVPersonnel.SelectedItems[0].SubItems[0].Text;
                txtPDutyId.Text = LVPersonnel.SelectedItems[0].SubItems[1].Text;
                cmbPersonnelDuties.SelectedIndex = Convert.ToInt32(LVPersonnel.SelectedItems[0].SubItems[1].Text) - 1;
                txtPName.Text = LVPersonnel.SelectedItems[0].SubItems[3].Text;
                txtPSurname.Text = LVPersonnel.SelectedItems[0].SubItems[4].Text;
            }
        }
    }
}
