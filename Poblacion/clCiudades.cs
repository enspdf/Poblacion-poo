using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poblacion
{
    class clCiudades
    {
        private string _codigoCiudad;
        public string CodigoCiudad
        {
            get { return _codigoCiudad; }
            set { _codigoCiudad = value; }
        }

        private string _nombreCiudad;
        public string NombreCiudad
        {
            get { return _nombreCiudad; }
            set { _nombreCiudad = value; }
        }

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

        public long Salario
        {
            get
            {
                if (_nombreCiudad == "Medellin")
                {
                    return 650000;
                }
                if (_nombreCiudad == "Bello")
                {
                    return 655000;
                }
                if (_nombreCiudad == "Cali")
                {
                    return 645000;
                }
                if (_nombreCiudad == "Neiva")
                {
                    return 640000;
                }
                if (_nombreCiudad == "Sucre")
                {
                    return 540000;
                }
                if (_nombreCiudad == "Bolivar")
                {
                    return 500000;
                }
                if (_nombreCiudad == "Cordoba")
                {
                    return 490000;
                }
                if (_nombreCiudad == "Merlo")
                {
                    return 510000;
                }
                if (_nombreCiudad == "Salta")
                {
                    return 500000;
                }
                if (_nombreCiudad == "Quilmes")
                {
                    return 480000;
                }
                if (_nombreCiudad == "Buenos")
                {
                    return 485000;
                }
                if (_nombreCiudad == "Formosa")
                {
                    return 450000;
                }
                if (_nombreCiudad == "Vicuna")
                {
                    return 465000;
                }
                if (_nombreCiudad == "Alma")
                {
                    return 410000;
                }
                if (_nombreCiudad == "Serna")
                {
                    return 487000;
                }
                if (_nombreCiudad == "Salvador")
                {
                    return 523000;
                }
                if (_nombreCiudad == "Vallenar")
                {
                    return 573000;
                }
                else
                {
                    return 430000;
                }
            }

        }
    }
}
