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
    public class sueLiquidacionGenerarActionExchange : Framework.Core.Exchange{

        public Int64 sueLiquidacion {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["sueLiquidacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].sueLiquidacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].sueLiquidacion = value;
               }
	          }
        public bool IssueLiquidacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IssueLiquidacionNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Grupo_Id {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String DescripcionGrupos {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["DescripcionGrupos"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].DescripcionGrupos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].DescripcionGrupos = value;
               }
	          }
        public bool IsDescripcionGruposNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsDescripcionGruposNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public DateTime FechaPago {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["FechaPago"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaPago;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaPago = value;
               }
	          }
        public bool IsFechaPagoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsFechaPagoNull();
             }
	        }
        public DateTime FechaDeposito {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["FechaDeposito"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaDeposito;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaDeposito = value;
               }
	          }
        public bool IsFechaDepositoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsFechaDepositoNull();
             }
	        }
        public String PeriodoDeposito {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["PeriodoDeposito"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].PeriodoDeposito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].PeriodoDeposito = value;
               }
	          }
        public bool IsPeriodoDepositoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsPeriodoDepositoNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public DateTime FechaInicial {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["FechaInicial"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaInicial;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaInicial = value;
               }
	          }
        public bool IsFechaInicialNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsFechaInicialNull();
             }
	        }
        public DateTime FechaFinal {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["FechaFinal"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaFinal;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaFinal = value;
               }
	          }
        public bool IsFechaFinalNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsFechaFinalNull();
             }
	        }
        public Boolean TodosLosPeriodos {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["TodosLosPeriodos"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].TodosLosPeriodos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].TodosLosPeriodos = value;
               }
	          }
        public bool IsTodosLosPeriodosNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsTodosLosPeriodosNull();
             }
	        }
        public String Periodo_Id {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Periodo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Periodo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Periodo_Id = value;
               }
	          }
        public bool IsPeriodo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsPeriodo_IdNull();
             }
	        }
        public String DescripcionPeriodicidad {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["DescripcionPeriodicidad"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].DescripcionPeriodicidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].DescripcionPeriodicidad = value;
               }
	          }
        public bool IsDescripcionPeriodicidadNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsDescripcionPeriodicidadNull();
             }
	        }
        public Boolean PorEmpleado {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["PorEmpleado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].PorEmpleado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].PorEmpleado = value;
               }
	          }
        public bool IsPorEmpleadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsPorEmpleadoNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Quincena {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Quincena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Quincena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Quincena = value;
               }
	          }
        public bool IsQuincenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsQuincenaNull();
             }
	        }
        public Int32 Semana {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Semana"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Semana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Semana = value;
               }
	          }
        public bool IsSemanaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSemanaNull();
             }
	        }
        public Int32 Decena {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Decena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Decena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Decena = value;
               }
	          }
        public bool IsDecenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsDecenaNull();
             }
	        }
        public Int32 Vez {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Vez"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Vez;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Vez = value;
               }
	          }
        public bool IsVezNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsVezNull();
             }
	        }
        public DateTime FechaContabilizacion {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["FechaContabilizacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaContabilizacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaContabilizacion = value;
               }
	          }
        public bool IsFechaContabilizacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsFechaContabilizacionNull();
             }
	        }
        public Int32 LegajoDesde {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["LegajoDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].LegajoDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].LegajoDesde = value;
               }
	          }
        public bool IsLegajoDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsLegajoDesdeNull();
             }
	        }
        public Int32 LegajoHasta {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["LegajoHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].LegajoHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].LegajoHasta = value;
               }
	          }
        public bool IsLegajoHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsLegajoHastaNull();
             }
	        }
        public String SucursalDesde {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public String TipoLiq {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["TipoLiq"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].TipoLiq;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].TipoLiq = value;
               }
	          }
        public bool IsTipoLiqNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsTipoLiqNull();
             }
	        }
        public Int32 RegistroActual {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["RegistroActual"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].RegistroActual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].RegistroActual = value;
               }
	          }
        public bool IsRegistroActualNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsRegistroActualNull();
             }
	        }
        public String Mensaje {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Mensaje"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Mensaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Mensaje = value;
               }
	          }
        public bool IsMensajeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsMensajeNull();
             }
	        }
        public String Condicion {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Condicion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Condicion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Condicion = value;
               }
	          }
        public bool IsCondicionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsCondicionNull();
             }
	        }
        public Boolean DescargarWS {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["DescargarWS"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].DescargarWS;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].DescargarWS = value;
               }
	          }
        public bool IsDescargarWSNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsDescargarWSNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Centro1Desde {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Centro1Desde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Centro1Desde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Centro1Desde = value;
               }
	          }
        public bool IsCentro1DesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsCentro1DesdeNull();
             }
	        }
        public String Centro1Hasta {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Centro1Hasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Centro1Hasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Centro1Hasta = value;
               }
	          }
        public bool IsCentro1HastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsCentro1HastaNull();
             }
	        }
        public String ConvenioDesde {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["ConvenioDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].ConvenioDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].ConvenioDesde = value;
               }
	          }
        public bool IsConvenioDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsConvenioDesdeNull();
             }
	        }
        public String ConvenioHasta {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["ConvenioHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].ConvenioHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].ConvenioHasta = value;
               }
	          }
        public bool IsConvenioHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsConvenioHastaNull();
             }
	        }
        public String TipoPagoDesde {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["TipoPagoDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].TipoPagoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].TipoPagoDesde = value;
               }
	          }
        public bool IsTipoPagoDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsTipoPagoDesdeNull();
             }
	        }
        public String TipoPagoHasta {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["TipoPagoHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].TipoPagoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].TipoPagoHasta = value;
               }
	          }
        public bool IsTipoPagoHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsTipoPagoHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionGenerarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueLiquidacionGenerarDS );
     }
     public sueLiquidacionGenerarActionExchange() : base( "sueLiquidacionGenerar" ) {
     }

     public sueLiquidacionGenerarActionExchange(sueLiquidacionGenerarActionEnum.EnumsueLiquidacionGenerarAction pAccion) : base(sueLiquidacionGenerarActionEnum.GetAccionsueLiquidacionGenerarAction(pAccion)) {
     }

     public sueLiquidacionGenerarActionExchange(sueLiquidacionGenerarActionEnum.EnumsueLiquidacionGenerarAction pAccion, SueldosCommon.sueLiquidacionGenerarDS pdsParam) : base(sueLiquidacionGenerarActionEnum.GetAccionsueLiquidacionGenerarAction(pAccion), pdsParam) {
     }

     public sueLiquidacionGenerarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueLiquidacionGenerarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public sueLiquidacionGenerarActionExchange(SueldosCommon.sueLiquidacionGenerarDS pDS) : base() {
     this.Action = "";
     this.mParam = new SueldosCommon.sueLiquidacionGenerarDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueLiquidacionGenerarDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueLiquidacionGenerarDS)mParam;
	        }
     }
  }
}
