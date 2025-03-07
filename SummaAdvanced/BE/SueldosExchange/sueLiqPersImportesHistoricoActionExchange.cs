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
    public class sueLiqPersImportesHistoricoActionExchange : Framework.Core.Exchange{

        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionLegajo {
            get {
                if(((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0]["DescripcionLegajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].DescripcionLegajo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].DescripcionLegajo = value;
               }
	          }
        public bool IsDescripcionLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].IsDescripcionLegajoNull();
             }
	        }
        public Int32 Importe_Id {
            get {
                if(((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0]["Importe_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].Importe_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].Importe_Id = value;
               }
	          }
        public bool IsImporte_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].IsImporte_IdNull();
             }
	        }
        public String DescripcionImporte {
            get {
                if(((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0]["DescripcionImporte"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].DescripcionImporte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].DescripcionImporte = value;
               }
	          }
        public bool IsDescripcionImporteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].IsDescripcionImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesHistoricoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueLiqPersImportesHistoricoDS );
     }
     public sueLiqPersImportesHistoricoActionExchange() : base( "sueLiqPersImportesHistorico" ) {
     }

     public sueLiqPersImportesHistoricoActionExchange(sueLiqPersImportesHistoricoActionEnum.EnumsueLiqPersImportesHistoricoAction pAccion) : base(sueLiqPersImportesHistoricoActionEnum.GetAccionsueLiqPersImportesHistoricoAction(pAccion)) {
     }

     public sueLiqPersImportesHistoricoActionExchange(sueLiqPersImportesHistoricoActionEnum.EnumsueLiqPersImportesHistoricoAction pAccion, SueldosCommon.sueLiqPersImportesHistoricoDS pdsParam) : base(sueLiqPersImportesHistoricoActionEnum.GetAccionsueLiqPersImportesHistoricoAction(pAccion), pdsParam) {
     }

     public sueLiqPersImportesHistoricoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueLiqPersImportesHistoricoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueLiqPersImportesHistoricoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueLiqPersImportesHistoricoDS)mParam;
	        }
     }
  }
}
