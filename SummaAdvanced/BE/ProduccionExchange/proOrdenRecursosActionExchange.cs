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
    public class proOrdenRecursosActionExchange : Framework.Core.Exchange{

        public Int32 proOrden {
            get {
                if(((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0]["proOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].proOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].proOrden = value;
               }
	          }
        public bool IsproOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].IsproOrdenNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Recurso_Id {
            get {
                if(((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0]["Recurso_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].Recurso_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].Recurso_Id = value;
               }
	          }
        public bool IsRecurso_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].IsRecurso_IdNull();
             }
	        }
        public String DescripcionRecursos {
            get {
                if(((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0]["DescripcionRecursos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].DescripcionRecursos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].DescripcionRecursos = value;
               }
	          }
        public bool IsDescripcionRecursosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].IsDescripcionRecursosNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenRecursosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proOrdenRecursosDS );
     }
     public proOrdenRecursosActionExchange() : base( "proOrdenRecursos" ) {
     }

     public proOrdenRecursosActionExchange(proOrdenRecursosActionEnum.EnumproOrdenRecursosAction pAccion) : base(proOrdenRecursosActionEnum.GetAccionproOrdenRecursosAction(pAccion)) {
     }

     public proOrdenRecursosActionExchange(proOrdenRecursosActionEnum.EnumproOrdenRecursosAction pAccion, ProduccionCommon.proOrdenRecursosDS pdsParam) : base(proOrdenRecursosActionEnum.GetAccionproOrdenRecursosAction(pAccion), pdsParam) {
     }

     public proOrdenRecursosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proOrdenRecursosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proOrdenRecursosDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proOrdenRecursosDS)mParam;
	        }
     }
  }
}
