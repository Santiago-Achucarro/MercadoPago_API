using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comMovprovFactDifPrecRengActionExchange : Framework.Core.Exchange{

        public Int32 RenglonOrig {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["RenglonOrig"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].RenglonOrig;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].RenglonOrig = value;
               }
	          }
        public bool IsRenglonOrigNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsRenglonOrigNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String SegmentoStr {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["SegmentoStr"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].SegmentoStr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].SegmentoStr = value;
               }
	          }
        public bool IsSegmentoStrNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsSegmentoStrNull();
             }
	        }
        public Int32 ComordenComp {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["ComordenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].ComordenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].ComordenComp = value;
               }
	          }
        public bool IsComordenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsComordenCompNull();
             }
	        }
        public Int64 MovimientoOrig {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["MovimientoOrig"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].MovimientoOrig;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].MovimientoOrig = value;
               }
	          }
        public bool IsMovimientoOrigNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsMovimientoOrigNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Decimal CantidadOriginal {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["CantidadOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].CantidadOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].CantidadOriginal = value;
               }
	          }
        public bool IsCantidadOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsCantidadOriginalNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public Decimal Factor {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Factor"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Factor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Factor = value;
               }
	          }
        public bool IsFactorNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsFactorNull();
             }
	        }
        public Decimal PrecioOriginal {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["PrecioOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].PrecioOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].PrecioOriginal = value;
               }
	          }
        public bool IsPrecioOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsPrecioOriginalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovprovFactDifPrecRengDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovprovFactDifPrecRengDS );
     }
     public comMovprovFactDifPrecRengActionExchange() : base( "comMovprovFactDifPrecReng" ) {
     }

     public comMovprovFactDifPrecRengActionExchange(comMovprovFactDifPrecRengActionEnum.EnumcomMovprovFactDifPrecRengAction pAccion) : base(comMovprovFactDifPrecRengActionEnum.GetAccioncomMovprovFactDifPrecRengAction(pAccion)) {
     }

     public comMovprovFactDifPrecRengActionExchange(comMovprovFactDifPrecRengActionEnum.EnumcomMovprovFactDifPrecRengAction pAccion, ComprasCommon.comMovprovFactDifPrecRengDS pdsParam) : base(comMovprovFactDifPrecRengActionEnum.GetAccioncomMovprovFactDifPrecRengAction(pAccion), pdsParam) {
     }

     public comMovprovFactDifPrecRengActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovprovFactDifPrecRengDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovprovFactDifPrecRengDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovprovFactDifPrecRengDS)mParam;
	        }
     }
  }
}
