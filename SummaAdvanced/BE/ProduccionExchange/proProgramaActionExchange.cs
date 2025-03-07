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
    public class proProgramaActionExchange : Framework.Core.Exchange{

        public String Trabajo3_Id {
            get {
                if(((ProduccionCommon.proProgramaDS)mParam).Principal[0]["Trabajo3_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaDS)mParam).Principal[0].Trabajo3_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaDS)mParam).Principal[0].Trabajo3_Id = value;
               }
	          }
        public bool IsTrabajo3_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaDS)mParam).Principal[0].IsTrabajo3_IdNull();
             }
	        }
        public String DescripcionTrabajo3 {
            get {
                if(((ProduccionCommon.proProgramaDS)mParam).Principal[0]["DescripcionTrabajo3"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaDS)mParam).Principal[0].DescripcionTrabajo3;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaDS)mParam).Principal[0].DescripcionTrabajo3 = value;
               }
	          }
        public bool IsDescripcionTrabajo3Null {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaDS)mParam).Principal[0].IsDescripcionTrabajo3Null();
             }
	        }
        public String Proveedor_Id {
            get {
                if(((ProduccionCommon.proProgramaDS)mParam).Principal[0]["Proveedor_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaDS)mParam).Principal[0].Proveedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaDS)mParam).Principal[0].Proveedor_Id = value;
               }
	          }
        public bool IsProveedor_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaDS)mParam).Principal[0].IsProveedor_IdNull();
             }
	        }
        public String DescripcionProveedor {
            get {
                if(((ProduccionCommon.proProgramaDS)mParam).Principal[0]["DescripcionProveedor"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaDS)mParam).Principal[0].DescripcionProveedor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaDS)mParam).Principal[0].DescripcionProveedor = value;
               }
	          }
        public bool IsDescripcionProveedorNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaDS)mParam).Principal[0].IsDescripcionProveedorNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ProduccionCommon.proProgramaDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ProduccionCommon.proProgramaDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String PendHist {
            get {
                if(((ProduccionCommon.proProgramaDS)mParam).Principal[0]["PendHist"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaDS)mParam).Principal[0].PendHist;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaDS)mParam).Principal[0].PendHist = value;
               }
	          }
        public bool IsPendHistNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaDS)mParam).Principal[0].IsPendHistNull();
             }
	        }
        public Boolean SoloEnProd {
            get {
                if(((ProduccionCommon.proProgramaDS)mParam).Principal[0]["SoloEnProd"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaDS)mParam).Principal[0].SoloEnProd;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaDS)mParam).Principal[0].SoloEnProd = value;
               }
	          }
        public bool IsSoloEnProdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaDS)mParam).Principal[0].IsSoloEnProdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proProgramaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proProgramaDS );
     }
     public proProgramaActionExchange() : base( "proPrograma" ) {
     }

     public proProgramaActionExchange(proProgramaActionEnum.EnumproProgramaAction pAccion) : base(proProgramaActionEnum.GetAccionproProgramaAction(pAccion)) {
     }

     public proProgramaActionExchange(proProgramaActionEnum.EnumproProgramaAction pAccion, ProduccionCommon.proProgramaDS pdsParam) : base(proProgramaActionEnum.GetAccionproProgramaAction(pAccion), pdsParam) {
     }

     public proProgramaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proProgramaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proProgramaDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proProgramaDS)mParam;
	        }
     }
  }
}
