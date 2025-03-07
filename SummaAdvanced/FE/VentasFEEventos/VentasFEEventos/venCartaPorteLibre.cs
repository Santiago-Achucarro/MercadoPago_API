using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;

namespace VentasFEEventos
{
    public class venCartaPorteLibre
    {
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCompCartaPorteLibreDS PorFactura(VentasCommon.venCompCartaPorteLibreDS pCommonDS, VentasCommon.venCompCartaPorteLibreDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            // si existe la factura lleno los datos de la misma

            VentasExchange.venMovimientosCPActionExchange eFac = new VentasExchange.venMovimientosCPActionExchange(VentasExchange.venMovimientosCPActionEnum.EnumvenMovimientosCPAction.Datos)
            {
                Segmento1C = pCommonDSNoPost.Ubicaciones[0].Segmento1C,
                Segmento2C = pCommonDSNoPost.Ubicaciones[0].Segmento2C,
                Segmento3C = pCommonDSNoPost.Ubicaciones[0].Segmento3C,
                Segmento4C = pCommonDSNoPost.Ubicaciones[0].Segmento4C,

                Segmento1N = pCommonDSNoPost.Ubicaciones[0].Segmento1N,
                Segmento2N = pCommonDSNoPost.Ubicaciones[0].Segmento2N,
                Segmento3N = pCommonDSNoPost.Ubicaciones[0].Segmento3N,
                Segmento4N = pCommonDSNoPost.Ubicaciones[0].Segmento4N,
                Segmento_Id = pCommonDSNoPost.Ubicaciones[0].Segmento_Id
            };


            eFac = new VentasExchange.venMovimientosCPActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eFac, cmd));
            if (eFac.Existe)
            {
                pCommonDSNoPost.Ubicaciones[0].Cliente_Id = eFac.Cliente_Id;
                pCommonDSNoPost.Ubicaciones[0].Sucursal = 1 /* eFac.Sucursal*/;
                pCommonDSNoPost.Ubicaciones[0].Nombre = eFac.RazonSocial;
                pCommonDSNoPost.Ubicaciones[0].Calle = eFac.Calle;
                pCommonDSNoPost.Ubicaciones[0].NumeroExterior = eFac.NroExterior;
                pCommonDSNoPost.Ubicaciones[0].Numerointerior = eFac.NroInterior;
                pCommonDSNoPost.Ubicaciones[0].CodigoPostal = eFac.CodPostal;
                pCommonDSNoPost.Ubicaciones[0].Estado = eFac.Provincia_Id;
                pCommonDSNoPost.Ubicaciones[0].Pais_Id = eFac.Pais_Id;
                pCommonDSNoPost.Ubicaciones[0].Colonia = eFac.c_ColoniaEntr;
                pCommonDSNoPost.Ubicaciones[0].Localidad = eFac.c_LocalidadEntr;
                pCommonDSNoPost.Ubicaciones[0].Municipio = eFac.c_MunicipioEntr;





                int nReng = 1;
                foreach (var ren in eFac.Param.Cuerpo)
                {
                    pCommonDSNoPost.Materiales.AddMaterialesRow(0, pCommonDS.Ubicaciones[0].Ubicacion, nReng++, ren.BienesTransp, ren.Descripcion,
                            ren.Cantidad, ren.Medida_Id, ren.MaterialPeligroso ? "Si" : "No", ren.CveMaterialPeligroso, ren.Embalaje,
                            "", "", ren.PesoEnKg, ren.Precio, "", "", "");
                }
                pCommonDSNoPost.AcceptChanges();
            }
            return pCommonDSNoPost;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCompCartaPorteLibreDS MiSucursal(VentasCommon.venCompCartaPorteLibreDS pCommonDS, VentasCommon.venCompCartaPorteLibreDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            var eEmpre = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);

            var eSuc =
            GeneralesValidacion.genSucursalesEmpr.ExistePosteadoyActiva(pCommonDSNoPost.Ubicaciones[0].Mi_Sucursal, cmd);

