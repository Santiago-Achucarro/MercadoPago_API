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
    public class proRecetasTrabajo3ActionExchange : Framework.Core.Exchange{

        public String Receta_Id {
            get {
                if(((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0]["Receta_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].Receta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].Receta_Id = value;
               }
	          }
        public bool IsReceta_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].IsReceta_IdNull();
             }
	        }
        public String DescripcionRecetas {
            get {
                if(((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0]["DescripcionRecetas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].DescripcionRecetas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].DescripcionRecetas = value;
               }
	          }
        public bool IsDescripcionRecetasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].IsDescripcionRecetasNull();
             }
	        }
        public String Trabajo3_Id {
            get {
                if(((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0]["Trabajo3_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].Trabajo3_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].Trabajo3_Id = value;
               }
	          }
        public bool IsTrabajo3_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].IsTrabajo3_IdNull();
             }
	        }
        public String DescripcionTrabajo3 {
            get {
                if(((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0]["DescripcionTrabajo3"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].DescripcionTrabajo3;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].DescripcionTrabajo3 = value;
               }
	          }
        public bool IsDescripcionTrabajo3Null {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].IsDescripcionTrabajo3Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasTrabajo3DS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proRecetasTrabajo3DS );
     }
     public proRecetasTrabajo3ActionExchange() : base( "proRecetasTrabajo3" ) {
     }

     public proRecetasTrabajo3ActionExchange(proRecetasTrabajo3ActionEnum.EnumproRecetasTrabajo3Action pAccion) : base(proRecetasTrabajo3ActionEnum.GetAccionproRecetasTrabajo3Action(pAccion)) {
     }

     public proRecetasTrabajo3ActionExchange(proRecetasTrabajo3ActionEnum.EnumproRecetasTrabajo3Action pAccion, ProduccionCommon.proRecetasTrabajo3DS pdsParam) : base(proRecetasTrabajo3ActionEnum.GetAccionproRecetasTrabajo3Action(pAccion), pdsParam) {
     }

     public proRecetasTrabajo3ActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proRecetasTrabajo3DS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proRecetasTrabajo3DS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proRecetasTrabajo3DS)mParam;
	        }
     }
  }
}
