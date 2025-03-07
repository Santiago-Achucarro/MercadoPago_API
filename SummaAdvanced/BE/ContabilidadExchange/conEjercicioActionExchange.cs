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
    public class conEjercicioActionExchange : Framework.Core.Exchange{

        public Int16 Ejercicio {
            get {
                if(((ContabilidadCommon.conEjercicioDS)mParam).Principal[0]["Ejercicio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].Ejercicio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].Ejercicio = value;
               }
	          }
        public bool IsEjercicioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].IsEjercicioNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ContabilidadCommon.conEjercicioDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conEjercicioDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conEjercicioDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conEjercicioDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conEjercicioDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conEjercicioDS );
     }
     public conEjercicioActionExchange() : base( "conEjercicio" ) {
     }

     public conEjercicioActionExchange(conEjercicioActionEnum.EnumconEjercicioAction pAccion) : base(conEjercicioActionEnum.GetAccionconEjercicioAction(pAccion)) {
     }

     public conEjercicioActionExchange(conEjercicioActionEnum.EnumconEjercicioAction pAccion, ContabilidadCommon.conEjercicioDS pdsParam) : base(conEjercicioActionEnum.GetAccionconEjercicioAction(pAccion), pdsParam) {
     }

     public conEjercicioActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conEjercicioDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conEjercicioDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conEjercicioDS)mParam;
	        }
     }
  }
}
