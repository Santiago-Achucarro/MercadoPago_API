using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comEmbGastosActionExchange : Framework.Core.Exchange{

        public Int64 comEmbarques {
            get {
                if(((ComprasCommon.comEmbGastosDS)mParam).Principal[0]["comEmbarques"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].comEmbarques;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].comEmbarques = value;
               }
	          }
        public bool IscomEmbarquesNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].IscomEmbarquesNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ComprasCommon.comEmbGastosDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Detalle {
            get {
                if(((ComprasCommon.comEmbGastosDS)mParam).Principal[0]["Detalle"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].Detalle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].Detalle = value;
               }
	          }
        public bool IsDetalleNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].IsDetalleNull();
             }
	        }
        public Decimal ImporteOriginal {
            get {
                if(((ComprasCommon.comEmbGastosDS)mParam).Principal[0]["ImporteOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].ImporteOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].ImporteOriginal = value;
               }
	          }
        public bool IsImporteOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].IsImporteOriginalNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((ComprasCommon.comEmbGastosDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comEmbGastosDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((ComprasCommon.comEmbGastosDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String CantidadImporte {
            get {
                if(((ComprasCommon.comEmbGastosDS)mParam).Principal[0]["CantidadImporte"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].CantidadImporte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].CantidadImporte = value;
               }
	          }
        public bool IsCantidadImporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].IsCantidadImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comEmbGastosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comEmbGastosDS );
     }
     public comEmbGastosActionExchange() : base( "comEmbGastos" ) {
     }

     public comEmbGastosActionExchange(comEmbGastosActionEnum.EnumcomEmbGastosAction pAccion) : base(comEmbGastosActionEnum.GetAccioncomEmbGastosAction(pAccion)) {
     }

     public comEmbGastosActionExchange(comEmbGastosActionEnum.EnumcomEmbGastosAction pAccion, ComprasCommon.comEmbGastosDS pdsParam) : base(comEmbGastosActionEnum.GetAccioncomEmbGastosAction(pAccion), pdsParam) {
     }

     public comEmbGastosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comEmbGastosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comEmbGastosDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comEmbGastosDS)mParam;
	        }
     }
  }
}
