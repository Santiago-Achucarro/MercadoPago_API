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
    public class venMovimientosFiscalINEActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public String ClaveIdentidad {
            get {
                if(((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0]["ClaveIdentidad"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].ClaveIdentidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].ClaveIdentidad = value;
               }
	          }
        public bool IsClaveIdentidadNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].IsClaveIdentidadNull();
             }
	        }
        public Decimal idContabilidad {
            get {
                if(((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0]["idContabilidad"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].idContabilidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].idContabilidad = value;
               }
	          }
        public bool IsidContabilidadNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].IsidContabilidadNull();
             }
	        }
        public String Ambito {
            get {
                if(((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0]["Ambito"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].Ambito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].Ambito = value;
               }
	          }
        public bool IsAmbitoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].IsAmbitoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalINEDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovimientosFiscalINEDS );
     }
     public venMovimientosFiscalINEActionExchange() : base( "venMovimientosFiscalINE" ) {
     }

     public venMovimientosFiscalINEActionExchange(venMovimientosFiscalINEActionEnum.EnumvenMovimientosFiscalINEAction pAccion) : base(venMovimientosFiscalINEActionEnum.GetAccionvenMovimientosFiscalINEAction(pAccion)) {
     }

     public venMovimientosFiscalINEActionExchange(venMovimientosFiscalINEActionEnum.EnumvenMovimientosFiscalINEAction pAccion, VentasCommon.venMovimientosFiscalINEDS pdsParam) : base(venMovimientosFiscalINEActionEnum.GetAccionvenMovimientosFiscalINEAction(pAccion), pdsParam) {
     }

     public venMovimientosFiscalINEActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovimientosFiscalINEDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovimientosFiscalINEDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovimientosFiscalINEDS)mParam;
	        }
     }
  }
}
