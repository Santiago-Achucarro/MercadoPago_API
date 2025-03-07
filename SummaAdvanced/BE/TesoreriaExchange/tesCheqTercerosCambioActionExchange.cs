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
    public class tesCheqTercerosCambioActionExchange : Framework.Core.Exchange{

        public DateTime FechaVencimiento {
            get {
                if(((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0]["FechaVencimiento"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].FechaVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].FechaVencimiento = value;
               }
	          }
        public bool IsFechaVencimientoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].IsFechaVencimientoNull();
             }
	        }
        public String Banco_Id {
            get {
                if(((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0]["Banco_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].Banco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].Banco_Id = value;
               }
	          }
        public bool IsBanco_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].IsBanco_IdNull();
             }
	        }
        public String DescBanco {
            get {
                if(((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0]["DescBanco"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].DescBanco;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].DescBanco = value;
               }
	          }
        public bool IsDescBancoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].IsDescBancoNull();
             }
	        }
        public Int32 numCheque {
            get {
                if(((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0]["numCheque"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].numCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].numCheque = value;
               }
	          }
        public bool IsnumChequeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].IsnumChequeNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqTercerosCambioDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCheqTercerosCambioDS );
     }
     public tesCheqTercerosCambioActionExchange() : base( "tesCheqTercerosCambio" ) {
     }

     public tesCheqTercerosCambioActionExchange(tesCheqTercerosCambioActionEnum.EnumtesCheqTercerosCambioAction pAccion) : base(tesCheqTercerosCambioActionEnum.GetAcciontesCheqTercerosCambioAction(pAccion)) {
     }

     public tesCheqTercerosCambioActionExchange(tesCheqTercerosCambioActionEnum.EnumtesCheqTercerosCambioAction pAccion, TesoreriaCommon.tesCheqTercerosCambioDS pdsParam) : base(tesCheqTercerosCambioActionEnum.GetAcciontesCheqTercerosCambioAction(pAccion), pdsParam) {
     }

     public tesCheqTercerosCambioActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCheqTercerosCambioDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCheqTercerosCambioDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCheqTercerosCambioDS)mParam;
	        }
     }
  }
}
