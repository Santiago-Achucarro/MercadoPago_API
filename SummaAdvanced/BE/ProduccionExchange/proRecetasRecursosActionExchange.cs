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
    public class proRecetasRecursosActionExchange : Framework.Core.Exchange{

        public String Receta_Id {
            get {
                if(((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0]["Receta_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].Receta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].Receta_Id = value;
               }
	          }
        public bool IsReceta_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].IsReceta_IdNull();
             }
	        }
        public String DescripcionRecetas {
            get {
                if(((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0]["DescripcionRecetas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].DescripcionRecetas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].DescripcionRecetas = value;
               }
	          }
        public bool IsDescripcionRecetasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].IsDescripcionRecetasNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Recurso_Id {
            get {
                if(((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0]["Recurso_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].Recurso_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].Recurso_Id = value;
               }
	          }
        public bool IsRecurso_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].IsRecurso_IdNull();
             }
	        }
        public String DescripcionRecursos {
            get {
                if(((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0]["DescripcionRecursos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].DescripcionRecursos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].DescripcionRecursos = value;
               }
	          }
        public bool IsDescripcionRecursosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].IsDescripcionRecursosNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasRecursosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proRecetasRecursosDS );
     }
     public proRecetasRecursosActionExchange() : base( "proRecetasRecursos" ) {
     }

     public proRecetasRecursosActionExchange(proRecetasRecursosActionEnum.EnumproRecetasRecursosAction pAccion) : base(proRecetasRecursosActionEnum.GetAccionproRecetasRecursosAction(pAccion)) {
     }

     public proRecetasRecursosActionExchange(proRecetasRecursosActionEnum.EnumproRecetasRecursosAction pAccion, ProduccionCommon.proRecetasRecursosDS pdsParam) : base(proRecetasRecursosActionEnum.GetAccionproRecetasRecursosAction(pAccion), pdsParam) {
     }

     public proRecetasRecursosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proRecetasRecursosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proRecetasRecursosDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proRecetasRecursosDS)mParam;
	        }
     }
  }
}
