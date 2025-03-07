using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genCancMovApliImporActionExchange : Framework.Core.Exchange{

        public Int64 conAsientos {
            get {
                if(((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0]["conAsientos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].conAsientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].conAsientos = value;
               }
	          }
        public bool IsconAsientosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].IsconAsientosNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Boolean EsDelAp {
            get {
                if(((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0]["EsDelAp"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].EsDelAp;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].EsDelAp = value;
               }
	          }
        public bool IsEsDelApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].IsEsDelApNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovApliImporDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genCancMovApliImporDS );
     }
     public genCancMovApliImporActionExchange() : base( "genCancMovApliImpor" ) {
     }

     public genCancMovApliImporActionExchange(genCancMovApliImporActionEnum.EnumgenCancMovApliImporAction pAccion) : base(genCancMovApliImporActionEnum.GetAcciongenCancMovApliImporAction(pAccion)) {
     }

     public genCancMovApliImporActionExchange(genCancMovApliImporActionEnum.EnumgenCancMovApliImporAction pAccion, GeneralesCommon.genCancMovApliImporDS pdsParam) : base(genCancMovApliImporActionEnum.GetAcciongenCancMovApliImporAction(pAccion), pdsParam) {
     }

     public genCancMovApliImporActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genCancMovApliImporDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genCancMovApliImporDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genCancMovApliImporDS)mParam;
	        }
     }
  }
}
