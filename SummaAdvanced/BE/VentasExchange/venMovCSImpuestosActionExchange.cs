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
    public class venMovCSImpuestosActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 RenglonCuerpo {
            get {
                if(((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0]["RenglonCuerpo"] != DBNull.Value  ){
                    return ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].RenglonCuerpo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].RenglonCuerpo = value;
               }
	          }
        public bool IsRenglonCuerpoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].IsRenglonCuerpoNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String DescripcionImpuestos {
            get {
                if(((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0]["DescripcionImpuestos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].DescripcionImpuestos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].DescripcionImpuestos = value;
               }
	          }
        public bool IsDescripcionImpuestosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].IsDescripcionImpuestosNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal ImporteMonedaNac {
            get {
                if(((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0]["ImporteMonedaNac"] != DBNull.Value  ){
                    return ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].ImporteMonedaNac;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].ImporteMonedaNac = value;
               }
	          }
        public bool IsImporteMonedaNacNull {
             get {
                 return mParam==null || ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].IsImporteMonedaNacNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Decimal BaseImponible {
            get {
                if(((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0]["BaseImponible"] != DBNull.Value  ){
                    return ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].BaseImponible;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].BaseImponible = value;
               }
	          }
        public bool IsBaseImponibleNull {
             get {
                 return mParam==null || ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].IsBaseImponibleNull();
             }
	        }
        public Decimal BaseImponibleMonedaNac {
            get {
                if(((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0]["BaseImponibleMonedaNac"] != DBNull.Value  ){
                    return ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].BaseImponibleMonedaNac;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].BaseImponibleMonedaNac = value;
               }
	          }
        public bool IsBaseImponibleMonedaNacNull {
             get {
                 return mParam==null || ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].IsBaseImponibleMonedaNacNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovCSImpuestosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovCSImpuestosDS );
     }
     public venMovCSImpuestosActionExchange() : base( "venMovCSImpuestos" ) {
     }

     public venMovCSImpuestosActionExchange(venMovCSImpuestosActionEnum.EnumvenMovCSImpuestosAction pAccion) : base(venMovCSImpuestosActionEnum.GetAccionvenMovCSImpuestosAction(pAccion)) {
     }

     public venMovCSImpuestosActionExchange(venMovCSImpuestosActionEnum.EnumvenMovCSImpuestosAction pAccion, VentasCommon.venMovCSImpuestosDS pdsParam) : base(venMovCSImpuestosActionEnum.GetAccionvenMovCSImpuestosAction(pAccion), pdsParam) {
     }

     public venMovCSImpuestosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovCSImpuestosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovCSImpuestosDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovCSImpuestosDS)mParam;
	        }
     }
  }
}
