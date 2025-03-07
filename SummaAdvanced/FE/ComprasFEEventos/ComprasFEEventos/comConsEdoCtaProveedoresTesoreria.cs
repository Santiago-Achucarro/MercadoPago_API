using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
using System.Xml;
using System.Security.Cryptography;

namespace ComprasFEEventos
{
    public class comConsEdoCtaProveedoresTesoreria
    {



        [Generalidades.QFuncion_AccionDescargarFila]
        public Generalidades.DescargaArchivoDS Xml(ComprasCommon.comConsEdoCtaProveedoresTesoreriaDS exch,
         ComprasCommon.comConsEdoCtaProveedoresTesoreriaDS exchNoPost, int pIndice, Command cmd)
        {
            ComprasExchange.comMovProvActionExchange ExcMp = new ComprasExchange.comMovProvActionExchange(ComprasExchange.comMovProvActionEnum.EnumcomMovProvAction.Datos)
            {
                comMovProv = exch.Cuerpo[pIndice].comMovProv
            };

            ExcMp = new ComprasExchange.comMovProvActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcMp, cmd));
            if (ExcMp.Existe && ExcMp.XMLFiscal != "")
            {
                string lNombreArchivo = ExcMp.ClaveFiscal;
                if (lNombreArchivo == "")
                    lNombreArchivo = ExcMp.Proveed_Id + "_" + ExcMp.Segmento1N.ToString();

                return Generalidades.Archivos.ConvertirADatasetDownload("XML", lNombreArchivo + ".xml", false, "XML",
                                    Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(ExcMp.XMLFiscal)));
            }
            Generalidades.qFunctionalException.GenerarExcepcion("No_Se_pudo_Descargar_el_XML");
            return new Generalidades.DescargaArchivoDS();
        }


        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresTesoreriaDS AdjuntarXml(ComprasCommon.comConsEdoCtaProveedoresTesoreriaDS exch,
                ComprasCommon.comConsEdoCtaProveedoresTesoreriaDS exchNoPost, int pIndice, Command cmd)

        {
            if ( String.IsNullOrEmpty(exch.Principal[0].Xml))
            {
                Generalidades.Archivos.QEstadoArchivo qEstadoArchivo;
                string lNombreCliente;
                string lNombreTemp;
                Generalidades.Archivos.ObtenerInfoArchivoUpload(exch.Principal[0].XmlUpload, cmd.Instalacion,
                        cmd.Empresa_Id, cmd.Usuario_Id, out qEstadoArchivo, out lNombreCliente, out lNombreTemp);


                string lUUID = "";
                string lRfcEmisor = "";
                string lRfcReceptor = "";
                if (qEstadoArchivo.Equals(Generalidades.Archivos.QEstadoArchivo.Nuevo))
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(lNombreTemp);
                    // Averiguo el UUID 

                    XmlNodeList Timbre = xDoc.GetElementsByTagName("tfd:TimbreFiscalDigital");
                    if (Timbre.Count == 0)
                        Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_TimbreFiscal");

                    lUUID = ((XmlElement)Timbre[0]).GetAttribute("UUID");

                    XmlNodeList Emisor = xDoc.GetElementsByTagName("cfdi:Emisor");
                    if (Emisor.Count == 0)
                        Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_Emisor");

                    lRfcEmisor = ((XmlElement)Emisor[0]).GetAttribute("Rfc");
                    ComprasExchange.comProveedoresActionExchange ePROV = new ComprasExchange.comProveedoresActionExchange(ComprasExchange.comProveedoresActionEnum.EnumcomProveedoresAction.Datos)
                    {
                        Proveed_Id = exch.Cuerpo[pIndice].Proveed_Id
                    };
                    ePROV = new ComprasExchange.comProveedoresActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ePROV, cmd));

                    if (ePROV.CUIT.Trim() != lRfcEmisor.Trim())
                        Generalidades.qFunctionalException.GenerarExcepcion("El_XML_Pertenece_Al_Proveedor_<0>", new object[] { lRfcEmisor });

                    XmlNodeList Receptor = xDoc.GetElementsByTagName("cfdi:Receptor");
                    if (Receptor.Count == 0)
                        Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_Receptor");

                    lRfcReceptor = ((XmlElement)Receptor[0]).GetAttribute("Rfc");
                    GeneralesExchange.genEmpresasActionExchange eEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
                    if (eEmpr.Cuit.Trim() != lRfcReceptor)
                        Generalidades.qFunctionalException.GenerarExcepcion("El_XML_Pertenece_A_La_Empresa_<0>", new object[] { lRfcReceptor });
                    // TODO GUARDAR
                    ComprasExchange.comMovProvActionExchange eMovProv = new ComprasExchange.comMovProvActionExchange(ComprasExchange.comMovProvActionEnum.EnumcomMovProvAction.AdjuntarXML);
                    eMovProv.comMovProv = exch.Cuerpo[pIndice].comMovProv;
                    eMovProv.XMLFiscal = xDoc.InnerXml;
                    eMovProv.ClaveFiscal = lUUID;
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(eMovProv, cmd);
                    //Generalidades.qFunctionalException.GenerarExcepcion("UUID:" + lUUID + " Emisor:" + lRfcEmisor + " Receptor:" + lRfcReceptor);

                }
                exch.Cuerpo[pIndice].XML = 1;
                return exch;
            }
            else
            {
                string lUUID = "";
                string lRfcEmisor = "";
                string lRfcReceptor = "";
                ComprasExchange.comCFDISatActionExchange eCFDI = new ComprasExchange.comCFDISatActionExchange(ComprasExchange.comCFDISatActionEnum.EnumcomCFDISatAction.Datos)
                {
                    UUID = exch.Principal[0].Xml
                };
                eCFDI = new ComprasExchange.comCFDISatActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCFDI, cmd));
                XmlDocument xDoc = new XmlDocument();

                xDoc.LoadXml(eCFDI.XML);
                // Averiguo el UUID 

                XmlNodeList Timbre = xDoc.GetElementsByTagName("tfd:TimbreFiscalDigital");
                if (Timbre.Count == 0)
                    Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_TimbreFiscal");

                lUUID = ((XmlElement)Timbre[0]).GetAttribute("UUID");

                XmlNodeList Emisor = xDoc.GetElementsByTagName("cfdi:Emisor");
                if (Emisor.Count == 0)
                    Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_Emisor");

                lRfcEmisor = ((XmlElement)Emisor[0]).GetAttribute("Rfc");
                ComprasExchange.comProveedoresDatosCUITActionExchange ePROV = new ComprasExchange.comProveedoresDatosCUITActionExchange(ComprasExchange.comProveedoresDatosCUITActionEnum.EnumcomProveedoresDatosCUITAction.Datos)
                {
                    Proveed_Id = lRfcEmisor
                };
                ePROV = new ComprasExchange.comProveedoresDatosCUITActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ePROV, cmd));
                if (exch.Cuerpo[pIndice].Proveed_Id.Trim() != ePROV.Proveed_Id.Trim())
                    Generalidades.qFunctionalException.GenerarExcepcion("El_XML_Pertenece_Al_Proveedor_<0>", new object[] { ePROV.Proveed_Id });

                XmlNodeList Receptor = xDoc.GetElementsByTagName("cfdi:Receptor");
                if (Receptor.Count == 0)
                    Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_Receptor");

                lRfcReceptor = ((XmlElement)Receptor[0]).GetAttribute("Rfc");
                GeneralesExchange.genEmpresasActionExchange eEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
                if (eEmpr.Cuit.Trim() != lRfcReceptor)
                    Generalidades.qFunctionalException.GenerarExcepcion("El_XML_Pertenece_A_La_Empresa_<0>", new object[] { lRfcReceptor });
                // TODO GUARDAR
                ComprasExchange.comMovProvActionExchange eMovProv = new ComprasExchange.comMovProvActionExchange(ComprasExchange.comMovProvActionEnum.EnumcomMovProvAction.AdjuntarXML);
                eMovProv.comMovProv = exch.Cuerpo[pIndice].comMovProv;
                eMovProv.XMLFiscal = xDoc.InnerXml;
                eMovProv.ClaveFiscal = lUUID;
                Generalidades.QBIInternal.WrapperExecuteActionInternal(eMovProv, cmd);
                //Generalidades.qFunctionalException.GenerarExcepcion("UUID:" + lUUID + " Emisor:" + lRfcEmisor + " Receptor:" + lRfcReceptor);


                exch.Cuerpo[pIndice].XML = 1;
                return exch;
            }

        }
    }
}
