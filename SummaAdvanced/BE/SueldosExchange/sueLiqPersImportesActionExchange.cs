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
    public class sueLiqPersImportesActionExchange : Framework.Core.Exchange{

        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionLegajo {
            get {
                if(((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0]["DescripcionLegajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].DescripcionLegajo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].DescripcionLegajo = value;
               }
	          }
        public bool IsDescripcionLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].IsDescripcionLegajoNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqPersImportesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueLiqPersImportesDS );
     }
     public sueLiqPersImportesActionExchange() : base( "sueLiqPersImportes" ) {
     }

     public sueLiqPersImportesActionExchange(sueLiqPersImportesActionEnum.EnumsueLiqPersImportesAction pAccion) : base(sueLiqPersImportesActionEnum.GetAccionsueLiqPersImportesAction(pAccion)) {
     }

     public sueLiqPersImportesActionExchange(sueLiqPersImportesActionEnum.EnumsueLiqPersImportesAction pAccion, SueldosCommon.sueLiqPersImportesDS pdsParam) : base(sueLiqPersImportesActionEnum.GetAccionsueLiqPersImportesAction(pAccion), pdsParam) {
     }

     public sueLiqPersImportesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueLiqPersImportesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueLiqPersImportesDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueLiqPersImportesDS)mParam;
	        }
     }
  }
}
