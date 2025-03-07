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
    public class proOrdenTrabajos3ActionExchange : Framework.Core.Exchange{

        public Int32 proOrden {
            get {
                if(((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0]["proOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].proOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].proOrden = value;
               }
	          }
        public bool IsproOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].IsproOrdenNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Trabajo3_Id {
            get {
                if(((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0]["Trabajo3_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].Trabajo3_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].Trabajo3_Id = value;
               }
	          }
        public bool IsTrabajo3_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].IsTrabajo3_IdNull();
             }
	        }
        public String DescripcionTrabajo3 {
            get {
                if(((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0]["DescripcionTrabajo3"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].DescripcionTrabajo3;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].DescripcionTrabajo3 = value;
               }
	          }
        public bool IsDescripcionTrabajo3Null {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].IsDescripcionTrabajo3Null();
             }
	        }
        public String Proveed_Id {
            get {
                if(((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String DescripcionProveedor {
            get {
                if(((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0]["DescripcionProveedor"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].DescripcionProveedor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].DescripcionProveedor = value;
               }
	          }
        public bool IsDescripcionProveedorNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].IsDescripcionProveedorNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenTrabajos3DS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proOrdenTrabajos3DS );
     }
     public proOrdenTrabajos3ActionExchange() : base( "proOrdenTrabajos3" ) {
     }

     public proOrdenTrabajos3ActionExchange(proOrdenTrabajos3ActionEnum.EnumproOrdenTrabajos3Action pAccion) : base(proOrdenTrabajos3ActionEnum.GetAccionproOrdenTrabajos3Action(pAccion)) {
     }

     public proOrdenTrabajos3ActionExchange(proOrdenTrabajos3ActionEnum.EnumproOrdenTrabajos3Action pAccion, ProduccionCommon.proOrdenTrabajos3DS pdsParam) : base(proOrdenTrabajos3ActionEnum.GetAccionproOrdenTrabajos3Action(pAccion), pdsParam) {
     }

     public proOrdenTrabajos3ActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proOrdenTrabajos3DS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proOrdenTrabajos3DS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proOrdenTrabajos3DS)mParam;
	        }
     }
  }
}
