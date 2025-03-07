using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImpuestosPruebas
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
                ImpuestosDAL.impJurisdicciones.Guardar("01", "001", 0001, "UNICO", false, 1, true, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ImpuestosDAL.impJurisdicciones.Datos("001", "1").Principal;
                ImpuestosDAL.impJurisdicciones.Eliminar("01", "1");
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
                /*
                ImpuestosDAL.impTipoImpuesto.Guardar(01, "UNICO", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = ImpuestosDAL.impTipoImpuesto.Datos(01, "1").Principal;
                ImpuestosDAL.impTipoImpuesto.Eliminar(01, "1");
                MessageBox.Show("Elimino");
                */
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
