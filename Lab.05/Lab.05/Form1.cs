using Lab._05.entities;
using Lab._05.servicies;
using System.Windows.Forms;

namespace Lab._05
{
    public partial class Form1 : Form
    {
        private CineService cineService = new CineService();
        public Form1()
        {
            InitializeComponent();
        }


        /*//////////////////////////////////////////////////////////////////////////////////////*/
        private void MostrarCinesEnDataGrid(List<Cine> cinesss)
        {
            dgCine.DataSource = null;

            if (cinesss.Count == 0)
            {
                lblTotalRegistros.Text = "0";
                return;
            }
            else
            {

                dgCine.DataSource = cinesss;

                lblTotalRegistros.Text = cinesss.Count.ToString();


            }
        }

        /*//////////////////////////////////////////////////////////////////////////////////////*/

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgCine.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            String codigo = dgCine.SelectedRows[0].Cells[0].Value.ToString();


            cineService.Eliminar(codigo);


            MostrarCinesEnDataGrid(cineService.ListarTodo());
        }

        /*//////////////////////////////////////////////////////////////////////////////////////*/

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MostrarCinesEnDataGrid(cineService.OrdenarPorPropiedad());
        }

        /*//////////////////////////////////////////////////////////////////////////////////////*/

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese nombre a buscar");
                return;
            }

            String propiedad = tbBuscar.Text;

            MostrarCinesEnDataGrid(cineService.BuscarPorPropiedad(propiedad));
        }



        /*//////////////////////////////////////////////////////////////////////////////////////*/

        private static void Form1_Load(object sender, EventArgs e)
        {

        }

        /*//////////////////////////////////////////////////////////////////////////////////////*/

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Validación de campos vacíos
            if (tbCodigo.Text == "" || tbDireccion.Text == "" || tbGerente.Text == "" || tbPropiedad.Text == "" || tbArea.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }


            double area;
            if (!double.TryParse(tbArea.Text, out area))
            {
                MessageBox.Show("Ingrese un número válido para el área.");
                return;
            }




            int numeroDeSalas;
            if (!int.TryParse(tbSalas.Text, out numeroDeSalas))
            {
                MessageBox.Show("Ingrese un número válido para el número de salas.");
                return;
            }


            Cine nuevoCine = new Cine()
            {
                Codigo = tbCodigo.Text,
                Direccion = tbDireccion.Text,
                Gerente = tbGerente.Text,
                Propiedad = tbPropiedad.Text,
                Area = area,
                NumeroDeSalas = numeroDeSalas 
            };


            bool registrado = cineService.Registrar(nuevoCine);

            if (!registrado)
            {
                MessageBox.Show("Código ya registrado");
                return;
            }

            // Mostrar todos los cines en el DataGrid
            MostrarCinesEnDataGrid(cineService.ListarTodo());


        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MostrarCinesEnDataGrid(cineService.ListarTodo());
            tbArea.Text = "";
            tbBuscar.Text = "";
            tbCodigo.Text = "";
            tbDireccion.Text = "";
            tbGerente.Text = "";
            tbPropiedad.Text = "";
            tbSalas.Text = "";
        }

        private void tbGerente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
