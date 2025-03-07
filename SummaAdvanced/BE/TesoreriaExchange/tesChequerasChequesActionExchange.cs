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
    public class tesChequerasChequesActionExchange : Framework.Core.Exchange{

        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public Int32 Chequera_Id {
            get {
                if(((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0]["Chequera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].Chequera_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].Chequera_Id = value;
               }
	          }
        public bool IsChequera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].IsChequera_IdNull();
             }
	        }
        public Int32 numCheque {
            get {
                if(((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0]["numCheque"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].numCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].numCheque = value;
               }
	          }
        public bool IsnumChequeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].IsnumChequeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesChequerasChequesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesChequerasChequesDS );
     }
     public tesChequerasChequesActionExchange() : base( "tesChequerasCheques" ) {
     }

     public tesChequerasChequesActionExchange(tesChequerasChequesActionEnum.EnumtesChequerasChequesAction pAccion) : base(tesChequerasChequesActionEnum.GetAcciontesChequerasChequesAction(pAccion)) {
     }

     public tesChequerasChequesActionExchange(tesChequerasChequesActionEnum.EnumtesChequerasChequesAction pAccion, TesoreriaCommon.tesChequerasChequesDS pdsParam) : base(tesChequerasChequesActionEnum.GetAcciontesChequerasChequesAction(pAccion), pdsParam) {
     }

     public tesChequerasChequesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesChequerasChequesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesChequerasChequesDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesChequerasChequesDS)mParam;
	        }
     }
  }
}
