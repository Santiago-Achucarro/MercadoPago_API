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
    public class proMovCierreRecursosActionExchange : Framework.Core.Exchange{

        public Int64 proMovCierreOrden {
            get {
                if(((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0]["proMovCierreOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].proMovCierreOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].proMovCierreOrden = value;
               }
	          }
        public bool IsproMovCierreOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].IsproMovCierreOrdenNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Recurso_Id {
            get {
                if(((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0]["Recurso_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].Recurso_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].Recurso_Id = value;
               }
	          }
        public bool IsRecurso_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].IsRecurso_IdNull();
             }
	        }
        public String DescripcionRecursos {
            get {
                if(((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0]["DescripcionRecursos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].DescripcionRecursos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].DescripcionRecursos = value;
               }
	          }
        public bool IsDescripcionRecursosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].IsDescripcionRecursosNull();
             }
	        }
        public String SubRecurso_Id {
            get {
                if(((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0]["SubRecurso_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].SubRecurso_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].SubRecurso_Id = value;
               }
	          }
        public bool IsSubRecurso_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].IsSubRecurso_IdNull();
             }
	        }
        public String DescripcionSubRecurso {
            get {
                if(((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0]["DescripcionSubRecurso"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].DescripcionSubRecurso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].DescripcionSubRecurso = value;
               }
	          }
        public bool IsDescripcionSubRecursoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].IsDescripcionSubRecursoNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal Costo {
            get {
                if(((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0]["Costo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].Costo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].Costo = value;
               }
	          }
        public bool IsCostoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].IsCostoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreRecursosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proMovCierreRecursosDS );
     }
     public proMovCierreRecursosActionExchange() : base( "proMovCierreRecursos" ) {
     }

     public proMovCierreRecursosActionExchange(proMovCierreRecursosActionEnum.EnumproMovCierreRecursosAction pAccion) : base(proMovCierreRecursosActionEnum.GetAccionproMovCierreRecursosAction(pAccion)) {
     }

     public proMovCierreRecursosActionExchange(proMovCierreRecursosActionEnum.EnumproMovCierreRecursosAction pAccion, ProduccionCommon.proMovCierreRecursosDS pdsParam) : base(proMovCierreRecursosActionEnum.GetAccionproMovCierreRecursosAction(pAccion), pdsParam) {
     }

     public proMovCierreRecursosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proMovCierreRecursosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proMovCierreRecursosDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proMovCierreRecursosDS)mParam;
	        }
     }
  }
}
