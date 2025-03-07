using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueLiqPersImportesXLSActionExchange : Framework.Core.Exchange{

        public Int32 Importe_Id {
            get {
                if(((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0]["Importe_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].Importe_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].Importe_Id = value;
               }
	          }
        public bool IsImporte_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].IsImporte_IdNull();
             }
	        }
        public String DescripcionImporte {
            get {
                if(((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0]["DescripcionImporte"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].DescripcionImporte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].DescripcionImporte = value;
               }
	          }
        public bool IsDescripcionImporteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].IsDescripcionImporteNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Upload {
            get {
                if(((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].IsUploadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesXLSDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueLiqPersImportesXLSDS );
     }
     public sueLiqPersImportesXLSActionExchange() : base( "sueLiqPersImportesXLS" ) {
     }

     public sueLiqPersImportesXLSActionExchange(sueLiqPersImportesXLSActionEnum.EnumsueLiqPersImportesXLSAction pAccion) : base(sueLiqPersImportesXLSActionEnum.GetAccionsueLiqPersImportesXLSAction(pAccion)) {
     }

     public sueLiqPersImportesXLSActionExchange(sueLiqPersImportesXLSActionEnum.EnumsueLiqPersImportesXLSAction pAccion, SueldosCommon.sueLiqPersImportesXLSDS pdsParam) : base(sueLiqPersImportesXLSActionEnum.GetAccionsueLiqPersImportesXLSAction(pAccion), pdsParam) {
     }

     public sueLiqPersImportesXLSActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueLiqPersImportesXLSDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueLiqPersImportesXLSDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueLiqPersImportesXLSDS)mParam;
	        }
     }
  }
}
