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
    public class tesAIDepositosActionExchange : Framework.Core.Exchange{

        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String CarteraCheq_Id {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["CarteraCheq_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].CarteraCheq_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].CarteraCheq_Id = value;
               }
	          }
        public bool IsCarteraCheq_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsCarteraCheq_IdNull();
             }
	        }
        public String DescripcionIdCheqTerceros {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["DescripcionIdCheqTerceros"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].DescripcionIdCheqTerceros;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].DescripcionIdCheqTerceros = value;
               }
	          }
        public bool IsDescripcionIdCheqTercerosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsDescripcionIdCheqTercerosNull();
             }
	        }
        public Int32 numCheque {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["numCheque"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].numCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].numCheque = value;
               }
	          }
        public bool IsnumChequeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsnumChequeNull();
             }
	        }
        public DateTime FechaVencimiento {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["FechaVencimiento"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].FechaVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].FechaVencimiento = value;
               }
	          }
        public bool IsFechaVencimientoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsFechaVencimientoNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public String Clearing {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["Clearing"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Clearing;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Clearing = value;
               }
	          }
        public bool IsClearingNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsClearingNull();
             }
	        }
        public String DescripcionClearing {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["DescripcionClearing"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].DescripcionClearing;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].DescripcionClearing = value;
               }
	          }
        public bool IsDescripcionClearingNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsDescripcionClearingNull();
             }
	        }
        public String Banco_Id {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["Banco_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Banco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Banco_Id = value;
               }
	          }
        public bool IsBanco_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsBanco_IdNull();
             }
	        }
        public String DescripcionBancos {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["DescripcionBancos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].DescripcionBancos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].DescripcionBancos = value;
               }
	          }
        public bool IsDescripcionBancosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsDescripcionBancosNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String DescripcionClientes {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["DescripcionClientes"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].DescripcionClientes;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].DescripcionClientes = value;
               }
	          }
        public bool IsDescripcionClientesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsDescripcionClientesNull();
             }
	        }
        public String cuentaBanco {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["cuentaBanco"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].cuentaBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].cuentaBanco = value;
               }
	          }
        public bool IscuentaBancoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IscuentaBancoNull();
             }
	        }
        public String sucBanco {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["sucBanco"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].sucBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].sucBanco = value;
               }
	          }
        public bool IssucBancoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IssucBancoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIDepositosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesAIDepositosDS );
     }
     public tesAIDepositosActionExchange() : base( "tesAIDepositos" ) {
     }

     public tesAIDepositosActionExchange(tesAIDepositosActionEnum.EnumtesAIDepositosAction pAccion) : base(tesAIDepositosActionEnum.GetAcciontesAIDepositosAction(pAccion)) {
     }

     public tesAIDepositosActionExchange(tesAIDepositosActionEnum.EnumtesAIDepositosAction pAccion, TesoreriaCommon.tesAIDepositosDS pdsParam) : base(tesAIDepositosActionEnum.GetAcciontesAIDepositosAction(pAccion), pdsParam) {
     }

     public tesAIDepositosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesAIDepositosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesAIDepositosDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesAIDepositosDS)mParam;
	        }
     }
  }
}
