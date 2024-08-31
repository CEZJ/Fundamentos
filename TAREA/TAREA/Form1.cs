using TAREA.controllers;
using TAREA.entities;

namespace TAREA;


public partial class Form1 : Form
{
    private AtencionController atencionController = new AtencionController();

    public Form1()
    {
        InitializeComponent();
    }
    private void MostrarEnDataGrid(Atencion[] atenciones)
    {
        dgAtenciones.DataSource = null;
        dgAtenciones.DataSource = atenciones;

        lblTotalServicio1.Text = atencionController.ObtenerTotalServicio1().ToString();
        lblTotalServicio2.Text = atencionController.ObtenerTotalServicio2().ToString();
        lblTotalServicio3.Text = atencionController.ObtenerTotalServicio3().ToString();
        lblPromedioServicio1.Text = atencionController.ObtenerPromedioLavado().ToString();
        lblServicioMenorDemanda.Text = atencionController.ObtenerServicioMenorDemanda().ToString();
    }
    private void btnRegistrar_Click_1(object sender, EventArgs e)
    {
        if (cbTipoAuto.Text == "" || cbTipoServicio.Text == "")
        {
            MessageBox.Show("ingrese todos los campos");
            return;
        }


        Atencion atencion = new Atencion()
        {
            TipoAuto = cbTipoAuto.Text,
            TipoServicio = cbTipoServicio.Text
        };

        atencionController.Registrar(atencion);


        MostrarEnDataGrid(atencionController.ListarTodo());
    }

    private void cbTipoAuto_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void dgAtenciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }
}
