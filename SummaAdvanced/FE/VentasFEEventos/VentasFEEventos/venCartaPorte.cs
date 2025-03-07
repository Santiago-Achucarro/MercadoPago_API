using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;

namespace VentasFEEventos
{
    public class venCartaPorte
    {


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCartaPorteDS AgregarFactura(VentasCommon.venCartaPorteDS pCommonDS, VentasCommon.venCartaPorteDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            VentasExchange.venMovimientosCPActionExchange eFac = new VentasExchange.venMovimientosCPActionExchange(VentasExchange.venMovimientosCPActionEnum.EnumvenMovimientosCPAction.Datos) {
                Segmento1C = pCommonDSNoPost.Facturas[0].Segmento1C,
                Segmento2C = pCommonDSNoPost.Facturas[0].Segmento2C,
                Segmento3C = pCommonDSNoPost.Facturas[0].Segmento3C,
                Segmento4C = pCommonDSNoPost.Facturas[0].Segmento4C,

                Segmento1N = pCommonDSNoPost.Facturas[0].Segmento1N,
                Segmento2N = pCommonDSNoPost.Facturas[0].Segmento2N,
                Segmento3N = pCommonDSNoPost.Facturas[0].Segmento3N,
                Segmento4N = pCommonDSNoPost.Facturas[0].Segmento4N,
                Segmento_Id = pCommonDSNoPost.Facturas[0].Segmento_Id
            };


            eFac = new VentasExchange.venMovimientosCPActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eFac, cmd));
            
           if (eFac.Param.Principal.Count > 0) { 
           
                pCommonDSNoPost.Facturas[0].venMovimientos = eFac.venMovimientos;
                pCommonDSNoPost.Facturas[0].Fecha= eFac.Fecha;
                pCommonDSNoPost.Facturas[0].Cliente_Id = eFac.Cliente_Id;
                pCommonDSNoPost.Facturas[0].RazonSocial= eFac.RazonSocial;
                pCommonDSNoPost.Facturas[0].Calle= eFac.Calle;
                pCommonDSNoPost.Facturas[0].NroExterior= eFac.NroExterior;
                pCommonDSNoPost.Facturas[0].NroInterior= eFac.NroInterior;
                pCommonDSNoPost.Facturas[0].CodPostal= eFac.CodPostal;
                pCommonDSNoPost.Facturas[0].Colonia= eFac.Colonia;
                pCommonDSNoPost.Facturas[0].Localidad= eFac.Localidad;
                pCommonDSNoPost.Facturas[0].Provincia_Id= eFac.Provincia_Id;
                pCommonDSNoPost.Facturas[0].Pais_Id= eFac.Pais_Id;
                pCommonDSNoPost.Facturas[0].c_ColoniaEntr= eFac.c_ColoniaEntr;
                pCommonDSNoPost.Facturas[0].c_LocalidadEntr= eFac.c_LocalidadEntr;
                pCommonDSNoPost.Facturas[0].c_MunicipioEntr= eFac.c_MunicipioEntr;
                //pCommonDSNoPost.Facturas[0].Parada = 3;







            }
            //pCommonDSNoPost.Facturas.AddFacturasRow(eFac.Param.Principal[0].venMovimientos, pCommonDSNoPost.Facturas[0].Parada, pCommonDSNoPost.Facturas[0].DistanciaRecorrida   , pCommonDSNoPost.Facturas[0].FechaHoraProgLlegada, eFac.Param.Principal[0].Segmento_Id, eFac.Param.Principal[0].Segmento1C, eFac.Param.Principal[0].Segmento2C, 
            //        eFac.Param.Principal[0].Segmento3C, eFac.Param.Principal[0].Segmento4C, eFac.Param.Principal[0].Segmento1N, eFac.Param.Principal[0].Segmento2N, eFac.Param.Principal[0].Segmento3N, eFac.Param.Principal[0].Segmento4N, eFac.Param.Principal[0].Fecha, 
            //        eFac.Param.Principal[0].Cliente_Id, eFac.Param.Principal[0].RazonSocial,
            //        eFac.Param.Principal[0].Calle, eFac.Param.Principal[0].NroExterior, eFac.Param.Principal[0].NroInterior, eFac.Param.Principal[0].CodPostal, eFac.Param.Principal[0].Colonia, eFac.Param.Principal[0].Localidad,
            //        eFac.Param.Principal[0].Provincia_Id, eFac.Param.Principal[0].Pais_Id, eFac.Param.Principal[0].c_ColoniaEntr, eFac.Param.Principal[0].c_LocalidadEntr, eFac.Param.Principal[0].c_MunicipioEntr, eFac.Param.Principal[0].TotalDistRec, pCommonDSNoPost.Facturas[0].FechaHoraProgLlegada, eFac.Param.Principal[0].FechaCP);

            foreach (var ren in eFac.Param.Cuerpo)
            {
                pCommonDSNoPost.Cuerpo.AddCuerpoRow(ren.venMovimientos,ren.RenglonCuerpo,ren.Producto_Id,ren.BienesTransp,ren.Descripcion,ren.Cantidad,ren.Precio,ren.Medida_Id,ren.PesoEnKg,ren.MaterialPeligroso,ren.CveMaterialPeligroso,ren.Embalaje,true);
            }
            pCommonDSNoPost.Principal[0].Existe = true;
            pCommonDSNoPost.AcceptChanges();
            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCartaPorteDS SiguienteParada(VentasCommon.venCartaPorteDS pCommonDS, VentasCommon.venCartaPorteDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            if (pCommonDS.Facturas.Count > 0)
            {
                pCommonDSNoPost.Facturas[0].Parada =
              pCommonDS.Facturas.Select(factura => factura.Parada).Max() + 1;

            }
            else

                pCommonDSNoPost.Facturas[0].Parada = 2;


                return pCommonDSNoPost;
        }
        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string Parametros(VentasCommon.venCartaPorteDS exch, Framework.Core.Command cmd)
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
        public Generalidades.CorreoDS Enviar(VentasCommon.venCartaPorteDS pCommonDS, Command cmd)
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
                lRetorno.Adjuntos.AddAdjuntosRow(1, Guid.NewGuid().ToString(), eCP.NombreArchivo + ".xml", "xml", eCP.XML, Generalidades.Archivos.QEstadoArchivo.Nuevo.ToString());

            }
            else
            {
                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");
            }
            return lRetorno;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidaUbicacion(VentasCommon.venCartaPorteDS pCommonDS, VentasCommon.venCartaPorteDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            
            if (pCommonDSNoPost.Facturas[0].DistanciaRecorrida == 0)
                 return "Debe_ingresar_La_Distancia_Recorrida";
            
            return "";
        }


    }
}
