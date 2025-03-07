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
    public class conPeriodosActionExchange : Framework.Core.Exchange{

        public Int16 Ejercicio {
            get {
                if(((ContabilidadCommon.conPeriodosDS)mParam).Principal[0]["Ejercicio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Ejercicio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Ejercicio = value;
               }
	          }
        public bool IsEjercicioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].IsEjercicioNull();
             }
	        }
        public Int16 Periodo {
            get {
                if(((ContabilidadCommon.conPeriodosDS)mParam).Principal[0]["Periodo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Periodo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Periodo = value;
               }
	          }
        public bool IsPeriodoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].IsPeriodoNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ContabilidadCommon.conPeriodosDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime Fecha_Desde {
            get {
                if(((ContabilidadCommon.conPeriodosDS)mParam).Principal[0]["Fecha_Desde"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Fecha_Desde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Fecha_Desde = value;
               }
	          }
        public bool IsFecha_DesdeNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].IsFecha_DesdeNull();
             }
	        }
        public DateTime Fecha_Hasta {
            get {
                if(((ContabilidadCommon.conPeriodosDS)mParam).Principal[0]["Fecha_Hasta"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Fecha_Hasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Fecha_Hasta = value;
               }
	          }
        public bool IsFecha_HastaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].IsFecha_HastaNull();
             }
	        }
        public String Estado {
            get {
                if(((ContabilidadCommon.conPeriodosDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conPeriodosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conPeriodosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conPeriodosDS );
     }
     public conPeriodosActionExchange() : base( "conPeriodos" ) {
     }

     public conPeriodosActionExchange(conPeriodosActionEnum.EnumconPeriodosAction pAccion) : base(conPeriodosActionEnum.GetAccionconPeriodosAction(pAccion)) {
     }

     public conPeriodosActionExchange(conPeriodosActionEnum.EnumconPeriodosAction pAccion, ContabilidadCommon.conPeriodosDS pdsParam) : base(conPeriodosActionEnum.GetAccionconPeriodosAction(pAccion), pdsParam) {
     }

     public conPeriodosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conPeriodosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conPeriodosDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conPeriodosDS)mParam;
	        }
     }
  }
}
