using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace pryGestioInventarioVidela
{
    public partial class frmPrincipal : Form
    {
        BaseDatos BaseDatos = new BaseDatos();
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BaseDatos.ConectarBD(toolStripStatusLabelConex);
            BaseDatos.CargarCategorias(cmbCategoria);
            BaseDatos.CargarCategorias(cmbCategoriaBusq);
           

            cboTipoReporte.Items.Add("Listado general de productos");
            cboTipoReporte.Items.Add("Productos por categoría");
            cboTipoReporte.Items.Add("Productos con bajo stock");
            cboTipoReporte.SelectedIndex = 0; 
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void mrcDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                BaseDatos.AgregarProducto(
                    Convert.ToInt32(txtCodigo.Text),
                    Convert.ToString(cmbCategoria.Text),
                    txtNombre.Text,
                    txtDescripcion.Text,
                    Convert.ToInt32(txtPrecio.Text),
                    Convert.ToInt32(txtStock.Text)
                );

                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }
        private bool ValidarCampos()
        {
  
            if (string.IsNullOrWhiteSpace(cmbCategoria.Text))
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Debe ingresar un **código válido y numérico**.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            if (BaseDatos.VerificarCodigoExistente(codigo))
            {
                MessageBox.Show($"El código de producto '{codigo}' **ya existe**. Ingrese un código diferente.", "Código Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para el producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }

            if (!int.TryParse(txtPrecio.Text, out int precio))
            {
                MessageBox.Show("El precio debe ser un **valor numérico entero**.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un **valor numérico entero**.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            // Si todas las validaciones pasan
            return true;
        }
        private void LimpiarCampos()
        {
            BaseDatos.ConectarBD(toolStripStatusLabelConex);
            txtCodigo.Text = BaseDatos.ObtenerProximoCodigo().ToString(); // Actualiza el código al siguiente disponible
            cmbCategoria.SelectedIndex = -1;
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCodigo.Focus();
        }
        private void LimpiarCamposBusq()
        {
            txtCodigoBusq.Clear();
            txtNombreBusq.Clear();
            txtDescripcionBusq.Clear();
            cmbCategoriaBusq.SelectedIndex = -1;
            txtPrecioBusq.Clear();
            txtStockBusq.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBusq.Text))
            {
                MessageBox.Show("Debe ingresar un código para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBusq.Focus();
                return;
            }
            if (int.TryParse(txtCodigoBusq.Text, out int codigo))
            {
                // Usamos la instancia global 'BaseDatos'
                bool encontrado = BaseDatos.BuscarProducto(
                    codigo,
                    txtNombreBusq,
                    txtDescripcionBusq,
                    cmbCategoriaBusq,
                    txtPrecioBusq,
                    txtStockBusq
                );

                if (encontrado)
                {
                    toolStripStatusLabelConex.Text = "Producto encontrado.";
                    toolStripStatusLabelConex.BackColor = Color.LightGreen;
                }
                else
                {
                    toolStripStatusLabelConex.Text = "Producto no encontrado.";
                    toolStripStatusLabelConex.BackColor = Color.LightPink;
                }
            }
            else
            {
                MessageBox.Show("El código debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoBusq.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones
            if (string.IsNullOrWhiteSpace(txtCodigoBusq.Text))
            {
                MessageBox.Show("Debe ingresar un código de producto válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBusq.Focus();
                return;
            }
            if (!int.TryParse(txtCodigoBusq.Text, out int codigo))
            {
                MessageBox.Show("El código debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtPrecioBusq.Text, out int precio) || !int.TryParse(txtStockBusq.Text, out int stock))
            {
                MessageBox.Show("El precio y el stock deben ser valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool actualizado = BaseDatos.ModificarProducto(
                codigo,
                txtNombreBusq.Text,
                txtDescripcionBusq.Text,
                cmbCategoriaBusq.Text,
                precio,
                stock
            );

            if (actualizado)
            {
                MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripStatusLabelConex.Text = "Producto actualizado correctamente";
                toolStripStatusLabelConex.BackColor = Color.LightGreen;
                LimpiarCamposBusq();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el producto. Verifique el código ingresado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toolStripStatusLabelConex.Text = "Error al modificar producto";
                toolStripStatusLabelConex.BackColor = Color.LightPink;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones
            if (string.IsNullOrWhiteSpace(txtCodigoBusq.Text))
            {
                MessageBox.Show("Debe ingresar un código de producto válido para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBusq.Focus();
                return;
            }
            if (!int.TryParse(txtCodigoBusq.Text, out int codigo))
            {
                MessageBox.Show("El código debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {

                bool eliminado = BaseDatos.EliminarProducto(codigo);

                if (eliminado)
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    toolStripStatusLabelConex.Text = "Producto eliminado correctamente";
                    toolStripStatusLabelConex.BackColor = Color.LightGreen;
                    LimpiarCamposBusq();
                }
                else
                {
                    MessageBox.Show("No se encontró el producto para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    toolStripStatusLabelConex.Text = "Error al eliminar producto";
                    toolStripStatusLabelConex.BackColor = Color.LightPink;
                }
            }
            else
            {
                toolStripStatusLabelConex.Text = "Eliminación cancelada";
                toolStripStatusLabelConex.BackColor = Color.LightYellow;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string opcion = cboTipoReporte.SelectedItem.ToString();

            if (opcion == "Listado general de productos")
            {
                MostrarGrillaGeneral();
            }
            else if (opcion == "Productos por categoría")
            {
                MostrarGraficoPorCategoria();
            }
            else if (opcion == "Productos con bajo stock")
            {
                MostrarBajoStock();
            }
        }
        public void MostrarGrillaGeneral()
        {
            chartInventario.Visible = false;
            dgvProductos.Visible = true;

            using (OleDbConnection conexion = new OleDbConnection(BaseDatos.cadenaConexion))
            {
                string consulta = "SELECT [Código], [Categoría], [Nombre], [Descripción], [Precio], [Stock] FROM Productos";
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvProductos.DataSource = tabla;
            }

            // Colores según stock
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.Cells["Stock"].Value != null && fila.Cells["Stock"].Value.ToString() != "")
                {
                    int stock = Convert.ToInt32(fila.Cells["Stock"].Value);
                    if (stock < 3)
                        fila.DefaultCellStyle.BackColor = Color.LightCoral; // rojo
                    else if (stock > 10)
                        fila.DefaultCellStyle.BackColor = Color.LightGreen; // verde
                }
            }
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void MostrarGraficoPorCategoria()
        {
            dgvProductos.Visible = false;
            chartInventario.Visible = true;
            chartInventario.Series.Clear();
            chartInventario.ChartAreas.Clear();

            chartInventario.ChartAreas.Add(new ChartArea("MainArea"));
            Series serie = new Series("Productos por Categoría");
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true;

            using (OleDbConnection conexion = new OleDbConnection(BaseDatos.cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT [Categoría], COUNT(*) AS Cantidad FROM Productos GROUP BY [Categoría]";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string categoria = lector["Categoría"].ToString();
                    int cantidad = Convert.ToInt32(lector["Cantidad"]);
                    serie.Points.AddXY(categoria, cantidad);
                }
            }

            chartInventario.Series.Add(serie);
            chartInventario.Titles.Clear();
            chartInventario.Titles.Add("Cantidad de productos por categoría");       
        }
        public void MostrarBajoStock()
        {
            chartInventario.Visible = false;
            dgvProductos.Visible = true;
            using (OleDbConnection conexion = new OleDbConnection(BaseDatos.cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT [Código], [Categoría], [Nombre], [Descripción], [Precio], [Stock] FROM Productos WHERE [Stock] < 3";
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvProductos.DataSource = tabla;
            }

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                fila.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        private void chartInventario_Click(object sender, EventArgs e)
        {

        }

        private void cbReporte_Enter(object sender, EventArgs e)
        {

        }
    }
}
