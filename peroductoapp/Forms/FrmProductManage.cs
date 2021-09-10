using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peroductoapp.Forms
{
    public partial class FrmProductManage : Form
    {
  

       
            private ProductoModel productoModel;
            public FrmProductManage()
            {
                productoModel = new ProductoModel();
                InitializeComponent();
            }

            private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            }

         
            private void rtbProductView_TextChanged(object sender, EventArgs e)
            {

            }

            private void pnlCaducity_Paint(object sender, PaintEventArgs e)
            {

            }

            private void pnlMeasureUnit_Paint(object sender, PaintEventArgs e)
            {

            }

            private void pnlPriceRange_Paint(object sender, PaintEventArgs e)
            {

            }

            private void pnlId_Paint(object sender, PaintEventArgs e)
            {

            }

            private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }

        private void cmbFinder_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    pnlId.Visible = true;
                    pnlMeasureUnit.Visible = false;
                    pnlPriceRange.Visible = false;
                    pnlCaducity.Visible = false;
                    break;
                case 1:
                    pnlId.Visible = false;
                    pnlMeasureUnit.Visible = true;
                    pnlPriceRange.Visible = false;
                    pnlCaducity.Visible = false;
                    break;
                case 2:
                    pnlId.Visible = false;
                    pnlMeasureUnit.Visible = false;
                    pnlPriceRange.Visible = true;
                    pnlCaducity.Visible = false;
                    break;
                case 3:
                    pnlId.Visible = false;
                    pnlMeasureUnit.Visible = false;
                    pnlPriceRange.Visible = false;
                    pnlCaducity.Visible = true;
                    break;
            }

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.ProductoModel = productoModel;
            frmProducto.ShowDialog();

            rtbProductView.Text = productoModel.GetProductosAsJson();
        }
    }
    }
    