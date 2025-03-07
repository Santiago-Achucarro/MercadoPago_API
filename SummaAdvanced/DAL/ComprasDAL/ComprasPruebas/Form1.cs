using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprasPruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Auxiliar = new Generalidades.configReader("C:\\SummaAdv\\DALConfig.xml").getValue("//Conexion", "StringConection").ToString();
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
              //  ComprasDAL.comConPago.Guardar("1", "2", 0001, "Empresa", "FF", 0, 1, true, true, false, 1, true, "1");
                //MessageBox.Show("Guardo");
                //this.dataGridView1.DataSource = ComprasDAL.comConPago.Datos("1", "1").Principal;
                //ComprasDAL.comConPago.Eliminar("1", "1");
                MessageBox.Show("Elimino");
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
                ComprasDAL.comForEntre.Guardar("1", "1", "ENTREGA PROVEEDOR", 0, false, 1, true, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ComprasDAL.comForEntre.Datos("1", "1").Principal;
                ComprasDAL.comForEntre.Eliminar("1", "1");
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
                ComprasDAL.comProvTipos.Guardar("1", "2", 0001, "SERVICIOS", false, 1, false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ComprasDAL.comProvTipos.Datos("1", "1").Principal;
                ComprasDAL.comProvTipos.Eliminar("1", "1");
                MessageBox.Show("Elimino");
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
                ComprasDAL.comRegiones.Guardar("1", "2", 0001, "UNICA", false, 1, false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ComprasDAL.comRegiones.Datos("1", "1").Principal;
                ComprasDAL.comRegiones.Eliminar("1", "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                //ComprasDAL.comTipoPermi.Guardar("1", "2", 0001, "UNICA", "A", true, false, 1, false,false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ComprasDAL.comTipoPermi.Datos("1", "1").Principal;
                ComprasDAL.comTipoPermi.Eliminar("1", "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
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
                //ComprasDAL.comOCCuerpo.Guardar(1, 1, 10, 0, 0, 0, Convert.ToDateTime("01/01/2016"), 250, false, 0, "PZA", " ", " ", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ComprasDAL.comOCCuerpo.Datos(1, 1, "1").Principal;
                ComprasDAL.comOCCuerpo.Eliminar(1, 1, "1");
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
                ComprasDAL.comOCArticulo.Guardar(1, 1, "00001", 0, 10, 250, "1", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ComprasDAL.comOCArticulo.Datos(1, 1, "1").Principal;
                ComprasDAL.comOCArticulo.Eliminar(1, 1, "1");
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
                ComprasDAL.comOCMemo.Guardar(1, 1, "PRUEBA 111", "5200-2026", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ComprasDAL.comOCMemo.Datos(1, 1, "1").Principal;
                ComprasDAL.comOCMemo.Eliminar(1, 1, "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = ComprasDAL.comImpuestos.Datos("IVA16", Auxiliar).Principal;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = ComprasDAL.comAsiCierreCr.Datos(1, 1, Auxiliar).Principal;
        }
    }
}
    

