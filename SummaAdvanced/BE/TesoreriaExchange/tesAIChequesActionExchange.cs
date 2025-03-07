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
    public class tesAIChequesActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public DateTime FechaVencimiento {
            get {
                if(((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0]["FechaVencimiento"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].FechaVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].FechaVencimiento = value;
               }
	          }
        public bool IsFechaVencimientoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].IsFechaVencimientoNull();
             }
	        }
        public Int32 Chequera_Id {
            get {
                if(((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0]["Chequera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Chequera_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Chequera_Id = value;
               }
	          }
        public bool IsChequera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].IsChequera_IdNull();
             }
	        }
        public Int32 numCheque {
            get {
                if(((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0]["numCheque"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].numCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].numCheque = value;
               }
	          }
        public bool IsnumChequeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].IsnumChequeNull();
             }
	        }
        public String AlaOrden {
            get {
                if(((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0]["AlaOrden"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].AlaOrden;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].AlaOrden = value;
               }
	          }
        public bool IsAlaOrdenNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].IsAlaOrdenNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAIChequesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesAIChequesDS );
     }
     public tesAIChequesActionExchange() : base( "tesAICheques" ) {
     }

     public tesAIChequesActionExchange(tesAIChequesActionEnum.EnumtesAIChequesAction pAccion) : base(tesAIChequesActionEnum.GetAcciontesAIChequesAction(pAccion)) {
     }

     public tesAIChequesActionExchange(tesAIChequesActionEnum.EnumtesAIChequesAction pAccion, TesoreriaCommon.tesAIChequesDS pdsParam) : base(tesAIChequesActionEnum.GetAcciontesAIChequesAction(pAccion), pdsParam) {
     }

     public tesAIChequesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesAIChequesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesAIChequesDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesAIChequesDS)mParam;
	        }
     }
  }
}
