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
    public class comCFDISatActionExchange : Framework.Core.Exchange{

        public String UUID {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["UUID"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].UUID;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].UUID = value;
               }
	          }
        public bool IsUUIDNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsUUIDNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String RFCEmisor {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["RFCEmisor"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].RFCEmisor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].RFCEmisor = value;
               }
	          }
        public bool IsRFCEmisorNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsRFCEmisorNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public String Folio {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["Folio"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Folio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Folio = value;
               }
	          }
        public bool IsFolioNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsFolioNull();
             }
	        }
        public String Serie {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public Boolean Subido {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["Subido"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Subido;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Subido = value;
               }
	          }
        public bool IsSubidoNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsSubidoNull();
             }
	        }
        public String XML {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["XML"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].XML;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].XML = value;
               }
	          }
        public bool IsXMLNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsXMLNull();
             }
	        }
        public Int32 Usuario {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["Usuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Usuario;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Usuario = value;
               }
	          }
        public bool IsUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsUsuarioNull();
             }
	        }
        public DateTime FechaCarga {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["FechaCarga"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].FechaCarga;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].FechaCarga = value;
               }
	          }
        public bool IsFechaCargaNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsFechaCargaNull();
             }
	        }
        public String Upload {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsUploadNull();
             }
	        }
        public String TipoDeComprobante {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["TipoDeComprobante"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].TipoDeComprobante;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].TipoDeComprobante = value;
               }
	          }
        public bool IsTipoDeComprobanteNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsTipoDeComprobanteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comCFDISatDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comCFDISatDS );
     }
     public comCFDISatActionExchange() : base( "comCFDISat" ) {
     }

     public comCFDISatActionExchange(comCFDISatActionEnum.EnumcomCFDISatAction pAccion) : base(comCFDISatActionEnum.GetAccioncomCFDISatAction(pAccion)) {
     }

     public comCFDISatActionExchange(comCFDISatActionEnum.EnumcomCFDISatAction pAccion, ComprasCommon.comCFDISatDS pdsParam) : base(comCFDISatActionEnum.GetAccioncomCFDISatAction(pAccion), pdsParam) {
     }

     public comCFDISatActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comCFDISatDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comCFDISatDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comCFDISatDS)mParam;
	        }
     }
  }
}
