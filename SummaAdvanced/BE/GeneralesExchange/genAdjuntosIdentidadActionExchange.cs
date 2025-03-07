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
    public class genAdjuntosIdentidadActionExchange : Framework.Core.Exchange{

        public String Tabla_Id {
            get {
                if(((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0]["Tabla_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0].Tabla_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0].Tabla_Id = value;
               }
	          }
        public bool IsTabla_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0].IsTabla_IdNull();
             }
	        }
        public Int64 Identity_Id {
            get {
                if(((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0]["Identity_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0].Identity_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0].Identity_Id = value;
               }
	          }
        public bool IsIdentity_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0].IsIdentity_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosIdentidadDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAdjuntosIdentidadDS );
     }
     public genAdjuntosIdentidadActionExchange() : base( "genAdjuntosIdentidad" ) {
     }

     public genAdjuntosIdentidadActionExchange(genAdjuntosIdentidadActionEnum.EnumgenAdjuntosIdentidadAction pAccion) : base(genAdjuntosIdentidadActionEnum.GetAcciongenAdjuntosIdentidadAction(pAccion)) {
     }

     public genAdjuntosIdentidadActionExchange(genAdjuntosIdentidadActionEnum.EnumgenAdjuntosIdentidadAction pAccion, GeneralesCommon.genAdjuntosIdentidadDS pdsParam) : base(genAdjuntosIdentidadActionEnum.GetAcciongenAdjuntosIdentidadAction(pAccion), pdsParam) {
     }

     public genAdjuntosIdentidadActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAdjuntosIdentidadDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAdjuntosIdentidadDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAdjuntosIdentidadDS)mParam;
	        }
     }
  }
}
