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
    public class genControlesSeteosActionExchange : Framework.Core.Exchange{

        public String Formulario_Id {
            get {
                if(((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0]["Formulario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0].Formulario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0].Formulario_Id = value;
               }
	          }
        public bool IsFormulario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0].IsFormulario_IdNull();
             }
	        }
        public String DescripcionFormularios {
            get {
                if(((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0]["DescripcionFormularios"] != DBNull.Value  ){
                    return ((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0].DescripcionFormularios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0].DescripcionFormularios = value;
               }
	          }
        public bool IsDescripcionFormulariosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0].IsDescripcionFormulariosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genControlesSeteosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genControlesSeteosDS );
     }
     public genControlesSeteosActionExchange() : base( "genControlesSeteos" ) {
     }

     public genControlesSeteosActionExchange(genControlesSeteosActionEnum.EnumgenControlesSeteosAction pAccion) : base(genControlesSeteosActionEnum.GetAcciongenControlesSeteosAction(pAccion)) {
     }

     public genControlesSeteosActionExchange(genControlesSeteosActionEnum.EnumgenControlesSeteosAction pAccion, GeneralesCommon.genControlesSeteosDS pdsParam) : base(genControlesSeteosActionEnum.GetAcciongenControlesSeteosAction(pAccion), pdsParam) {
     }

     public genControlesSeteosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genControlesSeteosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genControlesSeteosActionExchange(GeneralesCommon.genControlesSeteosDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genControlesSeteosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genControlesSeteosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genControlesSeteosDS)mParam;
	        }
     }
  }
}
