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
    public class conTiposSATActionExchange : Framework.Core.Exchange{

        public String TipoSAT_Id {
            get {
                if(((ContabilidadCommon.conTiposSATDS)mParam).Principal[0]["TipoSAT_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].TipoSAT_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].TipoSAT_Id = value;
               }
	          }
        public bool IsTipoSAT_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].IsTipoSAT_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conTiposSATDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Rubro {
            get {
                if(((ContabilidadCommon.conTiposSATDS)mParam).Principal[0]["Rubro"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].Rubro;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].Rubro = value;
               }
	          }
        public bool IsRubroNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].IsRubroNull();
             }
	        }
        public Boolean Circulante {
            get {
                if(((ContabilidadCommon.conTiposSATDS)mParam).Principal[0]["Circulante"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].Circulante;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].Circulante = value;
               }
	          }
        public bool IsCirculanteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].IsCirculanteNull();
             }
	        }
        public Boolean Imputable {
            get {
                if(((ContabilidadCommon.conTiposSATDS)mParam).Principal[0]["Imputable"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].Imputable;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].Imputable = value;
               }
	          }
        public bool IsImputableNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].IsImputableNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conTiposSATDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposSATDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conTiposSATDS );
     }
     public conTiposSATActionExchange() : base( "conTiposSAT" ) {
     }

     public conTiposSATActionExchange(conTiposSATActionEnum.EnumconTiposSATAction pAccion) : base(conTiposSATActionEnum.GetAccionconTiposSATAction(pAccion)) {
     }

     public conTiposSATActionExchange(conTiposSATActionEnum.EnumconTiposSATAction pAccion, ContabilidadCommon.conTiposSATDS pdsParam) : base(conTiposSATActionEnum.GetAccionconTiposSATAction(pAccion), pdsParam) {
     }

     public conTiposSATActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conTiposSATDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conTiposSATDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conTiposSATDS)mParam;
	        }
     }
  }
}
