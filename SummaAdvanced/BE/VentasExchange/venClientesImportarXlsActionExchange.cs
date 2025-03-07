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
    public class venClientesImportarXlsActionExchange : Framework.Core.Exchange{

        public String Ruta {
            get {
                if(((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0]["Ruta"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].Ruta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].Ruta = value;
               }
	          }
        public bool IsRutaNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].IsRutaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public Boolean BackGroundWorker {
            get {
                if(((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0]["BackGroundWorker"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].BackGroundWorker;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].BackGroundWorker = value;
               }
	          }
        public bool IsBackGroundWorkerNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].IsBackGroundWorkerNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public Boolean DetieneError {
            get {
                if(((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0]["DetieneError"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].DetieneError;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].DetieneError = value;
               }
	          }
        public bool IsDetieneErrorNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesImportarXlsDS)mParam).Principal[0].IsDetieneErrorNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venClientesImportarXlsDS );
     }
     public venClientesImportarXlsActionExchange() : base( "venClientesImportarXls" ) {
     }

     public venClientesImportarXlsActionExchange(venClientesImportarXlsActionEnum.EnumvenClientesImportarXlsAction pAccion) : base(venClientesImportarXlsActionEnum.GetAccionvenClientesImportarXlsAction(pAccion)) {
     }

     public venClientesImportarXlsActionExchange(venClientesImportarXlsActionEnum.EnumvenClientesImportarXlsAction pAccion, VentasCommon.venClientesImportarXlsDS pdsParam) : base(venClientesImportarXlsActionEnum.GetAccionvenClientesImportarXlsAction(pAccion), pdsParam) {
     }

     public venClientesImportarXlsActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venClientesImportarXlsDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venClientesImportarXlsDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venClientesImportarXlsDS)mParam;
	        }
     }
  }
}
