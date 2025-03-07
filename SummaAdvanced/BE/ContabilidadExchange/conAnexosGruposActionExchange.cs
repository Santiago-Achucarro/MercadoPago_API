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
    public class conAnexosGruposActionExchange : Framework.Core.Exchange{

        public String GrupoAne_ID {
            get {
                if(((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0]["GrupoAne_ID"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].GrupoAne_ID;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].GrupoAne_ID = value;
               }
	          }
        public bool IsGrupoAne_IDNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].IsGrupoAne_IDNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int16 orden {
            get {
                if(((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0]["orden"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].orden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].orden = value;
               }
	          }
        public bool IsordenNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].IsordenNull();
             }
	        }
        public Int16 Origen {
            get {
                if(((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0]["Origen"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].Origen;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].Origen = value;
               }
	          }
        public bool IsOrigenNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].IsOrigenNull();
             }
	        }
        public String DescripcionOrigen {
            get {
                if(((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0]["DescripcionOrigen"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].DescripcionOrigen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].DescripcionOrigen = value;
               }
	          }
        public bool IsDescripcionOrigenNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].IsDescripcionOrigenNull();
             }
	        }
        public String VerifTipo {
            get {
                if(((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0]["VerifTipo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].VerifTipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].VerifTipo = value;
               }
	          }
        public bool IsVerifTipoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].IsVerifTipoNull();
             }
	        }
        public String Description {
            get {
                if(((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0]["Description"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].Description;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].Description = value;
               }
	          }
        public bool IsDescriptionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].IsDescriptionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosGruposDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conAnexosGruposDS );
     }
     public conAnexosGruposActionExchange() : base( "conAnexosGrupos" ) {
     }

     public conAnexosGruposActionExchange(conAnexosGruposActionEnum.EnumconAnexosGruposAction pAccion) : base(conAnexosGruposActionEnum.GetAccionconAnexosGruposAction(pAccion)) {
     }

     public conAnexosGruposActionExchange(conAnexosGruposActionEnum.EnumconAnexosGruposAction pAccion, ContabilidadCommon.conAnexosGruposDS pdsParam) : base(conAnexosGruposActionEnum.GetAccionconAnexosGruposAction(pAccion), pdsParam) {
     }

     public conAnexosGruposActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conAnexosGruposDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conAnexosGruposDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conAnexosGruposDS)mParam;
	        }
     }
  }
}
