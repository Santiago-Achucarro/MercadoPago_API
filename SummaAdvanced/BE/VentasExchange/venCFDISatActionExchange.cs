using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venCFDISatActionExchange : Framework.Core.Exchange{

        public String UUID {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["UUID"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].UUID;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].UUID = value;
               }
	          }
        public bool IsUUIDNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsUUIDNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String RFCReceptor {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["RFCReceptor"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].RFCReceptor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].RFCReceptor = value;
               }
	          }
        public bool IsRFCReceptorNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsRFCReceptorNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public Decimal Impuestos {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["Impuestos"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].Impuestos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].Impuestos = value;
               }
	          }
        public bool IsImpuestosNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsImpuestosNull();
             }
	        }
        public Int64 Folio {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["Folio"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].Folio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].Folio = value;
               }
	          }
        public bool IsFolioNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsFolioNull();
             }
	        }
        public String Serie {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public String XML {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["XML"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].XML;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].XML = value;
               }
	          }
        public bool IsXMLNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsXMLNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime FechaCarga {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["FechaCarga"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].FechaCarga;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].FechaCarga = value;
               }
	          }
        public bool IsFechaCargaNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsFechaCargaNull();
             }
	        }
        public String TipoComprobante {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["TipoComprobante"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].TipoComprobante;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].TipoComprobante = value;
               }
	          }
        public bool IsTipoComprobanteNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsTipoComprobanteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCFDISatDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCFDISatDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCFDISatDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCFDISatDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCFDISatDS );
     }
     public venCFDISatActionExchange() : base( "venCFDISat" ) {
     }

     public venCFDISatActionExchange(venCFDISatActionEnum.EnumvenCFDISatAction pAccion) : base(venCFDISatActionEnum.GetAccionvenCFDISatAction(pAccion)) {
     }

     public venCFDISatActionExchange(venCFDISatActionEnum.EnumvenCFDISatAction pAccion, VentasCommon.venCFDISatDS pdsParam) : base(venCFDISatActionEnum.GetAccionvenCFDISatAction(pAccion), pdsParam) {
     }

     public venCFDISatActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCFDISatDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCFDISatDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCFDISatDS)mParam;
	        }
     }
  }
}
