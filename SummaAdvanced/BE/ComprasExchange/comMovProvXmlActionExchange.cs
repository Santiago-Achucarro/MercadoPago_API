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
    public class comMovProvXmlActionExchange : Framework.Core.Exchange{

        public String ProveedorDesde {
            get {
                if(((ComprasCommon.comMovProvXmlDS)mParam).Principal[0]["ProveedorDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].ProveedorDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].ProveedorDesde = value;
               }
	          }
        public bool IsProveedorDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].IsProveedorDesdeNull();
             }
	        }
        public String ProveedorHasta {
            get {
                if(((ComprasCommon.comMovProvXmlDS)mParam).Principal[0]["ProveedorHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].ProveedorHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].ProveedorHasta = value;
               }
	          }
        public bool IsProveedorHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].IsProveedorHastaNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ComprasCommon.comMovProvXmlDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ComprasCommon.comMovProvXmlDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Pendiente {
            get {
                if(((ComprasCommon.comMovProvXmlDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public String Upload {
            get {
                if(((ComprasCommon.comMovProvXmlDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].IsUploadNull();
             }
	        }
        public String lupXml {
            get {
                if(((ComprasCommon.comMovProvXmlDS)mParam).Principal[0]["lupXml"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].lupXml;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].lupXml = value;
               }
	          }
        public bool IslupXmlNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].IslupXmlNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovProvXmlDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvXmlDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovProvXmlDS );
     }
     public comMovProvXmlActionExchange() : base( "comMovProvXml" ) {
     }

     public comMovProvXmlActionExchange(comMovProvXmlActionEnum.EnumcomMovProvXmlAction pAccion) : base(comMovProvXmlActionEnum.GetAccioncomMovProvXmlAction(pAccion)) {
     }

     public comMovProvXmlActionExchange(comMovProvXmlActionEnum.EnumcomMovProvXmlAction pAccion, ComprasCommon.comMovProvXmlDS pdsParam) : base(comMovProvXmlActionEnum.GetAccioncomMovProvXmlAction(pAccion), pdsParam) {
     }

     public comMovProvXmlActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovProvXmlDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovProvXmlDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovProvXmlDS)mParam;
	        }
     }
  }
}
