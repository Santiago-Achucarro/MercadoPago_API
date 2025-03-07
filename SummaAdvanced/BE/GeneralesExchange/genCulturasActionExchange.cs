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
    public class genCulturasActionExchange : Framework.Core.Exchange{

        public String Cultura {
            get {
                if(((GeneralesCommon.genCulturasDS)mParam).Principal[0]["Cultura"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCulturasDS)mParam).Principal[0].Cultura;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCulturasDS)mParam).Principal[0].Cultura = value;
               }
	          }
        public bool IsCulturaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCulturasDS)mParam).Principal[0].IsCulturaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genCulturasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCulturasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCulturasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCulturasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genCulturasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCulturasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCulturasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCulturasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genCulturasDS );
     }
     public genCulturasActionExchange() : base( "genCulturas" ) {
     }

     public genCulturasActionExchange(genCulturasActionEnum.EnumgenCulturasAction pAccion) : base(genCulturasActionEnum.GetAcciongenCulturasAction(pAccion)) {
     }

     public genCulturasActionExchange(genCulturasActionEnum.EnumgenCulturasAction pAccion, GeneralesCommon.genCulturasDS pdsParam) : base(genCulturasActionEnum.GetAcciongenCulturasAction(pAccion), pdsParam) {
     }

     public genCulturasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genCulturasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genCulturasDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genCulturasDS)mParam;
	        }
     }
  }
}
