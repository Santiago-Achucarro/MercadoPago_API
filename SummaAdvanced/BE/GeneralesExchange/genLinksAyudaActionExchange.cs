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
    public class genLinksAyudaActionExchange : Framework.Core.Exchange{

        public String CodigoLnk {
            get {
                if(((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0]["CodigoLnk"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].CodigoLnk;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].CodigoLnk = value;
               }
	          }
        public bool IsCodigoLnkNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].IsCodigoLnkNull();
             }
	        }
        public String Dominio_Id {
            get {
                if(((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0]["Dominio_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].Dominio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].Dominio_Id = value;
               }
	          }
        public bool IsDominio_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].IsDominio_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Link {
            get {
                if(((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0]["Link"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].Link;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].Link = value;
               }
	          }
        public bool IsLinkNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].IsLinkNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLinksAyudaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genLinksAyudaDS );
     }
     public genLinksAyudaActionExchange() : base( "genLinksAyuda" ) {
     }

     public genLinksAyudaActionExchange(genLinksAyudaActionEnum.EnumgenLinksAyudaAction pAccion) : base(genLinksAyudaActionEnum.GetAcciongenLinksAyudaAction(pAccion)) {
     }

     public genLinksAyudaActionExchange(genLinksAyudaActionEnum.EnumgenLinksAyudaAction pAccion, GeneralesCommon.genLinksAyudaDS pdsParam) : base(genLinksAyudaActionEnum.GetAcciongenLinksAyudaAction(pAccion), pdsParam) {
     }

     public genLinksAyudaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genLinksAyudaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genLinksAyudaDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genLinksAyudaDS)mParam;
	        }
     }
  }
}
