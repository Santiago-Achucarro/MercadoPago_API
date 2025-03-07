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
    public class VenCondPagoCuotasActionExchange : Framework.Core.Exchange{

        public Int32 venCondPago {
            get {
                if(((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0]["venCondPago"] != DBNull.Value  ){
                    return ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].venCondPago;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].venCondPago = value;
               }
	          }
        public bool IsvenCondPagoNull {
             get {
                 return mParam==null || ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].IsvenCondPagoNull();
             }
	        }
        public String CondPagoCli_Id {
            get {
                if(((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0]["CondPagoCli_Id"] != DBNull.Value  ){
                    return ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].CondPagoCli_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].CondPagoCli_Id = value;
               }
	          }
        public bool IsCondPagoCli_IdNull {
             get {
                 return mParam==null || ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].IsCondPagoCli_IdNull();
             }
	        }
        public String DescripcionCondPago {
            get {
                if(((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0]["DescripcionCondPago"] != DBNull.Value  ){
                    return ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].DescripcionCondPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].DescripcionCondPago = value;
               }
	          }
        public bool IsDescripcionCondPagoNull {
             get {
                 return mParam==null || ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].IsDescripcionCondPagoNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Int32 Dias {
            get {
                if(((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0]["Dias"] != DBNull.Value  ){
                    return ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].Dias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].Dias = value;
               }
	          }
        public bool IsDiasNull {
             get {
                 return mParam==null || ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].IsDiasNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.VenCondPagoCuotasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.VenCondPagoCuotasDS );
     }
     public VenCondPagoCuotasActionExchange() : base( "VenCondPagoCuotas" ) {
     }

     public VenCondPagoCuotasActionExchange(VenCondPagoCuotasActionEnum.EnumVenCondPagoCuotasAction pAccion) : base(VenCondPagoCuotasActionEnum.GetAccionVenCondPagoCuotasAction(pAccion)) {
     }

     public VenCondPagoCuotasActionExchange(VenCondPagoCuotasActionEnum.EnumVenCondPagoCuotasAction pAccion, VentasCommon.VenCondPagoCuotasDS pdsParam) : base(VenCondPagoCuotasActionEnum.GetAccionVenCondPagoCuotasAction(pAccion), pdsParam) {
     }

     public VenCondPagoCuotasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.VenCondPagoCuotasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.VenCondPagoCuotasDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.VenCondPagoCuotasDS)mParam;
	        }
     }
  }
}
