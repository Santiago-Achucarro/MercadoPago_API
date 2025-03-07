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
    public class tesCFDICobranzaRelActionExchange : Framework.Core.Exchange{

        public Int32 tesCFDICobranza {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0]["tesCFDICobranza"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0].tesCFDICobranza;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0].tesCFDICobranza = value;
               }
	          }
        public bool IstesCFDICobranzaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0].IstesCFDICobranzaNull();
             }
	        }
        public Int32 tesCFDICobranzaR {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0]["tesCFDICobranzaR"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0].tesCFDICobranzaR;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0].tesCFDICobranzaR = value;
               }
	          }
        public bool IstesCFDICobranzaRNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0].IstesCFDICobranzaRNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaRelDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCFDICobranzaRelDS );
     }
     public tesCFDICobranzaRelActionExchange() : base( "tesCFDICobranzaRel" ) {
     }

     public tesCFDICobranzaRelActionExchange(tesCFDICobranzaRelActionEnum.EnumtesCFDICobranzaRelAction pAccion) : base(tesCFDICobranzaRelActionEnum.GetAcciontesCFDICobranzaRelAction(pAccion)) {
     }

     public tesCFDICobranzaRelActionExchange(tesCFDICobranzaRelActionEnum.EnumtesCFDICobranzaRelAction pAccion, TesoreriaCommon.tesCFDICobranzaRelDS pdsParam) : base(tesCFDICobranzaRelActionEnum.GetAcciontesCFDICobranzaRelAction(pAccion), pdsParam) {
     }

     public tesCFDICobranzaRelActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCFDICobranzaRelDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCFDICobranzaRelDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCFDICobranzaRelDS)mParam;
	        }
     }
  }
}
