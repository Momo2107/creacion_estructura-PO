﻿using creacion_estructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creacion_estructura
{
    public class Estudiante : Miembros_de_la_comunidad
    {

        public string Carrera {  get; set; }
        public int   cant_CreditosCursando { get; set; }
        public int cant_CreditosCursados { get; set; }

        public bool EstudianteActivo { get; set; }


        public void Estudiar ()
        {

        }


    }
}
