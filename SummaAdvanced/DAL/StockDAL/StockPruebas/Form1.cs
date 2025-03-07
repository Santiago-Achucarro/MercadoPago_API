using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockPruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Auxiliar = new Generalidades.configReader("C:\\SummaAdv\\DALConfig.xml").getValue("//Conexion", "StringConection").ToString();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StockDAL.stkCausasMovi.Guardar("0001","0001",0, "CAJA", "1110-000", "E", "ADMINSUMMA",false, 1, true, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = StockDAL.stkCausasMovi.Datos("0001", "1").Principal;
                StockDAL.stkCausasMovi.Eliminar("0001", "1");
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
                StockDAL.stkCFComImp.Insertar(1, "IVA16", Auxiliar);
                MessageBox.Show("Guardo");
                StockDAL.stkCFComImp.Eliminar("IVA16", "", Auxiliar);
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
                StockDAL.stkCFVenImp.Insertar(1, "IVA16", Auxiliar);
                MessageBox.Show("Guardo");
                
                StockDAL.stkCFVenImp.Eliminar("GR", "IVA16", Auxiliar);
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
                StockDAL.stkCondFisCompra.Guardar("GR","GR",0, "GRAVADO 16", false, 1, true, Auxiliar);
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = StockDAL.stkCondFisCompra.Datos("GR", Auxiliar).Principal;
                StockDAL.stkCondFisCompra.Eliminar("GR", Auxiliar);
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
                StockDAL.stkCondFisVenta.Guardar("GR", "GR",0,"Gravado al 16", false, 1, true, Auxiliar);
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = StockDAL.stkCondFisVenta.Datos("GR", Auxiliar).Principal;
                StockDAL.stkCondFisVenta.Eliminar("GR", Auxiliar);
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
                /*
                StockDAL.stkDepositos.Guardar("0001", "0002", 0001, "0001", "CENTRAL", "CALLE 12", "1", "9999", "1000", "1001",
                                      00, false, "1110-000", "1210-000", "1310-000", "1410-000",  false, "10", false, "CDMX",
                                      "09500", "CMDX", false, false, true, 1, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = StockDAL.stkDepositos.Datos("0001", "1").Principal;
                StockDAL.stkDepositos.Eliminar("0001", "1");
                MessageBox.Show("Elimino");
                */
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
                StockDAL.stkTipos.Guardar("INS","INS",0, "INSUMOS",false, 1, true, Auxiliar);
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = StockDAL.stkTipos.Datos("INS", Auxiliar).Principal;
                StockDAL.stkTipos.Eliminar("INS", Auxiliar);
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
                StockDAL.stkTiposMov.Guardar("E", "ENTRADAS", 1, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = StockDAL.stkTiposMov.Datos("CO", "1").Principal;
                StockDAL.stkTiposMov.Eliminar("C", "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                StockDAL.stkUniMed.Guardar("PZ", "PZA", 0001, "PIEZA", 00, "999.99", "102", false, 1, false,"", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = StockDAL.stkUniMed.Datos("PZA", "1").Principal;
                StockDAL.stkUniMed.Eliminar("PZ", "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
