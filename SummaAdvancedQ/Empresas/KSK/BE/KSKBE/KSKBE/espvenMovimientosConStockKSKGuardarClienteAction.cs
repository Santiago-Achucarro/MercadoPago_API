using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;
using VentasExchange;
using static VentasExchange.venClieHabitualActionEnum;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenMovimientosConStockKSKGuardarClienteAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenMovimientosConStockKSKGuardarClienteAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenMovimientosConStockKSKGuardarClienteAction. No olvide de dar de
    /// alta la acción "espvenMovimientosConStockKSKGuardarClienteAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenMovimientosConStockKSKGuardarClienteAction : Framework.Core.IAction
    {
        /// <summary>
        /// Ejecuta la acción, utilizando el Command y el <c>Exchange</c> 
        /// (especializado para la acción que se está desarrollando)
        /// como parámetros, y opcionalmente devolviendo el resultado en
        /// <c>Response</c>.
        ///
        /// </summary>
        /// <param name="cmd">El comando con la información de contexto y
        /// parámetros necesarios para llevar a cabo la acción</param>
        /// <param name="exch">El request especializado para la acción actual
        /// según se describió en el "Asistente de Acciones".</param>

        public Exchange Execute(Command cmd, Exchange exch)
        {
            VentasExchange.venMovimientosConStockActionExchange req = new VentasExchange.venMovimientosConStockActionExchange(exch);
            //VentasExchange.venMovimientosConStockActionExchange res = new VentasExchange.venMovimientosConStockActionExchange();

            try
            {


                KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

                venClieHabitualActionExchange exchClieCF = new venClieHabitualActionExchange(
                                                venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);

                exchClieCF.Cliente_Id = "11111111";
                exchClieCF.Sucursal = 1;
                exchClieCF = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClieCF, cmd));

                exchClieCF.Cliente_Id = ds.Principal[0].ClienteNuevo_Id;
                exchClieCF.Cliente_Id_Nueva = exchClieCF.Cliente_Id;

                exchClieCF.CUIT = exchClieCF.Cliente_Id;
                exchClieCF.TipoDoc = exchClieCF.CUIT.Trim().Length <= 8 ? "7" : "1";

                exchClieCF.RazonSocial = ds.Principal[0].DescripcionClienteNuevo;

                exchClieCF.EMail = ds.Principal[0].Email;
                exchClieCF.NombreFantasia = ds.Principal[0].DescripcionClienteNuevo;
                exchClieCF.Direccion1_Fact = ds.Principal[0].DireccionClienteNuevo;

                exchClieCF.Action = venClieHabitualActionEnum.GetAccionvenClieHabitualAction(
                                                venClieHabitualActionEnum.EnumvenClieHabitualAction.Guardar);

                Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClieCF, cmd);
                req.Param.Principal[0].Cliente_Id = ds.Principal[0].ClienteNuevo_Id;
              

                //busco el cliente que acabo de guardar arriba para traer el identyty que tiene y guardar en el especial
                venClieHabitualActionExchange exchClieAux = 
                                new venClieHabitualActionExchange(EnumvenClieHabitualAction.Datos)
                {
                    Cliente_Id = req.Param.Principal[0].Cliente_Id,
                    Sucursal = 1
                };
                exchClieAux = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClieAux, cmd));
                KSKDAL.espvenClieHabitualKSK.Guardar(exchClieAux.genEntidades, exchClieAux.Sucursal, ds.Principal[0].Celular,
                    ds.Principal[0].Mes, ds.Principal[0].Dia, ds.Principal[0].Instagram, ds.Principal[0].Youtube, ds.Principal[0].Linkedin,
                    ds.Principal[0].Facebook, cmd.ConnectionString);



                req.Existe = true;
                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);

                return new Exchange(req);
            }
            catch (FaultException<QuestionFault> ex)
            {
                throw ex;
                ;
            }
            catch (FaultException<FunctionalFault> ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                Generalidades.qTechnicalException.GenerarExcepcion(ex.Message);
                throw new Exception("Error al generar Tecnical Exception");
            }
        }

    }
}
