using ProyectoPOS_1CA_A.CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOS_1CA_A.CapaPresentacion
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        //creacion de una lista estatica que simulura la Db
        public static List<Producto> listaProductos = new List<Producto>();


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            //Cargar los datos iniciales
            if (!listaProductos.Any())
                listaProductos.Add(new Producto
                {
                    Id = 1,
                    Nombre = "CafeGourmet",
                    Descripcion = "Importado",
                    Precio = 10.5m,
                    Stock = 100,
                    Estado = true
                });

            listaProductos.Add(new Producto
            {
                Id = 2,
                Nombre = "Cafe Borbom",
                Descripcion = "Importado",
                Precio = 10.5m,
                Stock = 100,
                Estado = true
            });
            listaProductos.Add(new Producto
            {
                Id = 3,
                Nombre = "Cheescake",
                Descripcion = "Dulce Sabor",
                Precio = 15.75m,
                Stock = 75,
            });
            RefrescarGrid();
        }
        //asignar la lista como data soucer al datagridview
        private void RefrescarGrid()
        {
            dgvProductos.DataSource = null; //Limpiar el data sourcce
            dgvProductos.DataSource = listaProductos; //asignar lista de datos
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Validaciones basicas
            //Valida que el nombre no este vacio
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {

                MessageBox.Show("El nombre del producto es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            //Valida que el precio sea ingresado
            if (!Validaciones.EsDecimal(txtPrecio.Text))
            {
                MessageBox.Show("El Precio del producto debe ser en valor numerico", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
                return;
            }
            //Valida que el stock sea entero y no decimal.
            if (!Validaciones.EsEntero(txtStock.Text))
            {
                MessageBox.Show("El numero ingresado debe ser entero", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStock.Focus();
                return;

            }
        }
    }
}

    
