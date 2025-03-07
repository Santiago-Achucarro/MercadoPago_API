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
    public class sueLiqEmpleadosActionExchange : Framework.Core.Exchange{

        public Int64 sueLiquidacion {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["sueLiquidacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].sueLiquidacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].sueLiquidacion = value;
               }
	          }
        public bool IssueLiquidacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IssueLiquidacionNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Grupo_Id {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String DescripcionGrupos {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["DescripcionGrupos"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].DescripcionGrupos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].DescripcionGrupos = value;
               }
	          }
        public bool IsDescripcionGruposNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsDescripcionGruposNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public DateTime FechaPago {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["FechaPago"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].FechaPago;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].FechaPago = value;
               }
	          }
        public bool IsFechaPagoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsFechaPagoNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public DateTime FechaInicial {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["FechaInicial"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].FechaInicial;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].FechaInicial = value;
               }
	          }
        public bool IsFechaInicialNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsFechaInicialNull();
             }
	        }
        public DateTime FechaFinal {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["FechaFinal"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].FechaFinal;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].FechaFinal = value;
               }
	          }
        public bool IsFechaFinalNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsFechaFinalNull();
             }
	        }
        public String Periodo_Id {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Periodo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Periodo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Periodo_Id = value;
               }
	          }
        public bool IsPeriodo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsPeriodo_IdNull();
             }
	        }
        public String DescripcionPeriodicidad {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["DescripcionPeriodicidad"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].DescripcionPeriodicidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].DescripcionPeriodicidad = value;
               }
	          }
        public bool IsDescripcionPeriodicidadNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsDescripcionPeriodicidadNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Quincena {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Quincena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Quincena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Quincena = value;
               }
	          }
        public bool IsQuincenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsQuincenaNull();
             }
	        }
        public Int32 Semana {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Semana"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Semana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Semana = value;
               }
	          }
        public bool IsSemanaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSemanaNull();
             }
	        }
        public Int32 Decena {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Decena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Decena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Decena = value;
               }
	          }
        public bool IsDecenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsDecenaNull();
             }
	        }
        public Int32 Vez {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Vez"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Vez;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Vez = value;
               }
	          }
        public bool IsVezNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsVezNull();
             }
	        }
        public Int32 LegajoDesde {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["LegajoDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].LegajoDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].LegajoDesde = value;
               }
	          }
        public bool IsLegajoDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsLegajoDesdeNull();
             }
	        }
        public Int32 LegajoHasta {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["LegajoHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].LegajoHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].LegajoHasta = value;
               }
	          }
        public bool IsLegajoHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsLegajoHastaNull();
             }
	        }
        public String SucursalDesde {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public String TipoLiq {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["TipoLiq"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].TipoLiq;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].TipoLiq = value;
               }
	          }
        public bool IsTipoLiqNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsTipoLiqNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqEmpleadosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueLiqEmpleadosDS );
     }
     public sueLiqEmpleadosActionExchange() : base( "sueLiqEmpleados" ) {
     }

     public sueLiqEmpleadosActionExchange(sueLiqEmpleadosActionEnum.EnumsueLiqEmpleadosAction pAccion) : base(sueLiqEmpleadosActionEnum.GetAccionsueLiqEmpleadosAction(pAccion)) {
     }

     public sueLiqEmpleadosActionExchange(sueLiqEmpleadosActionEnum.EnumsueLiqEmpleadosAction pAccion, SueldosCommon.sueLiqEmpleadosDS pdsParam) : base(sueLiqEmpleadosActionEnum.GetAccionsueLiqEmpleadosAction(pAccion), pdsParam) {
     }

     public sueLiqEmpleadosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueLiqEmpleadosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public sueLiqEmpleadosActionExchange(SueldosCommon.sueLiqEmpleadosDS pDS) : base() {
     this.Action = "";
     this.mParam = new SueldosCommon.sueLiqEmpleadosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueLiqEmpleadosDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueLiqEmpleadosDS)mParam;
	        }
     }
  }
}
