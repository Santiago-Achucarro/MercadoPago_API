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
    public class genAtributosValorIdentidadActionExchange : Framework.Core.Exchange{

        public Int64 Identity_id {
            get {
                if(((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0]["Identity_id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0].Identity_id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0].Identity_id = value;
               }
	          }
        public bool IsIdentity_idNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0].IsIdentity_idNull();
             }
	        }
        public String Tabla_id {
            get {
                if(((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0]["Tabla_id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0].Tabla_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0].Tabla_id = value;
               }
	          }
        public bool IsTabla_idNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0].IsTabla_idNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValorIdentidadDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAtributosValorIdentidadDS );
     }
     public genAtributosValorIdentidadActionExchange() : base( "genAtributosValorIdentidad" ) {
     }

     public genAtributosValorIdentidadActionExchange(genAtributosValorIdentidadActionEnum.EnumgenAtributosValorIdentidadAction pAccion) : base(genAtributosValorIdentidadActionEnum.GetAcciongenAtributosValorIdentidadAction(pAccion)) {
     }

     public genAtributosValorIdentidadActionExchange(genAtributosValorIdentidadActionEnum.EnumgenAtributosValorIdentidadAction pAccion, GeneralesCommon.genAtributosValorIdentidadDS pdsParam) : base(genAtributosValorIdentidadActionEnum.GetAcciongenAtributosValorIdentidadAction(pAccion), pdsParam) {
     }

     public genAtributosValorIdentidadActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAtributosValorIdentidadDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAtributosValorIdentidadDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAtributosValorIdentidadDS)mParam;
	        }
     }
  }
}
