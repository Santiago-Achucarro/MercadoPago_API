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
    public class genAtriGralesClasesActionExchange : Framework.Core.Exchange{

        public String Tabla_Id {
            get {
                if(((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0]["Tabla_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0].Tabla_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0].Tabla_Id = value;
               }
	          }
        public bool IsTabla_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0].IsTabla_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtriGralesClasesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAtriGralesClasesDS );
     }
     public genAtriGralesClasesActionExchange() : base( "genAtriGralesClases" ) {
     }

     public genAtriGralesClasesActionExchange(genAtriGralesClasesActionEnum.EnumgenAtriGralesClasesAction pAccion) : base(genAtriGralesClasesActionEnum.GetAcciongenAtriGralesClasesAction(pAccion)) {
     }

     public genAtriGralesClasesActionExchange(genAtriGralesClasesActionEnum.EnumgenAtriGralesClasesAction pAccion, GeneralesCommon.genAtriGralesClasesDS pdsParam) : base(genAtriGralesClasesActionEnum.GetAcciongenAtriGralesClasesAction(pAccion), pdsParam) {
     }

     public genAtriGralesClasesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAtriGralesClasesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAtriGralesClasesDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAtriGralesClasesDS)mParam;
	        }
     }
  }
}
