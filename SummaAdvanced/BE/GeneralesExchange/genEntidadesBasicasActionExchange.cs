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
    public class genEntidadesBasicasActionExchange : Framework.Core.Exchange{

        public Int32 Entidad_Id {
            get {
                if(((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0]["Entidad_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0].Entidad_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0].Entidad_Id = value;
               }
	          }
        public bool IsEntidad_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0].IsEntidad_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesBasicasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genEntidadesBasicasDS );
     }
     public genEntidadesBasicasActionExchange() : base( "genEntidadesBasicas" ) {
     }

     public genEntidadesBasicasActionExchange(genEntidadesBasicasActionEnum.EnumgenEntidadesBasicasAction pAccion) : base(genEntidadesBasicasActionEnum.GetAcciongenEntidadesBasicasAction(pAccion)) {
     }

     public genEntidadesBasicasActionExchange(genEntidadesBasicasActionEnum.EnumgenEntidadesBasicasAction pAccion, GeneralesCommon.genEntidadesBasicasDS pdsParam) : base(genEntidadesBasicasActionEnum.GetAcciongenEntidadesBasicasAction(pAccion), pdsParam) {
     }

     public genEntidadesBasicasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genEntidadesBasicasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genEntidadesBasicasDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genEntidadesBasicasDS)mParam;
	        }
     }
  }
}
