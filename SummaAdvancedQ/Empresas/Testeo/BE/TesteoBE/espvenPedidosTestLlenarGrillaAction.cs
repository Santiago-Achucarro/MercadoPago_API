using System;
using Framework.Core;
using TesteoExchange;
using System.ServiceModel;

namespace TesteoBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenPedidosTestLlenarGrillaAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenPedidosTestLlenarGrillaAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenPedidosTestLlenarGrillaAction. No olvide de dar de
    /// alta la acción "espvenPedidosTestLlenarGrillaAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenPedidosTestLlenarGrillaAction : Framework.Core.IAction
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
            VentasExchange.venPedidosActionExchange req = new VentasExchange.venPedidosActionExchange(exch);
            VentasExchange.venPedidosActionExchange res = new VentasExchange.venPedidosActionExchange();
            try
            {
                TestCommon.espvenPedidosTestDS ds = new TestCommon.espvenPedidosTestDS();
                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
                StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange(StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);
                exchProd.Producto_Id = ds.CodigoBarras[0].CodigoBarras;
                exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchProd, cmd));
                
                if (!exchProd.Existe)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("El producto no existe");
                }
                if (!exchProd.Posteado)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("El producto no está posteado");
                }
                if (exchProd.Inactivo)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("El producto está inactivo");
                }
                VentasExchange.venListasPrecProdActionExchange exchPrec = new VentasExchange.venListasPrecProdActionExchange(VentasExchange.venListasPrecProdActionEnum.EnumvenListasPrecProdAction.Datos);
                exchPrec.Producto_Id = ds.CodigoBarras[0].CodigoBarras;
                exchPrec.ListaPrecio_Id = req.ListaPrecio_Id;
                exchPrec = new VentasExchange.venListasPrecProdActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchPrec, cmd));
                if (!exchPrec.Existe)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("El producto no está incluído en la ista de precios");
                }

                GeneralesExchange.genUsuariosActionExchange exchUsu = new GeneralesExchange.genUsuariosActionExchange(GeneralesExchange.genUsuariosActionEnum.EnumgenUsuariosAction.DatosIdentity);
                exchUsu.genUsuarios = cmd.Usuario_Id;
                exchUsu = new GeneralesExchange.genUsuariosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchUsu, cmd));

                GeneralesExchange.genSucursalesEmprActionExchange exchSuc = new GeneralesExchange.genSucursalesEmprActionExchange(GeneralesExchange.genSucursalesEmprActionEnum.EnumgenSucursalesEmprAction.Datos);
                exchSuc.Sucursal = exchUsu.Sucursal;
                exchSuc = new GeneralesExchange.genSucursalesEmprActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSuc, cmd));

                req.Param.grdCuerpo.AddgrdCuerpoRow(0, 0, exchProd.Producto_Id, exchProd.Descripcion, exchProd.Medida_Id, exchProd.DescripcionUniMed, exchSuc.DepositoVentas, exchSuc.DescripcionDepositoVentas, 1, 1, 0, 0, 0, exchPrec.PrecioLista, 0, exchProd.CFVenta_Id, exchPrec.PrecioLista, exchPrec.PrecioLista, 0, "", 0, DateTime.Now.Date, false, 0, "", false, false, "", "", "", "", 0, 0, false);
                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);
                req.Existe = true;

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
