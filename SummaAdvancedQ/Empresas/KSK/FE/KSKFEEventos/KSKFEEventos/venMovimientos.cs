using Framework.Core;
using GeneralesExchange;
using KSKBE.Varios;
using KSKFEEventos.Auxiliares;
using KSKFEEventos.MP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using VentasCommon;
using VentasExchange;
using static VentasExchange.venClieHabitualActionEnum;

namespace KSKFEEventos
{
    public class venMovimientos
    {
        public enum venMovimientosVar
        {
            TipoCartera, TipoTarjeta
        }

        #region ObtenerParametrosReporte
        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string ObtnerParametros(VentasCommon.venMovimientosConStockDS Exch, Command cmd)
        {
            var ren = Exch.Principal[0];
            string lRetorno = "Segmento_Id|" + ren.Segmento_Id + "@Segmento1N|" + ren.Segmento1N + "@Segmento2N|" +
                ren.Segmento2N + "@Segmento3N|" + ren.Segmento3N + "@Segmento4N|" + ren.Segmento4N + "@Segmento1C|" +
                ren.Segmento1C + "@Segmento2C|" + ren.Segmento2C + "@Segmento3C|" + ren.Segmento3C + "@Segmento4C|" + ren.Segmento4C;
            ///....Debe retornar un string del siguiente estilo: NombrePar1|ValorPar1@NombrePar2|ValorPar2@...
            return lRetorno;
        }
        #endregion
        #region AccionGrilla-AsignarCobranza
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosConStockDS AsignarCobranza(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            exch = AsignarCobranzaInterna(exch, exchNoPost, pIndice, cmd, true, ds);

            return exch;

        }
        #endregion
        #region AccionGrilla-AsignarImportes
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosConStockDS AsignarImportes(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
            ds.Principal[0].MPMensaje = "N";
            
            decimal cotizacion = 1;
            decimal resto = 0;

            if (ds.Principal[0].ImporteAAsignar == 0)
            {
                if (ds.Identificadores[pIndice]["Renglon"] != DBNull.Value && ds.Identificadores[pIndice].Renglon >= 0)
                {
                    // Si nunca elegí el renglón del identificador y sigue es 0 al entrar acá daba error porque //
                    // nunca había asignado el número de renglón //
                    exch.Cobranza[ds.Identificadores[pIndice].Renglon].Delete();
                    exch.Cobranza.AcceptChanges();
                    ds.Identificadores[pIndice].Renglon = -1;

                    //22/09/2023 - Gustavo - si esta en la lista de netos lo borro
                    var objNeto = NetosFactura.Carteras.Find(x => x.Cartera_Id == ds.Identificadores[pIndice].Cartera_Id);
                    if (objNeto != null) NetosFactura.Carteras.Remove(objNeto);
                    //------------------------------------------------------------------------------------------

                }
            }


            else
            {
                //Gustavo 01/09/2024
                //me fijo si es en dolares
                if (ds.Identificadores[pIndice].Cartera_Id == "DOL")
                {


                    GeneralesExchange.genTipoCambioActionExchange oGenTipoCambio =
                        new GeneralesExchange.genTipoCambioActionExchange(GeneralesExchange.genTipoCambioActionEnum.EnumgenTipoCambioAction.Datos);

                    oGenTipoCambio.Moneda_Id = "DOL";
                    oGenTipoCambio.Empresa_Id = 1;
                    oGenTipoCambio.Fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    oGenTipoCambio = new genTipoCambioActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(oGenTipoCambio, cmd));
                    cotizacion = oGenTipoCambio.CambioVenta == 0 ? 1 : oGenTipoCambio.CambioVenta;

                    resto = NetosFactura.Importe - (ds.Principal[0].ImporteAAsignar * cotizacion);

                    //cambio el valor de la cobranza porque esta expresada en USD
                    exch.Cobranza.First(x => x.Cartera_Id == "DOL").Importe = ds.Principal[0].ImporteAAsignar * cotizacion;

                    if (resto < 0)
                    {
                        //Muestro en la grilla de indentificadores
                        ds.Identificadores.First(x => x.Cartera_Id == "PES").Importe = resto;

                        //agrego renglon en la cobranza
                        //req.Param.Cobranza.AddCobranzaRow(req.Param.Cobranza.Count, "RED", "Redondeo", "EF", diferencia, 1, "", "", "", "", DateTime.Now, "", "", 0, "", 0, 0, 0, 0, 0, 0, 0);
                        exch.Cobranza.AddCobranzaRow(exch.Cobranza.Count, "PES", "Pesos", "EF", 
                            resto, 1, "", "", "", "", DateTime.Now, "", "", 0, 
                            "", 0, 0, 0, 0, 0, 0, 0);

                    }
                    
                
                }
                    


                //22/09/2023 - Gustavo - si no esta lo agrego a la lista de netos.
                var NetoCartera = NetosFactura.Carteras.Find(x => x.Cartera_Id == ds.Identificadores[pIndice].Cartera_Id);
                if (NetoCartera == null) NetosFactura.Carteras.Add(new NetoCartera
                { Cartera_Id = ds.Identificadores[pIndice].Cartera_Id, Importe = ds.Principal[0].ImporteAAsignar * cotizacion });
                else
                    NetoCartera.Importe = ds.Principal[0].ImporteAAsignar * cotizacion;

                //------------------------------------------------------------------------------------------

            }

            if (ds.Identificadores[pIndice].Cartera_Id == "MPAGO")
                ds.Principal[0].MPMensaje = "S";

            ds.Identificadores[pIndice].Importe = ds.Principal[0].ImporteAAsignar * cotizacion;


            ds = CalcularImportes(ds, ds.Principal[0].ImporteAAsignar * cotizacion);

            Generalidades.Especializacion.UnirDatatSets(exch, ds);

            return exch;
        }
        #endregion
        #region AccionGrilla-BuscarPromos
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosConStockDS BuscarPromos(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);


            TesoreriaExchange.tesT3PromocionesVigentesActionExchange exchPromo = new TesoreriaExchange.tesT3PromocionesVigentesActionExchange(TesoreriaExchange.tesT3PromocionesVigentesActionEnum.EnumtesT3PromocionesVigentesAction.Datos)
            {
                Cartera_Id = ds.Identificadores[pIndice].Cartera_Id,
                Fecha = exch.Principal[0].Fecha
            };
            
            //17/11/2023 - Para Mercado Pago
            //TODO: Verificar si esto esta bien
            ds.Principal[0].CarteraSel = exchPromo.Cartera_Id;
            ////////////////////////////////////////////////

