using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabilidadPruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string Auxiliar = new Generalidades.configReader("C:\\SummaAdv\\DALConfig.xml").getValue("//Conexion", "StringConection").ToString();/*@"Server=isis\sqlExpress2014;Database=FM;User Id=sa;Password=tatinga2014;";*/

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ContabilidadDAL.conCentro1.Guardar("9999", "9999", 0, "Prueba", 1, true, "", false, 1, true, Auxiliar);
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ContabilidadDAL.conCentro1.Datos("9999", Auxiliar).Principal;
                ContabilidadDAL.conCentro1.Eliminar("9999", Auxiliar);
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
                ContabilidadDAL.conRubros.Guardar("0001", "Activo", "ACT", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ContabilidadDAL.conRubros.Datos("1", "1").Principal;
                //ContabilidadDAL.conRubros.Eliminar("1", "1");
                //MessageBox.Show("Elimino");
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
                ContabilidadDAL.conSituPatri.Guardar("ACCAP", "1", "Accionistas", 65, "1");
                MessageBox.Show("Guardo");
                dataGridView1.DataSource = ContabilidadDAL.conSituPatri.Datos("ACCAP", "1").Principal;
                // ContabilidadDAL.conSituPatri.Eliminar("ACCAP", "1");
                // MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }




        private void button8_Click(object sender, EventArgs e)
        {


        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                ContabilidadDAL.conBaseCentro.Guardar("1", "0100", 20, "1");
                MessageBox.Show("Guardo");
                dataGridView1.DataSource = ContabilidadDAL.conBaseCentro.Datos("1", "0100", "1").Principal;
                ContabilidadDAL.conBaseCentro.Eliminar("1", "0100", "1");
                MessageBox.Show("Elimino");
                */
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                ContabilidadDAL.conBaseDistri.Guardar("001", "002", "UNICA", "1", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ContabilidadDAL.conBaseDistri.Datos("1", "1").Principal;
                // ContabilidadDAL.conBaseDistri.Eliminar("1", "1");
                // MessageBox.Show("Elimino");
                */
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                ContabilidadDAL.conCuadro1Filas.Guardar(1, 1, "UNICA", this.Auxiliar);
                MessageBox.Show("Guardó");
                this.dataGridView1.DataSource = ContabilidadDAL.conCuadro1Filas.Datos(1, "1").Principal;
                // ContabilidadDAL.conCuadro1Filas.Eliminar(1, "1");
                // MessageBox.Show("Elimino");
                */
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                int a = ContabilidadDAL.conSubCuentas.Guardar("100", "100", 0001, "Sueldos y Salarios", 0, "0", false,
                    false, 1, true, "",this.Auxiliar);
                MessageBox.Show("Guardó");
                this.dataGridView1.DataSource = ContabilidadDAL.conSubCuentas.Datos("100", this.Auxiliar).Principal;
                ContabilidadDAL.conSubCuentas.Eliminar("100", this.Auxiliar);
                MessageBox.Show("Eliminó");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                ContabilidadDAL.conTiposContables.Guardar("ACCAP",  "Actualización de Capital", "ACCAP", "Balance", "0", true, "3", "Capital Social", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ContabilidadDAL.conTiposContables.Datos("AACAP", "1").Principal;
                // ContabilidadDAL.contiposcontables.Eliminar("AACAP","1");
                // MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                ContabilidadDAL.conTipoEspeciales.Guardar("0001", "1", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ContabilidadDAL.conTipoEspeciales.Datos("0001", "1").Principal;
                ContabilidadDAL.conTipoEspeciales.Eliminar("0001", "1");
                MessageBox.Show("Elimino");
                */
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                ContabilidadDAL.conTiposSAT.Guardar("100", "Código para uso exclusivo de contribuyentes del sector financiero", 
                    "ORD", true, false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ContabilidadDAL.conTiposSAT.Datos("100", "1").Principal;
                ContabilidadDAL.conTiposSAT.Eliminar("100", "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btConCuentas_Click(object sender, EventArgs e)
        {
            try
            {
                ContabilidadDAL.conCuentas.Guardar("1000-000", "1000-000", 0, "", "Activo", "1", false, 1, "", "", 0, "",
                        Generalidades.Nulls.NullDate, "", false, "", false, "", "MXP", "", 0, false,
                            "100", "D", false, 1, true,"", Auxiliar);
                MessageBox.Show("Guardado");

                ContabilidadDAL.conCuentas.Guardar("1000-001", "1000-001", 0, "", "Activo", "1", false, 1, "", "", 0, "",
                        Generalidades.Nulls.NullDate, "", false, "", false, "", "MXP", "", 0, false,
                            "100", "D", false, 1, true,"", Auxiliar);

                ContabilidadDAL.conCuentas.Eliminar("1000-001", Auxiliar);
                MessageBox.Show("Elimino");

                this.dataGridView1.DataSource = ContabilidadDAL.conCuentas.Datos("1000-000", Auxiliar).Principal;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCtaActu_Click(object sender, EventArgs e)
        {
            try
            {

               ContabilidadCommon.conCuentasActualizacionDS lds =ContabilidadDAL.conCuentas.ActualizacionDatos("1000-000", 1, Auxiliar);

                this.cmbTabla.Items.Clear();
                for (int i = 0; i < lds.Tables.Count; i++)
                    this.cmbTabla.Items.Add(lds.Tables[i].TableName);
                
                cmbTabla.SelectedItem = this.cmbTabla.Items[0];
                this.cmbTabla.Visible = true;
                this.dataGridView1.DataSource = lds;
                this.dataGridView1.DataMember = cmbTabla.SelectedItem.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataMember = cmbTabla.SelectedItem.ToString(); ;
        }
    }

}