using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conFechasCierresActionExchange : Framework.Core.Exchange{

        public DateTime FechaCierreCompras {
            get {
                if(((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0]["FechaCierreCompras"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreCompras;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreCompras = value;
               }
	          }
        public bool IsFechaCierreComprasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].IsFechaCierreComprasNull();
             }
	        }
        public DateTime FechaCierreImpuestos {
            get {
                if(((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0]["FechaCierreImpuestos"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreImpuestos;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreImpuestos = value;
               }
	          }
        public bool IsFechaCierreImpuestosNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].IsFechaCierreImpuestosNull();
             }
	        }
        public DateTime FechaCierreTesoreria {
            get {
                if(((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0]["FechaCierreTesoreria"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreTesoreria;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreTesoreria = value;
               }
	          }
        public bool IsFechaCierreTesoreriaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].IsFechaCierreTesoreriaNull();
             }
	        }
        public DateTime FechaCierreStock {
            get {
                if(((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0]["FechaCierreStock"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreStock;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreStock = value;
               }
	          }
        public bool IsFechaCierreStockNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].IsFechaCierreStockNull();
             }
	        }
        public DateTime FechaCierreVentas {
            get {
                if(((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0]["FechaCierreVentas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreVentas;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreVentas = value;
               }
	          }
        public bool IsFechaCierreVentasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].IsFechaCierreVentasNull();
             }
	        }
        public DateTime FechaCierreActivoFijo {
            get {
                if(((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0]["FechaCierreActivoFijo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreActivoFijo;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreActivoFijo = value;
               }
	          }
        public bool IsFechaCierreActivoFijoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].IsFechaCierreActivoFijoNull();
             }
	        }
        public DateTime FechaCierreSueldos {
            get {
                if(((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0]["FechaCierreSueldos"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreSueldos;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].FechaCierreSueldos = value;
               }
	          }
        public bool IsFechaCierreSueldosNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].IsFechaCierreSueldosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conFechasCierresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conFechasCierresDS );
     }
     public conFechasCierresActionExchange() : base( "conFechasCierres" ) {
     }

     public conFechasCierresActionExchange(conFechasCierresActionEnum.EnumconFechasCierresAction pAccion) : base(conFechasCierresActionEnum.GetAccionconFechasCierresAction(pAccion)) {
     }

     public conFechasCierresActionExchange(conFechasCierresActionEnum.EnumconFechasCierresAction pAccion, ContabilidadCommon.conFechasCierresDS pdsParam) : base(conFechasCierresActionEnum.GetAccionconFechasCierresAction(pAccion), pdsParam) {
     }

     public conFechasCierresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conFechasCierresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conFechasCierresDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conFechasCierresDS)mParam;
	        }
     }
  }
}
