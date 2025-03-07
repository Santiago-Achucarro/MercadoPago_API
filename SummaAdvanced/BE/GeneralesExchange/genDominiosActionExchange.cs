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
    public class genDominiosActionExchange : Framework.Core.Exchange{

        public String Dominio_Id {
            get {
                if(((GeneralesCommon.genDominiosDS)mParam).Principal[0]["Dominio_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genDominiosDS)mParam).Principal[0].Dominio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genDominiosDS)mParam).Principal[0].Dominio_Id = value;
               }
	          }
        public bool IsDominio_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genDominiosDS)mParam).Principal[0].IsDominio_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genDominiosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genDominiosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genDominiosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genDominiosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genDominiosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genDominiosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genDominiosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genDominiosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genDominiosDS );
     }
     public genDominiosActionExchange() : base( "genDominios" ) {
     }

     public genDominiosActionExchange(genDominiosActionEnum.EnumgenDominiosAction pAccion) : base(genDominiosActionEnum.GetAcciongenDominiosAction(pAccion)) {
     }

     public genDominiosActionExchange(genDominiosActionEnum.EnumgenDominiosAction pAccion, GeneralesCommon.genDominiosDS pdsParam) : base(genDominiosActionEnum.GetAcciongenDominiosAction(pAccion), pdsParam) {
     }

     public genDominiosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genDominiosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genDominiosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genDominiosDS)mParam;
	        }
     }
  }
}
