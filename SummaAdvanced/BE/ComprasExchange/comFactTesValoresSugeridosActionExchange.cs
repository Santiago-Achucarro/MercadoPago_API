using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comFactTesValoresSugeridosActionExchange : Framework.Core.Exchange{

        public String Proveed_id {
            get {
                if(((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0]["Proveed_id"] != DBNull.Value  ){
                    return ((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0].Proveed_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0].Proveed_id = value;
               }
	          }
        public bool IsProveed_idNull {
             get {
                 return mParam==null || ((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0].IsProveed_idNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comFactTesValoresSugeridosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comFactTesValoresSugeridosDS );
     }
     public comFactTesValoresSugeridosActionExchange() : base( "comFactTesValoresSugeridos" ) {
     }

     public comFactTesValoresSugeridosActionExchange(comFactTesValoresSugeridosActionEnum.EnumcomFactTesValoresSugeridosAction pAccion) : base(comFactTesValoresSugeridosActionEnum.GetAccioncomFactTesValoresSugeridosAction(pAccion)) {
     }

     public comFactTesValoresSugeridosActionExchange(comFactTesValoresSugeridosActionEnum.EnumcomFactTesValoresSugeridosAction pAccion, ComprasCommon.comFactTesValoresSugeridosDS pdsParam) : base(comFactTesValoresSugeridosActionEnum.GetAccioncomFactTesValoresSugeridosAction(pAccion), pdsParam) {
     }

     public comFactTesValoresSugeridosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comFactTesValoresSugeridosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comFactTesValoresSugeridosDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comFactTesValoresSugeridosDS)mParam;
	        }
     }
  }
}
