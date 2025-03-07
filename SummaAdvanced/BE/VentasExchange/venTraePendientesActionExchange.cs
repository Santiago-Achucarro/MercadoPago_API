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
    public class venTraePendientesActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venTraePendientesDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venTraePendientesDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTraePendientesDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venTraePendientesDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((VentasCommon.venTraePendientesDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((VentasCommon.venTraePendientesDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTraePendientesDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((VentasCommon.venTraePendientesDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.venTraePendientesDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venTraePendientesDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTraePendientesDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venTraePendientesDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String Cliente_id {
            get {
                if(((VentasCommon.venTraePendientesDS)mParam).Principal[0]["Cliente_id"] != DBNull.Value  ){
                    return ((VentasCommon.venTraePendientesDS)mParam).Principal[0].Cliente_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTraePendientesDS)mParam).Principal[0].Cliente_id = value;
               }
	          }
        public bool IsCliente_idNull {
             get {
                 return mParam==null || ((VentasCommon.venTraePendientesDS)mParam).Principal[0].IsCliente_idNull();
             }
	        }
        public Int32 Signo {
            get {
                if(((VentasCommon.venTraePendientesDS)mParam).Principal[0]["Signo"] != DBNull.Value  ){
                    return ((VentasCommon.venTraePendientesDS)mParam).Principal[0].Signo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTraePendientesDS)mParam).Principal[0].Signo = value;
               }
	          }
        public bool IsSignoNull {
             get {
                 return mParam==null || ((VentasCommon.venTraePendientesDS)mParam).Principal[0].IsSignoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venTraePendientesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venTraePendientesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTraePendientesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venTraePendientesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venTraePendientesDS );
     }
     public venTraePendientesActionExchange() : base( "venTraePendientes" ) {
     }

     public venTraePendientesActionExchange(venTraePendientesActionEnum.EnumvenTraePendientesAction pAccion) : base(venTraePendientesActionEnum.GetAccionvenTraePendientesAction(pAccion)) {
     }

     public venTraePendientesActionExchange(venTraePendientesActionEnum.EnumvenTraePendientesAction pAccion, VentasCommon.venTraePendientesDS pdsParam) : base(venTraePendientesActionEnum.GetAccionvenTraePendientesAction(pAccion), pdsParam) {
     }

     public venTraePendientesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venTraePendientesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venTraePendientesDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venTraePendientesDS)mParam;
	        }
     }
  }
}
