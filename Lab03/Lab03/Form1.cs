using Lab03.controllers;
using Lab03.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {

        private AnimalController animalController = new AnimalController();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAnimalesEnDataGrid(Animal[] animales)
        {
            dgAnimales.DataSource = null;
            dgAnimales.DataSource = animales;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbEspecie.Text == "" || tbPeso.Text == "" || tbHabitat.Text == "" || tbDieta.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Animal animal = new Animal() { Nombre = tbNombre.Text, Especie = tbEspecie.Text, Peso = double.Parse(tbPeso.Text), Habitat = tbHabitat.Text, Dieta = tbDieta.Text, };
            animalController.Registrar(animal);

            MostrarAnimalesEnDataGrid(animalController.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgAnimales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            String nombre = dgAnimales.SelectedRows[0].Cells[0].Value.ToString();

            animalController.Eliminar(nombre);

            MostrarAnimalesEnDataGrid(animalController.ListarTodo());
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgAnimales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            if (tbNombre.Text == "" || tbEspecie.Text == "" || tbPeso.Text == "" || tbHabitat.Text == "" || tbDieta.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            String nombreOriginal = dgAnimales.SelectedRows[0].Cells[0].Value.ToString();

            Animal animalModificado = new Animal()
            {
                Nombre = tbNombre.Text,
                Especie = tbEspecie.Text,
                Peso = double.Parse(tbPeso.Text),
                Habitat = tbHabitat.Text,
                Dieta = tbDieta.Text
            };
         animalController.Modificar(nombreOriginal, animalModificado);


            MostrarAnimalesEnDataGrid(animalController.ListarTodo());
        }
    }
}