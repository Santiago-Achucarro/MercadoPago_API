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
    public class suePagosHabiPorEmpleadoActionExchange : Framework.Core.Exchange{

        public Boolean Marca {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Marca"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Marca;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Marca = value;
               }
	          }
        public bool IsMarcaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsMarcaNull();
             }
	        }
        public Int32 Secuencia {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Secuencia"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Secuencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Secuencia = value;
               }
	          }
        public bool IsSecuenciaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsSecuenciaNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionPersonal {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["DescripcionPersonal"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].DescripcionPersonal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].DescripcionPersonal = value;
               }
	          }
        public bool IsDescripcionPersonalNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsDescripcionPersonalNull();
             }
	        }
        public Int64 sueLiquidacion {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["sueLiquidacion"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].sueLiquidacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].sueLiquidacion = value;
               }
	          }
        public bool IssueLiquidacionNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IssueLiquidacionNull();
             }
	        }
        public Int64 tesMovimientos {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public DateTime FechaHabilitacion {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["FechaHabilitacion"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].FechaHabilitacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].FechaHabilitacion = value;
               }
	          }
        public bool IsFechaHabilitacionNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsFechaHabilitacionNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Quincena {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Quincena"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Quincena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Quincena = value;
               }
	          }
        public bool IsQuincenaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsQuincenaNull();
             }
	        }
        public Int32 Decena {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Decena"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Decena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Decena = value;
               }
	          }
        public bool IsDecenaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsDecenaNull();
             }
	        }
        public Int32 Semana {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Semana"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Semana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Semana = value;
               }
	          }
        public bool IsSemanaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsSemanaNull();
             }
	        }
        public Int32 Vez {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Vez"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Vez;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Vez = value;
               }
	          }
        public bool IsVezNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsVezNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.suePagosHabiPorEmpleadoDS );
     }
     public suePagosHabiPorEmpleadoActionExchange() : base( "suePagosHabiPorEmpleado" ) {
     }

     public suePagosHabiPorEmpleadoActionExchange(suePagosHabiPorEmpleadoActionEnum.EnumsuePagosHabiPorEmpleadoAction pAccion) : base(suePagosHabiPorEmpleadoActionEnum.GetAccionsuePagosHabiPorEmpleadoAction(pAccion)) {
     }

     public suePagosHabiPorEmpleadoActionExchange(suePagosHabiPorEmpleadoActionEnum.EnumsuePagosHabiPorEmpleadoAction pAccion, SueldosCommon.suePagosHabiPorEmpleadoDS pdsParam) : base(suePagosHabiPorEmpleadoActionEnum.GetAccionsuePagosHabiPorEmpleadoAction(pAccion), pdsParam) {
     }

     public suePagosHabiPorEmpleadoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.suePagosHabiPorEmpleadoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.suePagosHabiPorEmpleadoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.suePagosHabiPorEmpleadoDS)mParam;
	        }
     }
  }
}
