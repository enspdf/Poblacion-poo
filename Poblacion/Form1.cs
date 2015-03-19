using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poblacion
{
    public partial class Form1 : Form
    {
        clCiudades ciuda = new clCiudades();
        long val;
        List<clPaises> listapaises = new List<clPaises>();
        List<ClDepartamentos> listadepartamentos = new List<ClDepartamentos>();
        List<clCiudades> listaciudades = new List<clCiudades>();
        
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();

            //Llenando combobox de los paises asociados
            clPaises objetoPais;
            List<clPaises> listaPaises = new List<clPaises>();

            objetoPais = new clPaises();
            objetoPais.CodigoPais = "01";
            objetoPais.NombrePais = "Colombia";
            listaPaises.Add(objetoPais);

            objetoPais = new clPaises();
            objetoPais.CodigoPais = "02";
            objetoPais.NombrePais = "Argentina";
            listaPaises.Add(objetoPais);

            objetoPais = new clPaises();
            objetoPais.CodigoPais = "03";
            objetoPais.NombrePais = "Chile";
            listaPaises.Add(objetoPais);

            ClDepartamentos objetodepartamentos;

            objetodepartamentos = new ClDepartamentos();
            objetodepartamentos.CodigoPais = "01";
            objetodepartamentos.NombrePais = "Colombia";
            objetodepartamentos.CodigoDepartamento = "001";
            objetodepartamentos.NombreDepartamento = "Antioquia";
            listadepartamentos.Add(objetodepartamentos);

            objetodepartamentos = new ClDepartamentos();
            objetodepartamentos.CodigoPais = "01";
            objetodepartamentos.NombrePais = "Colombia";
            objetodepartamentos.CodigoDepartamento = "0001";
            objetodepartamentos.NombreDepartamento = "Valle";
            listadepartamentos.Add(objetodepartamentos);

            objetodepartamentos = new ClDepartamentos();
            objetodepartamentos.CodigoPais = "01";
            objetodepartamentos.NombrePais = "Colombia";
            objetodepartamentos.CodigoDepartamento = "00001";
            objetodepartamentos.NombreDepartamento = "Cauca";
            listadepartamentos.Add(objetodepartamentos);

            objetodepartamentos = new ClDepartamentos();
            objetodepartamentos.CodigoPais = "02";
            objetodepartamentos.NombrePais = "Argentina";
            objetodepartamentos.CodigoDepartamento = "002";
            objetodepartamentos.NombreDepartamento = "Bermejo";
            listadepartamentos.Add(objetodepartamentos);

            objetodepartamentos = new ClDepartamentos();
            objetodepartamentos.CodigoPais = "02";
            objetodepartamentos.NombrePais = "Argentina";
            objetodepartamentos.CodigoDepartamento = "0002";
            objetodepartamentos.NombreDepartamento = "Chaco";
            listadepartamentos.Add(objetodepartamentos);

            objetodepartamentos = new ClDepartamentos();
            objetodepartamentos.CodigoPais = "02";
            objetodepartamentos.NombrePais = "Argentina";
            objetodepartamentos.CodigoDepartamento = "00002";
            objetodepartamentos.NombreDepartamento = "Mendoza";
            listadepartamentos.Add(objetodepartamentos);

            objetodepartamentos = new ClDepartamentos();
            objetodepartamentos.CodigoPais = "03";
            objetodepartamentos.NombrePais = "Chile";
            objetodepartamentos.CodigoDepartamento = "003";
            objetodepartamentos.NombreDepartamento = "Maula";
            listadepartamentos.Add(objetodepartamentos);

            objetodepartamentos = new ClDepartamentos();
            objetodepartamentos.CodigoPais = "03";
            objetodepartamentos.NombrePais = "Chile";
            objetodepartamentos.CodigoDepartamento = "0003";
            objetodepartamentos.NombreDepartamento = "Bio";
            listadepartamentos.Add(objetodepartamentos);

            objetodepartamentos = new ClDepartamentos();
            objetodepartamentos.CodigoPais = "03";
            objetodepartamentos.NombrePais = "Chile";
            objetodepartamentos.CodigoDepartamento = "00003";
            objetodepartamentos.NombreDepartamento = "Atacama";
            listadepartamentos.Add(objetodepartamentos);

            clCiudades objetociudades;

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "01";
            objetociudades.NombrePais = "Colombia";
            objetociudades.CodigoDepartamento = "001";
            objetociudades.NombreDepartamento = "Antioquia";
            objetociudades.CodigoCiudad = "011";
            objetociudades.NombreCiudad = "Medellin";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "01";
            objetociudades.NombrePais = "Colombia";
            objetociudades.CodigoDepartamento = "001";
            objetociudades.NombreDepartamento = "Antioquia";
            objetociudades.CodigoCiudad = "0111";
            objetociudades.NombreCiudad = "Bello";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "01";
            objetociudades.NombrePais = "Colombia";
            objetociudades.CodigoDepartamento = "0001";
            objetociudades.NombreDepartamento = "Valle";
            objetociudades.CodigoCiudad = "022";
            objetociudades.NombreCiudad = "Cali";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "01";
            objetociudades.NombrePais = "Colombia";
            objetociudades.CodigoDepartamento = "0001";
            objetociudades.NombreDepartamento = "Valle";
            objetociudades.CodigoCiudad = "0222";
            objetociudades.NombreCiudad = "Neiva";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "01";
            objetociudades.NombrePais = "Colombia";
            objetociudades.CodigoDepartamento = "00001";
            objetociudades.NombreDepartamento = "Cauca";
            objetociudades.CodigoCiudad = "033";
            objetociudades.NombreCiudad = "Sucre";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "01";
            objetociudades.NombrePais = "Colombia";
            objetociudades.CodigoDepartamento = "00001";
            objetociudades.NombreDepartamento = "Cauca";
            objetociudades.CodigoCiudad = "0333";
            objetociudades.NombreCiudad = "Bolivar";
            listaciudades.Add(objetociudades);
            
            //parte 2
            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "02";
            objetociudades.NombrePais = "Argentina";
            objetociudades.CodigoDepartamento = "002";
            objetociudades.NombreDepartamento = "Bermejo";
            objetociudades.CodigoCiudad = "1011";
            objetociudades.NombreCiudad = "Cordoba";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "02";
            objetociudades.NombrePais = "Argentina";
            objetociudades.CodigoDepartamento = "002";
            objetociudades.NombreDepartamento = "Bermejo";
            objetociudades.CodigoCiudad = "1022";
            objetociudades.NombreCiudad = "Merlo";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "02";
            objetociudades.NombrePais = "Argentina";
            objetociudades.CodigoDepartamento = "0002";
            objetociudades.NombreDepartamento = "Chaco";
            objetociudades.CodigoCiudad = "1033";
            objetociudades.NombreCiudad = "Salta";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "02";
            objetociudades.NombrePais = "Argentina";
            objetociudades.CodigoDepartamento = "0002";
            objetociudades.NombreDepartamento = "Chaco";
            objetociudades.CodigoCiudad = "1044";
            objetociudades.NombreCiudad = "Quilmes";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "02";
            objetociudades.NombrePais = "Argentina";
            objetociudades.CodigoDepartamento = "00002";
            objetociudades.NombreDepartamento = "Mendoza";
            objetociudades.CodigoCiudad = "1055";
            objetociudades.NombreCiudad = "Buenos";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "02";
            objetociudades.NombrePais = "Argentina";
            objetociudades.CodigoDepartamento = "00002";
            objetociudades.NombreDepartamento = "Mendoza";
            objetociudades.CodigoCiudad = "1066";
            objetociudades.NombreCiudad = "Formosa";
            listaciudades.Add(objetociudades);

            //parte 3

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "03";
            objetociudades.NombrePais = "Chile";
            objetociudades.CodigoDepartamento = "003";
            objetociudades.NombreDepartamento = "Maula";
            objetociudades.CodigoCiudad = "2011";
            objetociudades.NombreCiudad = "Vicuna";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "03";
            objetociudades.NombrePais = "Chile";
            objetociudades.CodigoDepartamento = "003";
            objetociudades.NombreDepartamento = "Maula";
            objetociudades.CodigoCiudad = "2022";
            objetociudades.NombreCiudad = "Alma";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "03";
            objetociudades.NombrePais = "Chile";
            objetociudades.CodigoDepartamento = "0003";
            objetociudades.NombreDepartamento = "Bio";
            objetociudades.CodigoCiudad = "2033";
            objetociudades.NombreCiudad = "Serna";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "03";
            objetociudades.NombrePais = "Chile";
            objetociudades.CodigoDepartamento = "0003";
            objetociudades.NombreDepartamento = "Bio";
            objetociudades.CodigoCiudad = "2044";
            objetociudades.NombreCiudad = "Salvador";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "03";
            objetociudades.NombrePais = "Chile";
            objetociudades.CodigoDepartamento = "00003";
            objetociudades.NombreDepartamento = "Atacama";
            objetociudades.CodigoCiudad = "2055";
            objetociudades.NombreCiudad = "Vallenar";
            listaciudades.Add(objetociudades);

            objetociudades = new clCiudades();
            objetociudades.CodigoPais = "03";
            objetociudades.NombrePais = "Chile";
            objetociudades.CodigoDepartamento = "00003";
            objetociudades.NombreDepartamento = "Atacama";
            objetociudades.CodigoCiudad = "2066";
            objetociudades.NombreCiudad = "Vilos";
            listaciudades.Add(objetociudades);

            //lenar combobox
            cbPais.DataSource = listaPaises;
            cbPais.DisplayMember = "NombrePais";
            cbPais.ValueMember = "CodigoPais";
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoPaisSeleccionado = cbPais.SelectedValue.ToString();
            List<ClDepartamentos> listaDepartamentoFiltrada =
            listadepartamentos.Where(w => w.CodigoPais == codigoPaisSeleccionado).ToList(); 

            //llenar combobox
            cbDepartamento.DataSource = null;
            cbDepartamento.DataSource = listaDepartamentoFiltrada;
            cbDepartamento.DisplayMember= "NombreDepartamento";
            cbDepartamento.ValueMember = "CodigoDepartamento";
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoDepartamentoSeleccionado = null;
            if (cbDepartamento.SelectedValue != null)
            {
                codigoDepartamentoSeleccionado = cbDepartamento.SelectedValue.ToString();
                List<clCiudades> listaCiudadesFiltrada =
                listaciudades.Where(w => w.CodigoDepartamento == codigoDepartamentoSeleccionado).ToList();

                //llenar combobox
                cbCiudad.DataSource = null;
                cbCiudad.DataSource = listaCiudadesFiltrada;
                cbCiudad.DisplayMember = "NombreCiudad";
                cbCiudad.ValueMember = "CodigoCiudad";
            }
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciuda.NombreCiudad = cbCiudad.Text;
            val = ciuda.Salario;
            txtSalario_promedio.Text = val.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            long habitantes = long.Parse(txtN_habitantes.Text);
            long total = val * habitantes;
            txtIngresos.Text = total.ToString();
        }
    }
}
