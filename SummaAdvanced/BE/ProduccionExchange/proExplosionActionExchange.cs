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
    public class proExplosionActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((ProduccionCommon.proExplosionDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExplosionDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProducto {
            get {
                if(((ProduccionCommon.proExplosionDS)mParam).Principal[0]["DescripcionProducto"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExplosionDS)mParam).Principal[0].DescripcionProducto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExplosionDS)mParam).Principal[0].DescripcionProducto = value;
               }
	          }
        public bool IsDescripcionProductoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExplosionDS)mParam).Principal[0].IsDescripcionProductoNull();
             }
	        }
        public String Receta_Id {
            get {
                if(((ProduccionCommon.proExplosionDS)mParam).Principal[0]["Receta_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Receta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Receta_Id = value;
               }
	          }
        public bool IsReceta_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExplosionDS)mParam).Principal[0].IsReceta_IdNull();
             }
	        }
        public String DescripcionReceta {
            get {
                if(((ProduccionCommon.proExplosionDS)mParam).Principal[0]["DescripcionReceta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExplosionDS)mParam).Principal[0].DescripcionReceta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExplosionDS)mParam).Principal[0].DescripcionReceta = value;
               }
	          }
        public bool IsDescripcionRecetaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExplosionDS)mParam).Principal[0].IsDescripcionRecetaNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ProduccionCommon.proExplosionDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExplosionDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proExplosionDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExplosionDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean SoloFaltantes {
            get {
                if(((ProduccionCommon.proExplosionDS)mParam).Principal[0]["SoloFaltantes"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExplosionDS)mParam).Principal[0].SoloFaltantes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExplosionDS)mParam).Principal[0].SoloFaltantes = value;
               }
	          }
        public bool IsSoloFaltantesNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExplosionDS)mParam).Principal[0].IsSoloFaltantesNull();
             }
	        }
        public Decimal Costo {
            get {
                if(((ProduccionCommon.proExplosionDS)mParam).Principal[0]["Costo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Costo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Costo = value;
               }
	          }
        public bool IsCostoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExplosionDS)mParam).Principal[0].IsCostoNull();
             }
	        }
        public Boolean ConCorte {
            get {
                if(((ProduccionCommon.proExplosionDS)mParam).Principal[0]["ConCorte"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExplosionDS)mParam).Principal[0].ConCorte;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExplosionDS)mParam).Principal[0].ConCorte = value;
               }
	          }
        public bool IsConCorteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExplosionDS)mParam).Principal[0].IsConCorteNull();
             }
	        }
        public String Nivel {
            get {
                if(((ProduccionCommon.proExplosionDS)mParam).Principal[0]["Nivel"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Nivel;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Nivel = value;
               }
	          }
        public bool IsNivelNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExplosionDS)mParam).Principal[0].IsNivelNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proExplosionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proExplosionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proExplosionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proExplosionDS );
     }
     public proExplosionActionExchange() : base( "proExplosion" ) {
     }

     public proExplosionActionExchange(proExplosionActionEnum.EnumproExplosionAction pAccion) : base(proExplosionActionEnum.GetAccionproExplosionAction(pAccion)) {
     }

     public proExplosionActionExchange(proExplosionActionEnum.EnumproExplosionAction pAccion, ProduccionCommon.proExplosionDS pdsParam) : base(proExplosionActionEnum.GetAccionproExplosionAction(pAccion), pdsParam) {
     }

     public proExplosionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proExplosionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proExplosionDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proExplosionDS)mParam;
	        }
     }
  }
}
