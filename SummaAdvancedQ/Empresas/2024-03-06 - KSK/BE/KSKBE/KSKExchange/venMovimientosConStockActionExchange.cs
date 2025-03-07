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
    public class venMovimientosConStockActionExchange : Framework.Core.Exchange{

        public Decimal Efectivo {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["Efectivo"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Efectivo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Efectivo = value;
               }
	          }
        public bool IsEfectivoNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsEfectivoNull();
             }
	        }
        public Decimal Cheque {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["Cheque"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Cheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Cheque = value;
               }
	          }
        public bool IsChequeNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsChequeNull();
             }
	        }
        public Int32 NroCheque {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["NroCheque"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].NroCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].NroCheque = value;
               }
	          }
        public bool IsNroChequeNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsNroChequeNull();
             }
	        }
        public String Banco_Id {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["Banco_Id"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Banco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Banco_Id = value;
               }
	          }
        public bool IsBanco_IdNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsBanco_IdNull();
             }
	        }
        public Decimal Debito {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["Debito"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Debito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Debito = value;
               }
	          }
        public bool IsDebitoNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsDebitoNull();
             }
	        }
        public Decimal Credito {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["Credito"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Credito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Credito = value;
               }
	          }
        public bool IsCreditoNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsCreditoNull();
             }
	        }
        public Int32 NroTarjeta {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["NroTarjeta"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].NroTarjeta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].NroTarjeta = value;
               }
	          }
        public bool IsNroTarjetaNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsNroTarjetaNull();
             }
	        }
        public Decimal Transferencia {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["Transferencia"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Transferencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Transferencia = value;
               }
	          }
        public bool IsTransferenciaNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsTransferenciaNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public Boolean ACredito {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["ACredito"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].ACredito;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].ACredito = value;
               }
	          }
        public bool IsACreditoNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsACreditoNull();
             }
	        }
        public String Autorizada {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["Autorizada"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Autorizada;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Autorizada = value;
               }
	          }
        public bool IsAutorizadaNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsAutorizadaNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String Leyenda {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["Leyenda"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Leyenda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].Leyenda = value;
               }
	          }
        public bool IsLeyendaNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsLeyendaNull();
             }
	        }
        public Decimal ValorUnitario {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["ValorUnitario"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].ValorUnitario;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].ValorUnitario = value;
               }
	          }
        public bool IsValorUnitarioNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsValorUnitarioNull();
             }
	        }
        public String ClaveFiscal {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["ClaveFiscal"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].ClaveFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].ClaveFiscal = value;
               }
	          }
        public bool IsClaveFiscalNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsClaveFiscalNull();
             }
	        }
        public String CodigoBarra {
            get {
                if(((KSKCommon.venMovimientosConStockDS)mParam).Principal[0]["CodigoBarra"] != DBNull.Value  ){
                    return ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].CodigoBarra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].CodigoBarra = value;
               }
	          }
        public bool IsCodigoBarraNull {
             get {
                 return mParam==null || ((KSKCommon.venMovimientosConStockDS)mParam).Principal[0].IsCodigoBarraNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.venMovimientosConStockDS );
     }
     public venMovimientosConStockActionExchange() : base( "venMovimientosConStock" ) {
     }

     public venMovimientosConStockActionExchange(venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction pAccion) : base(venMovimientosConStockActionEnum.GetAccionvenMovimientosConStockAction(pAccion)) {
     }

     public venMovimientosConStockActionExchange(venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction pAccion, KSKCommon.venMovimientosConStockDS pdsParam) : base(venMovimientosConStockActionEnum.GetAccionvenMovimientosConStockAction(pAccion), pdsParam) {
     }

     public venMovimientosConStockActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.venMovimientosConStockDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venMovimientosConStockActionExchange(KSKCommon.venMovimientosConStockDS pDS) : base() {
     this.Action = "";
     this.mParam = new KSKCommon.venMovimientosConStockDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.venMovimientosConStockDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.venMovimientosConStockDS)mParam;
	        }
     }
  }
}
