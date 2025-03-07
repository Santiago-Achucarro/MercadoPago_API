using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conTipoEspecialesActionExchange : Framework.Core.Exchange{

        public String TipoEspe_Id {
            get {
                if(((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0]["TipoEspe_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0].TipoEspe_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0].TipoEspe_Id = value;
               }
	          }
        public bool IsTipoEspe_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0].IsTipoEspe_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTipoEspecialesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conTipoEspecialesDS );
     }
     public conTipoEspecialesActionExchange() : base( "conTipoEspeciales" ) {
     }

     public conTipoEspecialesActionExchange(conTipoEspecialesActionEnum.EnumconTipoEspecialesAction pAccion) : base(conTipoEspecialesActionEnum.GetAccionconTipoEspecialesAction(pAccion)) {
     }

     public conTipoEspecialesActionExchange(conTipoEspecialesActionEnum.EnumconTipoEspecialesAction pAccion, ContabilidadCommon.conTipoEspecialesDS pdsParam) : base(conTipoEspecialesActionEnum.GetAccionconTipoEspecialesAction(pAccion), pdsParam) {
     }

     public conTipoEspecialesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conTipoEspecialesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conTipoEspecialesDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conTipoEspecialesDS)mParam;
	        }
     }
  }
}
