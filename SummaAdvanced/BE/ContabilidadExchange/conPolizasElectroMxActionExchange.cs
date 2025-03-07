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
    public class conPolizasElectroMxActionExchange : Framework.Core.Exchange{

        public Int32 Anio {
            get {
                if(((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public String TipoSolicitud {
            get {
                if(((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0]["TipoSolicitud"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].TipoSolicitud;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].TipoSolicitud = value;
               }
	          }
        public bool IsTipoSolicitudNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].IsTipoSolicitudNull();
             }
	        }
        public String NumOrden {
            get {
                if(((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0]["NumOrden"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].NumOrden;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].NumOrden = value;
               }
	          }
        public bool IsNumOrdenNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].IsNumOrdenNull();
             }
	        }
        public String NumTramite {
            get {
                if(((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0]["NumTramite"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].NumTramite;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].NumTramite = value;
               }
	          }
        public bool IsNumTramiteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].IsNumTramiteNull();
             }
	        }
        public String Sello {
            get {
                if(((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0]["Sello"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].Sello;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].Sello = value;
               }
	          }
        public bool IsSelloNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].IsSelloNull();
             }
	        }
        public String noCertificado {
            get {
                if(((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0]["noCertificado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].noCertificado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].noCertificado = value;
               }
	          }
        public bool IsnoCertificadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].IsnoCertificadoNull();
             }
	        }
        public String Certificado {
            get {
                if(((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0]["Certificado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].Certificado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].Certificado = value;
               }
	          }
        public bool IsCertificadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].IsCertificadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPolizasElectroMxDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conPolizasElectroMxDS );
     }
     public conPolizasElectroMxActionExchange() : base( "conPolizasElectroMx" ) {
     }

     public conPolizasElectroMxActionExchange(conPolizasElectroMxActionEnum.EnumconPolizasElectroMxAction pAccion) : base(conPolizasElectroMxActionEnum.GetAccionconPolizasElectroMxAction(pAccion)) {
     }

     public conPolizasElectroMxActionExchange(conPolizasElectroMxActionEnum.EnumconPolizasElectroMxAction pAccion, ContabilidadCommon.conPolizasElectroMxDS pdsParam) : base(conPolizasElectroMxActionEnum.GetAccionconPolizasElectroMxAction(pAccion), pdsParam) {
     }

     public conPolizasElectroMxActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conPolizasElectroMxDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conPolizasElectroMxDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conPolizasElectroMxDS)mParam;
	        }
     }
  }
}
