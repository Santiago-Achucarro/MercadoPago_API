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
    public class conAsientosAnulActionExchange : Framework.Core.Exchange{

        public Int64 conAsientos {
            get {
                if(((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0]["conAsientos"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].conAsientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].conAsientos = value;
               }
	          }
        public bool IsconAsientosNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].IsconAsientosNull();
             }
	        }
        public DateTime FechaAnulacion {
            get {
                if(((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0]["FechaAnulacion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].FechaAnulacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].FechaAnulacion = value;
               }
	          }
        public bool IsFechaAnulacionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].IsFechaAnulacionNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String TipoEnvio {
            get {
                if(((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0]["TipoEnvio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].TipoEnvio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].TipoEnvio = value;
               }
	          }
        public bool IsTipoEnvioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].IsTipoEnvioNull();
             }
	        }
        public String Causa {
            get {
                if(((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0]["Causa"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].Causa;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].Causa = value;
               }
	          }
        public bool IsCausaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].IsCausaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosAnulDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conAsientosAnulDS );
     }
     public conAsientosAnulActionExchange() : base( "conAsientosAnul" ) {
     }

     public conAsientosAnulActionExchange(conAsientosAnulActionEnum.EnumconAsientosAnulAction pAccion) : base(conAsientosAnulActionEnum.GetAccionconAsientosAnulAction(pAccion)) {
     }

     public conAsientosAnulActionExchange(conAsientosAnulActionEnum.EnumconAsientosAnulAction pAccion, ContabilidadCommon.conAsientosAnulDS pdsParam) : base(conAsientosAnulActionEnum.GetAccionconAsientosAnulAction(pAccion), pdsParam) {
     }

     public conAsientosAnulActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conAsientosAnulDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public conAsientosAnulActionExchange(ContabilidadCommon.conAsientosAnulDS pDS) : base() {
     this.Action = "";
     this.mParam = new ContabilidadCommon.conAsientosAnulDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conAsientosAnulDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conAsientosAnulDS)mParam;
	        }
     }
  }
}
