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
    public class comMovProvRemiPendDatosRemiActionExchange : Framework.Core.Exchange{

        public Int32 Renglon {
            get {
                if(((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProducto {
            get {
                if(((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0]["DescripcionProducto"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].DescripcionProducto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].DescripcionProducto = value;
               }
	          }
        public bool IsDescripcionProductoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].IsDescripcionProductoNull();
             }
	        }
        public Decimal CantidadOriginal {
            get {
                if(((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0]["CantidadOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].CantidadOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].CantidadOriginal = value;
               }
	          }
        public bool IsCantidadOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].IsCantidadOriginalNull();
             }
	        }
        public Decimal PrecioOriginal {
            get {
                if(((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0]["PrecioOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].PrecioOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].PrecioOriginal = value;
               }
	          }
        public bool IsPrecioOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].IsPrecioOriginalNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal Factor {
            get {
                if(((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0]["Factor"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Factor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Factor = value;
               }
	          }
        public bool IsFactorNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].IsFactorNull();
             }
	        }
        public String SegmentoStr {
            get {
                if(((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0]["SegmentoStr"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].SegmentoStr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].SegmentoStr = value;
               }
	          }
        public bool IsSegmentoStrNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].IsSegmentoStrNull();
             }
	        }
        public Int64 stkMoviCabe {
            get {
                if(((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovProvRemiPendDatosRemiDS );
     }
     public comMovProvRemiPendDatosRemiActionExchange() : base( "comMovProvRemiPendDatosRemi" ) {
     }

     public comMovProvRemiPendDatosRemiActionExchange(comMovProvRemiPendDatosRemiActionEnum.EnumcomMovProvRemiPendDatosRemiAction pAccion) : base(comMovProvRemiPendDatosRemiActionEnum.GetAccioncomMovProvRemiPendDatosRemiAction(pAccion)) {
     }

     public comMovProvRemiPendDatosRemiActionExchange(comMovProvRemiPendDatosRemiActionEnum.EnumcomMovProvRemiPendDatosRemiAction pAccion, ComprasCommon.comMovProvRemiPendDatosRemiDS pdsParam) : base(comMovProvRemiPendDatosRemiActionEnum.GetAccioncomMovProvRemiPendDatosRemiAction(pAccion), pdsParam) {
     }

     public comMovProvRemiPendDatosRemiActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovProvRemiPendDatosRemiDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public comMovProvRemiPendDatosRemiActionExchange(ComprasCommon.comMovProvRemiPendDatosRemiDS pDS) : base() {
     this.Action = "";
     this.mParam = new ComprasCommon.comMovProvRemiPendDatosRemiDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovProvRemiPendDatosRemiDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovProvRemiPendDatosRemiDS)mParam;
	        }
     }
  }
}
