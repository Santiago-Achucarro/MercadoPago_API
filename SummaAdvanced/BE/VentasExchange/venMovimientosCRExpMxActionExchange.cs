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
    public class venMovimientosCRExpMxActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 RenglonCuerpo {
            get {
                if(((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0]["RenglonCuerpo"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].RenglonCuerpo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].RenglonCuerpo = value;
               }
	          }
        public bool IsRenglonCuerpoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].IsRenglonCuerpoNull();
             }
	        }
        public Decimal CantidadAduana {
            get {
                if(((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0]["CantidadAduana"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].CantidadAduana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].CantidadAduana = value;
               }
	          }
        public bool IsCantidadAduanaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].IsCantidadAduanaNull();
             }
	        }
        public String UnidadAduana {
            get {
                if(((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0]["UnidadAduana"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].UnidadAduana;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].UnidadAduana = value;
               }
	          }
        public bool IsUnidadAduanaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].IsUnidadAduanaNull();
             }
	        }
        public Decimal ValorUnitarioAduana {
            get {
                if(((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0]["ValorUnitarioAduana"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].ValorUnitarioAduana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].ValorUnitarioAduana = value;
               }
	          }
        public bool IsValorUnitarioAduanaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].IsValorUnitarioAduanaNull();
             }
	        }
        public Decimal ValorDolares {
            get {
                if(((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0]["ValorDolares"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].ValorDolares;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].ValorDolares = value;
               }
	          }
        public bool IsValorDolaresNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].IsValorDolaresNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCRExpMxDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovimientosCRExpMxDS );
     }
     public venMovimientosCRExpMxActionExchange() : base( "venMovimientosCRExpMx" ) {
     }

     public venMovimientosCRExpMxActionExchange(venMovimientosCRExpMxActionEnum.EnumvenMovimientosCRExpMxAction pAccion) : base(venMovimientosCRExpMxActionEnum.GetAccionvenMovimientosCRExpMxAction(pAccion)) {
     }

     public venMovimientosCRExpMxActionExchange(venMovimientosCRExpMxActionEnum.EnumvenMovimientosCRExpMxAction pAccion, VentasCommon.venMovimientosCRExpMxDS pdsParam) : base(venMovimientosCRExpMxActionEnum.GetAccionvenMovimientosCRExpMxAction(pAccion), pdsParam) {
     }

     public venMovimientosCRExpMxActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovimientosCRExpMxDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovimientosCRExpMxDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovimientosCRExpMxDS)mParam;
	        }
     }
  }
}
