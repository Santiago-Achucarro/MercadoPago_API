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
    public class conEjercicioPeriodoActionExchange : Framework.Core.Exchange{

        public Int16 Ejercicio {
            get {
                if(((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0]["Ejercicio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].Ejercicio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].Ejercicio = value;
               }
	          }
        public bool IsEjercicioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].IsEjercicioNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Int32 MesInicioEjercicio {
            get {
                if(((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0]["MesInicioEjercicio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].MesInicioEjercicio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].MesInicioEjercicio = value;
               }
	          }
        public bool IsMesInicioEjercicioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].IsMesInicioEjercicioNull();
             }
	        }
        public Int32 CantPeriodos {
            get {
                if(((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0]["CantPeriodos"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].CantPeriodos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].CantPeriodos = value;
               }
	          }
        public bool IsCantPeriodosNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].IsCantPeriodosNull();
             }
	        }
        public Int32 Ejercicios {
            get {
                if(((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0]["Ejercicios"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].Ejercicios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].Ejercicios = value;
               }
	          }
        public bool IsEjerciciosNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].IsEjerciciosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioPeriodoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conEjercicioPeriodoDS );
     }
     public conEjercicioPeriodoActionExchange() : base( "conEjercicioPeriodo" ) {
     }

     public conEjercicioPeriodoActionExchange(conEjercicioPeriodoActionEnum.EnumconEjercicioPeriodoAction pAccion) : base(conEjercicioPeriodoActionEnum.GetAccionconEjercicioPeriodoAction(pAccion)) {
     }

     public conEjercicioPeriodoActionExchange(conEjercicioPeriodoActionEnum.EnumconEjercicioPeriodoAction pAccion, ContabilidadCommon.conEjercicioPeriodoDS pdsParam) : base(conEjercicioPeriodoActionEnum.GetAccionconEjercicioPeriodoAction(pAccion), pdsParam) {
     }

     public conEjercicioPeriodoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conEjercicioPeriodoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public conEjercicioPeriodoActionExchange(ContabilidadCommon.conEjercicioPeriodoDS pDS) : base() {
     this.Action = "";
     this.mParam = new ContabilidadCommon.conEjercicioPeriodoDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conEjercicioPeriodoDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conEjercicioPeriodoDS)mParam;
	        }
     }
  }
}
