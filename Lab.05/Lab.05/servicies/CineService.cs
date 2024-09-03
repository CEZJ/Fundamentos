using Lab._05.entities;
using Lab._05.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._05.servicies
{
    internal class CineService
    {
        private CineRepository cineRepositorio = new CineRepository();

        public bool Registrar(Cine cici)
        {
            if (cineRepositorio.Existe(cici.Codigo))
            {
                return false;
            }
            else
            {
                cineRepositorio.Registrar(cici);
                return true;
            }
        }
        public List<Cine> ListarTodo()
        {
            return CineRepository.ListarTodo();
        }
        public void Eliminar(String codigo)
        {
            cineRepositorio.Eliminar(codigo);
        }
        public List<Cine> BuscarPorPropiedad(String direccion)
        {
            return cineRepositorio.BuscarPorPropiedad(direccion);
        }
        public List<Cine> OrdenarPorPropiedad()
        {
            return cineRepositorio.OrdenarPorPropiedad();
        }
    }
}
