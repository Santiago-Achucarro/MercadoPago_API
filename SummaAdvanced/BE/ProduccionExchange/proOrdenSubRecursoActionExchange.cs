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
    public class proOrdenSubRecursoActionExchange : Framework.Core.Exchange{

        public Int32 proOrden {
            get {
                if(((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0]["proOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].proOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].proOrden = value;
               }
	          }
        public bool IsproOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].IsproOrdenNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String DescripcionOrdenRecursos {
            get {
                if(((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0]["DescripcionOrdenRecursos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].DescripcionOrdenRecursos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].DescripcionOrdenRecursos = value;
               }
	          }
        public bool IsDescripcionOrdenRecursosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].IsDescripcionOrdenRecursosNull();
             }
	        }
        public String SubRecurso_Id {
            get {
                if(((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0]["SubRecurso_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].SubRecurso_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].SubRecurso_Id = value;
               }
	          }
        public bool IsSubRecurso_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].IsSubRecurso_IdNull();
             }
	        }
        public String DescripcionSubRecursos {
            get {
                if(((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0]["DescripcionSubRecursos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].DescripcionSubRecursos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].DescripcionSubRecursos = value;
               }
	          }
        public bool IsDescripcionSubRecursosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].IsDescripcionSubRecursosNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenSubRecursoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proOrdenSubRecursoDS );
     }
     public proOrdenSubRecursoActionExchange() : base( "proOrdenSubRecurso" ) {
     }

     public proOrdenSubRecursoActionExchange(proOrdenSubRecursoActionEnum.EnumproOrdenSubRecursoAction pAccion) : base(proOrdenSubRecursoActionEnum.GetAccionproOrdenSubRecursoAction(pAccion)) {
     }

     public proOrdenSubRecursoActionExchange(proOrdenSubRecursoActionEnum.EnumproOrdenSubRecursoAction pAccion, ProduccionCommon.proOrdenSubRecursoDS pdsParam) : base(proOrdenSubRecursoActionEnum.GetAccionproOrdenSubRecursoAction(pAccion), pdsParam) {
     }

     public proOrdenSubRecursoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proOrdenSubRecursoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proOrdenSubRecursoDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proOrdenSubRecursoDS)mParam;
	        }
     }
  }
}
