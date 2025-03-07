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
    public class genWSFactElecActionExchange : Framework.Core.Exchange{

        public String TipoFE {
            get {
                if(((GeneralesCommon.genWSFactElecDS)mParam).Principal[0]["TipoFE"] != DBNull.Value  ){
                    return ((GeneralesCommon.genWSFactElecDS)mParam).Principal[0].TipoFE;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genWSFactElecDS)mParam).Principal[0].TipoFE = value;
               }
	          }
        public bool IsTipoFENull {
             get {
                 return mParam==null || ((GeneralesCommon.genWSFactElecDS)mParam).Principal[0].IsTipoFENull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genWSFactElecDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genWSFactElecDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genWSFactElecDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genWSFactElecDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genWSFactElecDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genWSFactElecDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genWSFactElecDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genWSFactElecDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genWSFactElecDS );
     }
     public genWSFactElecActionExchange() : base( "genWSFactElec" ) {
     }

     public genWSFactElecActionExchange(genWSFactElecActionEnum.EnumgenWSFactElecAction pAccion) : base(genWSFactElecActionEnum.GetAcciongenWSFactElecAction(pAccion)) {
     }

     public genWSFactElecActionExchange(genWSFactElecActionEnum.EnumgenWSFactElecAction pAccion, GeneralesCommon.genWSFactElecDS pdsParam) : base(genWSFactElecActionEnum.GetAcciongenWSFactElecAction(pAccion), pdsParam) {
     }

     public genWSFactElecActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genWSFactElecDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genWSFactElecDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genWSFactElecDS)mParam;
	        }
     }
  }
}
