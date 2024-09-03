using Lab._05.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._05.repositories
{
    internal class CineRepository
    {
        private static List<Cine> cines = new List<Cine>();

        public bool Existe(String codigo)
        {

            return cines.Exists(cici => cici.Codigo.Equals(codigo));
        }

        public void Registrar(Cine cici)
        {
            cines.Add(cici);
        }

        public static List<Cine> ListarTodo()
        {
            return cines;
        }

        public void Eliminar(String codigo)
        {
            cines.RemoveAll(cici => cici.Codigo.Equals(codigo));
        }

        public List<Cine> BuscarPorPropiedad(String propiedad)
        {
            return cines.Where(cine => cine.Propiedad.Equals(propiedad)).ToList();
        }

        public List<Cine> OrdenarPorPropiedad()
        {
            return cines.OrderBy(cici => cici.Propiedad).ToList();
        }
    }
}

