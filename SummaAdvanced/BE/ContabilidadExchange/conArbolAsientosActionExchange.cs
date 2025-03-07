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
    public class conArbolAsientosActionExchange : Framework.Core.Exchange{

        public Int16 Ejercicio {
            get {
                if(((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0]["Ejercicio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Ejercicio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Ejercicio = value;
               }
	          }
        public bool IsEjercicioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].IsEjercicioNull();
             }
	        }
        public Int16 Periodo {
            get {
                if(((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0]["Periodo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Periodo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Periodo = value;
               }
	          }
        public bool IsPeriodoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].IsPeriodoNull();
             }
	        }
        public String Tipo {
            get {
                if(((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public String Centro1Desde {
            get {
                if(((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0]["Centro1Desde"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Centro1Desde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Centro1Desde = value;
               }
	          }
        public bool IsCentro1DesdeNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].IsCentro1DesdeNull();
             }
	        }
        public String Centro1Hasta {
            get {
                if(((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0]["Centro1Hasta"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Centro1Hasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Centro1Hasta = value;
               }
	          }
        public bool IsCentro1HastaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].IsCentro1HastaNull();
             }
	        }
        public String Centro2Desde {
            get {
                if(((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0]["Centro2Desde"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Centro2Desde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Centro2Desde = value;
               }
	          }
        public bool IsCentro2DesdeNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].IsCentro2DesdeNull();
             }
	        }
        public String Centro2Hasta {
            get {
                if(((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0]["Centro2Hasta"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Centro2Hasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Centro2Hasta = value;
               }
	          }
        public bool IsCentro2HastaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].IsCentro2HastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conArbolAsientosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conArbolAsientosDS );
     }
     public conArbolAsientosActionExchange() : base( "conArbolAsientos" ) {
     }

     public conArbolAsientosActionExchange(conArbolAsientosActionEnum.EnumconArbolAsientosAction pAccion) : base(conArbolAsientosActionEnum.GetAccionconArbolAsientosAction(pAccion)) {
     }

     public conArbolAsientosActionExchange(conArbolAsientosActionEnum.EnumconArbolAsientosAction pAccion, ContabilidadCommon.conArbolAsientosDS pdsParam) : base(conArbolAsientosActionEnum.GetAccionconArbolAsientosAction(pAccion), pdsParam) {
     }

     public conArbolAsientosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conArbolAsientosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conArbolAsientosDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conArbolAsientosDS)mParam;
	        }
     }
  }
}
