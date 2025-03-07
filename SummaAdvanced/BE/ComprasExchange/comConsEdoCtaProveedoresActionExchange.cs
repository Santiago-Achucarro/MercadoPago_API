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
    public class comConsEdoCtaProveedoresActionExchange : Framework.Core.Exchange{

        public String Proveed_Id {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public Int32 PendHist {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["PendHist"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].PendHist;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].PendHist = value;
               }
	          }
        public bool IsPendHistNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsPendHistNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Int32 Empresa {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["Empresa"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Empresa;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Empresa = value;
               }
	          }
        public bool IsEmpresaNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsEmpresaNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public DateTime FechaAplicacion {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["FechaAplicacion"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].FechaAplicacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].FechaAplicacion = value;
               }
	          }
        public bool IsFechaAplicacionNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsFechaAplicacionNull();
             }
	        }
        public DateTime FechaApli {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["FechaApli"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].FechaApli;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].FechaApli = value;
               }
	          }
        public bool IsFechaApliNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsFechaApliNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String XmlUpload {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["XmlUpload"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].XmlUpload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].XmlUpload = value;
               }
	          }
        public bool IsXmlUploadNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsXmlUploadNull();
             }
	        }
        public String Xml {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["Xml"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Xml;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Xml = value;
               }
	          }
        public bool IsXmlNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsXmlNull();
             }
	        }
        public String OrigenXml {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["OrigenXml"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].OrigenXml;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].OrigenXml = value;
               }
	          }
        public bool IsOrigenXmlNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsOrigenXmlNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comConsEdoCtaProveedoresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comConsEdoCtaProveedoresDS );
     }
     public comConsEdoCtaProveedoresActionExchange() : base( "comConsEdoCtaProveedores" ) {
     }

     public comConsEdoCtaProveedoresActionExchange(comConsEdoCtaProveedoresActionEnum.EnumcomConsEdoCtaProveedoresAction pAccion) : base(comConsEdoCtaProveedoresActionEnum.GetAccioncomConsEdoCtaProveedoresAction(pAccion)) {
     }

     public comConsEdoCtaProveedoresActionExchange(comConsEdoCtaProveedoresActionEnum.EnumcomConsEdoCtaProveedoresAction pAccion, ComprasCommon.comConsEdoCtaProveedoresDS pdsParam) : base(comConsEdoCtaProveedoresActionEnum.GetAccioncomConsEdoCtaProveedoresAction(pAccion), pdsParam) {
     }

     public comConsEdoCtaProveedoresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comConsEdoCtaProveedoresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comConsEdoCtaProveedoresDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comConsEdoCtaProveedoresDS)mParam;
	        }
     }
  }
}
