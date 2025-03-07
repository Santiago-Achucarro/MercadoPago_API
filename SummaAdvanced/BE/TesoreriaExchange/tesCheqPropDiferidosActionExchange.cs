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
    public class tesCheqPropDiferidosActionExchange : Framework.Core.Exchange{

        public DateTime FechaHasta {
            get {
                if(((TesoreriaCommon.tesCheqPropDiferidosDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDiferidosDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDiferidosDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDiferidosDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCheqPropDiferidosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropDiferidosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropDiferidosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropDiferidosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCheqPropDiferidosDS );
     }
     public tesCheqPropDiferidosActionExchange() : base( "tesCheqPropDiferidos" ) {
     }

     public tesCheqPropDiferidosActionExchange(tesCheqPropDiferidosActionEnum.EnumtesCheqPropDiferidosAction pAccion) : base(tesCheqPropDiferidosActionEnum.GetAcciontesCheqPropDiferidosAction(pAccion)) {
     }

     public tesCheqPropDiferidosActionExchange(tesCheqPropDiferidosActionEnum.EnumtesCheqPropDiferidosAction pAccion, TesoreriaCommon.tesCheqPropDiferidosDS pdsParam) : base(tesCheqPropDiferidosActionEnum.GetAcciontesCheqPropDiferidosAction(pAccion), pdsParam) {
     }

     public tesCheqPropDiferidosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCheqPropDiferidosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCheqPropDiferidosDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCheqPropDiferidosDS)mParam;
	        }
     }
  }
}
