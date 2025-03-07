using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesoreriaPruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TesoreriaDAL.tesBancos.Guardar("0001", "BANMX", 0001, "BANAMEX DOLL", false, 1, true,"", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesBancos.Datos("BANMX", "1").Principal;
                TesoreriaDAL.tesBancos.Eliminar("0001", "1");
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
                TesoreriaDAL.tesChequeras.Guardar(1, "0001",1, "1", "P", 1, 999999, 1, Convert.ToDateTime("01/01/2016"),
                                                 Convert.ToDateTime("31/12/9999"), " ", false, 1, true, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesChequeras.Datos(1, "0001", "1").Principal;
                TesoreriaDAL.tesChequeras.Eliminar(1, "0001", "1");
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
                TesoreriaDAL.tesClearing.Guardar("0", "Inmediato", 0, "N", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesClearing.Datos("0", "1").Principal;
                TesoreriaDAL.tesClearing.Eliminar("0", "1");
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
                TesoreriaDAL.tesGanancias.Guardar(01, 001, 0001, "Inmediato", false, 1, false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesGanancias.Datos(001, "1").Principal;
                TesoreriaDAL.tesGanancias.Eliminar(01, "1");
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
                TesoreriaDAL.tesGanCuerpo.Guardar(01, 99, 10, 10, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesGanCuerpo.Datos(01, 99, "1").Principal;
                TesoreriaDAL.tesGanCuerpo.Eliminar(01, 99, "1");
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
                TesoreriaDAL.tesSubTiposMov.Guardar("AC3", "AC3", "Acreditación de Cheques Caucionados", 1,"E","", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesSubTiposMov.Datos("AC3", "1").Principal;
                TesoreriaDAL.tesSubTiposMov.Eliminar("AC3", "1");
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
                TesoreriaDAL.tesTiposId.Guardar("CA","CA", "Caja de ahorro bancaria", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesTiposId.Datos("CA", "1").Principal;
                TesoreriaDAL.tesTiposId.Eliminar("CA", "1");
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
                TesoreriaDAL.tesIdBancoPropio.Guardar("0001", 1, "0001", 1, "2010-101", "2010-102", 8, 5, 10, 10, 0, "1", "1", "", "");
                MessageBox.Show("Guardo");
                //this.dataGridView1.DataSource = TesoreriaDAL.tesIdBancoPropio.Datos("0001", "1").Principal;
                TesoreriaDAL.tesIdBancoPropio.Eliminar("0001", "1");
                MessageBox.Show("Elimino");
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
                TesoreriaDAL.tesIdCajaAhorro.Guardar("RIO", "2010-103", 10, 0, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesIdCajaAhorro.Datos("RIO", "1").Principal;
                TesoreriaDAL.tesIdCajaAhorro.Eliminar("0001", "1");
                MessageBox.Show("Elimino");
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
                TesoreriaDAL.tesIdCheqTerceros.Guardar("CHQ", "0", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesIdCheqTerceros.Datos("CHQ", "1").Principal;
                TesoreriaDAL.tesIdCheqTerceros.Eliminar("0001", "1");
                MessageBox.Show("Elimino");
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
                TesoreriaDAL.tesIdentifica.Guardar("BMR", "BMER", 0001, "CP", "Banco Bancomer MN", "1120-401", " ", " ", "PES", "1",
                                                   false, false, null, 0, false, false, 1, false, "01", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesIdentifica.Datos("BMER", "1").Principal;
                TesoreriaDAL.tesIdentifica.Eliminar("BMER", "1");
                MessageBox.Show("Elimino");
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
                /*
                TesoreriaDAL.tesIdRetClien.Guardar(0001, 0, 0, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesIdRetClien.Datos(0001, "1").Principal;
                TesoreriaDAL.tesIdRetClien.Eliminar("0001", "1");
                MessageBox.Show("Elimino");
                */
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
                TesoreriaDAL.tesIdRetProv.Guardar("IB1", "0", "IIBBCABA", 1901, 0, 0, "0", 0, "Presidente", 1, false, "1", "");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesIdRetProv.Datos("IB1", "1").Principal;
                TesoreriaDAL.tesIdRetProv.Eliminar("IB1", "1");
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
                TesoreriaDAL.tesIdVarios.Guardar("VAR", true, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = TesoreriaDAL.tesIdVarios.Datos("VAR", "1").Principal;
                TesoreriaDAL.tesIdVarios.Eliminar("VAR", "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}