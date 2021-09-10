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
    public partial class Frmproducto : Form
    {
        public ProductoModel ProductoModel { get; set; }
        public Frmproducto()
        {
            InitializeComponent();
        }
        
      

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>().ToArray()
                                         );
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id = ProductoModel.GetLastProductoId() + 1,
                Nombre = txtName.Text,
                Descripcion = txtDesc.Text,
                Existencia = (int)nudExist.Value,
                Precio = nudPrice.Value,
                FechaVencimiento = dtpCaducity.Value,
                UnidadMedida = (UnidadMedida)cmbMeasureUnit.SelectedIndex
            };

            ProductoModel.Add(p);

            Dispose();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

   
