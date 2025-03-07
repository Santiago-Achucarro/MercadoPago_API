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
    public class sueLiquidacionActionExchange : Framework.Core.Exchange{

        public Int64 sueLiquidacion {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["sueLiquidacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].sueLiquidacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].sueLiquidacion = value;
               }
	          }
        public bool IssueLiquidacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IssueLiquidacionNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Grupo_Id {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String DescripcionGrupos {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["DescripcionGrupos"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].DescripcionGrupos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].DescripcionGrupos = value;
               }
	          }
        public bool IsDescripcionGruposNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsDescripcionGruposNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public DateTime FechaPago {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["FechaPago"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaPago;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaPago = value;
               }
	          }
        public bool IsFechaPagoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsFechaPagoNull();
             }
	        }
        public DateTime FechaDeposito {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["FechaDeposito"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaDeposito;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaDeposito = value;
               }
	          }
        public bool IsFechaDepositoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsFechaDepositoNull();
             }
	        }
        public String PeriodoDeposito {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["PeriodoDeposito"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].PeriodoDeposito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].PeriodoDeposito = value;
               }
	          }
        public bool IsPeriodoDepositoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsPeriodoDepositoNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public DateTime FechaInicial {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["FechaInicial"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaInicial;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaInicial = value;
               }
	          }
        public bool IsFechaInicialNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsFechaInicialNull();
             }
	        }
        public DateTime FechaFinal {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["FechaFinal"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaFinal;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaFinal = value;
               }
	          }
        public bool IsFechaFinalNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsFechaFinalNull();
             }
	        }
        public String Periodo_Id {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Periodo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Periodo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Periodo_Id = value;
               }
	          }
        public bool IsPeriodo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsPeriodo_IdNull();
             }
	        }
        public String DescripcionPeriodicidad {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["DescripcionPeriodicidad"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].DescripcionPeriodicidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].DescripcionPeriodicidad = value;
               }
	          }
        public bool IsDescripcionPeriodicidadNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsDescripcionPeriodicidadNull();
             }
	        }
        public Boolean PorEmpleado {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["PorEmpleado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].PorEmpleado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].PorEmpleado = value;
               }
	          }
        public bool IsPorEmpleadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsPorEmpleadoNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Quincena {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Quincena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Quincena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Quincena = value;
               }
	          }
        public bool IsQuincenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsQuincenaNull();
             }
	        }
        public Int32 Semana {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Semana"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Semana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Semana = value;
               }
	          }
        public bool IsSemanaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsSemanaNull();
             }
	        }
        public Int32 Decena {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Decena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Decena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Decena = value;
               }
	          }
        public bool IsDecenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsDecenaNull();
             }
	        }
        public Int32 Vez {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Vez"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Vez;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Vez = value;
               }
	          }
        public bool IsVezNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsVezNull();
             }
	        }
        public DateTime FechaContabilizacion {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["FechaContabilizacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaContabilizacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaContabilizacion = value;
               }
	          }
        public bool IsFechaContabilizacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsFechaContabilizacionNull();
             }
	        }
        public String SegundoPlano {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["SegundoPlano"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].SegundoPlano;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].SegundoPlano = value;
               }
	          }
        public bool IsSegundoPlanoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsSegundoPlanoNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueLiquidacionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiquidacionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueLiquidacionDS );
     }
     public sueLiquidacionActionExchange() : base( "sueLiquidacion" ) {
     }

     public sueLiquidacionActionExchange(sueLiquidacionActionEnum.EnumsueLiquidacionAction pAccion) : base(sueLiquidacionActionEnum.GetAccionsueLiquidacionAction(pAccion)) {
     }

     public sueLiquidacionActionExchange(sueLiquidacionActionEnum.EnumsueLiquidacionAction pAccion, SueldosCommon.sueLiquidacionDS pdsParam) : base(sueLiquidacionActionEnum.GetAccionsueLiquidacionAction(pAccion), pdsParam) {
     }

     public sueLiquidacionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueLiquidacionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public sueLiquidacionActionExchange(SueldosCommon.sueLiquidacionDS pDS) : base() {
     this.Action = "";
     this.mParam = new SueldosCommon.sueLiquidacionDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueLiquidacionDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueLiquidacionDS)mParam;
	        }
     }
  }
}
