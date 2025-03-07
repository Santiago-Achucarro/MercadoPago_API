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
    public class proRecetasProdActionExchange : Framework.Core.Exchange{

        public String Receta_Id {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["Receta_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Receta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Receta_Id = value;
               }
	          }
        public bool IsReceta_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsReceta_IdNull();
             }
	        }
        public String DescripcionReceta {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["DescripcionReceta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].DescripcionReceta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].DescripcionReceta = value;
               }
	          }
        public bool IsDescripcionRecetaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsDescripcionRecetaNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProducto {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["DescripcionProducto"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].DescripcionProducto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].DescripcionProducto = value;
               }
	          }
        public bool IsDescripcionProductoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsDescripcionProductoNull();
             }
	        }
        public String EntradaSalida {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["EntradaSalida"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].EntradaSalida;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].EntradaSalida = value;
               }
	          }
        public bool IsEntradaSalidaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsEntradaSalidaNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionMedida_Id {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["DescripcionMedida_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].DescripcionMedida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].DescripcionMedida_Id = value;
               }
	          }
        public bool IsDescripcionMedida_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsDescripcionMedida_IdNull();
             }
	        }
        public String Formula {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["Formula"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Formula;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Formula = value;
               }
	          }
        public bool IsFormulaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsFormulaNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal PorcentajeCosto {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["PorcentajeCosto"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].PorcentajeCosto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].PorcentajeCosto = value;
               }
	          }
        public bool IsPorcentajeCostoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsPorcentajeCostoNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean TomaDepoT3 {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["TomaDepoT3"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].TomaDepoT3;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].TomaDepoT3 = value;
               }
	          }
        public bool IsTomaDepoT3Null {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsTomaDepoT3Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proRecetasProdDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasProdDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proRecetasProdDS );
     }
     public proRecetasProdActionExchange() : base( "proRecetasProd" ) {
     }

     public proRecetasProdActionExchange(proRecetasProdActionEnum.EnumproRecetasProdAction pAccion) : base(proRecetasProdActionEnum.GetAccionproRecetasProdAction(pAccion)) {
     }

     public proRecetasProdActionExchange(proRecetasProdActionEnum.EnumproRecetasProdAction pAccion, ProduccionCommon.proRecetasProdDS pdsParam) : base(proRecetasProdActionEnum.GetAccionproRecetasProdAction(pAccion), pdsParam) {
     }

     public proRecetasProdActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proRecetasProdDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proRecetasProdDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proRecetasProdDS)mParam;
	        }
     }
  }
}