            pCommonDSNoPost.Ubicaciones[0].Rfc = eEmpre.Cuit;
            pCommonDSNoPost.Ubicaciones[0].Cliente_Id = "";
            pCommonDSNoPost.Ubicaciones[0].Sucursal = 1;
            pCommonDSNoPost.Ubicaciones[0].Nombre = eEmpre.RazonSocial + " " + eSuc.Descripcion;
            pCommonDSNoPost.Ubicaciones[0].Calle = eSuc.Direccion;
            pCommonDSNoPost.Ubicaciones[0].NumeroExterior = "";
            pCommonDSNoPost.Ubicaciones[0].Numerointerior = "";
            pCommonDSNoPost.Ubicaciones[0].CodigoPostal = eSuc.CodigoPostal;
            pCommonDSNoPost.Ubicaciones[0].Colonia = eSuc.codColonia;
            pCommonDSNoPost.Ubicaciones[0].Localidad = eSuc.codLocalidad;
            pCommonDSNoPost.Ubicaciones[0].Estado = eSuc.Provincia_Id;
            pCommonDSNoPost.Ubicaciones[0].Pais_Id = eSuc.Pais_Id;
            pCommonDSNoPost.Ubicaciones[0].Municipio = eSuc.codMunicipio;

            return pCommonDSNoPost;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCompCartaPorteLibreDS PorCliente(VentasCommon.venCompCartaPorteLibreDS pCommonDS, VentasCommon.venCompCartaPorteLibreDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            if (!String.IsNullOrEmpty(pCommonDSNoPost.Ubicaciones[0].Cliente_Id))
            {
                var eClie = VentasValidacion.venClieHabitual.ExistePosteadoyActivo(pCommonDSNoPost.Ubicaciones[0].Cliente_Id,
                    pCommonDSNoPost.Ubicaciones[0].Sucursal, cmd);

                pCommonDSNoPost.Ubicaciones[0].Rfc = eClie.CUIT;
                pCommonDSNoPost.Ubicaciones[0].Nombre = eClie.RazonSocial;
                pCommonDSNoPost.Ubicaciones[0].Calle = eClie.Direccion1_Entr;
                pCommonDSNoPost.Ubicaciones[0].NumeroExterior = eClie.NroExterior_Entr;
                pCommonDSNoPost.Ubicaciones[0].Numerointerior = eClie.NroInterior_Entr;
                pCommonDSNoPost.Ubicaciones[0].CodigoPostal = eClie.CodPostal_Entr;
                pCommonDSNoPost.Ubicaciones[0].Colonia = eClie.c_ColoniaEntr;
                pCommonDSNoPost.Ubicaciones[0].Localidad = eClie.c_LocalidadEntr;
                pCommonDSNoPost.Ubicaciones[0].Estado = eClie.Provincia_Id_Entr;
                pCommonDSNoPost.Ubicaciones[0].Pais_Id = eClie.Pais_Id_Entr;
                pCommonDSNoPost.Ubicaciones[0].Municipio = eClie.c_MunicipioEntr;
            }
            return pCommonDSNoPost;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCompCartaPorteLibreDS PorProducto(VentasCommon.venCompCartaPorteLibreDS pCommonDS, VentasCommon.venCompCartaPorteLibreDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            if (!String.IsNullOrEmpty(pCommonDSNoPost.Materiales[0].Producto_Id))
            {
                var eProd = StockValidacion.stkProductos.ExistePosteadoyActivo(pCommonDSNoPost.Materiales[0].Producto_Id, cmd);

                pCommonDSNoPost.Materiales[0].BienesTransp = eProd.CodigoFiscal;
                pCommonDSNoPost.Materiales[0].Descripcion = eProd.Descripcion;
                pCommonDSNoPost.Materiales[0].Medida_Id = eProd.Medida_Id;
                pCommonDSNoPost.Materiales[0].PesoEnKg = eProd.PesoEnKg;
                pCommonDSNoPost.Materiales[0].MaterialPeligroso = eProd.MaterialPeligroso ? "Si" : "No";
                pCommonDSNoPost.Materiales[0].CveMaterialPeligroso = eProd.CveMaterialPeligroso;
                pCommonDSNoPost.Materiales[0].Embalaje = eProd.Embalaje;


            }
            return pCommonDSNoPost;
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidaUbicacion(VentasCommon.venCompCartaPorteLibreDS pCommonDS, VentasCommon.venCompCartaPorteLibreDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            if (pCommonDSNoPost.Ubicaciones[0].Ubicacion<=0)
                return "La_Ubicacion_Debe_Ser_Mayor_que_Cero";

            if (pCommonDSNoPost.Ubicaciones[0].TipoEstacion != "01" && pCommonDSNoPost.Ubicaciones[0].TipoEstacion != "02" &&
                    pCommonDSNoPost.Ubicaciones[0].TipoEstacion != "03")
                return "Tipo_de_Estacion_invalido";

            if (pCommonDSNoPost.Ubicaciones[0].TipoEstacion == "01")
            {
                if (pCommonDS.Ubicaciones.ToList().Where(c => c.TipoEstacion == "01" && c.Ubicacion != pCommonDSNoPost.Ubicaciones[0].Ubicacion).Count() > 0)
                    return "Solo_Puede_Haber_Un_Origen";
            }
            else
            {
                if (pCommonDSNoPost.Ubicaciones[0].DistanciaRecorrida == 0)
                    return "Debe_ingresar_La_Distancia_Recorrida";
            }

            return "";
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidaMercancia(VentasCommon.venCompCartaPorteLibreDS pCommonDS, VentasCommon.venCompCartaPorteLibreDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            GeneralesValidacion.genEntidadesBasicasValor.Existe(3, cmd.Dominio_Id, pCommonDSNoPost.Materiales[0].BienesTransp, cmd);
            StockValidacion.stkUniMed.Existe(pCommonDSNoPost.Materiales[0].Medida_Id, cmd);

            if (pCommonDSNoPost.Materiales[0].Cantidad == 0)
                return "La_Cantdidad_Debe_Ser_mayor_que_Cero";

            if (pCommonDSNoPost.Materiales[0].PesoEnKg == 0)
                return "El_Peso_Debe_Ser_mayor_que_Cero";

            if (pCommonDSNoPost.Materiales[0].MaterialPeligroso == "Si")
            {
                GeneralesValidacion.genEntidadesBasicasValor.Existe(16, cmd.Dominio_Id, pCommonDSNoPost.Materiales[0].CveMaterialPeligroso, cmd);
                GeneralesValidacion.genEntidadesBasicasValor.Existe(17, cmd.Dominio_Id, pCommonDSNoPost.Materiales[0].Embalaje, cmd);
            }

            return "";
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCompCartaPorteLibreDS AsignarPorCP(VentasCommon.venCompCartaPorteLibreDS pCommonDS, VentasCommon.venCompCartaPorteLibreDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            if (!String.IsNullOrEmpty(pCommonDSNoPost.Ubicaciones[0].CodigoPostal))
            {
                // ASIGNAR POR LA NUEVA TABLA

                GeneralesExchange.genCodPostalActionExchange eCP = new GeneralesExchange.genCodPostalActionExchange(GeneralesExchange.genCodPostalActionEnum.EnumgenCodPostalAction.Datos)
                {
                    CodigoPostal = pCommonDSNoPost.Ubicaciones[0].CodigoPostal
                };
                eCP = new GeneralesExchange.genCodPostalActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCP, cmd));
                if (eCP.Existe)
                {
                    pCommonDSNoPost.Ubicaciones[0].Estado = eCP.Provincia_Id;
                    pCommonDSNoPost.Ubicaciones[0].Pais_Id = 52;
                    pCommonDSNoPost.Ubicaciones[0].Municipio = eCP.Municipio;
                    pCommonDSNoPost.Ubicaciones[0].Localidad = eCP.Localidad;
                    pCommonDSNoPost.Ubicaciones[0].Colonia = "";

                }


            }
            return pCommonDSNoPost;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCompCartaPorteLibreDS CambioUbicacion(VentasCommon.venCompCartaPorteLibreDS pCommonDS, VentasCommon.venCompCartaPorteLibreDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            foreach (var ren in pCommonDSNoPost.Materiales)
            {
                ren.idDestino = pCommonDSNoPost.Ubicaciones[0].Ubicacion;
            }
            return pCommonDSNoPost;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCompCartaPorteLibreDS Resto(VentasCommon.venCompCartaPorteLibreDS pCommonDS, VentasCommon.venCompCartaPorteLibreDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            VentasCommon.venCompCartaPorteLibreDS.MaterialesDataTable lRestoDT = new VentasCommon.venCompCartaPorteLibreDS.MaterialesDataTable();
            foreach (var ren in pCommonDS.Materiales)
            {
                if (ren.idDestino != pCommonDSNoPost.Ubicaciones[0].Ubicacion)
                {
                    int lSigno = -1;
                    if (pCommonDS.Ubicaciones.Where(c => c.Ubicacion == ren.idDestino).First().TipoEstacion == "01")
                        lSigno = 1;

                    if ((lRestoDT.Where(c => c.BienesTransp == ren.BienesTransp && c.Descripcion == ren.Descripcion &&
                        c.Medida_Id == ren.Medida_Id).Count() == 0))
                    {
                        lRestoDT.AddMaterialesRow(0, pCommonDSNoPost.Ubicaciones[0].Ubicacion, 0, ren.BienesTransp, ren.Descripcion, ren.Cantidad * lSigno, ren.Medida_Id, ren.MaterialPeligroso, ren.CveMaterialPeligroso,
                                ren.Embalaje, ren.DescripEmbalaje, ren.Dimensiones, ren.PesoEnKg, ren.ValorMercancia, ren.FraccionArancelaria,
                                ren.UUIDComercioExt, ren.Producto_Id); ;
                    }
                    else
                    {
                        var lRen = lRestoDT.Where(c => c.BienesTransp == ren.BienesTransp && c.Descripcion == ren.Descripcion &&
                        c.Medida_Id == ren.Medida_Id).First();
                        lRen.Cantidad += ren.Cantidad * lSigno;
                    }

                }
            }
            pCommonDSNoPost.Materiales.Clear();
            int nRenglon = 1;
            foreach (var ren in lRestoDT)
            {

                if (ren.Cantidad > 0)
                {
                    pCommonDSNoPost.Materiales.AddMaterialesRow(0, pCommonDSNoPost.Ubicaciones[0].Ubicacion, nRenglon++, ren.BienesTransp, ren.Descripcion, ren.Cantidad , ren.Medida_Id, ren.MaterialPeligroso, ren.CveMaterialPeligroso,
                            ren.Embalaje, ren.DescripEmbalaje, ren.Dimensiones, ren.PesoEnKg, ren.ValorMercancia, ren.FraccionArancelaria,
                            ren.UUIDComercioExt, ren.Producto_Id); ;
                }

            }

            pCommonDSNoPost.AcceptChanges();
            return pCommonDSNoPost;

        }



        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string Parametros(VentasCommon.venCompCartaPorteLibreDS exch, Framework.Core.Command cmd)
        {

            return
                     "Empresa_Id|" + cmd.Empresa_Id.ToString() + "@Segmento_Id|FC" +
                     "@Segmento1N|" + exch.Principal[0].Segmento1N.ToString() +
                     "@Segmento2N|" + exch.Principal[0].Segmento2N.ToString() +
                     "@Segmento3N|" + exch.Principal[0].Segmento3N.ToString() +
                     "@Segmento4N|" + exch.Principal[0].Segmento4N.ToString() +
                     "@Segmento1C|" + exch.Principal[0].Segmento1C +
                     "@Segmento2C|" + exch.Principal[0].Segmento2C +
                     "@Segmento3C|" + exch.Principal[0].Segmento3C +
                     "@Segmento4C|" + exch.Principal[0].Segmento4C;

        }


        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(VentasCommon.venCompCartaPorteLibreDS pCommonDS, Command cmd)
        {
            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();

            VentasExchange.venCompCartaPorteLibreActionExchange eCP = new VentasExchange.venCompCartaPorteLibreActionExchange(VentasExchange.venCompCartaPorteLibreActionEnum.EnumvenCompCartaPorteLibreAction.Descargar)
            {
                Segmento_Id = pCommonDS.Principal[0].Segmento_Id,
                Segmento1N = pCommonDS.Principal[0].Segmento1N,
                Segmento2N = pCommonDS.Principal[0].Segmento2N,
                Segmento3N = pCommonDS.Principal[0].Segmento3N,
                Segmento4N = pCommonDS.Principal[0].Segmento4N,
                Segmento1C = pCommonDS.Principal[0].Segmento1C,
                Segmento2C = pCommonDS.Principal[0].Segmento2C,
                Segmento3C = pCommonDS.Principal[0].Segmento3C,
                Segmento4C = pCommonDS.Principal[0].Segmento4C
            };
            eCP = new VentasExchange.venCompCartaPorteLibreActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCP, cmd));
            if (eCP.Existe)
            {
                //...... 
                //...... 
                // Los destinatarios van separados por ';'
                // El datatable de adjuntos tiene la misma estructura y forma de utilizarse que el datatable adjuntos de cualquier entidad o movimiwento
                // Se puede usar el método Generalidades.Auxiliares.AdjuntosCompletarDatos(NombreTabla, Identity, Path, cmd) para completar el datatable de ajuntos del mail, con los adjuntos asociados a la entidad o movimiento
                string lCuerpo = "Adjunto la Carta porte";
                lRetorno.Principal.AddPrincipalRow("Carta Porte", lCuerpo, "", "", "", false);
                lRetorno.Adjuntos.AddAdjuntosRow(1, Guid.NewGuid().ToString(), eCP.NombreArchivo, eCP.Extension, eCP.Archivo, Generalidades.Archivos.QEstadoArchivo.Nuevo.ToString());
                lRetorno.Adjuntos.AddAdjuntosRow(1, Guid.NewGuid().ToString(), eCP.NombreArchivo+".xml", "xml", eCP.XML, Generalidades.Archivos.QEstadoArchivo.Nuevo.ToString());

            }
            else
            {
                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");
            }
            return lRetorno;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCompCartaPorteLibreDS Pegar(VentasCommon.venCompCartaPorteLibreDS pCommonDS, VentasCommon.venCompCartaPorteLibreDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            // USO EXTENSION 

            if (string.IsNullOrWhiteSpace(pCommonDS.Principal[0].Extension))
                Generalidades.qFunctionalException.GenerarExcepcion("Debe_Pegar_de_Excel_Producto_Id,_Cantidad");

            string lTextoC = pCommonDS.Principal[0].Extension.Trim();
            pCommonDSNoPost.Materiales.Clear();
            int nReng = 1;
            foreach (var llin in lTextoC.Split('\n'))
            {
                string lTexto = llin;
                string lProducto_Id = Campo(ref lTexto);
                decimal lCantidad = toDecimal(Campo(ref lTexto));

                var eProd = StockValidacion.stkProductos.ExistePosteadoyActivo(lProducto_Id, cmd);
                pCommonDSNoPost.Materiales.AddMaterialesRow(0, pCommonDSNoPost.Ubicaciones[0].Ubicacion,
                        nReng++, eProd.CodigoFiscal, eProd.Descripcion,
                            lCantidad, eProd.Medida_Id, (eProd.MaterialPeligroso ? "Si" : "No"),
                                eProd.CveMaterialPeligroso, eProd.Embalaje, "", "", eProd.PesoEnKg,
                                eProd.CostoReposicion, "", "", lProducto_Id);
            }

            return pCommonDSNoPost;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCompCartaPorteLibreDS PegarCompleto(VentasCommon.venCompCartaPorteLibreDS pCommonDS, VentasCommon.venCompCartaPorteLibreDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            // USO EXTENSION 

            if (string.IsNullOrWhiteSpace(pCommonDS.Principal[0].Extension))
                Generalidades.qFunctionalException.GenerarExcepcion("Debe_Pegar_de_Excel_BienesTransp,Descripcion, Cantidad,Medida, PesoEnKg (Total), ValorDeclarado, MatPeligroso, CveMatPeligroso, Embalaje ");

            string lTextoC = pCommonDS.Principal[0].Extension.Trim();
            pCommonDSNoPost.Materiales.Clear();
            int nReng = 1;
            foreach (var llin in lTextoC.Split('\n'))
            {
                string lTexto = llin;
                string BienesTransp = Campo(ref lTexto);
                string Descripcion = Campo(ref lTexto);
                decimal lCantidad = toDecimal(Campo(ref lTexto));
                if (lCantidad<=0)
                    Generalidades.qFunctionalException.GenerarExcepcion("La_Cantidad_Debe_Ser_Mayor_Que_Cero");
                string Medida_Id = Campo(ref lTexto);
                StockValidacion.stkUniMed.ExistePosteadoyActivo(Medida_Id, cmd);
                decimal lPeso = toDecimal(Campo(ref lTexto))/ lCantidad;
                decimal ValorDeclarado = toDecimal(Campo(ref lTexto));
                string  MatPeligroso = Campo(ref lTexto);
                
                if (MatPeligroso != "Si" && MatPeligroso != "No")
                    Generalidades.qFunctionalException.GenerarExcepcion("Material_Peligroso_Debe_Ser_Si_o_No");
                string CveMaterialPeligroso = "";
                string Embalaje = "";

                if (MatPeligroso == "Si")
                {
                    CveMaterialPeligroso = Campo(ref lTexto);
                    Embalaje = Campo(ref lTexto);
                }

                pCommonDSNoPost.Materiales.AddMaterialesRow(0, pCommonDSNoPost.Ubicaciones[0].Ubicacion,
                        nReng++, BienesTransp, Descripcion,
                            lCantidad, Medida_Id, MatPeligroso ,
                                CveMaterialPeligroso, Embalaje, "", "", lPeso ,ValorDeclarado, "", "", "");
            }

            return pCommonDSNoPost;
        }



        private string Campo(ref string lLin)
        {

            string lRet = "";

            int n = lLin.IndexOf((char)9);
            if (n > 0)
            {
                lRet = lLin.Substring(0, n).Trim();
                lLin = lLin.Substring(n + 1);
            }
            else
            {
                lRet = lLin.Substring(0, n >= 0 ? n : lLin.Length).Trim();
                lLin = lLin.Length > 0 ? lLin.Substring(n == -1 ? lLin.Length : 1) : "";

            }

            return lRet;
        }

        private decimal toDecimal(string Cadena)
        {
            decimal lRet = 0;
            if (Cadena != "")

                try
                {
                    lRet = Convert.ToDecimal(Cadena);
                }
                catch
                {
                    lRet = 0;
                }
            return lRet;

        }
    }
}

