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
    public partial class FormKitchen : Form
    {
        public FormKitchen()
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

        private void FormKitchen_Load(object sender, EventArgs e)
        {
            rbProduct_CheckedChanged(sender, e);
            rbProduct.Checked = true;
            Category ctr = new Category();
            ctr.GetCategories(cmbCategory);
            ctr.GetCategories(LVCategory);
            cmbCategory.Items.Insert(0, "All Categories");
            cmbCategory.SelectedIndex = 0;
            lblSearch.Visible = false;
            txtSearch.Visible = false;
        }

        private void Clear()
        {
            txtSearch.Clear();
            txtCtrId.Clear();
            txtCtrName.Clear();
            txtCtrDescription.Clear();
            txtPrdId.Clear();
            txtPrdName.Clear();
            txtPrdPrice.Clear();
            txtPrdPrice.Text = string.Format("{0:##0.00}", 0);
        }

        int cId = 0;
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = new Product();
            if (cmbCategory.SelectedItem.ToString() == "All Categories")
            {
                p.ProductsList(LVProducts);
            }
            else
            {
                Category ctr = (Category)cmbCategory.SelectedItem;
                cId = ctr.Id;
                p.GetProductById(LVProducts, cId);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbProduct.Checked)
            {
                if (txtPrdName.Text.Trim() == "" || txtPrdPrice.Text.Trim() == "" || cmbCategory.SelectedItem.ToString() == "All Categories")
                {
                    MessageBox.Show("Fill in the empty spaces!");
                }
                else
                {
                    Product p = new Product();
                    p.CategoryId = cId;
                    p.ProductName = txtPrdName.Text;
                    p.Price = Convert.ToDecimal(txtPrdPrice.Text);
                    p.Description = "Product";
                    int result = p.AddProduct(p);
                    if (result != 0)
                    {
                        MessageBox.Show("Operation successful!");
                        Clear();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Operation failed!");
                    }
                }
            }
            else if (rbCategory.Checked)
            {
                if (txtCtrName.Text.Trim() == "" || txtCtrDescription.Text.Trim() == "")
                {
                    MessageBox.Show("Fill in the empty spaces!");
                }
                else
                {
                    Category c = new Category();
                    c.CategoryName = txtCtrName.Text;
                    c.Description = txtCtrDescription.Text;
                    int result = c.AddCategory(c);
                    if (result != 0)
                    {
                        MessageBox.Show("Operation successful!");
                        Clear();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Operation failed!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select category or product!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbProduct.Checked)
            {
                if (LVProducts.SelectedItems.Count > 0)
                {
                    if (txtPrdName.Text.Trim() == "" || txtPrdPrice.Text.Trim() == "" || cmbCategory.SelectedItem.ToString() == "All Categories")
                    {
                        MessageBox.Show("Fill in the empty spaces!");
                    }
                    else
                    {
                        Product p = new Product();
                        p.Id = Convert.ToInt32(txtPrdId.Text);
                        p.CategoryId = cId;
                        p.ProductName = txtPrdName.Text;
                        p.Price = Convert.ToDecimal(txtPrdPrice.Text);
                        p.Description = "Product";
                        int result = p.UpdateProduct(p);
                        if (result != 0)
                        {
                            MessageBox.Show("Operation successful!");
                            Clear();
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Operation failed!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select product from table!");
                }
            }
            else if (rbCategory.Checked)
            {
                if (LVCategory.SelectedItems.Count > 0)
                {
                    if (txtCtrId.Text.Trim() == "" || txtCtrName.Text.Trim() == "" || txtCtrDescription.Text.Trim() == "")
                    {
                        MessageBox.Show("Fill in the empty spaces!");
                    }
                    else
                    {
                        Category c = new Category();
                        c.Id = Convert.ToInt32(txtCtrId.Text);
                        c.CategoryName = txtCtrName.Text;
                        c.Description = txtCtrDescription.Text;
                        int result = c.UpdateCategory(c);
                        if (result != 0)
                        {
                            MessageBox.Show("Operation successful!");
                            Clear();
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Operation failed!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select category from table!");
                }
            }
            else
            {
                MessageBox.Show("Select category or product!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rbProduct.Checked)
            {
                if (LVProducts.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete it?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        Product p = new Product();
                        int result = p.DeleteProduct(Convert.ToInt32(LVProducts.SelectedItems[0].SubItems[0].Text));
                        if (result != 0)
                        {
                            MessageBox.Show("The product delete has been successful.");
                            Clear();
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Product delete failed!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select product from table!");
                }
            }
            else if (rbCategory.Checked)
            {
                if (LVCategory.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete it?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        Category c = new Category();
                        int result = c.DeleteCategory(Convert.ToInt32(LVCategory.SelectedItems[0].SubItems[0].Text));
                        Product p = new Product();
                        p.DeleteProductSameCatgory(result);
                        //p.DeleteProductSameCatgory(result, 1);
                        if (result != 0)
                        {
                            MessageBox.Show("The product delete has been successful.");
                            Clear();
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Product delete failed!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select category from table!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select category or product!");
            }
        }

        private void LVProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVProducts.SelectedItems.Count > 0)
            {
                txtPrdId.Text = LVProducts.SelectedItems[0].SubItems[0].Text;
                txtCtrId.Text = LVProducts.SelectedItems[0].SubItems[1].Text;
                cmbCategory.SelectedIndex = Convert.ToInt32(LVProducts.SelectedItems[0].SubItems[1].Text) - 1;
                txtCtrName.Text = LVProducts.SelectedItems[0].SubItems[2].Text;
                txtPrdName.Text = LVProducts.SelectedItems[0].SubItems[3].Text;
                txtPrdPrice.Text = LVProducts.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void LVCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVCategory.SelectedItems.Count > 0)
            {
                txtCtrId.Text = LVProducts.SelectedItems[0].SubItems[0].Text;
                txtCtrName.Text = LVProducts.SelectedItems[0].SubItems[1].Text;
                txtCtrDescription.Text = LVProducts.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblSearch.Visible = true;
            txtSearch.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbProduct.Checked)
            {
                Product p = new Product();
                p.GetProductByName(LVProducts, txtSearch.Text);
            }
            else if (rbCategory.Checked)
            {
                Category ctr = new Category();
                ctr.CategorySearch(LVCategory, txtSearch.Text);
            }
            else
            {
                MessageBox.Show("Select product or category");
            }
        }

        private void rbProduct_CheckedChanged(object sender, EventArgs e)
        {
            panelProduct.Visible = true;
            panelCategory.Visible = false;
            LVProducts.Visible = true;
            LVCategory.Visible = false;
            Clear();
            refresh();
        }

        private void rbCategory_CheckedChanged(object sender, EventArgs e)
        {
            panelCategory.Visible = true;
            panelProduct.Visible = false;
            LVCategory.Visible = true;
            LVProducts.Visible = false;
            Clear();
            refresh();
        }

        private void refresh()
        {
            Category c = new Category();
            c.GetCategories(cmbCategory);
            c.GetCategories(LVCategory);
            cmbCategory.Items.Insert(0, "All Categories");
            cmbCategory.SelectedIndex = 0;
            Product p = new Product();
            p.ProductsList(LVProducts);
        }
    }
}
