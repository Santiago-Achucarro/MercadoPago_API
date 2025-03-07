using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ContabilidadFEEventos
{
    public class conArbolResultados
    {

        [Generalidades.QFuncion_AccionFilaColumnaGrilla]
        public ContabilidadCommon.conArbolAsientosDS TraerResumen(ContabilidadCommon.conArbolAsientosDS exch, ContabilidadCommon.conArbolAsientosDS exchNoPost,
          int pIndice, string pColumna, Framework.Core.Command cmd)
        {

            if (pColumna.Substring(0, 3) != "PER")
                Generalidades.qFunctionalException.GenerarExcepcion("Debe_Seleccionar_Una_Columna_de_un_Periodo_Contable");
            int Periodo = Convert.ToInt32(pColumna.Substring(3, 2));

            // traigo los empledos de la base
            ContabilidadExchange.conArbolAsientosActionExchange eArbol = new ContabilidadExchange.conArbolAsientosActionExchange(ContabilidadExchange.conArbolAsientosActionEnum.EnumconArbolAsientosAction.Resumen)
            {
                Ejercicio = exch.Principal[0].Ejercicio,
                Periodo = exch.Principal[0].Periodo
            };
            eArbol.Param.PeriodoDetalle.AddPeriodoDetalleRow(exchNoPost.Arbol[pIndice].Cuenta_Id, exch.Principal[0].Ejercicio,
                    Periodo, "", "", "");

            eArbol.Param.AcceptChanges();
            eArbol = new ContabilidadExchange.conArbolAsientosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eArbol, cmd));
            exchNoPost.Resumen.Clear();
            exchNoPost.PeriodoDetalle.Clear();
            exchNoPost.Resumen.Merge(eArbol.Param.Resumen);
            exchNoPost.PeriodoDetalle.Merge(eArbol.Param.PeriodoDetalle);
            exchNoPost.PeriodoDetalle.AcceptChanges();
            exchNoPost.Resumen.AcceptChanges();
            return exchNoPost;

        }
        [Generalidades.QFuncion_AccionGrilla]
        public ContabilidadCommon.conArbolAsientosDS TraerDetalle(ContabilidadCommon.conArbolAsientosDS exch, ContabilidadCommon.conArbolAsientosDS exchNoPost,
        int pIndice, Framework.Core.Command cmd)
        {


            // traigo los empledos de la base
            ContabilidadExchange.conArbolAsientosActionExchange eArbol = new ContabilidadExchange.conArbolAsientosActionExchange(ContabilidadExchange.conArbolAsientosActionEnum.EnumconArbolAsientosAction.Detalle)
            {
                Ejercicio = exch.Principal[0].Ejercicio,
                Periodo = exch.Principal[0].Periodo
            };
            eArbol.Param.PeriodoDetalle.AddPeriodoDetalleRow(exchNoPost.Resumen[pIndice].Cuenta_Id, exch.Principal[0].Ejercicio,
                    exchNoPost.PeriodoDetalle[0].Periodo, exchNoPost.Resumen[pIndice].Formulario_Id, exchNoPost.Resumen[pIndice].Centro1_Id, exchNoPost.Resumen[pIndice].Centro2_Id);

            eArbol.Param.AcceptChanges();
            eArbol = new ContabilidadExchange.conArbolAsientosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eArbol, cmd));
            exchNoPost.Detalle.Clear();
            exchNoPost.Detalle.Merge(eArbol.Param.Detalle);
            exchNoPost.Detalle.AcceptChanges();
            return exchNoPost;

        }

        ///Si no es invocado desde eventos de grilla
        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string ObtenerParametrosReporte(ContabilidadCommon.conArbolAsientosDS Exch, Framework.Core.Command cmd)
        {
            if (Exch.Principal[0].IsEjercicioNull())
                Generalidades.qFunctionalException.GenerarExcepcion("Debe_Ingresar_un_Ejercicio");
            string lRetorno = "";
            lRetorno = "Ejercicio|" + Exch.Principal[0].Ejercicio.ToString() + "@PeriodoHasta|" + Exch.Principal[0].Periodo.ToString() + "@Empresa|" + cmd.Empresa_Id.ToString() +
                "@Centro1Desde|" + Exch.Principal[0].Centro1Desde + "@Centro1Hasta|" + Exch.Principal[0].Centro1Hasta + "@Centro2Desde|" + Exch.Principal[0].Centro2Desde + "@Centro2Hasta|" +
                Exch.Principal[0].Centro2Hasta +"@Tipo|"+Exch.Principal[0].Tipo;
                
            ///....Debe retornar un string del siguiente estilo: NombrePar1|ValorPar1@NombrePar2|ValorPar2@...
            return lRetorno;
        }

        [Generalidades.QFuncion_ObtenerDatosReporte]
        public DataSet ObtenerDatosReporte(string pParametros, Framework.Core.Command cmd)
        {
            //0=Ejercicio - 1=PeriodoHasta - 2=Empresa - 3=Centro1Desde - 4=Centro2Hasta - 5=Centro2Desde - 6=Centro2Hasta
            string[] Args = pParametros.Split('@');
            ContabilidadExchange.conArbolAsientosActionExchange eArbol = 
                new ContabilidadExchange.conArbolAsientosActionExchange(ContabilidadExchange.conArbolAsientosActionEnum.EnumconArbolAsientosAction.Datos);
            eArbol.Param.Principal.AddPrincipalRow(Convert.ToInt16(Args[0].Split('|')[1]), Convert.ToInt16(Args[1].Split('|')[1]), Args[7].Split('|')[1], Args[3].Split('|')[1],
                Args[4].Split('|')[1], Args[5].Split('|')[1], Args[6].Split('|')[1], false);
            eArbol.Param.Principal[0].Delete();
            eArbol.Param.AcceptChanges();
            eArbol = new ContabilidadExchange.conArbolAsientosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eArbol, cmd));
            DataSet lRetorno = new DataSet();
            
            ContabilidadCommon.conArbolAsientosDS.ArbolDataTable dt = new ContabilidadCommon.conArbolAsientosDS.ArbolDataTable();
            ///....Debe retornar un dataset con el conjunto de datos a utilizar en el reporte
            dt.Merge(eArbol.Param.Arbol, false, MissingSchemaAction.Ignore);
            dt.TableName = "Principal";
            lRetorno.Tables.Add(dt);
            
            return lRetorno;
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXls(ContabilidadCommon.conArbolAsientosDS Exch, Command cmd)
        {

            string lParmetros = ObtenerParametrosReporte(Exch, cmd);
            DataSet dataSet = ObtenerDatosReporte(lParmetros, cmd);
            return Generalidades.Archivos.DataSetAXLSxaDownload("Informe.xlsx", dataSet,
                    cmd.Instalacion, cmd.Empresa_Id, cmd.Usuario_Id);

        }
    }
}
