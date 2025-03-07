using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Root.Reports;
using System.Drawing;
using System.IO;


namespace TesoreriaFEEventos
{
    public class tesCheqPropImpresion
    {
        [Generalidades.QFuncion_ObtenerPDFEspecial]
        public Generalidades.DescargaArchivoDS GenerarPDF(TesoreriaCommon.tesCheqPropImpresionDS Exch, Framework.Core.Command cmd)
        {
            //int m = 30;//margen

            Report report = new Report(new PdfFormatter());
            FontDef fd = new FontDef(report, "Helvetica");
            FontProp fp = new FontPropMM(fd, 2, System.Drawing.Color.Black);
            FontProp fp1 = new FontPropMM(fd, 2, System.Drawing.Color.Black);
            FontProp fp2 = new FontPropMM(fd, 2, System.Drawing.Color.Black);
            FontProp fp_Title = new FontPropMM(fd, 4);

            int lCantTotal = Exch.Cheques.Rows.Count;
            int lCantPorHoja = 4;

            int iCheq = 0;

            for (int j = 1; j <= lCantTotal; j++)
            {
                Root.Reports.Page page = new Root.Reports.Page(report);
                page.rHeightMM = (12 * 25.4);  //304.2;
                page.rWidthMM = (8 * 24.4); //203.2;
                fp_Title.bBold = true;
                fp1.bBold = true;
                fp2.bBold = true;
                fp2.bItalic = true;
                for (int i = 1; (j <= lCantTotal) && (i <= lCantPorHoja); i++)
                {
                    //Double rX = 40;
                    Double rY = ((i - 1) * 76.2);
                    //Double rYTemp, rYContinue;
                    Double rYcopy = rY;
                    //centrado al medio del dpdf
                    page.AddMM(120, rY + 8, new RepString(fp1, Exch.Cheques[iCheq].Importe.ToString("C2")));
                    //rY += fp_Title.rLineFeedMM;

                    string lFecha = Exch.Cheques[iCheq].Fecha.Day.ToString() + "          " + 
                        GeneralidadesFEAdv.Varios.NombreMes(Exch.Cheques[iCheq].Fecha.Month) + "               " +
                        Exch.Cheques[iCheq].Fecha.Year.ToString();

                    string lFechaVto = Exch.Cheques[iCheq].FechaVencimiento.Day.ToString() + "          " +
                        GeneralidadesFEAdv.Varios.NombreMes(Exch.Cheques[iCheq].FechaVencimiento.Month) + "               " +
                        Exch.Cheques[iCheq].FechaVencimiento.Year.ToString();

                    page.AddMM(70, rY + 28, new RepString(fp, lFecha));
                    //page.AddRightMM(rX + 4, rY - 9, new RepString(fp1, "Fecha 1 MM"));
                    //rY += fp.rLineFeedMM;
                    page.AddMM(45, rY + 35, new RepString(fp, lFechaVto));
                    //page.AddRightMM(rX + 64, rY - 14, new RepString(fp1, "Fecha 2 MM"));
                    //rY += fp.rLineFeedMM;
                    page.AddMM(55, rY + 45, new RepString(fp, Exch.Cheques[iCheq].aLaOrden));
                    //page.AddRightMM(rX + 130, rY - 18, new RepString(fp1, "Sigue"));
                    //rY += fp.rLineFeedMM;
                    page.AddMM(65, rY + 55, new RepString(fp, GeneralidadesFEAdv.Varios.NroALetra(Exch.Cheques[iCheq].Importe)));
                    //page.AddRightMM(rX + 18, rY - 12, new RepString(fp1, "Letra MM"));

                    /*
                    rY += fp.rLineFeedMM;
                    page.AddMM(rX + 100, rY - 19, new RepString(fp, "TIPO DE CONTACTO:"));
                    page.AddRightMM(rX + 116, rY - 16, new RepString(fp1, "TIPO_CONTACTO"));
                    // defino el lapiz para la linea
                    PenProp lapiz = new PenProp(report, 1, Color.Blue);
                    page.AddMM(2, i * 76.2, new RepLineMM(lapiz, 203.2, 0));
                    */
                    j++;
                    iCheq++;
                }
                j--;
            }

            string lPath = Generalidades.Archivos.ObtenerPathTemporal(cmd.Instalacion, cmd.Empresa_Id, cmd.Usuario_Id);

            DateTime lDateTime = GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd);
            string lArchivo = lPath + "\\" + "sc" + lDateTime.Hour + lDateTime.Minute + lDateTime.Second + ".pdf";
            if (!System.IO.Directory.Exists(lPath))
                System.IO.Directory.CreateDirectory(lPath);
            report.Save(lArchivo);
            var lbytes = File.ReadAllBytes(lArchivo);
            string lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "Cheques.pdf", false, "pdf", lbase64);

        }

    }
}
