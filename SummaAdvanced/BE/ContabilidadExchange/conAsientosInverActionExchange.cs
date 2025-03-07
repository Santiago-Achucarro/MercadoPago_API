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
    public class conAsientosInverActionExchange : Framework.Core.Exchange{

        public Int64 conAsientos {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["conAsientos"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].conAsientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].conAsientos = value;
               }
	          }
        public bool IsconAsientosNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsconAsientosNull();
             }
	        }
        public Int16 Ejercicio {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Ejercicio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Ejercicio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Ejercicio = value;
               }
	          }
        public bool IsEjercicioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsEjercicioNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String LeyendaLibroDiario {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["LeyendaLibroDiario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].LeyendaLibroDiario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].LeyendaLibroDiario = value;
               }
	          }
        public bool IsLeyendaLibroDiarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsLeyendaLibroDiarioNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal CambioMonedaOriginal {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["CambioMonedaOriginal"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].CambioMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].CambioMonedaOriginal = value;
               }
	          }
        public bool IsCambioMonedaOriginalNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsCambioMonedaOriginalNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String Formulario_Id {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Formulario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Formulario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Formulario_Id = value;
               }
	          }
        public bool IsFormulario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsFormulario_IdNull();
             }
	        }
        public String DescripcionFormulario {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["DescripcionFormulario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].DescripcionFormulario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].DescripcionFormulario = value;
               }
	          }
        public bool IsDescripcionFormularioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsDescripcionFormularioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Especial {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Especial"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Especial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Especial = value;
               }
	          }
        public bool IsEspecialNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsEspecialNull();
             }
	        }
        public String Sucursal {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public Decimal TotalDebe {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["TotalDebe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].TotalDebe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].TotalDebe = value;
               }
	          }
        public bool IsTotalDebeNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsTotalDebeNull();
             }
	        }
        public Decimal TotalHaber {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["TotalHaber"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].TotalHaber;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].TotalHaber = value;
               }
	          }
        public bool IsTotalHaberNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsTotalHaberNull();
             }
	        }
        public Decimal Diferencia {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Diferencia"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Diferencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Diferencia = value;
               }
	          }
        public bool IsDiferenciaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsDiferenciaNull();
             }
	        }
        public Int32 AsientosTipo_Id {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["AsientosTipo_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].AsientosTipo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].AsientosTipo_Id = value;
               }
	          }
        public bool IsAsientosTipo_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsAsientosTipo_IdNull();
             }
	        }
        public String LeyendaLibroDiario1 {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["LeyendaLibroDiario1"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].LeyendaLibroDiario1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].LeyendaLibroDiario1 = value;
               }
	          }
        public bool IsLeyendaLibroDiario1Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsLeyendaLibroDiario1Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosInverDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conAsientosInverDS );
     }
     public conAsientosInverActionExchange() : base( "conAsientosInver" ) {
     }

     public conAsientosInverActionExchange(conAsientosInverActionEnum.EnumconAsientosInverAction pAccion) : base(conAsientosInverActionEnum.GetAccionconAsientosInverAction(pAccion)) {
     }

     public conAsientosInverActionExchange(conAsientosInverActionEnum.EnumconAsientosInverAction pAccion, ContabilidadCommon.conAsientosInverDS pdsParam) : base(conAsientosInverActionEnum.GetAccionconAsientosInverAction(pAccion), pdsParam) {
     }

     public conAsientosInverActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conAsientosInverDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conAsientosInverDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conAsientosInverDS)mParam;
	        }
     }
  }
}
