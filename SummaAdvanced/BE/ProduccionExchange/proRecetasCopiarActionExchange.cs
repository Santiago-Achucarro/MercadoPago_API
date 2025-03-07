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
    public class proRecetasCopiarActionExchange : Framework.Core.Exchange{

        public String RecetaOrigen_Id {
            get {
                if(((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0]["RecetaOrigen_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].RecetaOrigen_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].RecetaOrigen_Id = value;
               }
	          }
        public bool IsRecetaOrigen_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].IsRecetaOrigen_IdNull();
             }
	        }
        public String DescripcionOrigen {
            get {
                if(((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0]["DescripcionOrigen"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].DescripcionOrigen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].DescripcionOrigen = value;
               }
	          }
        public bool IsDescripcionOrigenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].IsDescripcionOrigenNull();
             }
	        }
        public String RecetaDestino_Id {
            get {
                if(((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0]["RecetaDestino_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].RecetaDestino_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].RecetaDestino_Id = value;
               }
	          }
        public bool IsRecetaDestino_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].IsRecetaDestino_IdNull();
             }
	        }
        public String DescripcionDestino {
            get {
                if(((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0]["DescripcionDestino"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].DescripcionDestino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].DescripcionDestino = value;
               }
	          }
        public bool IsDescripcionDestinoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].IsDescripcionDestinoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasCopiarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proRecetasCopiarDS );
     }
     public proRecetasCopiarActionExchange() : base( "proRecetasCopiar" ) {
     }

     public proRecetasCopiarActionExchange(proRecetasCopiarActionEnum.EnumproRecetasCopiarAction pAccion) : base(proRecetasCopiarActionEnum.GetAccionproRecetasCopiarAction(pAccion)) {
     }

     public proRecetasCopiarActionExchange(proRecetasCopiarActionEnum.EnumproRecetasCopiarAction pAccion, ProduccionCommon.proRecetasCopiarDS pdsParam) : base(proRecetasCopiarActionEnum.GetAccionproRecetasCopiarAction(pAccion), pdsParam) {
     }

     public proRecetasCopiarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proRecetasCopiarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proRecetasCopiarDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proRecetasCopiarDS)mParam;
	        }
     }
  }
}
