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
    public class proTrabajo3ProvActionExchange : Framework.Core.Exchange{

        public String Trabajo3_Id {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["Trabajo3_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Trabajo3_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Trabajo3_Id = value;
               }
	          }
        public bool IsTrabajo3_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsTrabajo3_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String DescripcionProveed {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["DescripcionProveed"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].DescripcionProveed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].DescripcionProveed = value;
               }
	          }
        public bool IsDescripcionProveedNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsDescripcionProveedNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public Decimal Precio {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["Precio"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Precio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Precio = value;
               }
	          }
        public bool IsPrecioNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsPrecioNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Predeterminado {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["Predeterminado"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Predeterminado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Predeterminado = value;
               }
	          }
        public bool IsPredeterminadoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsPredeterminadoNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDeposito {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["DescripcionDeposito"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].DescripcionDeposito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].DescripcionDeposito = value;
               }
	          }
        public bool IsDescripcionDepositoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsDescripcionDepositoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proTrabajo3ProvDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proTrabajo3ProvDS );
     }
     public proTrabajo3ProvActionExchange() : base( "proTrabajo3Prov" ) {
     }

     public proTrabajo3ProvActionExchange(proTrabajo3ProvActionEnum.EnumproTrabajo3ProvAction pAccion) : base(proTrabajo3ProvActionEnum.GetAccionproTrabajo3ProvAction(pAccion)) {
     }

     public proTrabajo3ProvActionExchange(proTrabajo3ProvActionEnum.EnumproTrabajo3ProvAction pAccion, ProduccionCommon.proTrabajo3ProvDS pdsParam) : base(proTrabajo3ProvActionEnum.GetAccionproTrabajo3ProvAction(pAccion), pdsParam) {
     }

     public proTrabajo3ProvActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proTrabajo3ProvDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proTrabajo3ProvDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proTrabajo3ProvDS)mParam;
	        }
     }
  }
}
