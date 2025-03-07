using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proSubRecursosActionExchange : Framework.Core.Exchange{

        public Int32 proSubRecursos {
            get {
                if(((ProduccionCommon.proSubRecursosDS)mParam).Principal[0]["proSubRecursos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].proSubRecursos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].proSubRecursos = value;
               }
	          }
        public bool IsproSubRecursosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].IsproSubRecursosNull();
             }
	        }
        public String SubRecurso_Id {
            get {
                if(((ProduccionCommon.proSubRecursosDS)mParam).Principal[0]["SubRecurso_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].SubRecurso_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].SubRecurso_Id = value;
               }
	          }
        public bool IsSubRecurso_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].IsSubRecurso_IdNull();
             }
	        }
        public String SubRecurso_Id_Nueva {
            get {
                if(((ProduccionCommon.proSubRecursosDS)mParam).Principal[0]["SubRecurso_Id_Nueva"] != DBNull.Value  ){
                    return ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].SubRecurso_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].SubRecurso_Id_Nueva = value;
               }
	          }
        public bool IsSubRecurso_Id_NuevaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].IsSubRecurso_Id_NuevaNull();
             }
	        }
        public String Recurso_Id {
            get {
                if(((ProduccionCommon.proSubRecursosDS)mParam).Principal[0]["Recurso_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Recurso_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Recurso_Id = value;
               }
	          }
        public bool IsRecurso_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].IsRecurso_IdNull();
             }
	        }
        public String DescripcionRecursos {
            get {
                if(((ProduccionCommon.proSubRecursosDS)mParam).Principal[0]["DescripcionRecursos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].DescripcionRecursos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].DescripcionRecursos = value;
               }
	          }
        public bool IsDescripcionRecursosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].IsDescripcionRecursosNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ProduccionCommon.proSubRecursosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Decimal Capacidad {
            get {
                if(((ProduccionCommon.proSubRecursosDS)mParam).Principal[0]["Capacidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Capacidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Capacidad = value;
               }
	          }
        public bool IsCapacidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].IsCapacidadNull();
             }
	        }
        public Decimal Costo {
            get {
                if(((ProduccionCommon.proSubRecursosDS)mParam).Principal[0]["Costo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Costo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Costo = value;
               }
	          }
        public bool IsCostoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].IsCostoNull();
             }
	        }
        public Boolean Predeterminado {
            get {
                if(((ProduccionCommon.proSubRecursosDS)mParam).Principal[0]["Predeterminado"] != DBNull.Value  ){
                    return ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Predeterminado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Predeterminado = value;
               }
	          }
        public bool IsPredeterminadoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].IsPredeterminadoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ProduccionCommon.proSubRecursosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proSubRecursosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proSubRecursosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proSubRecursosDS );
     }
     public proSubRecursosActionExchange() : base( "proSubRecursos" ) {
     }

     public proSubRecursosActionExchange(proSubRecursosActionEnum.EnumproSubRecursosAction pAccion) : base(proSubRecursosActionEnum.GetAccionproSubRecursosAction(pAccion)) {
     }

     public proSubRecursosActionExchange(proSubRecursosActionEnum.EnumproSubRecursosAction pAccion, ProduccionCommon.proSubRecursosDS pdsParam) : base(proSubRecursosActionEnum.GetAccionproSubRecursosAction(pAccion), pdsParam) {
     }

     public proSubRecursosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proSubRecursosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proSubRecursosDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proSubRecursosDS)mParam;
	        }
     }
  }
}
