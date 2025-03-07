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
    public class genReportesSPActionExchange : Framework.Core.Exchange{

        public Int32 genReportes {
            get {
                if(((GeneralesCommon.genReportesSPDS)mParam).Principal[0]["genReportes"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].genReportes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].genReportes = value;
               }
	          }
        public bool IsgenReportesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].IsgenReportesNull();
             }
	        }
        public String Reporte_Id {
            get {
                if(((GeneralesCommon.genReportesSPDS)mParam).Principal[0]["Reporte_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].Reporte_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].Reporte_Id = value;
               }
	          }
        public bool IsReporte_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].IsReporte_IdNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((GeneralesCommon.genReportesSPDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String StoreProcedure {
            get {
                if(((GeneralesCommon.genReportesSPDS)mParam).Principal[0]["StoreProcedure"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].StoreProcedure;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].StoreProcedure = value;
               }
	          }
        public bool IsStoreProcedureNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].IsStoreProcedureNull();
             }
	        }
        public String DataTable {
            get {
                if(((GeneralesCommon.genReportesSPDS)mParam).Principal[0]["DataTable"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].DataTable;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].DataTable = value;
               }
	          }
        public bool IsDataTableNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].IsDataTableNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genReportesSPDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesSPDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genReportesSPDS );
     }
     public genReportesSPActionExchange() : base( "genReportesSP" ) {
     }

     public genReportesSPActionExchange(genReportesSPActionEnum.EnumgenReportesSPAction pAccion) : base(genReportesSPActionEnum.GetAcciongenReportesSPAction(pAccion)) {
     }

     public genReportesSPActionExchange(genReportesSPActionEnum.EnumgenReportesSPAction pAccion, GeneralesCommon.genReportesSPDS pdsParam) : base(genReportesSPActionEnum.GetAcciongenReportesSPAction(pAccion), pdsParam) {
     }

     public genReportesSPActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genReportesSPDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genReportesSPDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genReportesSPDS)mParam;
	        }
     }
  }
}
