using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesRengMoviActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String DescripcionIdentifica {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["DescripcionIdentifica"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].DescripcionIdentifica;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].DescripcionIdentifica = value;
               }
	          }
        public bool IsDescripcionIdentificaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsDescripcionIdentificaNull();
             }
	        }
        public Decimal ImporteOrig {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["ImporteOrig"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].ImporteOrig;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].ImporteOrig = value;
               }
	          }
        public bool IsImporteOrigNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsImporteOrigNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal Tipomov {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Tipomov"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Tipomov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Tipomov = value;
               }
	          }
        public bool IsTipomovNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTipomovNull();
             }
	        }
        public String Clase {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public String TipoCartera {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["TipoCartera"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TipoCartera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TipoCartera = value;
               }
	          }
        public bool IsTipoCarteraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTipoCarteraNull();
             }
	        }
        public Int32 tesCheqProp {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["tesCheqProp"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].tesCheqProp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].tesCheqProp = value;
               }
	          }
        public bool IstesCheqPropNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IstesCheqPropNull();
             }
	        }
        public Int32 CPChequera_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPChequera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPChequera_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPChequera_Id = value;
               }
	          }
        public bool IsCPChequera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPChequera_IdNull();
             }
	        }
        public Int32 CPnumCheque {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPnumCheque"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPnumCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPnumCheque = value;
               }
	          }
        public bool IsCPnumChequeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPnumChequeNull();
             }
	        }
        public String CPEstado_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPEstado_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPEstado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPEstado_Id = value;
               }
	          }
        public bool IsCPEstado_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPEstado_IdNull();
             }
	        }
        public String CPTipoChequera {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPTipoChequera"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPTipoChequera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPTipoChequera = value;
               }
	          }
        public bool IsCPTipoChequeraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPTipoChequeraNull();
             }
	        }
        public Int32 CPChequeraDesde {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPChequeraDesde"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPChequeraDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPChequeraDesde = value;
               }
	          }
        public bool IsCPChequeraDesdeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPChequeraDesdeNull();
             }
	        }
        public Int32 CPChequeraHasta {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPChequeraHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPChequeraHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPChequeraHasta = value;
               }
	          }
        public bool IsCPChequeraHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPChequeraHastaNull();
             }
	        }
        public Int32 CPChequeraProximo {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPChequeraProximo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPChequeraProximo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPChequeraProximo = value;
               }
	          }
        public bool IsCPChequeraProximoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPChequeraProximoNull();
             }
	        }
        public DateTime CPFechaVencimiento {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPFechaVencimiento"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPFechaVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPFechaVencimiento = value;
               }
	          }
        public bool IsCPFechaVencimientoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPFechaVencimientoNull();
             }
	        }
        public String CPAlaOrden {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPAlaOrden"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPAlaOrden;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPAlaOrden = value;
               }
	          }
        public bool IsCPAlaOrdenNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPAlaOrdenNull();
             }
	        }
        public String CPCuit {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPCuit"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPCuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPCuit = value;
               }
	          }
        public bool IsCPCuitNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPCuitNull();
             }
	        }
        public String CPCuentaDestino {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPCuentaDestino"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPCuentaDestino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPCuentaDestino = value;
               }
	          }
        public bool IsCPCuentaDestinoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPCuentaDestinoNull();
             }
	        }
        public String CPBanco_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPBanco_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPBanco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPBanco_Id = value;
               }
	          }
        public bool IsCPBanco_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPBanco_IdNull();
             }
	        }
        public String CPDescripcionBanco {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPDescripcionBanco"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPDescripcionBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPDescripcionBanco = value;
               }
	          }
        public bool IsCPDescripcionBancoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPDescripcionBancoNull();
             }
	        }
        public String CPBancoDestinoExt {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CPBancoDestinoExt"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPBancoDestinoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CPBancoDestinoExt = value;
               }
	          }
        public bool IsCPBancoDestinoExtNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCPBancoDestinoExtNull();
             }
	        }
        public Int32 tesCheqTerceros {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["tesCheqTerceros"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].tesCheqTerceros;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].tesCheqTerceros = value;
               }
	          }
        public bool IstesCheqTercerosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IstesCheqTercerosNull();
             }
	        }
        public String CTBanco_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTBanco_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTBanco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTBanco_Id = value;
               }
	          }
        public bool IsCTBanco_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTBanco_IdNull();
             }
	        }
        public String CTDescripcionBanco {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTDescripcionBanco"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTDescripcionBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTDescripcionBanco = value;
               }
	          }
        public bool IsCTDescripcionBancoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTDescripcionBancoNull();
             }
	        }
        public String CTClearing {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTClearing"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTClearing;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTClearing = value;
               }
	          }
        public bool IsCTClearingNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTClearingNull();
             }
	        }
        public String CTVariable {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTVariable"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTVariable;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTVariable = value;
               }
	          }
        public bool IsCTVariableNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTVariableNull();
             }
	        }
        public Int16 CTClearingDias {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTClearingDias"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTClearingDias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTClearingDias = value;
               }
	          }
        public bool IsCTClearingDiasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTClearingDiasNull();
             }
	        }
        public DateTime CTFechaVencimiento {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTFechaVencimiento"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTFechaVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTFechaVencimiento = value;
               }
	          }
        public bool IsCTFechaVencimientoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTFechaVencimientoNull();
             }
	        }
        public String CTsucBanco {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTsucBanco"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTsucBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTsucBanco = value;
               }
	          }
        public bool IsCTsucBancoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTsucBancoNull();
             }
	        }
        public String CTcuentaBanco {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTcuentaBanco"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTcuentaBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTcuentaBanco = value;
               }
	          }
        public bool IsCTcuentaBancoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTcuentaBancoNull();
             }
	        }
        public Int32 CTnumCheque {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTnumCheque"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTnumCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTnumCheque = value;
               }
	          }
        public bool IsCTnumChequeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTnumChequeNull();
             }
	        }
        public String CTEstado_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTEstado_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTEstado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTEstado_Id = value;
               }
	          }
        public bool IsCTEstado_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTEstado_IdNull();
             }
	        }
        public String CTCliente_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTCliente_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTCliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTCliente_Id = value;
               }
	          }
        public bool IsCTCliente_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTCliente_IdNull();
             }
	        }
        public String CTRazonSocial {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTRazonSocial"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTRazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTRazonSocial = value;
               }
	          }
        public bool IsCTRazonSocialNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTRazonSocialNull();
             }
	        }
        public String CTLectoraCheques {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["CTLectoraCheques"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTLectoraCheques;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].CTLectoraCheques = value;
               }
	          }
        public bool IsCTLectoraChequesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCTLectoraChequesNull();
             }
	        }
        public Int64 FPAsiento_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPAsiento_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPAsiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPAsiento_Id = value;
               }
	          }
        public bool IsFPAsiento_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPAsiento_IdNull();
             }
	        }
        public DateTime FPFecha_Ane {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPFecha_Ane"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPFecha_Ane;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPFecha_Ane = value;
               }
	          }
        public bool IsFPFecha_AneNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPFecha_AneNull();
             }
	        }
        public DateTime FPFechaFiscal {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPFechaFiscal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPFechaFiscal;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPFechaFiscal = value;
               }
	          }
        public bool IsFPFechaFiscalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPFechaFiscalNull();
             }
	        }
        public String FPCuit {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPCuit"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPCuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPCuit = value;
               }
	          }
        public bool IsFPCuitNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPCuitNull();
             }
	        }
        public String FPTipoDoc {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPTipoDoc"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPTipoDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPTipoDoc = value;
               }
	          }
        public bool IsFPTipoDocNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPTipoDocNull();
             }
	        }
        public String FPIdFiscal {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPIdFiscal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPIdFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPIdFiscal = value;
               }
	          }
        public bool IsFPIdFiscalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPIdFiscalNull();
             }
	        }
        public String FPRazonSocial {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPRazonSocial"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPRazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPRazonSocial = value;
               }
	          }
        public bool IsFPRazonSocialNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPRazonSocialNull();
             }
	        }
        public String FPDireccion1 {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPDireccion1"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPDireccion1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPDireccion1 = value;
               }
	          }
        public bool IsFPDireccion1Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPDireccion1Null();
             }
	        }
        public String FPDireccion2 {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPDireccion2"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPDireccion2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPDireccion2 = value;
               }
	          }
        public bool IsFPDireccion2Null {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPDireccion2Null();
             }
	        }
        public String Localidad {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String Cod_Postal {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Cod_Postal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Cod_Postal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Cod_Postal = value;
               }
	          }
        public bool IsCod_PostalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsCod_PostalNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String FPDescripcionPcia {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPDescripcionPcia"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPDescripcionPcia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPDescripcionPcia = value;
               }
	          }
        public bool IsFPDescripcionPciaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPDescripcionPciaNull();
             }
	        }
        public String FPCondFiscal_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPCondFiscal_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPCondFiscal_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPCondFiscal_Id = value;
               }
	          }
        public bool IsFPCondFiscal_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPCondFiscal_IdNull();
             }
	        }
        public String FPDescripcionCondFiscal {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPDescripcionCondFiscal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPDescripcionCondFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPDescripcionCondFiscal = value;
               }
	          }
        public bool IsFPDescripcionCondFiscalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPDescripcionCondFiscalNull();
             }
	        }
        public Int16 FPOrigen_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPOrigen_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPOrigen_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPOrigen_Id = value;
               }
	          }
        public bool IsFPOrigen_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPOrigen_IdNull();
             }
	        }
        public String FPDescripcionOrigen {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPDescripcionOrigen"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPDescripcionOrigen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPDescripcionOrigen = value;
               }
	          }
        public bool IsFPDescripcionOrigenNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPDescripcionOrigenNull();
             }
	        }
        public Boolean FPVieneDeFiscal {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPVieneDeFiscal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPVieneDeFiscal;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPVieneDeFiscal = value;
               }
	          }
        public bool IsFPVieneDeFiscalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPVieneDeFiscalNull();
             }
	        }
        public String FPXMLFiscal {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPXMLFiscal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPXMLFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPXMLFiscal = value;
               }
	          }
        public bool IsFPXMLFiscalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPXMLFiscalNull();
             }
	        }
        public Int32 FPTipoCompFE {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPTipoCompFE"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPTipoCompFE;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPTipoCompFE = value;
               }
	          }
        public bool IsFPTipoCompFENull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPTipoCompFENull();
             }
	        }
        public String FPClaveFiscal {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPClaveFiscal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPClaveFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPClaveFiscal = value;
               }
	          }
        public bool IsFPClaveFiscalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPClaveFiscalNull();
             }
	        }
        public Int32 FPconRenglonProv {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPconRenglonProv"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPconRenglonProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPconRenglonProv = value;
               }
	          }
        public bool IsFPconRenglonProvNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPconRenglonProvNull();
             }
	        }
        public String FPArchvoXml {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FPArchvoXml"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPArchvoXml;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FPArchvoXml = value;
               }
	          }
        public bool IsFPArchvoXmlNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFPArchvoXmlNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Decimal Exencion {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Exencion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Exencion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Exencion = value;
               }
	          }
        public bool IsExencionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsExencionNull();
             }
	        }
        public Decimal BaseImponible {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["BaseImponible"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].BaseImponible;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].BaseImponible = value;
               }
	          }
        public bool IsBaseImponibleNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsBaseImponibleNull();
             }
	        }
        public Decimal Acum {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Acum"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Acum;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Acum = value;
               }
	          }
        public bool IsAcumNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsAcumNull();
             }
	        }
        public Decimal TRet {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["TRet"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TRet;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TRet = value;
               }
	          }
        public bool IsTRetNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTRetNull();
             }
	        }
        public Decimal AcumTot {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["AcumTot"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].AcumTot;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].AcumTot = value;
               }
	          }
        public bool IsAcumTotNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsAcumTotNull();
             }
	        }
        public String FacturaRet {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["FacturaRet"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FacturaRet;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].FacturaRet = value;
               }
	          }
        public bool IsFacturaRetNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsFacturaRetNull();
             }
	        }
        public Int64 comMovProv {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public String SucursalRet {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["SucursalRet"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].SucursalRet;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].SucursalRet = value;
               }
	          }
        public bool IsSucursalRetNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsSucursalRetNull();
             }
	        }
        public Int32 ComprobanteRet {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["ComprobanteRet"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].ComprobanteRet;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].ComprobanteRet = value;
               }
	          }
        public bool IsComprobanteRetNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsComprobanteRetNull();
             }
	        }
        public String TDFormaDePagoP {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["TDFormaDePagoP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDFormaDePagoP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDFormaDePagoP = value;
               }
	          }
        public bool IsTDFormaDePagoPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTDFormaDePagoPNull();
             }
	        }
        public String TDNumOperacion {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["TDNumOperacion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDNumOperacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDNumOperacion = value;
               }
	          }
        public bool IsTDNumOperacionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTDNumOperacionNull();
             }
	        }
        public String TDCtaOrdenante {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["TDCtaOrdenante"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDCtaOrdenante;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDCtaOrdenante = value;
               }
	          }
        public bool IsTDCtaOrdenanteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTDCtaOrdenanteNull();
             }
	        }
        public String TDRfcEmisorCtaOrd {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["TDRfcEmisorCtaOrd"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDRfcEmisorCtaOrd;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDRfcEmisorCtaOrd = value;
               }
	          }
        public bool IsTDRfcEmisorCtaOrdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTDRfcEmisorCtaOrdNull();
             }
	        }
        public String TDNomBancoOrdExt {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["TDNomBancoOrdExt"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDNomBancoOrdExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDNomBancoOrdExt = value;
               }
	          }
        public bool IsTDNomBancoOrdExtNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTDNomBancoOrdExtNull();
             }
	        }
        public String TDTipoCadPago {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["TDTipoCadPago"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDTipoCadPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDTipoCadPago = value;
               }
	          }
        public bool IsTDTipoCadPagoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTDTipoCadPagoNull();
             }
	        }
        public String TDCadPago {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["TDCadPago"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDCadPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDCadPago = value;
               }
	          }
        public bool IsTDCadPagoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTDCadPagoNull();
             }
	        }
        public String TDSelloPago {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["TDSelloPago"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDSelloPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDSelloPago = value;
               }
	          }
        public bool IsTDSelloPagoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTDSelloPagoNull();
             }
	        }
        public String TDCertPago {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["TDCertPago"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDCertPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].TDCertPago = value;
               }
	          }
        public bool IsTDCertPagoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsTDCertPagoNull();
             }
	        }
        public Decimal Diferencia {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Diferencia"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Diferencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Diferencia = value;
               }
	          }
        public bool IsDiferenciaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsDiferenciaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDHDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesRengMoviDHDS );
     }
     public tesRengMoviActionExchange() : base( "tesRengMovi" ) {
     }

     public tesRengMoviActionExchange(tesRengMoviActionEnum.EnumtesRengMoviAction pAccion) : base(tesRengMoviActionEnum.GetAcciontesRengMoviAction(pAccion)) {
     }

     public tesRengMoviActionExchange(tesRengMoviActionEnum.EnumtesRengMoviAction pAccion, TesoreriaCommon.tesRengMoviDHDS pdsParam) : base(tesRengMoviActionEnum.GetAcciontesRengMoviAction(pAccion), pdsParam) {
     }

     public tesRengMoviActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesRengMoviDHDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesRengMoviDHDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesRengMoviDHDS)mParam;
	        }
     }
  }
}
