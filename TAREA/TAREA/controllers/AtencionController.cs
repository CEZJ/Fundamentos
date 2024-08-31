﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAREA.entities;

namespace TAREA.controllers
{
    internal class AtencionController
    {
        private Atencion[] atenciones = new Atencion[100];
        int cont = 0;
        private double montoLavado = 0;
        private int totalServicio1 = 0;
        private int totalServicio2 = 0;
        private int totalServicio3 = 0;


        public Atencion[] ListarTodo() {return atenciones;}

        public int ObtenerTotalServicio1(){return totalServicio1;}

        public int ObtenerTotalServicio2(){return totalServicio2;}

        public int ObtenerTotalServicio3(){return totalServicio3;}

        public void Registrar(Atencion atencion)
        {
            switch (atencion.TipoServicio)
            {
                case "1":
                    atencion.Monto = 10;
                    totalServicio1++;
                    break;
                case "2":
                    atencion.Monto = 15;
                    totalServicio2++;
                    break;
                case "3":
                    atencion.Monto = 10;
                    totalServicio3++;
                    break;
            }
            if (atencion.TipoAuto.Equals("C")) atencion.Monto *= 1.05;


            if (atencion.TipoServicio.Equals("1")) montoLavado += atencion.Monto;

            atenciones[cont] = atencion;
            cont++;
        }

        public String ObtenerServicioMenorDemanda()
        {
            if (totalServicio1 < totalServicio2 && totalServicio1 < totalServicio3)
            {
                return "Lavado";
            }
            else if (totalServicio1 > totalServicio2 && totalServicio1 < totalServicio3)
            {
                return "Encerado";
            }
            else
            {
                return "Silicona";
            }
        }

        public double ObtenerPromedioLavado()
        {
            return montoLavado / totalServicio1;
        }
    }
}
