using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralesPruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private string Auxiliar = "Server=ARGENTA;Database=PumoAdv;User Id=summalogin;Password=tatinga;";
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                GeneralesDAL.genAtributosGenerales.Guardar(1, 1, 1, "PRUEBA", "C", 10, 0, Auxiliar);
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = GeneralesDAL.genAtributosGenerales.Datos(0001, 0001, "1").Principal;
                GeneralesDAL.genAtributosGenerales.Eliminar(0001, 0001, "1");
                MessageBox.Show("Elimino");
                */
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {/*
                GeneralesDAL.genContadores.Guardar(1, 1, "Facturas", 1, "BOPA800717ES2", Convert.ToDateTime("11/01/2016"), 1, 999999, Convert.ToDateTime("11/01/2016"), Convert.ToDateTime("11/01/2016"), 1, Auxiliar);
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = GeneralesDAL.genContadores.Datos(1,1, Auxiliar).Principal;
                GeneralesDAL.genContadores.Eliminar(1,1, Auxiliar);
                MessageBox.Show("Elimino");
                */
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralesDAL.genSegmentosNombres.Guardar(0001, "UNICO1", "UNICO1", "UNICO1", "UNICO1", "UNICO1", "UNICO1", "UNICO1", "UNICO1", 1, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = GeneralesDAL.genSegmentosNombres.Datos(0001, "1").Principal;
                GeneralesDAL.genSegmentosNombres.Eliminar(0001, "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //GeneralesDAL.genSegmentos.Guardar("PRUEBA", "PRUEBA",0, "UNICO ", 1, 2, 3, 4, false, 1, 2, 3, 4, 
                //        1, 1, 1, 1, 1, 1, 1, 1, 01, 02, 03, 04, 1, 2, 3, 4, false, 1, false, Auxiliar);

                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = GeneralesDAL.genSegmentos.Datos("PRUEBA", "1").Principal;
                GeneralesDAL.genSegmentos.Eliminar("PRUEBA", "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralesDAL.genPermisos.Guardar("ADMINSUMMA", "genMonedas", 1, true, true, true, true,true, Auxiliar);
                MessageBox.Show("Guardo");
                //this.dataGridView1.DataSource = GeneralesDAL.genPermisos.Datos(1, "genMonedas", "1").Principal;
                GeneralesDAL.genPermisos.Eliminar(1, "genMonedas", "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralesDAL.genEntidades.Guardar(0001, Convert.ToDateTime("15/01/2016"), 1, "BOPA800717ES","1", "", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = GeneralesDAL.genEntidades.Datos(0001, "1").Principal;
                GeneralesDAL.genEntidades.Eliminar(0001, "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralesDAL.genMonedas.Guardar("MXP", "MXP", 0, "Pesos Mexicanos", "$", "", "", "", 2, false, 1, true, Auxiliar);
                this.dataGridView1.DataSource = GeneralesDAL.genMonedas.Datos("MXP", Auxiliar).Tables[0];

                GeneralesDAL.genMonedas.Guardar("MX", "MX", 0,"Prueba", "$$", "", "", "", 2, false, 1, false, Auxiliar);
                GeneralesDAL.genMonedas.Eliminar("MX",Auxiliar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
                GeneralesCommon.genEmpresasDS lds =
                GeneralesDAL.genEmpresas.Datos("summaAdv", Auxiliar);

            dataGridView1.DataSource = lds.Principal;
                        
            pictureBox1.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(lds.Principal[0].Logo)));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralesDAL.genUsuarios.insertarLogin(1, 1, Guid.NewGuid().ToString(), Auxiliar);
                int n = GeneralesDAL.genUsuarios.ActualizarCaduca("AAA",Auxiliar);
                MessageBox.Show("Actulizo" + n.ToString());
                n = GeneralesDAL.genUsuarios.CuantosLogeados(Auxiliar);
                MessageBox.Show("logueados "+n.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
