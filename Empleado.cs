﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creacion_estructura
{
    public class Empleado : Miembros_de_la_comunidad
    {

        public string EmpresaqueLabora {  get; set; }
        public double Salario { get; set; } 
        public int TiempoLaborando {  get; set; }
        

    }
}
