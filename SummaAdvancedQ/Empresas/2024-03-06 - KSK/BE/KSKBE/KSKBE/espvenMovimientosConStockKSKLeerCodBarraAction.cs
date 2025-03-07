using Framework.Core;
using System;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenMovimientosConStockKSKLeerCodBarraAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenMovimientosConStockKSKLeerCodBarraAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenMovimientosConStockKSKLeerCodBarraAction. No olvide de dar de
    /// alta la acción "espvenMovimientosConStockKSKLeerCodBarraAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenMovimientosConStockKSKLeerCodBarraAction : Framework.Core.IAction
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
           // VentasExchange.venMovimientosConStockActionExchange res = new VentasExchange.venMovimientosConStockActionExchange();
            try
            {
                //Cambios Ale
                /*
                KSKCommon.espMovCodBarraDS ds = new KSKCommon.espMovCodBarraDS();
                exchProd.Producto_Id = ds.CodigoBarra[0].CodigoBarra;
                 */
                KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
                //Fin Ale


                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
                StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange(StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);
                exchProd.Producto_Id = ds.Principal[0].CodigoBarra;
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
                exchPrec.Producto_Id = ds.Principal[0].CodigoBarra;
                exchPrec.ListaPrecio_Id = req.Param.venMovConStock[0].ListaPrecio_Id;
                exchPrec.Version = 1; //Ale

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

                //Gustavo 06/06/2023 Si esta en el cuerpo le sumo uno a la cantidad
                bool encontrado = false;
                int renglon = req.Param.grdCuerpo.Count;


                for (int i = 0; i < req.Param.grdCuerpo.Count; i++)
                {
                    if (req.Param.grdCuerpo[i].Producto_Id.ToUpper() == ds.Principal[0].CodigoBarra.ToUpper())
                    {
                        encontrado = true;

                        req.Param.grdCuerpo[i].CantEntregada++;
                        req.Param.grdCuerpo[i].CantEntregadaForm++;
                        req.Param.grdCuerpo[i].CantFacturada++;
                        req.Param.grdCuerpo[i].CantOriginal++;
                        break;
                    }
                }

                

                //TODO: Gustavo - 20 / 06 / 2023 si tiene un precio promo lo tomo y lo pongo en el renglon
                    //Verificar con Alejandro si son esos los campos que tengo que tocar

                decimal precioForm;
                precioForm = exchPrec.PrecioPromocion != 0 ? exchPrec.PrecioPromocion : exchPrec.PrecioLista;


                renglon++;
                if (!encontrado)
                {
                    req.Param.grdCuerpo.AddgrdCuerpoRow(0, renglon, //Gustavo 05/06/2023 - no se porque le pone siempre el renglon 1 y da error de pk cuando quiere guardar.
                        0, ds.Principal[0].CodigoBarra, exchProd.CFVenta_Id, exchProd.Descripcion, exchSuc.DepositoVentas, exchSuc.DescripcionDepositoVentas, 
                        exchProd.Medida_Id, exchProd.DescripcionUniMed, 1, 1, 1, 0, 1, "", 0, "", 
                        precioForm,0, exchPrec.PrecioLista, precioForm, 0, 0, 0, 0, 0, 0, 0, "", DateTime.Now.Date, 0, "", 0, 0, "", "", "", "", "", 1);

                    /*ANTES DE LA MODIFICACION
                    req.Param.grdCuerpo.AddgrdCuerpoRow(0, renglon, //gustavo - puse la variable renglon sino daba error de PK
                        0, ds.Principal[0].CodigoBarra, exchProd.CFVenta_Id, exchProd.Descripcion,
                        exchSuc.DepositoVentas, exchSuc.DescripcionDepositoVentas, exchProd.Medida_Id, exchProd.DescripcionUniMed,
                        1, 1, 1, 0, 1, "", 0, "", exchPrec.PrecioLista, 0, exchPrec.PrecioLista, 0, 0, 0, 0, 0, 0, 0, 0, "", DateTime.Now.Date, 0, "", 0, 0, "", "", "", "", "", 1);
                    */
                }

                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);

                ds.Principal[0].CodigoBarra = "";
                req.Existe = true;

                return new Exchange(req);

            }
            catch (FaultException<QuestionFault> ex)
            {
                throw ex;
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
