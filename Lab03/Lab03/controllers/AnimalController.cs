using Lab03.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.controllers
{
    internal class AnimalController
    {
        private Animal[] animales = new Animal[100];
        private int cont = 0;

        public Animal[] ListarTodo()
        {
            return animales;
        }

        public void Registrar(Animal animal)
        {
            animales[cont] = animal;
            cont++;
        }

        public void Eliminar(String nombre)
        {
            int pos = Array.FindIndex(animales, animal => animal.Nombre.Equals(nombre));
            for (int i = 0; i < cont; i++)
            {
                if (i >= pos)
                {
                    animales[i] = animales[i + 1];
                }
            }
            cont--;
        }
        public void Modificar(string nombreOriginal, Animal animalModificado)
        {
            int index = Array.FindIndex(animales,animal => animal.Nombre.Equals(nombreOriginal));
            if (index != -1)
            {
                animales[index] = animalModificado;
            }
        }
    }

}
