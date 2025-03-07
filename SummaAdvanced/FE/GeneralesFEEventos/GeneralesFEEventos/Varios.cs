using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralesFEEventos
{
    public class Varios
    {
        public static string NroALetra(decimal pNro, string pMonedaId, string pMonedaDesc)
        {
            return NroALetra(pNro, false, pMonedaId, pMonedaDesc);
        }

        public static string NroALetra(decimal pNro, bool pSinCentavos, string pMonedaId, string pMonedaDesc)
        {
            return NroALetra(pNro, pSinCentavos, pMonedaId, pMonedaDesc);
        }


        public static string NroALetra(decimal pNro)
        {
            return NroALetra(pNro, false, "", "");
        }

        public static string NroALetra(decimal pNro, bool pSinCentavos)
        {
            return NroALetra(pNro, pSinCentavos, "", "");
        }
        
        
        public static string NroALetra(decimal pNro, bool pSinCentavos, string pMonedaId, string pMonedaDesc, string lPais)
        {
            return NroALetra(pNro, pSinCentavos, pMonedaId, pMonedaDesc, lPais, "");
        }

        public static string NroALetra(decimal pNro, bool pSinCentavos, string pMonedaId, string pMonedaDesc, string lPais, string lMonedaCE)
        {
            decimal value = Math.Floor(pNro);
            int centavos = Convert.ToInt32(Math.Round((pNro - value) * 100, 0));

            string lNroEnLetra = "";
            string lLeyendaEnteroCent = " con ";

            if (lPais == "MX" && pMonedaId != "" && pMonedaDesc != "")
            {
                
                lNroEnLetra = NumeroALetra(value) +" "+ pMonedaDesc.Trim() + (pSinCentavos ? "" :
                    " " + centavos.ToString("00") + "/100 " + lMonedaCE);
            }
            else
            {
                lNroEnLetra = NumeroALetra(value) + (pSinCentavos ? "" :
                    lLeyendaEnteroCent + centavos.ToString("00") + "/100");
                if (pMonedaDesc != "")
                {
                    lNroEnLetra = pMonedaDesc + " " + lNroEnLetra;
                }
            }
            return lNroEnLetra;
        }

        private static string NumeroALetra(decimal value)
        {
            string Num2Text;
            if (value == 0)
                Num2Text = "CERO";
            else if (value == 1)
                Num2Text = "UN";
            else if (value == 2)
                Num2Text = "DOS";
            else if (value == 3)
                Num2Text = "TRES";
            else if (value == 4)
                Num2Text = "CUATRO";
            else if (value == 5)
                Num2Text = "CINCO";
            else if (value == 6)
                Num2Text = "SEIS";
            else if (value == 7)
                Num2Text = "SIETE";
            else if (value == 8)
                Num2Text = "OCHO";
            else if (value == 9)
                Num2Text = "NUEVE";
            else if (value == 10)
                Num2Text = "DIEZ";
            else if (value == 11)
                Num2Text = "ONCE";
            else if (value == 12)
                Num2Text = "DOCE";
            else if (value == 13)
                Num2Text = "TRECE";
            else if (value == 14)
                Num2Text = "CATORCE";
            else if (value == 15)
                Num2Text = "QUINCE";
            else if (value < 20)
                Num2Text = "DIECI" + NumeroALetra(value - 10);
            else if (value == 20)
                Num2Text = "VEINTE";
            else if (value < 30)
                Num2Text = "VEINTI" + NumeroALetra(value - 20);
            else if (value == 30)
                Num2Text = "TREINTA";
            else if (value == 40)
                Num2Text = "CUARENTA";
            else if (value == 50)
                Num2Text = "CINCUENTA";
            else if (value == 60)
                Num2Text = "SESENTA";
            else if (value == 70)
                Num2Text = "SETENTA";
            else if (value == 80)
                Num2Text = "OCHENTA";
            else if (value == 90)
                Num2Text = "NOVENTA";
            else if (value < 100)
                Num2Text = NumeroALetra(Math.Floor(value / 10) * 10) + " Y " + NumeroALetra(value % 10);
            else if (value == 100)
                Num2Text = "CIEN";
            else if (value < 200)
                Num2Text = "CIENTO " + NumeroALetra(value - 100);
            else if (value == 200 || value == 300 || value == 400 || value == 600 || value == 800)
                Num2Text = NumeroALetra(Math.Floor(value / 100)) + "CIENTOS";
            else if (value == 500)
                Num2Text = "QUINIENTOS";
            else if (value == 700)
                Num2Text = "SETECIENTOS";
            else if (value == 900)
                Num2Text = "NOVECIENTOS";
            else if (value < 1000)
                Num2Text = NumeroALetra(Math.Floor(value / 100) * 100) + " " + NumeroALetra(value % 100);
            else if (value == 1000)
                Num2Text = "MIL";
            else if (value < 2000)
                Num2Text = "MIL " + NumeroALetra(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = NumeroALetra(Math.Floor(value / 1000)) + " MIL";
                if (value % 1000 > 0) Num2Text += " " + NumeroALetra(value % 1000);
            }
            else if (value == 1000000)
                Num2Text = "UN MILLON";
            else if (value < 2000000)
                Num2Text = "UN MILLON " + NumeroALetra(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = NumeroALetra(Math.Floor(value / 1000000)) + " MILLONES";
                if (value % 1000000 > 0) Num2Text += " " + NumeroALetra(value % 1000000);
            }
            else if (value == 1000000000000)
                Num2Text = "UN BILLON";
            else if (value < 2000000000000)
                Num2Text = "UN BILLON " + NumeroALetra(value % 1000000000000);
            else
            {
                Num2Text = NumeroALetra(Math.Floor(value / 1000000000000)) + " BILLONES";
                if (value % 1000000000000 > 0) Num2Text += " " + NumeroALetra(value % 1000000000000);
            }

            Num2Text = Num2Text.ToLower();
            Num2Text = Num2Text.Substring(0, 1).ToUpper() + Num2Text.Substring(1);

            return Num2Text;
        }
    }
}