            exchPromo = new TesoreriaExchange.tesT3PromocionesVigentesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchPromo, cmd));

            exchPromo.Param.Principal.Where(p => !p.IsPromocion_IdNull()).ToList().ForEach(p =>
            {
                ds.Promociones.AddPromocionesRow(p.Promocion_Id, p.Descripcion, pIndice);
            });

            Generalidades.Especializacion.UnirDatatSets(exch, ds);

            return exch;
        }
        #endregion
        #region AccionGrilla-BuscarCuota
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosConStockDS BuscarCuotas(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            int lIdentificadorElegido = ds.Promociones[pIndice].IdentificarElegido;

            TesoreriaExchange.tesT3PromocionesCuotasActionExchange exchCuotas = new TesoreriaExchange.tesT3PromocionesCuotasActionExchange(TesoreriaExchange.tesT3PromocionesCuotasActionEnum.EnumtesT3PromocionesCuotasAction.CalcularCuotas)
            {
                Promocion_Id = ds.Promociones[pIndice].Promocion_Id,
                //Total = ds.Principal[0].ImporteAAsignar
                Total = ds.Identificadores[lIdentificadorElegido].Importe,
                DescripcionT3Promociones = ds.Promociones[pIndice].Descripcion


            };

            //Gustavo 26/09/2024 guardo el identificador
            ds.Identificadores[lIdentificadorElegido].T3Promocion = ds.Promociones[pIndice].Promocion_Id;
            ds.Principal[0].T3Promocion = ds.Promociones[pIndice].Promocion_Id;
            ds.Principal[0].CTLectoraCheques = ds.Promociones[pIndice].Descripcion;
            ds.Identificadores[lIdentificadorElegido].DescripcionPromocion = ds.Promociones[pIndice].Descripcion;

            ////////////////////////////////////////////


            exchCuotas = new TesoreriaExchange.tesT3PromocionesCuotasActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchCuotas, cmd));

            exchCuotas.Param.Principal.ToList().ForEach(c =>
            {
                ds.Cuotas.AddCuotasRow(c.Cuota, c.Coeficiente, c.ValorCuota, c.Total, pIndice);
            });

            Generalidades.Especializacion.UnirDatatSets(exch, ds);

            return exch;
        }
        #endregion
        #region AccionGrilla-ElegirCuotas
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosConStockDS ElegirCuotas(venMovimientosConStockDS exch, venMovimientosConStockDS exchNoPost, int pIndice, Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);


            exch = AsignarCobranzaInterna(exch, exchNoPost, pIndice, cmd, false, ds);



            ds.Principal[0].T3Cuotas = ds.Cuotas[pIndice].Cuota;
            ds.Principal[0].T3Coeficiente = ds.Cuotas[pIndice].Coeficiente;

            //22/09/2023 - Gustavo - Cambio el importeAsignado por el total
            //ds.Principal[0].ImporteAsignado = ds.Cuotas[pIndice].Total;
            //ds.Principal[0].ImporteAsignado = ds.Identificadores.Sum(x => x.Importe);
            ds = CalcularImportes(ds, 0);
            //-------------------------------------------------------------------


            //pongo los valores de las cuotas elegidas en los identificadores

            


            Generalidades.Especializacion.UnirDatatSets(exch, ds);

            return exch;
        }
        #endregion
        #region AccionGrilla-StockxDeposito
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosConStockDS StockXDeposito(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            exch.ConsStock.Clear();



            StockExchange.stkExistenciasXDepositoActionExchange eCons = new StockExchange.stkExistenciasXDepositoActionExchange(StockExchange.stkExistenciasXDepositoActionEnum.EnumstkExistenciasXDepositoAction.Datos)
            {
                ProductoDesde = pIndice == -1 ? exchNoPost.grdCuerpo[0].Producto_Id : exch.grdCuerpo[pIndice].Producto_Id,
                ProductoHasta = pIndice == -1 ? exchNoPost.grdCuerpo[0].Producto_Id : exch.grdCuerpo[pIndice].Producto_Id,
                DepositoDesde = "",
                DepositoHasta = "ZZZZZ",
                GrupoDesde = "",
                GrupoHasta = "ZZZZZ",
                FamiliaDesde = "",
                FamiliaHasta = "ZZZZZ",
                TipoDesde = "",
                TipoHasta = "ZZZZZ"
            };


            Exchange eConsRes = Generalidades.QBIInternal.WrapperExecuteActionInternal(eCons, cmd);

            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            //ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            ds.StockXDep.Merge(eConsRes.RawDataSet.Tables["Resultado"], false, System.Data.MissingSchemaAction.Add);
            Generalidades.Especializacion.UnirDatatSets(exch, ds);

            return exch;
        }
        #endregion
        #region GuardarClienteDesdeFactura
        [Generalidades.QFuncion_AccionFE]
        public VentasCommon.venMovimientosConStockDS GuardarClienteDesdeFactura(VentasCommon.venMovimientosConStockDS pCommonDS, Command cmd)
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
            pCommonDS.Principal[0].Cliente_Id = ds.Principal[0].ClienteNuevo_Id;

            //busco el cliente que acabo de guardar arriba para traer el identyty que tiene y guardar en el especial
            venClieHabitualActionExchange exchClieAux = new venClieHabitualActionExchange(EnumvenClieHabitualAction.Datos)
            {
                Cliente_Id = pCommonDS.Principal[0].Cliente_Id,
                Sucursal = 1
            };
            exchClieAux = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClieAux, cmd));
            KSKDAL.espvenClieHabitualKSK.Guardar(exchClieAux.genEntidades, exchClieAux.Sucursal, ds.Principal[0].Celular,
                ds.Principal[0].Mes, ds.Principal[0].Dia, ds.Principal[0].Instagram, ds.Principal[0].Youtube, ds.Principal[0].Linkedin,
                ds.Principal[0].Facebook, cmd.ConnectionString);



            pCommonDS.Principal[0].Existe = true;

            //Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);
            ds.Clear();

            return pCommonDS;
        }
        #endregion

        #region AccionFE-GenerarCodigo
        [Generalidades.QFuncion_AccionFE]
        public VentasCommon.venMovimientosConStockDS GenerarCodigo(VentasCommon.venMovimientosConStockDS pCommonDS, Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            //Buscar codigo siguiente
            string sucursal = pCommonDS.Principal[0].Segmento2C;

           

            // Ahora busco el codigo
            ConectarSQL conectar = new ConectarSQL();
            Console.WriteLine($"Buscando Siguiente codigo de la sucursal {sucursal}");
            DataTable tabla = conectar.EjecutarConsulta($@"exec espvenClienteKSKNumerMaximo  '{sucursal}'");
            ds.Principal[0].ClienteNuevo_Id = tabla.Rows[0][0].ToString();

            pCommonDS.Principal[0].Existe = true;
            Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);

            return pCommonDS;
        }

        #endregion

        #region AccionFE-BuscarCliente
        [Generalidades.QFuncion_AccionFE]

        public VentasCommon.venMovimientosConStockDS BuscarCliente(VentasCommon.venMovimientosConStockDS pCommonDS, Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            venClieHabitualActionExchange exchClie = new venClieHabitualActionExchange(venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos)
            {
                Cliente_Id = ds.Principal[0].ClienteNuevo_Id,
                Sucursal = 1
            };

            exchClie = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClie, cmd));

            #region comentario del proceso anterior
            //if (exchClie.Existe)
            //{
            //    ds.Principal[0].DescripcionClienteNuevo = exchClie.RazonSocial;
            //    ds.Principal[0].DireccionClienteNuevo = exchClie.Direccion1_Fact;
            //    if (exchClie.Param.grdContactos.Count() > 0)
            //        ds.Principal[0].Email = exchClie.Param.grdContactos[0].Email;
            //    else
            //        ds.Principal[0].Email = "";
            //}
            //else
            //{
            //    ds.Principal[0].DescripcionClienteNuevo = "";
            //    ds.Principal[0].DireccionClienteNuevo = "";
            //    ds.Principal[0].Email = "";
            //}
            #endregion


            if (exchClie.Existe)
            {
                ds.Principal[0].DescripcionClienteNuevo = exchClie.RazonSocial;
                //ds.Principal[0].RazonSocial = exchClie.RazonSocial;
                ds.Principal[0].DireccionClienteNuevo = exchClie.Direccion1_Fact;
                ds.Principal[0].Email = exchClie.EMail;


                if (exchClie.Param.grdContactos.Count() > 0)
                    ds.Principal[0].Email = exchClie.Param.grdContactos[0].Email;


                KSKCommon.espvenClieHabitualKSKDS dsAux = KSKDAL.espvenClieHabitualKSK.Datos(exchClie.genEntidades, exchClie.Sucursal, cmd.ConnectionString);
                //dsAux.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
                //Generalidades.Especializacion.UnirDatatSets(exchClie.Param, dsAux);

                if (dsAux.Principal.Count > 0)
                {
                    ds.Principal[0].Dia = dsAux.Principal[0].Dia == 0 ? 1 : dsAux.Principal[0].Dia;
                    ds.Principal[0].Mes = dsAux.Principal[0].Mes == 0 ? 1 : dsAux.Principal[0].Mes;
                    ds.Principal[0].Celular = dsAux.Principal[0].Celular;
                    ds.Principal[0].Instagram = dsAux.Principal[0].Instagram;
                    ds.Principal[0].Youtube = dsAux.Principal[0].Youtube;
                    ds.Principal[0].Linkedin = dsAux.Principal[0].Linkedin;
                    ds.Principal[0].Facebook = dsAux.Principal[0].Facebook;
                }
                else
                {
                    ds.Principal[0].Dia = 1;
                    ds.Principal[0].Mes = 1;
                    ds.Principal[0].Celular = "";
                    ds.Principal[0].Instagram = "";
                    ds.Principal[0].Youtube = "";
                    ds.Principal[0].Linkedin = "";
                    ds.Principal[0].Facebook = "";
                }



            }
            else
            {
                ds.Principal[0].DescripcionClienteNuevo = "";
                ds.Principal[0].DireccionClienteNuevo = "";
                ds.Principal[0].Email = "";
                ds.Principal[0].Celular = "";
                ds.Principal[0].Dia = 1;
                ds.Principal[0].Mes = 1;
                ds.Principal[0].Instagram = "";
                ds.Principal[0].Youtube = "";
                ds.Principal[0].Linkedin = "";
                ds.Principal[0].Facebook = "";
            }


            //Gustavo 30/10/2024 - Porque no encuentro la sucursal con la que esta logeado el cliente
            ds.Principal[0].SucursalLogin = pCommonDS.Principal[0].Segmento2C;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            // LO QUE SIGUE ES LA BETA PARA DARNOS CUENTA SI EL CLIENTE TIENE SEÑA

            // se agrega a la tabla Principal los siguientes campos.
            /// SenaFactura: es el numero de factura 
            /// SenaFecha: Es la fecha de la factura
            /// SemImporte: Es el importe de la seña
            /// ---
            /// Si existe la seña lleno los campos.
            /// Luego desde el formulario pregunto si SenImporte es > 0 
            /// si es > 0 entonces tiene seña y mando mensaje si quiero cargar la seña o algo asi


            var cliente = ds.Principal[0].ClienteNuevo_Id;
            ds.Principal[0].SenaImporte = 0;
            ds.Principal[0].SenaFactura = string.Empty;

            //buscar si el cliente tiene seña
            ConectarSQL conectar = new ConectarSQL();
            DataTable tabla = new DataTable();
            tabla = conectar.EjecutarConsulta($@"select a.RazonSocial,
                    sum(b.CantFacturada * b.PrecioForm) Importe, sum(b.CantFacturada * b.PrecioForm) Cobrado
                    from vVenMovimientos a
                    inner
                    join vvenMovConStockCr b on a.venMovimientos = b.venMovimientos
                                where b.Producto_Id = 'SEÑA' and a.Cliente_Id = '{cliente}' and
                                a.Fecha between getdate() - 30 and getdate()
                                group by a.RazonSocial");

            


            if (tabla.Rows.Count > 0 )
            {
                if ((Decimal)tabla.Rows[0][1] > 0)
                {
                    ds.Principal[0].SenaFactura = tabla.Rows[0][0].ToString();
                    ds.Principal[0].SenaImporte = (Decimal)tabla.Rows[0][1];

                    decimal importesena = ds.Principal[0].SenaImporte;
                    decimal importesenasiniva = importesena / 1.21m;
                    decimal importeimpuesto = importesena - importesenasiniva;

                 //   //voy a modificar a la fuerza el valor del precio de lista de la seña para que no me cague en el calculo
                 //   string texto = $@"update A 
	                //set PrecioLista = {importesena} 
	                //FROM venListasPrecProd A 
		               // INNER JOIN venListasPrecios B ON A.ListaPrecio_Id=B.venListasPrecios
		               // INNER JOIN stkProductos C ON C.stkProductos = A.Producto_Id
	                //WHERE
		               // c.Producto_Id = 'SEÑA' and b.ListaPrecio_Id = 'LOC'";

                 //   conectar.EjecutarQuerySinRespuesta(texto);

                    //la cobranza hace cualquier cosa asi que la unica manera es alternando la cantidad y el precio
                    //Cantidad = precio y precio = cantidad
                    pCommonDS.grdCuerpo.AddgrdCuerpoRow(0, 1, 0, "SEÑA", "GB210", "SEÑA", "LC1-LPA", "", "UN", "", 1,
                               -importesena, -importesena, 0, -importesena, "", 0, "L",
                                1, 0.83m, 1, 0.83m, 0.17M, 0, 0, 0, 0,
                                -importesenasiniva, -importesena, "", DateTime.Today, 0, "", 0, 0, "", "", "", "", "", -importesena);

                    //pCommonDS.grdCuerpo.AddgrdCuerpoRow(0, 1, 0, "SEÑA", "GB210", "SEÑA", "LC1-LPA", "", "UN", "", 1,
                    //    -1, -1, 0, -1, "", 0, "M",
                    //importesena, importesenasiniva, importesena, importesenasiniva, importeimpuesto, 0, 0, 0, 0,
                    //importesenasiniva, importesena, "", DateTime.Today, 0, "", 0, 0, "", "", "", "", "", -1);
                }

            }
            
                pCommonDS.Principal[0].Existe = true;
            Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);

            return pCommonDS;
        }


        #endregion
        #region AccionFE-CobrarPorMercadoPago
        [Generalidades.QFuncion_AccionFE]
        public VentasCommon.venMovimientosConStockDS CobrarPorMercadoPago(VentasCommon.venMovimientosConStockDS pCommonDS, Command cmd)
        {

            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
            ds.MercadoPago[0].IdMercadoPago = "1";

            pCommonDS.Principal[0].Existe = true;
            Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);


            if (pCommonDS.Cobranza[0].Cartera_Id == "MP")
            {
                string mensajeMP = string.Empty;
                string external_reference = pCommonDS.Principal[0].Segmento1C + pCommonDS.Principal[0].Segmento2C + pCommonDS.Principal[0].Segmento3C + "-" + pCommonDS.Principal[0].Segmento1N.ToString();

                GenerarOrden MpOrden = new GenerarOrden(pCommonDS.Cobranza[0].Importe, external_reference, "0225");
                //MpOrden.Borrar();
                if (MpOrden.Generar().Result)
                {
                    ds.MercadoPago[0].IdMercadoPago = "2";
                    string escaneado = MpOrden.Escaneo(external_reference).Result;
                    if (escaneado != "2")
                        Generalidades.qFunctionalException.GenerarExcepcion($"No se detecto escaneo: {MpOrden.Mensaje}");
                    //tendriamos que resetear la cobranza???
                }

            }


            return pCommonDS;
        }
        #endregion
        #region AccionFE-CobrarPorMercadoPago_Borrar
        [Generalidades.QFuncion_AccionFE]
        public VentasCommon.venMovimientosConStockDS CobrarPorMercadoPagoBorrar(VentasCommon.venMovimientosConStockDS pCommonDS, Command cmd)
        {

            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
            ds.MercadoPago[0].IdMercadoPago = "1";

            pCommonDS.Principal[0].Existe = true;
            Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);

            string external_reference = pCommonDS.Principal[0].Segmento1C + pCommonDS.Principal[0].Segmento2C + pCommonDS.Principal[0].Segmento3C + "-" + pCommonDS.Principal[0].Segmento1N.ToString();
            GenerarOrden MpOrden = new GenerarOrden(external_reference);
            MpOrden.Borrar();


            return pCommonDS;
        }
        #endregion
        #region AccionFE-CobrarPorMercadoPago_Orden
        [Generalidades.QFuncion_AccionFE]
        public VentasCommon.venMovimientosConStockDS CobrarPorMercadoPagoOrden(VentasCommon.venMovimientosConStockDS pCommonDS, Command cmd)
        {

            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
            ds.MercadoPago[0].IdMercadoPago = "1";

            pCommonDS.Principal[0].Existe = true;
            Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);




            if (pCommonDS.Cobranza[0].Cartera_Id == "MP")
            {
                string mensajeMP = string.Empty;
                string external_reference = pCommonDS.Principal[0].Segmento1C + pCommonDS.Principal[0].Segmento2C + pCommonDS.Principal[0].Segmento3C + "-" + pCommonDS.Principal[0].Segmento1N.ToString();

                GenerarOrden MpOrden = new GenerarOrden(pCommonDS.Cobranza[0].Importe, external_reference, "0225");
                //MpOrden.Borrar();
                if (MpOrden.Generar().Result)
                    ds.MercadoPago[0].IdMercadoPago = "1";
                else
                    Generalidades.qFunctionalException.GenerarExcepcion($"No se pudo generar la orden: {MpOrden.Mensaje}");
                //tendriamos que resetear la cobranza???

            }

            return pCommonDS;
        }
        #endregion
        #region AccionFE-CobrarPorMercadoPago_Escaneo
        [Generalidades.QFuncion_AccionFE]
        public VentasCommon.venMovimientosConStockDS CobrarPorMercadoPagoEscanear(VentasCommon.venMovimientosConStockDS pCommonDS, Command cmd)
        {

            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
            ds.MercadoPago[0].IdMercadoPago = "1";

            pCommonDS.Principal[0].Existe = true;
            Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);

            string mensajeMP = string.Empty;

            string external_reference = pCommonDS.Principal[0].Segmento1C + pCommonDS.Principal[0].Segmento2C + pCommonDS.Principal[0].Segmento3C + "-" + pCommonDS.Principal[0].Segmento1N.ToString();
            GenerarOrden MpOrden = new GenerarOrden(external_reference);
           
            string escaneado = MpOrden.Escaneo(external_reference).Result;
            if (escaneado != "2")
            {
                //IdMercadoPago, tiene que tomar el valor de escaneado y en funcion de ello mostrar carteles apropiados en el formulario
                ds.MercadoPago[0].IdMercadoPago = "1";
                Generalidades.qFunctionalException.GenerarExcepcion($"No se detecto escaneo: {MpOrden.Mensaje}");

            }
            else
            {
                ds.MercadoPago[0].IdMercadoPago = "2";
            }
            //tendriamos que resetear la cobranza???

            return pCommonDS;
        }
        #endregion
        #region ControlarAntesDeCobrar
        [Generalidades.QFuncion_AccionFE]
        public venMovimientosConStockDS ControlarAntesDeCobrar(venMovimientosConStockDS pCommonDS, Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();

            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            //
            ds.Principal[0].ImporteAAsignar = pCommonDS.Principal[0].Importe;
            ds.Principal[0].ImporteAsignado = 0;

            if (pCommonDS.Principal[0].Importe == 0)
            {
                bool esDevolucion = false;
                // Me fijo si hay algun negativo, en ese caso es una devolucion
                foreach (var item in pCommonDS.grdCuerpo)
                {
                    if (item.CantFacturada < 0)
                        esDevolucion = true;
                }

                if (!esDevolucion)
                    Generalidades.qFunctionalException.GenerarExcepcion("La Factura tiene importe 0");
            }

            //22/09/2023 - Gustavo - Lo llamo desde el formulario justo antes de abrir la cobranza
            //ya que en ese momento tengo el valor neto de la operacion
            NetosFactura.Importe = pCommonDS.Principal[0].Importe;
            //----------------------------------------------------------------------------------------------------

            Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);

            return pCommonDS;
        }
        #endregion
        #region AccionFE-OrdenarMediosDePago
        [Generalidades.QFuncion_AccionFE]
        public VentasCommon.venMovimientosConStockDS OrdenarMediosDePago(VentasCommon.venMovimientosConStockDS pCommonDS, Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();

            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            ds.Identificadores.DefaultView.Sort = "Importe Desc";

            DataTable miTabla = ds.Identificadores.DefaultView.ToTable(true);

            if (ds.Tables.Contains("Identificadores"))
            {
                ds.Tables.Remove("Identificadores");
            }

            miTabla.TableName = "Identificadores";
            ds.Tables.Add(miTabla);

            Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);

            return pCommonDS;
        }
        #endregion


        [Generalidades.QFuncion_AccionFE]
        public VentasCommon.venMovimientosConStockDS TrabajarSena(VentasCommon.venMovimientosConStockDS pCommonDS, Command cmd)
        {
            return pCommonDS;
            //var importesena = 8000;

            //// cambio el valor de la seña por las dudas
            //ConectarSQL conectar = new ConectarSQL();


            ////busco el valor de la seña

            ////voy a modificar a la fuerza el valor del precio de lista de la seña para que no me cague en el calculo
            //string texto = $@"update A 
	           //     set PrecioLista = {importesena} 
	           //     FROM venListasPrecProd A 
		          //      INNER JOIN venListasPrecios B ON A.ListaPrecio_Id=B.venListasPrecios
		          //      INNER JOIN stkProductos C ON C.stkProductos = A.Producto_Id
	           //     WHERE
		          //      c.Producto_Id = 'SEÑA' and b.ListaPrecio_Id = 'LOC'";

            //conectar.EjecutarQuerySinRespuesta(texto);

            //return pCommonDS;

        }
        #region AccionFE-Reiniciar
        [Generalidades.QFuncion_AccionFE]
        public VentasCommon.venMovimientosConStockDS Reiniciar(VentasCommon.venMovimientosConStockDS pCommonDS, Command cmd)
        {
            // Asigno un nuevo ds y el botón llama otra vez a la acción que trae todo otra vez de cero //
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();

            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            

            pCommonDS.Cobranza.Clear();
            pCommonDS.Cobranza.AcceptChanges();

            ds.Identificadores.ToList().ForEach(r =>
            {
                r.Importe = 0;
                r.SetRenglonNull();
            });


            //Gustavo 05/09/2024
            NetosFactura.Importe = pCommonDS.Principal[0].Importe;


            //ds.Principal[0].ImporteAAsignar = pCommonDS.Principal[0].Importe;
            //ds.Principal[0].ImporteAAsignar = ds.Principal[0].Total;
            ds.Principal[0].ImporteAsignado = 0;


            //Gustavo 17/11/2023
            ds.Principal[0].CarteraSel = string.Empty;


            NetosFactura.Carteras.Clear();
            ds = CalcularImportes(ds, 0);
            //22/09/2023 - Gustavo - Actualizo el importe a Asignar con el Neto y Elimino La lista de Netos
            //ds.Principal[0].ImporteAAsignar = NetosFactura.Importe;



            //El NetosFactura.Importe solo se actualiza en el ActualizarNetoFactura que se llama desde el formulario cuando vas a cobrar 
            //------------------------------------------------------------------------------------------

            Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);

            return pCommonDS;
        }
        #endregion
        #region AccionObtenerVariables-VariablesIdentifica
        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesIdentifica(VentasCommon.venMovimientosConStockDS pCommonDS, VentasCommon.venMovimientosConStockDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            TesoreriaExchange.tesIdentificaActionExchange exchIdentifica = new TesoreriaExchange.tesIdentificaActionExchange(TesoreriaExchange.tesIdentificaActionEnum.EnumtesIdentificaAction.Datos)
            {
                Cartera_Id = ds.Identificadores[pIndice].Cartera_Id
            };
            exchIdentifica = new TesoreriaExchange.tesIdentificaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchIdentifica, cmd));


            TesoreriaExchange.tesIdTarjetas3ActionExchange echt3 = new TesoreriaExchange.tesIdTarjetas3ActionExchange(TesoreriaExchange.tesIdTarjetas3ActionEnum.EnumtesIdTarjetas3Action.Datos)
            {
                Cartera_Id = ds.Identificadores[pIndice].Cartera_Id
            };
            echt3 = new TesoreriaExchange.tesIdTarjetas3ActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(echt3, cmd));


            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            lRetorno.Add(venMovimientosVar.TipoCartera.ToString(), exchIdentifica.TipoCartera);
            lRetorno.Add(venMovimientosVar.TipoTarjeta.ToString(), echt3.TipoTarjeta);

            return lRetorno;
        }
        #endregion

        #region ObtenerMascara-MascaraClientesGenerarCodigo
        [Generalidades.QFuncion_ObtenerMascara]
        public string MascaraClientesGenerarCodigo(VentasCommon.venMovimientosConStockDS pCommonDS, VentasCommon.venMovimientosConStockDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            //gustavo 05/11/2024 - tenia 2 0 demas y no te dejaba dar de alta en la factura un cliente nuevo
            //return "00000000000";

            //Gustavo 30/10/2024 - Porque no encuentro la sucursal con la que esta logeado el cliente
            ds.Principal[0].SucursalLogin = pCommonDS.Principal[0].Segmento2C;

            return string.Empty;
        }
        #endregion
        #region ObtenerMascara-MascaraClientes
        [Generalidades.QFuncion_ObtenerMascara]
        public string MascaraClientes(VentasCommon.venMovimientosConStockDS pCommonDS, VentasCommon.venMovimientosConStockDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            //Console.WriteLine($"Tipo Cliente: {ds.Principal[0].TipoCliente}");
            //if (ds.Principal[0].TipoCliente == "0")
            //    //return Generalidades.Mascaras.c_Mascara_CUIT;
            //    return "00000000";


            ////return "00000000000";
            ////gustavo 27/7/2023 - si no es RI devuelvo 8 digitos numericos para que ingrese el DNI
            ////gustavo 05/11/2024 - tenia un 0 demas y no te dejaba dar de alta en la factura un cliente nuevo
            //return "00000000000";

            return string.Empty;

        }
        #endregion
        #region ControlCartera
        [Generalidades.QFuncion_AccionFE]
        public venMovimientosConStockDS ControloCarteras(venMovimientosConStockDS pCommonDS, Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            if (ds.Principal[0].ImporteAAsignar > 0)
            {
                if (ds.Identificadores.Where(r => r.Importe > 0).Count() >= 2)
                    Generalidades.qFunctionalException.GenerarExcepcion("El_sistema_esta_configurado_para_cobrar_con_2_Carteras");
            }

            Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);

            return pCommonDS;
        }
        #endregion

        #region AccionFE-AsignarValoresTarjetas
        [Generalidades.QFuncion_AccionFE]
        public venMovimientosConStockDS AsignarValoresTarjeta(venMovimientosConStockDS pCommonDS, Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            //busco el indice donde estoy parado
            // foreach (var item in ds.Identificadores.Where(x => !x.IsRenglonNull()))
            foreach (var item in ds.Identificadores.Where(x => x.Importe != 0))
            {
                //if (item.Renglon >= 0)
                //{
                    if (item.TipoCartera == "T3")
                    {
                        if (ds.Principal[0].CarteraSel == item.Cartera_Id && item.Importe > 0)
                        {
                            item.T3Cupon = ds.Principal[0].T3Cupon;
                            item.T3Cuotas = ds.Principal[0].T3Cuotas;
                            item.T3Lote = ds.Principal[0].T3Lote;
                            item.T3Comercio = ds.Principal[0].T3Comercio;
                            item.T3Promocion = ds.Principal[0].T3Promocion;
                            item.T3Coeficiente = ds.Principal[0].T3Coeficiente;
                            item.T3NroTarjeta = ds.Principal[0].T3NroTarjeta;
                        }
                    }
                        
                //}
            }


           Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);

            return pCommonDS;
        }
        #endregion

        private VentasCommon.venMovimientosConStockDS AsignarCobranzaInterna(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd, bool pVieneDelForm, KSKCommon.espvenMovimientosConStockKSKDS ds)
        {
            DateTime lDateTime = GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd);

            int lPromocionElegida = 0;
            int lIdentificadorElegido = pIndice;

            //if (ds.Identificadores[lIdentificadorElegido].TipoCartera == "T3")
            //{
            if (!pVieneDelForm)
            {
                lPromocionElegida = ds.Cuotas[pIndice].PromocionElegida;
                lIdentificadorElegido = ds.Promociones[lPromocionElegida].IdentificarElegido;
            }
            //}


            var cartera = NetosFactura.Carteras.Find(x => x.Cartera_Id == ds.Identificadores[lIdentificadorElegido].Cartera_Id);



            // Si se asignó lo modifico sino lo agrego //
            if (ds.Identificadores[lIdentificadorElegido].IsRenglonNull() || ds.Identificadores[lIdentificadorElegido].Renglon == -1)
            {

                // Viene un registro en el dt Cobranzas //
                if (exch.Cobranza.Count == 1 && exch.Cobranza[0].IsImporteNull())
                {
                    exch.Cobranza.Clear();
                    exch.Cobranza.AcceptChanges();
                }
                /// ds.Identificadores[lIdentificadorElegido].Renglon da null y por eso no se le puede asignar ningun valor
                //// TODO: COMO CARAJO SE LE ASIGNA VALOR A ds.Identificadores[lIdentificadorElegido].Renglon 
                //////////////////////////////////////////////////////////////////////////
                ds.Identificadores[lIdentificadorElegido].Renglon = exch.Cobranza.Count;

                switch (ds.Identificadores[lIdentificadorElegido].TipoCartera)
                {

                    case "T3":
                        {
                            exch.Cobranza.AddCobranzaRow(exch.Cobranza.Count,
                                ds.Identificadores[lIdentificadorElegido].Cartera_Id, "",
                                ds.Identificadores[lIdentificadorElegido].TipoCartera,
                                ds.Cuotas[pIndice].Total,
                                //ds.Identificadores[lIdentificadorElegido].Importe / exch.Principal[0].Importe, "", "", "", "",
                                cartera.Importe == null ? ds.Identificadores[lIdentificadorElegido].Importe : cartera.Importe / NetosFactura.Importe,
                                "", "", "", "",
                                lDateTime.Date, "", "", 0, "",
                                ds.Cuotas[pIndice].Cuota, 0, 0, 0, 0,
                                ds.Promociones[lPromocionElegida].Promocion_Id,
                                ds.Cuotas[pIndice].Coeficiente);

                            ds.Identificadores[lIdentificadorElegido].Importe = ds.Cuotas[pIndice].Total; //ao
                            
                            
                            break;
                        }

                    default:
                        {
                            exch.Cobranza.AddCobranzaRow(exch.Cobranza.Count,
                                ds.Identificadores[lIdentificadorElegido].Cartera_Id, "",
                                ds.Identificadores[lIdentificadorElegido].TipoCartera,
                                ds.Principal[0].ImporteAAsignar,
                                ds.Principal[0].ImporteAAsignar / NetosFactura.Importe, "", "", "", "",
                                //ds.Principal[0].ImporteAAsignar / exch.Principal[0].Importe, "", "", "", "",
                                lDateTime.Date, "", "", 0, "", 0, 0, 0, 0, 0, 0, 0);
                            break;
                        }
                }


            }
            else
            {
                int lRenglon = ds.Identificadores[lIdentificadorElegido].Renglon;

                /// TODO: Hay veces que exch.Cobranza[lRenglon].Cartera_Id no esta inicializado y da error, como se inicializa
                exch.Cobranza[lRenglon].Cartera_Id = ds.Identificadores[lIdentificadorElegido].Cartera_Id;
                exch.Cobranza[lRenglon].TipoCartera = ds.Identificadores[lIdentificadorElegido].TipoCartera;
                //exch.Cobranza[lRenglon].Importe = ds.Identificadores[lIdentificadorElegido].Importe; //ao
                if (ds.Identificadores[lIdentificadorElegido].TipoCartera == "T3")
                {
                    exch.Cobranza[lRenglon].T3Cuotas = ds.Cuotas[pIndice].Cuota;
                    exch.Cobranza[lRenglon].T3Promocion = ds.Promociones[lPromocionElegida].Promocion_Id;
                    exch.Cobranza[lRenglon].T3Coeficiente = ds.Cuotas[pIndice].Coeficiente;
                }

                //exch.Cobranza[lRenglon].Importe = ds.Principal[0].ImporteAAsignar; //ao
                //exch.Cobranza[lRenglon].Ponderado = ds.Principal[0].ImporteAAsignar / exch.Principal[0].Importe; //ao
                //exch.Cobranza[lRenglon].Ponderado = ds.Identificadores[lIdentificadorElegido].Importe / exch.Principal[0].Importe; //ao
                exch.Cobranza[lRenglon].Ponderado = cartera.Importe == null ? ds.Identificadores[lIdentificadorElegido].Importe : cartera.Importe / NetosFactura.Importe; //ao

                //Gustavo 2 / 8 / 2023 - Para que actualice el total por si cambian de tipos de cobranza
                if (ds.Identificadores[lIdentificadorElegido].TipoCartera == "T3")
                {
                    exch.Cobranza[lRenglon].Importe = ds.Cuotas[pIndice].Total;
                    //exch.Cobranza[lRenglon].Ponderado = ds.Identificadores[lIdentificadorElegido].Importe / exch.Principal[0].Importe;

                    //ds.Identificadores[lIdentificadorElegido].Importe = ds.Cuotas[pIndice].Total; //ao

                }

                /////// Fin Gustavo
            }

            if (pVieneDelForm)
                Generalidades.Especializacion.UnirDatatSets(exch, ds);

            return exch;
        }
        private KSKCommon.espvenMovimientosConStockKSKDS CalcularImportes(KSKCommon.espvenMovimientosConStockKSKDS ds, decimal pImporteAAsignar)
        {
            //22/09/2023 - Gustavo - El importe a asignar es el Neto de la factura - la suma de todos los netos
            //ds.Principal[0].ImporteAAsignar = ds.Principal[0].Resto;
            ds.Principal[0].ImporteAAsignar = NetosFactura.Importe - NetosFactura.Carteras.Sum(x => x.Importe);
            //ds.Principal[0].Resto = ds.Principal[0].Total - ds.Principal[0].ImporteAsignado;
            ds.Principal[0].Resto = ds.Principal[0].ImporteAAsignar;
            ds.Principal[0].Total = ds.Identificadores.Sum(i => i.Importe) + ds.Principal[0].Resto;
            //-------------------------------------------------------------------------------------
            ds.Principal[0].ImporteAsignado = ds.Identificadores.Sum(i => i.Importe);


            return ds;
        }
        #region AccionFE-ActualizarCabeceraCobranza
        [Generalidades.QFuncion_AccionFE]
        public VentasCommon.venMovimientosConStockDS ActualizarCabeceraCobranza(VentasCommon.venMovimientosConStockDS pCommonDS, Command cmd)
        {
            KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
            ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

            ds = CalcularImportes(ds, 0);

            Generalidades.Especializacion.UnirDatatSets(pCommonDS, ds);
            return pCommonDS;
        }
        #endregion
        #region MostrarHTML-HTMLTicket
        [Generalidades.QFuncion_MostrarHTML]
        public string HTMLTicket(VentasCommon.venMovimientosConStockDS pCommonDS, VentasCommon.venMovimientosConStockDS pCommonDSNoPost, int pIndice, Command cmd)

        {

            return Comunes.HTMLTicket(pCommonDS, pCommonDSNoPost, pIndice, cmd);

            //    string lRetorno = "";
            //    //decimal lTotal = 0;
            //    //decimal lSubtotal = 0;


            //    var lSegmentoStr =
            //    GeneralesValidacion.genSegmentos.SegmentoStr(pCommonDS.Principal[0].Segmento_Id, "", pCommonDS.Principal[0].Segmento2C, "", pCommonDS.Principal[0].Segmento4C, pCommonDS.Principal[0].Segmento1N, pCommonDS.Principal[0].Segmento2N, pCommonDS.Principal[0].Segmento3N, pCommonDS.Principal[0].Segmento4N, cmd);

            //    var eEmpresa = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
            //    var eUsuario = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd);
            //    var eSucursal = GeneralesValidacion.genSucursalesEmpr.Existe(eUsuario.Sucursal, cmd);

            //    lRetorno += "<html><head></head><body>";
            //    lRetorno += "<FONT SIZE =\"2p\">";

            //    if (pCommonDS.Principal[0].Segmento1C == "F")
            //    {
            //        lRetorno += "<img alt='Imagen' height='100px' width='100px' src='data:image/png;base64," + eEmpresa.Logo + "' /><br>";
            //        lRetorno += eEmpresa.RazonSocial + "<br>";
            //        lRetorno += eEmpresa.Calle + " " + eEmpresa.NoExterior + " " + eEmpresa.Localidad + " " + "<br>";
            //        lRetorno += eEmpresa.DescripcionProvincias + " " + "<br>";
            //        lRetorno += "CUIT:" + eEmpresa.Cuit + " IIBB:" + eEmpresa.NumeroIIBB + "<br>";
            //        lRetorno += eEmpresa.CondFiscal + "<br>";
            //        lRetorno += "----------------------------------------------------------<br>";
            //        lRetorno += pCommonDS.Principal[0].Fecha.Day.ToString("00") + "/" + pCommonDS.Principal[0].Fecha.Month.ToString("00") + "/" + pCommonDS.Principal[0].Fecha.Year.ToString("0000") + "  ";
            //        lRetorno += pCommonDS.Principal[0].Fecha.Hour.ToString("00") + ":" + pCommonDS.Principal[0].Fecha.Minute.ToString("00") + ":" + pCommonDS.Principal[0].Fecha.Second.ToString("00") + "  ";
            //        lRetorno += "Nro.T.:" + lSegmentoStr.SegmentoSTR + "<br>";
            //        lRetorno += "----------------------------------------------------------<br>";
            //        //lRetorno += "RFC:" + eEmpresa.Cuit + "</p>";
            //        //lRetorno += "<p> </p>";
            //        lRetorno += eSucursal.Descripcion + "<br> ";
            //        lRetorno += eSucursal.Direccion + "<br>";
            //        lRetorno += eSucursal.Localidad + " " + eSucursal.DescripcionProvincias + " " + eSucursal.CodigoPostal + "<br>";
            //        lRetorno += "Te:" + eSucursal.Telefono + "<br>";
            //        //lRetorno += "<p> </p>";
            //        //lRetorno += "<p>Vendedor:" + pCommonDS.Principal[0].Vendedor_Id + "<br>";
            //        //lRetorno += pCommonDS.Principal[0].NombreFantasia + "</p>";
            //        //lRetorno += "<p> </p>";

            //        int nEspBlancos = 18;
            //        string EB = "";
            //        for (int i = 0; i < nEspBlancos; i++)
            //            EB += "&nbsp";

            //        lRetorno += "----------------------------------------------------------<br>";
            //        lRetorno += "Cant. Descripción" + EB + "Precio Uni      Total<br>";
            //        lRetorno += "----------------------------------------------------------<br>";
            //        nEspBlancos = 8;
            //        EB = "";
            //        foreach (var ren in pCommonDS.grdCuerpo)
            //        {

            //            nEspBlancos -= ren.CantOriginal.ToString().Length;
            //            for (int i = 0; i < nEspBlancos; i++)
            //                EB += "&nbsp";


            //            //string EBP_ID = "&nbsp";
            //            //nEspBlancos = 28;
            //            //nEspBlancos -= ren.Producto_Id.ToString().Length;
            //            //for (int i = 0; i < nEspBlancos; i++)
            //            //    EBP_ID += "&nbsp";

            //            string EBPF = "&nbsp";
            //            nEspBlancos = 10;
            //            nEspBlancos -= ren.PrecioForm.ToString().Length;
            //            for (int i = 0; i < nEspBlancos; i++)
            //                EBPF += "&nbsp";

            //            //string EBBonif = "&nbsp";
            //            //nEspBlancos = 6;
            //            //nEspBlancos -= ren.Bonificacion.ToString().Length;
            //            //for (int i = 0; i < nEspBlancos; i++)
            //            //    EBBonif += "&nbsp";

            //            string EBDescrip = "&nbsp";
            //            nEspBlancos = 3;
            //            nEspBlancos -= ren.DescripcionProductos.Length;
            //            for (int i = 0; i < nEspBlancos; i++)
            //                EBDescrip += "&nbsp";

            //            //string EBBonif = "&nbsp";
            //            //nEspBlancos = 6;
            //            //nEspBlancos -= ren.SubTotal.ToString().Length;
            //            //for (int i = 0; i < nEspBlancos; i++)
            //            //    EBBonif += "&nbsp";

            //            string EBSTFI = "&nbsp";
            //            nEspBlancos = 10;
            //            nEspBlancos -= ren.SubTotal.ToString().Length;
            //            for (int i = 0; i < nEspBlancos; i++)
            //                EBSTFI += "&nbsp";


            //            nEspBlancos = 10;
            //            nEspBlancos -= ren.SubTotal.ToString().Length;
            //            for (int i = 0; i <= nEspBlancos; i++)
            //                EB += "&nbsp";

            //            //if (ren.Producto_Id.Length > 13)
            //            //{
            //            //    lRetorno += ren.Producto_Id.Substring(0, 13) + EBP_ID + ren.PrecioForm.ToString() + EBPF + ren.Bonificacion.ToString() + EBBonif + lSubtotal.ToString() + "<br>";
            //            //    lRetorno += ren.Producto_Id.Substring(13, ren.Producto_Id.Length - 13) + "</p>";

            //            //}
            //            //else

            //            lRetorno += "<p>" + ren.CantOriginal.ToString() + EBDescrip + ren.DescripcionProductos + EBPF + ren.PrecioForm.ToString() + EBSTFI + ren.SubTotalFormImpuesto.ToString() + "</p>";

            //            EB = "";
            //            nEspBlancos = 8;

            //        }

            //        nEspBlancos = 50;
            //        nEspBlancos -= pCommonDS.Principal[0].SubTotal.ToString().Length;
            //        for (int i = 0; i < nEspBlancos; i++)
            //            EB += "&nbsp";

            //        lRetorno += "----------------------------------------------------------<br>";
            //        lRetorno += "SubTotal:" + EB + pCommonDS.Principal[0].SubTotal.ToString() + "<br>";

            //        pCommonDS.grdImpuestos.ToList().ForEach(i =>
            //        {
            //            lRetorno += i.DescripcionImpuestos + " " + i.Importe.ToString() + "<br>";
            //        });

            //        lRetorno += "==================================<br>";
            //        lRetorno += "<strong>Total:" + EB + pCommonDS.Principal[0].Importe.ToString() + "</strong><br>";
            //        lRetorno += "==================================<br>";
            //        lRetorno += "<p> </p>";
            //        lRetorno += "<p>" + GeneralidadesFEAdv.Varios.NroALetra(pCommonDS.Principal[0].Importe, false, pCommonDS.Principal[0].Moneda_Id, pCommonDS.Principal[0].DescripcionMonedas, eEmpresa.DescripcionPaises, eEmpresa.Moneda_Id) + "</p>";

            //        VentasExchange.venClieHabitualActionExchange exchClieH = VentasValidacion.venClieHabitual.ExistePosteadoyActivo(pCommonDS.Principal[0].Cliente_Id, pCommonDS.Principal[0].Sucursal, cmd);


            //        GeneralesExchange.genMonedasActionExchange exchMon = GeneralesValidacion.genMonedas.ExistePosteadoyActiva(pCommonDS.Principal[0].Moneda_Id, cmd);


            //        //lRetorno += "<img alt='Imagen' height='100px' width='100px' src='data:image/png;base64," + Convert.FromBase64String(GeneralidadesFEAdv.Varios.QrCode("https://www.afip.gob.ar/fe/qr/?p=" + GeneralidadesFEAdv.Varios.ToBase64(GeneralidadesFEAdv.Varios.ArmarJSONFEAR(1, pCommonDS.Principal[0].Fecha.Date, eEmpresa.Cuit, pCommonDS.Principal[0].Segmento2C, pCommonDS.venMovFiscal[0].Comprobante_Id, pCommonDS.Principal[0].Segmento1N, pCommonDS.Principal[0].Importe, exchMon.CodigoFiscal, pCommonDS.Principal[0].Cambio, exchClieH.TipoDoc, exchClieH.CUIT.Replace("-", ""), "E", pCommonDS.venMovFiscal[0].ClaveFiscal)))) + "' /><br>";


            //        lRetorno += "<img alt='Imagen' src='data:image/jpeg;base64," + GeneralidadesFEAdv.Varios.QrCode("https://www.afip.gob.ar/fe/qr/?p=" + GeneralidadesFEAdv.Varios.ToBase64(GeneralidadesFEAdv.Varios.ArmarJSONFEAR(1, pCommonDS.Principal[0].Fecha.Date, eEmpresa.Cuit, pCommonDS.Principal[0].Segmento2C, 81,pCommonDS.Principal[0].Segmento1N, pCommonDS.Principal[0].Importe, exchMon.CodigoFiscal, pCommonDS.Principal[0].Cambio, exchClieH.TipoDoc, exchClieH.CUIT.Replace("-", ""), "E", "12345678901234")), 10) + "' /><br>";

            //        lRetorno += "<p>----------------------------------------------------------</ p>";

            //    }
            //    else
            //    {
            //        lRetorno += "<p>" + eEmpresa.RazonSocial + "<br>";
            //        lRetorno += eEmpresa.Calle + " " + eEmpresa.NoExterior + " " + eEmpresa.Localidad + " " + "<br>";
            //        lRetorno += eEmpresa.DescripcionProvincias + " " + "<br>";
            //        lRetorno += "<p>**************** T I C K E T *****************</p>";
            //        lRetorno += "<p>----------------------------------------------------------</ p>";
            //        lRetorno += "<p>Ticket:" + lSegmentoStr.SegmentoSTR + "<br>";
            //        lRetorno += "<Fecha:" + pCommonDS.Principal[0].Fecha.Day.ToString("00") + "/" + pCommonDS.Principal[0].Fecha.Month.ToString("00") + "/" + pCommonDS.Principal[0].Fecha.Year.ToString("0000") + "<br>";
            //        lRetorno += "Hora:" + pCommonDS.Principal[0].Fecha.Hour.ToString("00") + ":" + pCommonDS.Principal[0].Fecha.Minute.ToString("00") + ":" + pCommonDS.Principal[0].Fecha.Second.ToString("00") + "</p>";
            //        lRetorno += "<p>----------------------------------------------------------</ p>";
            //        //lRetorno += "RFC:" + eEmpresa.Cuit + "</p>";
            //        lRetorno += "<p> </p>";
            //        lRetorno += "<p>" + eSucursal.Descripcion + "<br> ";
            //        lRetorno += eSucursal.Direccion + "<br>";
            //        lRetorno += eSucursal.Localidad + " " + eSucursal.DescripcionProvincias + "" + eSucursal.CodigoPostal + "<br>";
            //        lRetorno += "Te:" + eSucursal.Telefono + "</p>";
            //        lRetorno += "<p> </p>";
            //        //lRetorno += "<p>Vendedor:" + pCommonDS.Principal[0].Vendedor_Id + "<br>";
            //        //lRetorno += pCommonDS.Principal[0].NombreFantasia + "</p>";
            //        lRetorno += "<p> </p>";

            //        int nEspBlancos = 22;
            //        string EB = "";
            //        for (int i = 0; i < nEspBlancos; i++)
            //            EB += "&nbsp";

            //        lRetorno += "<p>----------------------------------------------------------</ p>";
            //        lRetorno += "<p>Cant. Descripción" + EB + "Precio Uni  Total</p>";
            //        lRetorno += "<p>----------------------------------------------------------</ p>";
            //        nEspBlancos = 8;
            //        EB = "";
            //        foreach (var ren in pCommonDS.grdCuerpo)
            //        {

            //            nEspBlancos -= ren.CantOriginal.ToString().Length;
            //            for (int i = 0; i < nEspBlancos; i++)
            //                EB += "&nbsp";

            //            //lSubtotal = ren.CantOriginal * Generalidades.Auxiliares.Redondear((ren.PrecioForm * (1 - ren.Bonificacion / 100)), 2);
            //            //lTotal += lSubtotal;

            //            //if (ren.DescripcionProductos.Length > 29)
            //            //{
            //            //    lRetorno += "<p>" + EB + ren.CantOriginal.ToString() + " " + ren.DescripcionProductos.Substring(0, 29) + "<br>";
            //            //    //10 espacios para los numeros
            //            //    lRetorno += "&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + ren.DescripcionProductos.Substring(29, ren.DescripcionProductos.Length - 29) + "<br>";

            //            //}
            //            //else
            //            //{
            //            //    lRetorno += "<p>" + EB + ren.CantOriginal.ToString() + " " + ren.DescripcionProductos + " " + "<br>";
            //            //}

            //            string EBP_ID = "&nbsp";
            //            nEspBlancos = 28;
            //            nEspBlancos -= ren.Producto_Id.ToString().Length;
            //            for (int i = 0; i < nEspBlancos; i++)
            //                EBP_ID += "&nbsp";

            //            string EBPF = "&nbsp";
            //            nEspBlancos = 10;
            //            nEspBlancos -= ren.PrecioForm.ToString().Length;
            //            for (int i = 0; i < nEspBlancos; i++)
            //                EBPF += "&nbsp";

            //            //string EBBonif = "&nbsp";
            //            //nEspBlancos = 6;
            //            //nEspBlancos -= ren.Bonificacion.ToString().Length;
            //            //for (int i = 0; i < nEspBlancos; i++)
            //            //    EBBonif += "&nbsp";

            //            string EBBonif = "&nbsp";
            //            nEspBlancos = 6;
            //            nEspBlancos -= ren.SubTotal.ToString().Length;
            //            for (int i = 0; i < nEspBlancos; i++)
            //                EBBonif += "&nbsp";


            //            nEspBlancos = 10;
            //            nEspBlancos -= ren.SubTotal.ToString().Length;
            //            for (int i = 0; i <= nEspBlancos; i++)
            //                EB += "&nbsp";

            //            //if (ren.Producto_Id.Length > 13)
            //            //{
            //            //    lRetorno += ren.Producto_Id.Substring(0, 13) + EBP_ID + ren.PrecioForm.ToString() + EBPF + ren.Bonificacion.ToString() + EBBonif + lSubtotal.ToString() + "<br>";
            //            //    lRetorno += ren.Producto_Id.Substring(13, ren.Producto_Id.Length - 13) + "</p>";

            //            //}
            //            //else

            //            lRetorno += "<p>" + ren.CantOriginal.ToString() + EBBonif + ren.DescripcionProductos + EBP_ID + ren.PrecioForm.ToString() + EBPF + ren.SubTotalFormImpuesto.ToString() + "</p>";





            //            EB = "";
            //            nEspBlancos = 8;

            //        }
            //        nEspBlancos = 10;

            //        nEspBlancos -= pCommonDS.Principal[0].Importe.ToString().Length;
            //        for (int i = 0; i < nEspBlancos; i++)
            //            EB += "&nbsp";

            //        lRetorno += "<p>----------------------------------------------------------</ p>";
            //        lRetorno += "<p><strong>Total:" + EB + pCommonDS.Principal[0].Importe.ToString() + "</strong></p>";
            //        lRetorno += "<p> </p>";
            //        lRetorno += "<p>" + GeneralidadesFEAdv.Varios.NroALetra(pCommonDS.Principal[0].Importe, false, pCommonDS.Principal[0].Moneda_Id, pCommonDS.Principal[0].DescripcionMonedas, eEmpresa.DescripcionPaises, eEmpresa.Moneda_Id) + "</p>";
            //        lRetorno += "<p> </p>";
            //        lRetorno += "<p>DOCUMENTO NO VÁLIDO COMO FACTURA</ p>";
            //        lRetorno += "<p>";
            //        lRetorno += "</p>";

            //        lRetorno += "<p>----------------------------------------------------------</ p>";




            //    }
            //    lRetorno += "</FONT></body></html>";

            //    ///El string debe representar la estructura de una página HTML
            //    return lRetorno;
        }
        #endregion
      
    }
}

