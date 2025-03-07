using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContabilidadCommon;
using Framework.Core;
using System.Data;

namespace ContabilidadFEEventos
{
    public class coninfDefiniblesGenerar
    {


        ///Si no es invocado desde eventos de grilla
        [Generalidades.QFuncion_ObtenerNombreReporte]
        public string Reporte(ContabilidadReportesCommon.conInfDefiniblesGenerarDS Exch, Command cmd)
        {
            // XM por mes , MA Mes Anterior , AA Año Anterior
            string lRetorno = "";
            if (Exch.Principal[0].Tipo == "XM")
                lRetorno = "conInfDefiniblesMensual";
            else
                if (Exch.Principal[0].Tipo == "AA")
                    lRetorno = "conInfDefMesAA";
                else
                    lRetorno = "conInfDefMes";

            return lRetorno;
        }


        [Generalidades.QFuncion_ObtenerDatosReporte]
        public DataSet ImprimirPorMes(string pParametros, Framework.Core.Command cmd)
        {
            string[] aParametros = pParametros.Split('@');
            string lTipo = aParametros[2].Split('|')[1];
            switch (lTipo)
            {
                case "XM":

                    ContabilidadExchange.conInfDefiniblesMenGenerarActionExchange eRepo = new ContabilidadExchange.conInfDefiniblesMenGenerarActionExchange(ContabilidadExchange.conInfDefiniblesMenGenerarActionEnum.EnumconInfDefiniblesMenGenerarAction.Datos)
                    {
                        Existe = true
                    };

                    eRepo.Param.Cabecera.AddCabeceraRow("", "", "", "", "", "", "", "", "", "", "", "", "", "", GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd),
                            aParametros[0].Split('|')[1], Convert.ToInt32(aParametros[3].Split('|')[1]),
                            Convert.ToInt32(aParametros[4].Split('|')[1]),
                            aParametros[5].Split('|')[1], aParametros[7].Split('|')[1], aParametros[9].Split('|')[1], aParametros[11].Split('|')[1]);
                    eRepo.Param.AcceptChanges();
                    eRepo = new ContabilidadExchange.conInfDefiniblesMenGenerarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eRepo, cmd));
                    return eRepo.Param;
                case "AA":
                    ContabilidadExchange.conInfDefiniblesAcuGenerarActionExchange eRepoMA = new ContabilidadExchange.conInfDefiniblesAcuGenerarActionExchange(ContabilidadExchange.conInfDefiniblesAcuGenerarActionEnum.EnumconInfDefiniblesAcuGenerarAction.Datos)
                    {
                        Existe = true
                    };
                    
                    eRepoMA.Param.Cabecera.AddCabeceraRow("", "", "", GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd),
                            aParametros[0].Split('|')[1], Convert.ToInt32(aParametros[3].Split('|')[1]),
                            Convert.ToInt32(aParametros[4].Split('|')[1]),
                            aParametros[5].Split('|')[1], aParametros[7].Split('|')[1], aParametros[9].Split('|')[1], aParametros[11].Split('|')[1]);

                    eRepoMA.Param.AcceptChanges();
                    eRepoMA = new ContabilidadExchange.conInfDefiniblesAcuGenerarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eRepoMA, cmd));
                    return eRepoMA.Param;
                case "MA":
                    ContabilidadExchange.conInfDefiniblesAcu1GenerarActionExchange eRepoAA = new ContabilidadExchange.conInfDefiniblesAcu1GenerarActionExchange(ContabilidadExchange.conInfDefiniblesAcu1GenerarActionEnum.EnumconInfDefiniblesAcu1GenerarAction.Datos)
                    {
                        Existe = true
                    };
                    eRepoAA.Param.Cabecera.AddCabeceraRow("", "", "", GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd),
                            aParametros[0].Split('|')[1], Convert.ToInt32(aParametros[3].Split('|')[1]),
                            Convert.ToInt32(aParametros[4].Split('|')[1]),
                            aParametros[5].Split('|')[1], aParametros[7].Split('|')[1], aParametros[9].Split('|')[1], aParametros[11].Split('|')[1]);

                    eRepoAA.Param.AcceptChanges();
                    eRepoAA = new ContabilidadExchange.conInfDefiniblesAcu1GenerarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eRepoAA, cmd));
                    return eRepoAA.Param;


            }

            Generalidades.qFunctionalException.GenerarExcepcion("Debe_Seleccionar_El_Tipo_de_Reporte");
            return new DataSet();
        }



    }
}
