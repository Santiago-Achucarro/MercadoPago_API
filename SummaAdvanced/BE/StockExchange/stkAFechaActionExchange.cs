using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkAFechaActionExchange : Framework.Core.Exchange{

        public Int32 stkInventarios {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["stkInventarios"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].stkInventarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].stkInventarios = value;
               }
	          }
        public bool IsstkInventariosNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsstkInventariosNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal CantidadAlterna {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["CantidadAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].CantidadAlterna;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].CantidadAlterna = value;
               }
	          }
        public bool IsCantidadAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsCantidadAlternaNull();
             }
	        }
        public String ClaseAlterna {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["ClaseAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].ClaseAlterna;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].ClaseAlterna = value;
               }
	          }
        public bool IsClaseAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsClaseAlternaNull();
             }
	        }
        public Boolean UsaDespachoImportacion {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["UsaDespachoImportacion"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].UsaDespachoImportacion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].UsaDespachoImportacion = value;
               }
	          }
        public bool IsUsaDespachoImportacionNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsUsaDespachoImportacionNull();
             }
	        }
        public Boolean Serializable {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["Serializable"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].Serializable;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].Serializable = value;
               }
	          }
        public bool IsSerializableNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsSerializableNull();
             }
	        }
        public Boolean TrabajaPorLotes {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["TrabajaPorLotes"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].TrabajaPorLotes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].TrabajaPorLotes = value;
               }
	          }
        public bool IsTrabajaPorLotesNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsTrabajaPorLotesNull();
             }
	        }
        public Boolean conVencimiento {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["conVencimiento"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].conVencimiento;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].conVencimiento = value;
               }
	          }
        public bool IsconVencimientoNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsconVencimientoNull();
             }
	        }
        public Decimal CantidadStk {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["CantidadStk"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].CantidadStk;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].CantidadStk = value;
               }
	          }
        public bool IsCantidadStkNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsCantidadStkNull();
             }
	        }
        public Decimal CantidadAternaStk {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["CantidadAternaStk"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].CantidadAternaStk;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].CantidadAternaStk = value;
               }
	          }
        public bool IsCantidadAternaStkNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsCantidadAternaStkNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkAFechaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkAFechaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAFechaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkAFechaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkAFechaDS );
     }
     public stkAFechaActionExchange() : base( "stkAFecha" ) {
     }

     public stkAFechaActionExchange(stkAFechaActionEnum.EnumstkAFechaAction pAccion) : base(stkAFechaActionEnum.GetAccionstkAFechaAction(pAccion)) {
     }

     public stkAFechaActionExchange(stkAFechaActionEnum.EnumstkAFechaAction pAccion, StockCommon.stkAFechaDS pdsParam) : base(stkAFechaActionEnum.GetAccionstkAFechaAction(pAccion), pdsParam) {
     }

     public stkAFechaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkAFechaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkAFechaActionExchange(StockCommon.stkAFechaDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkAFechaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkAFechaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkAFechaDS)mParam;
	        }
     }
  }
}
