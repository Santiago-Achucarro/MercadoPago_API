using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace KSKExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class espvenMovimientosConStockKSKActionExchange : Framework.Core.Exchange{

        public Int32 Terminal_Id {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Terminal_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Terminal_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Terminal_Id = value;
               }
	          }
        public bool IsTerminal_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsTerminal_IdNull();
             }
	        }
        public String DescripcionTerminal {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["DescripcionTerminal"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].DescripcionTerminal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].DescripcionTerminal = value;
               }
	          }
        public bool IsDescripcionTerminalNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsDescripcionTerminalNull();
             }
	        }
        public Decimal ImporteAAsignar {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["ImporteAAsignar"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].ImporteAAsignar;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].ImporteAAsignar = value;
               }
	          }
        public bool IsImporteAAsignarNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsImporteAAsignarNull();
             }
	        }
        public Decimal ImporteAsignado {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["ImporteAsignado"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].ImporteAsignado;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].ImporteAsignado = value;
               }
	          }
        public bool IsImporteAsignadoNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsImporteAsignadoNull();
             }
	        }
        public Decimal Total {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public Decimal Resto {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Resto"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Resto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Resto = value;
               }
	          }
        public bool IsRestoNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsRestoNull();
             }
	        }
        public Boolean Comanda {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Comanda"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Comanda;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Comanda = value;
               }
	          }
        public bool IsComandaNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsComandaNull();
             }
	        }
        public String CodigoBarra {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["CodigoBarra"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CodigoBarra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CodigoBarra = value;
               }
	          }
        public bool IsCodigoBarraNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsCodigoBarraNull();
             }
	        }
        public Decimal LimiteCF {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["LimiteCF"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].LimiteCF;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].LimiteCF = value;
               }
	          }
        public bool IsLimiteCFNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsLimiteCFNull();
             }
	        }
        public String TipoCliente {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["TipoCliente"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].TipoCliente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].TipoCliente = value;
               }
	          }
        public bool IsTipoClienteNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsTipoClienteNull();
             }
	        }
        public String ClienteNuevo_Id {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["ClienteNuevo_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].ClienteNuevo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].ClienteNuevo_Id = value;
               }
	          }
        public bool IsClienteNuevo_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsClienteNuevo_IdNull();
             }
	        }
        public String DescripcionClienteNuevo {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["DescripcionClienteNuevo"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].DescripcionClienteNuevo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].DescripcionClienteNuevo = value;
               }
	          }
        public bool IsDescripcionClienteNuevoNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsDescripcionClienteNuevoNull();
             }
	        }
        public String DireccionClienteNuevo {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["DireccionClienteNuevo"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].DireccionClienteNuevo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].DireccionClienteNuevo = value;
               }
	          }
        public bool IsDireccionClienteNuevoNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsDireccionClienteNuevoNull();
             }
	        }
        public String CTBanco_Id {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["CTBanco_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTBanco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTBanco_Id = value;
               }
	          }
        public bool IsCTBanco_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsCTBanco_IdNull();
             }
	        }
        public String CTDescripcionBanco {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["CTDescripcionBanco"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTDescripcionBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTDescripcionBanco = value;
               }
	          }
        public bool IsCTDescripcionBancoNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsCTDescripcionBancoNull();
             }
	        }
        public String CTClearing {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["CTClearing"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTClearing;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTClearing = value;
               }
	          }
        public bool IsCTClearingNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsCTClearingNull();
             }
	        }
        public DateTime CTFechaVencimiento {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["CTFechaVencimiento"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTFechaVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTFechaVencimiento = value;
               }
	          }
        public bool IsCTFechaVencimientoNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsCTFechaVencimientoNull();
             }
	        }
        public String CTsucBanco {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["CTsucBanco"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTsucBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTsucBanco = value;
               }
	          }
        public bool IsCTsucBancoNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsCTsucBancoNull();
             }
	        }
        public String CTcuentaBanco {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["CTcuentaBanco"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTcuentaBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTcuentaBanco = value;
               }
	          }
        public bool IsCTcuentaBancoNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsCTcuentaBancoNull();
             }
	        }
        public Int32 CTnumCheque {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["CTnumCheque"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTnumCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTnumCheque = value;
               }
	          }
        public bool IsCTnumChequeNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsCTnumChequeNull();
             }
	        }
        public String CTLectoraCheques {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["CTLectoraCheques"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTLectoraCheques;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CTLectoraCheques = value;
               }
	          }
        public bool IsCTLectoraChequesNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsCTLectoraChequesNull();
             }
	        }
        public Int32 T3Cuotas {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["T3Cuotas"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Cuotas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Cuotas = value;
               }
	          }
        public bool IsT3CuotasNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsT3CuotasNull();
             }
	        }
        public Int32 T3Cupon {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["T3Cupon"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Cupon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Cupon = value;
               }
	          }
        public bool IsT3CuponNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsT3CuponNull();
             }
	        }
        public Int32 T3Lote {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["T3Lote"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Lote;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Lote = value;
               }
	          }
        public bool IsT3LoteNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsT3LoteNull();
             }
	        }
        public Int32 T3Comercio {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["T3Comercio"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Comercio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Comercio = value;
               }
	          }
        public bool IsT3ComercioNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsT3ComercioNull();
             }
	        }
        public Int32 T3Terminal {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["T3Terminal"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Terminal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Terminal = value;
               }
	          }
        public bool IsT3TerminalNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsT3TerminalNull();
             }
	        }
        public Int32 T3Promocion {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["T3Promocion"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Promocion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Promocion = value;
               }
	          }
        public bool IsT3PromocionNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsT3PromocionNull();
             }
	        }
        public Decimal T3Coeficiente {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["T3Coeficiente"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Coeficiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].T3Coeficiente = value;
               }
	          }
        public bool IsT3CoeficienteNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsT3CoeficienteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Email {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Email"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Email;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Email = value;
               }
	          }
        public bool IsEmailNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsEmailNull();
             }
	        }
        public Int32 Dia {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Dia"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Dia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Dia = value;
               }
	          }
        public bool IsDiaNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsDiaNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public String Celular {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Celular"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Celular;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Celular = value;
               }
	          }
        public bool IsCelularNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsCelularNull();
             }
	        }
        public String Instagram {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Instagram"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Instagram;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Instagram = value;
               }
	          }
        public bool IsInstagramNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsInstagramNull();
             }
	        }
        public String Youtube {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Youtube"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Youtube;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Youtube = value;
               }
	          }
        public bool IsYoutubeNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsYoutubeNull();
             }
	        }
        public String Linkedin {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Linkedin"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Linkedin;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Linkedin = value;
               }
	          }
        public bool IsLinkedinNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsLinkedinNull();
             }
	        }
        public String Facebook {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Facebook"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Facebook;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Facebook = value;
               }
	          }
        public bool IsFacebookNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsFacebookNull();
             }
	        }
        public String MPEstado {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["MPEstado"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].MPEstado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].MPEstado = value;
               }
	          }
        public bool IsMPEstadoNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsMPEstadoNull();
             }
	        }
        public String CarteraSel {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["CarteraSel"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CarteraSel;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].CarteraSel = value;
               }
	          }
        public bool IsCarteraSelNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsCarteraSelNull();
             }
	        }
        public String Comprobante {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["Comprobante"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Comprobante;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].Comprobante = value;
               }
	          }
        public bool IsComprobanteNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsComprobanteNull();
             }
	        }
        public String MPMensaje {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["MPMensaje"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].MPMensaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].MPMensaje = value;
               }
	          }
        public bool IsMPMensajeNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsMPMensajeNull();
             }
	        }
        public String PrimeraVez {
            get {
                if(((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0]["PrimeraVez"] != DBNull.Value  ){
                    return ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].PrimeraVez;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].PrimeraVez = value;
               }
	          }
        public bool IsPrimeraVezNull {
             get {
                 return mParam==null || ((KSKCommon.espvenMovimientosConStockKSKDS)mParam).Principal[0].IsPrimeraVezNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.espvenMovimientosConStockKSKDS );
     }
     public espvenMovimientosConStockKSKActionExchange() : base( "espvenMovimientosConStockKSK" ) {
     }

     public espvenMovimientosConStockKSKActionExchange(espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction pAccion) : base(espvenMovimientosConStockKSKActionEnum.GetAccionespvenMovimientosConStockKSKAction(pAccion)) {
     }

     public espvenMovimientosConStockKSKActionExchange(espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction pAccion, KSKCommon.espvenMovimientosConStockKSKDS pdsParam) : base(espvenMovimientosConStockKSKActionEnum.GetAccionespvenMovimientosConStockKSKAction(pAccion), pdsParam) {
     }

     public espvenMovimientosConStockKSKActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.espvenMovimientosConStockKSKDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public espvenMovimientosConStockKSKActionExchange(KSKCommon.espvenMovimientosConStockKSKDS pDS) : base() {
     this.Action = "";
     this.mParam = new KSKCommon.espvenMovimientosConStockKSKDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.espvenMovimientosConStockKSKDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.espvenMovimientosConStockKSKDS)mParam;
	        }
     }
  }
}
