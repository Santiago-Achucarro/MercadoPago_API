using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proOrdenStockActionExchange : Framework.Core.Exchange{

        public Int64 proMovCierreOrden {
            get {
                if(((ProduccionCommon.proOrdenStockDS)mParam).Principal[0]["proMovCierreOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenStockDS)mParam).Principal[0].proMovCierreOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenStockDS)mParam).Principal[0].proMovCierreOrden = value;
               }
	          }
        public bool IsproMovCierreOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenStockDS)mParam).Principal[0].IsproMovCierreOrdenNull();
             }
	        }
        public Int64 stkMoviCabe {
            get {
                if(((ProduccionCommon.proOrdenStockDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenStockDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenStockDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenStockDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proOrdenStockDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenStockDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenStockDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenStockDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proOrdenStockDS );
     }
     public proOrdenStockActionExchange() : base( "proOrdenStock" ) {
     }

     public proOrdenStockActionExchange(proOrdenStockActionEnum.EnumproOrdenStockAction pAccion) : base(proOrdenStockActionEnum.GetAccionproOrdenStockAction(pAccion)) {
     }

     public proOrdenStockActionExchange(proOrdenStockActionEnum.EnumproOrdenStockAction pAccion, ProduccionCommon.proOrdenStockDS pdsParam) : base(proOrdenStockActionEnum.GetAccionproOrdenStockAction(pAccion), pdsParam) {
     }

     public proOrdenStockActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proOrdenStockDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proOrdenStockDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proOrdenStockDS)mParam;
	        }
     }
  }
}
