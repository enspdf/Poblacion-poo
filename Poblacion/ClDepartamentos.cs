﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poblacion
{
    class ClDepartamentos
    {
        private string _codigoDepartamento;
        public string CodigoDepartamento
        {
            get { return _codigoDepartamento; }
            set { _codigoDepartamento = value; }
        }

        private string _nombreDepartamento;
        public string NombreDepartamento
        {
            get { return _nombreDepartamento; }
            set { _nombreDepartamento = value; }
        }

        private string _codigoPais;
        public string CodigoPais
        {
            get { return _codigoPais; }
            set { _codigoPais = value; }
        }

        private string _nombrePais;
        public string NombrePais
        {
            get { return _nombrePais; }
            set { _nombrePais = value; }
        }
    }
}
