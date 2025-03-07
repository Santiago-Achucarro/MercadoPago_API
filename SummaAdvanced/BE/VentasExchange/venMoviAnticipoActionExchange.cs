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
    public class venMoviAnticipoActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMoviAnticipoDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((VentasCommon.venMoviAnticipoDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((VentasCommon.venMoviAnticipoDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMoviAnticipoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMoviAnticipoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMoviAnticipoDS );
     }
     public venMoviAnticipoActionExchange() : base( "venMoviAnticipo" ) {
     }

     public venMoviAnticipoActionExchange(venMoviAnticipoActionEnum.EnumvenMoviAnticipoAction pAccion) : base(venMoviAnticipoActionEnum.GetAccionvenMoviAnticipoAction(pAccion)) {
     }

     public venMoviAnticipoActionExchange(venMoviAnticipoActionEnum.EnumvenMoviAnticipoAction pAccion, VentasCommon.venMoviAnticipoDS pdsParam) : base(venMoviAnticipoActionEnum.GetAccionvenMoviAnticipoAction(pAccion), pdsParam) {
     }

     public venMoviAnticipoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMoviAnticipoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMoviAnticipoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMoviAnticipoDS)mParam;
	        }
     }
  }
}
