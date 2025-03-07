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
    public class conCatalogoElectroMXActionExchange : Framework.Core.Exchange{

        public Int32 Anio {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Boolean Genera_Catalogo {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["Genera_Catalogo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Genera_Catalogo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Genera_Catalogo = value;
               }
	          }
        public bool IsGenera_CatalogoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsGenera_CatalogoNull();
             }
	        }
        public Boolean Genera_Balanza {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["Genera_Balanza"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Genera_Balanza;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Genera_Balanza = value;
               }
	          }
        public bool IsGenera_BalanzaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsGenera_BalanzaNull();
             }
	        }
        public Boolean Genera_Poliza {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["Genera_Poliza"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Genera_Poliza;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Genera_Poliza = value;
               }
	          }
        public bool IsGenera_PolizaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsGenera_PolizaNull();
             }
	        }
        public String TipoSolicitud {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["TipoSolicitud"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].TipoSolicitud;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].TipoSolicitud = value;
               }
	          }
        public bool IsTipoSolicitudNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsTipoSolicitudNull();
             }
	        }
        public String Numorden {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["Numorden"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Numorden;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Numorden = value;
               }
	          }
        public bool IsNumordenNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsNumordenNull();
             }
	        }
        public String NumTramite {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["NumTramite"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].NumTramite;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].NumTramite = value;
               }
	          }
        public bool IsNumTramiteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsNumTramiteNull();
             }
	        }
        public Int32 Nivel {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["Nivel"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Nivel;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Nivel = value;
               }
	          }
        public bool IsNivelNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsNivelNull();
             }
	        }
        public String BytesCatalgo {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["BytesCatalgo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].BytesCatalgo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].BytesCatalgo = value;
               }
	          }
        public bool IsBytesCatalgoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsBytesCatalgoNull();
             }
	        }
        public String TipoEnvio {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["TipoEnvio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].TipoEnvio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].TipoEnvio = value;
               }
	          }
        public bool IsTipoEnvioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsTipoEnvioNull();
             }
	        }
        public DateTime FechaModBal {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["FechaModBal"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].FechaModBal;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].FechaModBal = value;
               }
	          }
        public bool IsFechaModBalNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsFechaModBalNull();
             }
	        }
        public String BytesBalanza {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["BytesBalanza"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].BytesBalanza;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].BytesBalanza = value;
               }
	          }
        public bool IsBytesBalanzaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsBytesBalanzaNull();
             }
	        }
        public String BytesPoliza {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["BytesPoliza"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].BytesPoliza;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].BytesPoliza = value;
               }
	          }
        public bool IsBytesPolizaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsBytesPolizaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCatalogoElectroMXDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conCatalogoElectroMXDS );
     }
     public conCatalogoElectroMXActionExchange() : base( "conCatalogoElectroMX" ) {
     }

     public conCatalogoElectroMXActionExchange(conCatalogoElectroMXActionEnum.EnumconCatalogoElectroMXAction pAccion) : base(conCatalogoElectroMXActionEnum.GetAccionconCatalogoElectroMXAction(pAccion)) {
     }

     public conCatalogoElectroMXActionExchange(conCatalogoElectroMXActionEnum.EnumconCatalogoElectroMXAction pAccion, ContabilidadCommon.conCatalogoElectroMXDS pdsParam) : base(conCatalogoElectroMXActionEnum.GetAccionconCatalogoElectroMXAction(pAccion), pdsParam) {
     }

     public conCatalogoElectroMXActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conCatalogoElectroMXDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conCatalogoElectroMXDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conCatalogoElectroMXDS)mParam;
	        }
     }
  }
}
