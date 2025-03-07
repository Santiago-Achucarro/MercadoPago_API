using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ImpuestosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class impCfdiMetaActionExchange : Framework.Core.Exchange{

        public String Uuid {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["Uuid"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Uuid;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Uuid = value;
               }
	          }
        public bool IsUuidNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsUuidNull();
             }
	        }
        public String RfcEmisor {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["RfcEmisor"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].RfcEmisor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].RfcEmisor = value;
               }
	          }
        public bool IsRfcEmisorNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsRfcEmisorNull();
             }
	        }
        public String RfcEmisor_Nueva {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["RfcEmisor_Nueva"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].RfcEmisor_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].RfcEmisor_Nueva = value;
               }
	          }
        public bool IsRfcEmisor_NuevaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsRfcEmisor_NuevaNull();
             }
	        }
        public String NombreEmisor {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["NombreEmisor"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].NombreEmisor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].NombreEmisor = value;
               }
	          }
        public bool IsNombreEmisorNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsNombreEmisorNull();
             }
	        }
        public String RfcReceptor {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["RfcReceptor"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].RfcReceptor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].RfcReceptor = value;
               }
	          }
        public bool IsRfcReceptorNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsRfcReceptorNull();
             }
	        }
        public String NombreReceptor {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["NombreReceptor"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].NombreReceptor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].NombreReceptor = value;
               }
	          }
        public bool IsNombreReceptorNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsNombreReceptorNull();
             }
	        }
        public String RfcPac {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["RfcPac"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].RfcPac;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].RfcPac = value;
               }
	          }
        public bool IsRfcPacNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsRfcPacNull();
             }
	        }
        public DateTime FechaEmision {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["FechaEmision"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].FechaEmision;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].FechaEmision = value;
               }
	          }
        public bool IsFechaEmisionNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsFechaEmisionNull();
             }
	        }
        public DateTime FechaCertificacionSat {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["FechaCertificacionSat"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].FechaCertificacionSat;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].FechaCertificacionSat = value;
               }
	          }
        public bool IsFechaCertificacionSatNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsFechaCertificacionSatNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public String EfectoComprobante {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["EfectoComprobante"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].EfectoComprobante;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].EfectoComprobante = value;
               }
	          }
        public bool IsEfectoComprobanteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsEfectoComprobanteNull();
             }
	        }
        public Boolean Estatus {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["Estatus"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Estatus;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Estatus = value;
               }
	          }
        public bool IsEstatusNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsEstatusNull();
             }
	        }
        public DateTime FechaCancelacion {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["FechaCancelacion"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].FechaCancelacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].FechaCancelacion = value;
               }
	          }
        public bool IsFechaCancelacionNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsFechaCancelacionNull();
             }
	        }
        public DateTime FechaDescarga {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["FechaDescarga"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].FechaDescarga;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].FechaDescarga = value;
               }
	          }
        public bool IsFechaDescargaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsFechaDescargaNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCfdiMetaDatosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impCfdiMetaDatosDS );
     }
     public impCfdiMetaActionExchange() : base( "impCfdiMeta" ) {
     }

     public impCfdiMetaActionExchange(impCfdiMetaActionEnum.EnumimpCfdiMetaAction pAccion) : base(impCfdiMetaActionEnum.GetAccionimpCfdiMetaAction(pAccion)) {
     }

     public impCfdiMetaActionExchange(impCfdiMetaActionEnum.EnumimpCfdiMetaAction pAccion, ImpuestosCommon.impCfdiMetaDatosDS pdsParam) : base(impCfdiMetaActionEnum.GetAccionimpCfdiMetaAction(pAccion), pdsParam) {
     }

     public impCfdiMetaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impCfdiMetaDatosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impCfdiMetaDatosDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impCfdiMetaDatosDS)mParam;
	        }
     }
  }
}
