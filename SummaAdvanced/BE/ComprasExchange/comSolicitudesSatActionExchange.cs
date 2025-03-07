using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comSolicitudesSatActionExchange : Framework.Core.Exchange{

        public Int32 Solicitud {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["Solicitud"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Solicitud;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Solicitud = value;
               }
	          }
        public bool IsSolicitudNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsSolicitudNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaDesde_Nueva {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["FechaDesde_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].FechaDesde_Nueva;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].FechaDesde_Nueva = value;
               }
	          }
        public bool IsFechaDesde_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsFechaDesde_NuevaNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Int32 Solicitud_Nueva {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["Solicitud_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Solicitud_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Solicitud_Nueva = value;
               }
	          }
        public bool IsSolicitud_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsSolicitud_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Emitidos {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["Emitidos"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Emitidos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Emitidos = value;
               }
	          }
        public bool IsEmitidosNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsEmitidosNull();
             }
	        }
        public Boolean Descargados {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["Descargados"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Descargados;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Descargados = value;
               }
	          }
        public bool IsDescargadosNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsDescargadosNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Pendiente {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public String SolicitudSat {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["SolicitudSat"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].SolicitudSat;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].SolicitudSat = value;
               }
	          }
        public bool IsSolicitudSatNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsSolicitudSatNull();
             }
	        }
        public Boolean MetaDatos {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["MetaDatos"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].MetaDatos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].MetaDatos = value;
               }
	          }
        public bool IsMetaDatosNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsMetaDatosNull();
             }
	        }
        public Boolean Nueva {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Nueva;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Nueva = value;
               }
	          }
        public bool IsNuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsNuevaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comSolicitudesSatDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comSolicitudesSatDS );
     }
     public comSolicitudesSatActionExchange() : base( "comSolicitudesSat" ) {
     }

     public comSolicitudesSatActionExchange(comSolicitudesSatActionEnum.EnumcomSolicitudesSatAction pAccion) : base(comSolicitudesSatActionEnum.GetAccioncomSolicitudesSatAction(pAccion)) {
     }

     public comSolicitudesSatActionExchange(comSolicitudesSatActionEnum.EnumcomSolicitudesSatAction pAccion, ComprasCommon.comSolicitudesSatDS pdsParam) : base(comSolicitudesSatActionEnum.GetAccioncomSolicitudesSatAction(pAccion), pdsParam) {
     }

     public comSolicitudesSatActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comSolicitudesSatDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comSolicitudesSatDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comSolicitudesSatDS)mParam;
	        }
     }
  }
}
