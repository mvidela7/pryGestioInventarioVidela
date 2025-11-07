using System;
using System.Collections.Generic;
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
    internal class BaseDatos
    {
        public static string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BaseGestiondeInventario.accdb";

        OleDbConnection coneccionBaseDatos;
        OleDbCommand comandoBaseDatos;
        OleDbDataReader lectorDataReader;

        public string nombreBaseDeDatos;
        public string mensaje = "";

        public void ConectarBD(ToolStripStatusLabel label)
        {
            try
            {
                // Cierra la conexión anterior si estaba abierta
                if (coneccionBaseDatos != null && coneccionBaseDatos.State == ConnectionState.Open)
                {
                    coneccionBaseDatos.Close();
                }

                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();

                label.Text = "Conectado a base de datos";
                label.BackColor = Color.LightGreen; // Color cambiado a verde para indicar éxito
            }
            catch (Exception error)
            {
                label.Text = "Error al conectar: " + error.Message;
                label.BackColor = Color.LightCoral; // Color para indicar error
            }

        }

        public void CargarCategorias(ComboBox categoria)
        {
            // Se limpian los items primero para evitar duplicados
            categoria.Items.Clear();
            string consulta = "SELECT DISTINCT Categoría FROM Productos";

            using (OleDbCommand comando = new OleDbCommand(consulta, coneccionBaseDatos))
            {
                try
                {
                    if (coneccionBaseDatos.State != ConnectionState.Open)
                        coneccionBaseDatos.Open();

                    using (OleDbDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            categoria.Items.Add(lector[0].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AgregarProducto(Int32 id, string cat, string nom, string desc, Int32 prec, Int32 stock)
        {
            string consulta = "INSERT INTO Productos (Código, Categoría, Nombre, Descripción, Precio, Stock) " +
                               "VALUES (@id, @cat, @nom, @desc, @prec, @stock)";

            using (OleDbCommand comando = new OleDbCommand(consulta, coneccionBaseDatos))
            {
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@cat", cat);
                comando.Parameters.AddWithValue("@nom", nom);
                comando.Parameters.AddWithValue("@desc", desc);
                comando.Parameters.AddWithValue("@prec", prec);
                comando.Parameters.AddWithValue("@stock", stock);

                try
                {
                    if (coneccionBaseDatos.State != ConnectionState.Open)
                        coneccionBaseDatos.Open();

                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar producto: " + ex.Message, "Error de Inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool VerificarCodigoExistente(int codigo)
        {
            string consulta = "SELECT COUNT(*) FROM Productos WHERE Código = @Codigo";

            using (OleDbCommand comando = new OleDbCommand(consulta, coneccionBaseDatos))
            {
                comando.Parameters.AddWithValue("@Codigo", codigo);

                // Usamos try-catch interno por si la conexión se cae justo aquí.
                try
                {
                    // Aseguramos que la conexión esté abierta para ejecutar
                    if (coneccionBaseDatos.State != ConnectionState.Open)
                        coneccionBaseDatos.Open();

                    int count = (int)comando.ExecuteScalar();
                    return count > 0; // true si existe (conteo > 0)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de verificación en BD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; // En caso de duda o error, mejor prevenir el insert.
                }
            }
        }
        public int ObtenerProximoCodigo()
        {
            int proximoCodigo = 1; // Valor predeterminado si no hay registros
            string consulta = "SELECT MAX(Código) FROM Productos";

            using (OleDbCommand comando = new OleDbCommand(consulta, coneccionBaseDatos))
            {
                try
                {
                    // Aseguramos que la conexión esté abierta para ejecutar el comando
                    if (coneccionBaseDatos.State != ConnectionState.Open)
                        coneccionBaseDatos.Open();

                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        // Si el resultado es un número, le sumamos 1
                        proximoCodigo = Convert.ToInt32(resultado) + 1;
                    }
            
                }
                catch (Exception ex)
                {
                    // Mantenemos el MessageBox para ver el error si falla por otra razón
                    MessageBox.Show("Error al obtener el próximo código: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return proximoCodigo;
        }

        public bool BuscarProducto(int codigo, TextBox txtNombreBusq, TextBox txtDescripcionBusq, ComboBox cmbCategoriaBusq, TextBox txtPrecioBusq, TextBox txtStockBusq)
        {
            bool encontrado = false;

            try
            {
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = CommandType.Text;
                comandoBaseDatos.CommandText = "SELECT * FROM Productos WHERE Código = @codigo";
                comandoBaseDatos.Parameters.AddWithValue("@codigo", codigo);

                OleDbDataReader lector = comandoBaseDatos.ExecuteReader();

                if (lector.Read())
                {
                    txtNombreBusq.Text = lector["Nombre"].ToString();
                    txtDescripcionBusq.Text = lector["Descripción"].ToString();
                    cmbCategoriaBusq.Text = lector["Categoría"].ToString();
                    txtPrecioBusq.Text = lector["Precio"].ToString();
                    txtStockBusq.Text = lector["Stock"].ToString();
                    encontrado = true;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese código.", "Buscar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message);
            }

            return encontrado;
        }

        public bool ModificarProducto(int codigo, string nombre, string descripcion, string categoria, int precio, int stock)
        {
            bool actualizado = false;

            try
            {
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = CommandType.Text;
                comandoBaseDatos.CommandText = "UPDATE Productos " +
                                               "SET Nombre = @nombre, " +
                                               "Descripción = @descripcion, " +
                                               "Categoría = @categoria, " +
                                               "Precio = @precio, " +
                                               "Stock = @stock " +
                                               "WHERE Código = @codigo";

                comandoBaseDatos.Parameters.AddWithValue("@nombre", nombre);
                comandoBaseDatos.Parameters.AddWithValue("@descripcion", descripcion);
                comandoBaseDatos.Parameters.AddWithValue("@categoria", categoria);
                comandoBaseDatos.Parameters.AddWithValue("@precio", precio);
                comandoBaseDatos.Parameters.AddWithValue("@stock", stock);
                comandoBaseDatos.Parameters.AddWithValue("@codigo", codigo);

                int filasAfectadas = comandoBaseDatos.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    actualizado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return actualizado;
        }
        public bool EliminarProducto(int codigo)
        {
            bool eliminado = false;

            try
            {
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = CommandType.Text;
                comandoBaseDatos.CommandText = "DELETE FROM Productos WHERE Código = @codigo";
                comandoBaseDatos.Parameters.AddWithValue("@codigo", codigo);

                int filasAfectadas = comandoBaseDatos.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    eliminado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return eliminado;
        }
    }
}
