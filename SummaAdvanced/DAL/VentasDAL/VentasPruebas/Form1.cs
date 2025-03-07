using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasPruebas
{
    public partial class Form1 : Form
    {
        private string lCadena ="Server=Argenta;Database=ProductosTIAdv;User Id=summalogin;Password=tatinga;";
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ClieEstados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cobradores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "CondFiscImp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(81, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "CondFiscal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(81, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "CondPago";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(81, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "CondPagoCuotas";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(247, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "FormaEntrega";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(247, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(132, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Impuestos";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(247, 85);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(132, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Incoterm";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(247, 114);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(132, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "Region";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(247, 143);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(132, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "TipoMov";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(247, 172);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(132, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "TiposClie";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(418, 27);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(132, 23);
            this.button13.TabIndex = 13;
            this.button13.Text = "Vendedores";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(418, 56);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(132, 23);
            this.button14.TabIndex = 14;
            this.button14.Text = "Zona";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1241, 493);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                VentasDAL.venClieEstados.Guardar("INCO", "INCOB", 0001, "INCOBRABLE", "NULL", false, false, true,0,false, lCadena);
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venClieEstados.Datos("INCOB", "1").Principal;
                VentasDAL.venClieEstados.Eliminar("INCOB", lCadena);
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
                VentasDAL.venCobradores.Guardar(1, "0001","0001", 1, "AARON BOTTON", 0001, 00, false, 1, true, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venCobradores.Datos("001", "1").Principal;
                VentasDAL.venCobradores.Eliminar("0001", "1");
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
                VentasDAL.venCondFiscImp.Insertar(1, "IVA16", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venCondFiscImp.Datos("GR", "IVA16", "1").Principal;
                VentasDAL.venCondFiscImp.Eliminar("GR", "IVA16", "1");
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
                VentasDAL.venCondFiscal.Guardar("15", "16", 001, "IVA16", " ", true, " ", false, true, "16", false, 1, false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venCondFiscal.Datos("16", "1").Principal;
                VentasDAL.venCondFiscal.Eliminar("15", "1");
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
                VentasDAL.venCondPago.Guardar("0", "0", 0, "CONTADO", 0, "FC", 0, 0, 0, 0, true, true, true, false, 1, false,"PUE", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venCondPago.Datos("0", "1").Principal;
                VentasDAL.venCondPago.Eliminar("0", "1");
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
                VentasDAL.venCondPagoCuotas.Guardar(0, 001, 0, 00, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venCondPagoCuotas.Datos("0", 001, "1").Principal;
                VentasDAL.venCondPagoCuotas.Eliminar("0", 0, "1");
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
                VentasDAL.venFormaEntrega.Guardar("FO","001", 0001, "Envío Foráneo", "NA", "NA", "CDMX", 52, "41950460", "QME030311HF1",
                                                  "16", 00, "Ariel", "Gerente", "arielj@quasarmexico.com", false, false, 1, false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venFormaEntrega.Datos("FO", "1").Principal;
                VentasDAL.venFormaEntrega.Eliminar("FO", "1");
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
                /*
                VentasDAL.venImpuestos.Guardar("IVA15", "IVA16", 0001, "IVA Trasladado 16%", 1, "16", false, "0", 16,
                                  Convert.ToDateTime("01/01/2016"), Convert.ToDateTime("31/12/2100"), "2", true, 0, 
                                  false, "2140-103", "2140-104", false, false, " ", "7400-101", false, 1, false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venImpuestos.Datos("IVA16", "1").Principal;
                VentasDAL.venImpuestos.Eliminar("IVA15", "1");
                MessageBox.Show("Elimino");
                */
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
                VentasDAL.venIncoterm.Guardar("001", "0001", "NUEVO", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venIncoterm.Datos("0001", "1").Principal;
                VentasDAL.venIncoterm.Eliminar("001", "1");
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
                VentasDAL.venRegion.Guardar("001", "CENT", 0001, "ZONA CENTRO MEX", false, 1, false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venRegion.Datos("CENT", "1").Principal;
                VentasDAL.venRegion.Eliminar("001", "1");
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
                VentasDAL.venTipoMov.Guardar("A", "Cob Débito Automatico", -1, "CDA", "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venTipoMov.Datos("A", "1").Principal;
                VentasDAL.venTipoMov.Eliminar("A", "1");
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
                VentasDAL.venTiposClie.Guardar("01","01", 0001, "Stock 60% $", " ", " ", 1, false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venTiposClie.Datos("01", "1").Principal;
                VentasDAL.venTiposClie.Eliminar("01", "1");
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
                VentasDAL.venVendedores.Guardar(0001, "0001", 0001, "Aaron Botton", 7, 10, 8, 0010, 1, " ", " ", true, 
                                                true,false, false, "1", false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venVendedores.Datos("0001", "1").Principal;
                VentasDAL.venVendedores.Eliminar(0001, "1");
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
                VentasDAL.venZona.Guardar("001", "0001", 0001, "CENTRO CDMX", false, 1, false, "1");
                MessageBox.Show("Guardo");
                this.dataGridView1.DataSource = VentasDAL.venZona.Datos("0001", "1").Principal;
                VentasDAL.venZona.Eliminar("001", "1");
                MessageBox.Show("Elimino");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
