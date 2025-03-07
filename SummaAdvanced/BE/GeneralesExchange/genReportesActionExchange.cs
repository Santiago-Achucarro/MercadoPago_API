using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genReportesActionExchange : Framework.Core.Exchange{

        public Int32 genReportes {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["genReportes"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].genReportes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].genReportes = value;
               }
	          }
        public bool IsgenReportesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsgenReportesNull();
             }
	        }
        public String Reporte_Id {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["Reporte_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].Reporte_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].Reporte_Id = value;
               }
	          }
        public bool IsReporte_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsReporte_IdNull();
             }
	        }
        public String Reporte_Id_Nueva {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["Reporte_Id_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].Reporte_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].Reporte_Id_Nueva = value;
               }
	          }
        public bool IsReporte_Id_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsReporte_Id_NuevaNull();
             }
	        }
        public String Titulo {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["Titulo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].Titulo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].Titulo = value;
               }
	          }
        public bool IsTituloNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsTituloNull();
             }
	        }
        public String Carpeta {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["Carpeta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].Carpeta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].Carpeta = value;
               }
	          }
        public bool IsCarpetaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsCarpetaNull();
             }
	        }
        public String Rpt {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["Rpt"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].Rpt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].Rpt = value;
               }
	          }
        public bool IsRptNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsRptNull();
             }
	        }
        public Boolean Estandar {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["Estandar"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].Estandar;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].Estandar = value;
               }
	          }
        public bool IsEstandarNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsEstandarNull();
             }
	        }
        public Boolean Local {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["Local"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].Local;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].Local = value;
               }
	          }
        public bool IsLocalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsLocalNull();
             }
	        }
        public String StoreProcedure {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["StoreProcedure"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].StoreProcedure;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].StoreProcedure = value;
               }
	          }
        public bool IsStoreProcedureNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsStoreProcedureNull();
             }
	        }
        public String TipoReporte {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["TipoReporte"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].TipoReporte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].TipoReporte = value;
               }
	          }
        public bool IsTipoReporteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsTipoReporteNull();
             }
	        }
        public String TamanioHoja {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["TamanioHoja"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].TamanioHoja;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].TamanioHoja = value;
               }
	          }
        public bool IsTamanioHojaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsTamanioHojaNull();
             }
	        }
        public Int32 AnchoHoja {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["AnchoHoja"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].AnchoHoja;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].AnchoHoja = value;
               }
	          }
        public bool IsAnchoHojaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsAnchoHojaNull();
             }
	        }
        public Int32 AltoHoja {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["AltoHoja"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].AltoHoja;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].AltoHoja = value;
               }
	          }
        public bool IsAltoHojaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsAltoHojaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genReportesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genReportesDS );
     }
     public genReportesActionExchange() : base( "genReportes" ) {
     }

     public genReportesActionExchange(genReportesActionEnum.EnumgenReportesAction pAccion) : base(genReportesActionEnum.GetAcciongenReportesAction(pAccion)) {
     }

     public genReportesActionExchange(genReportesActionEnum.EnumgenReportesAction pAccion, GeneralesCommon.genReportesDS pdsParam) : base(genReportesActionEnum.GetAcciongenReportesAction(pAccion), pdsParam) {
     }

     public genReportesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genReportesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genReportesDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genReportesDS)mParam;
	        }
     }
  }
}
