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
    public class conActualizarCuentasMovimientosActionExchange : Framework.Core.Exchange{

        public String Cuenta_A_Remplazar {
            get {
                if(((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0]["Cuenta_A_Remplazar"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].Cuenta_A_Remplazar;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].Cuenta_A_Remplazar = value;
               }
	          }
        public bool IsCuenta_A_RemplazarNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].IsCuenta_A_RemplazarNull();
             }
	        }
        public String DescripcionCuenta_A_Remplazar {
            get {
                if(((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0]["DescripcionCuenta_A_Remplazar"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].DescripcionCuenta_A_Remplazar;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].DescripcionCuenta_A_Remplazar = value;
               }
	          }
        public bool IsDescripcionCuenta_A_RemplazarNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].IsDescripcionCuenta_A_RemplazarNull();
             }
	        }
        public String Cuenta_Remplazo {
            get {
                if(((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0]["Cuenta_Remplazo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].Cuenta_Remplazo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].Cuenta_Remplazo = value;
               }
	          }
        public bool IsCuenta_RemplazoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].IsCuenta_RemplazoNull();
             }
	        }
        public String DescripcionCuenta_Remplazo {
            get {
                if(((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0]["DescripcionCuenta_Remplazo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].DescripcionCuenta_Remplazo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].DescripcionCuenta_Remplazo = value;
               }
	          }
        public bool IsDescripcionCuenta_RemplazoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].IsDescripcionCuenta_RemplazoNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conActualizarCuentasMovimientosDS );
     }
     public conActualizarCuentasMovimientosActionExchange() : base( "conActualizarCuentasMovimientos" ) {
     }

     public conActualizarCuentasMovimientosActionExchange(conActualizarCuentasMovimientosActionEnum.EnumconActualizarCuentasMovimientosAction pAccion) : base(conActualizarCuentasMovimientosActionEnum.GetAccionconActualizarCuentasMovimientosAction(pAccion)) {
     }

     public conActualizarCuentasMovimientosActionExchange(conActualizarCuentasMovimientosActionEnum.EnumconActualizarCuentasMovimientosAction pAccion, ContabilidadCommon.conActualizarCuentasMovimientosDS pdsParam) : base(conActualizarCuentasMovimientosActionEnum.GetAccionconActualizarCuentasMovimientosAction(pAccion), pdsParam) {
     }

     public conActualizarCuentasMovimientosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conActualizarCuentasMovimientosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public conActualizarCuentasMovimientosActionExchange(ContabilidadCommon.conActualizarCuentasMovimientosDS pDS) : base() {
     this.Action = "";
     this.mParam = new ContabilidadCommon.conActualizarCuentasMovimientosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conActualizarCuentasMovimientosDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conActualizarCuentasMovimientosDS)mParam;
	        }
     }
  }
}
