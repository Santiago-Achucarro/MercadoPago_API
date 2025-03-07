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
    public class stkMoviCuerpoActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Int32 RenglonReferencia {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["RenglonReferencia"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].RenglonReferencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].RenglonReferencia = value;
               }
	          }
        public bool IsRenglonReferenciaNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsRenglonReferenciaNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public Decimal Factor {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Factor"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Factor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Factor = value;
               }
	          }
        public bool IsFactorNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsFactorNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal CantidadForm {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["CantidadForm"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].CantidadForm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].CantidadForm = value;
               }
	          }
        public bool IsCantidadFormNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsCantidadFormNull();
             }
	        }
        public Decimal CostoUnitario {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["CostoUnitario"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].CostoUnitario;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].CostoUnitario = value;
               }
	          }
        public bool IsCostoUnitarioNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsCostoUnitarioNull();
             }
	        }
        public Decimal PrecioOriginal {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["PrecioOriginal"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].PrecioOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].PrecioOriginal = value;
               }
	          }
        public bool IsPrecioOriginalNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsPrecioOriginalNull();
             }
	        }
        public String MedidaAlterna {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["MedidaAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].MedidaAlterna;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].MedidaAlterna = value;
               }
	          }
        public bool IsMedidaAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsMedidaAlternaNull();
             }
	        }
        public String DescripcionMedidaAlterna {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["DescripcionMedidaAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionMedidaAlterna;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionMedidaAlterna = value;
               }
	          }
        public bool IsDescripcionMedidaAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDescripcionMedidaAlternaNull();
             }
	        }
        public Decimal CantidadAlternaForm {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["CantidadAlternaForm"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].CantidadAlternaForm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].CantidadAlternaForm = value;
               }
	          }
        public bool IsCantidadAlternaFormNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsCantidadAlternaFormNull();
             }
	        }
        public String Observaciones {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Decimal Descuento {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Descuento"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Descuento;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Descuento = value;
               }
	          }
        public bool IsDescuentoNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDescuentoNull();
             }
	        }
        public Int32 conRenglonDebe {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["conRenglonDebe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].conRenglonDebe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].conRenglonDebe = value;
               }
	          }
        public bool IsconRenglonDebeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsconRenglonDebeNull();
             }
	        }
        public String CuentaDebe {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["CuentaDebe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].CuentaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].CuentaDebe = value;
               }
	          }
        public bool IsCuentaDebeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsCuentaDebeNull();
             }
	        }
        public String DescripcionCuentaDebe {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["DescripcionCuentaDebe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCuentaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCuentaDebe = value;
               }
	          }
        public bool IsDescripcionCuentaDebeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDescripcionCuentaDebeNull();
             }
	        }
        public String Centro1Debe {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Centro1Debe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Centro1Debe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Centro1Debe = value;
               }
	          }
        public bool IsCentro1DebeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsCentro1DebeNull();
             }
	        }
        public String DescripcionCentro1Debe {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["DescripcionCentro1Debe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCentro1Debe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCentro1Debe = value;
               }
	          }
        public bool IsDescripcionCentro1DebeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDescripcionCentro1DebeNull();
             }
	        }
        public String Centro2Debe {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Centro2Debe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Centro2Debe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Centro2Debe = value;
               }
	          }
        public bool IsCentro2DebeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsCentro2DebeNull();
             }
	        }
        public String DescripcionCentro2Debe {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["DescripcionCentro2Debe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCentro2Debe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCentro2Debe = value;
               }
	          }
        public bool IsDescripcionCentro2DebeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDescripcionCentro2DebeNull();
             }
	        }
        public String ClaseDebe {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["ClaseDebe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].ClaseDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].ClaseDebe = value;
               }
	          }
        public bool IsClaseDebeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsClaseDebeNull();
             }
	        }
        public Decimal ImporteContableDebe {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["ImporteContableDebe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].ImporteContableDebe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].ImporteContableDebe = value;
               }
	          }
        public bool IsImporteContableDebeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsImporteContableDebeNull();
             }
	        }
        public Int32 conRenglonHaber {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["conRenglonHaber"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].conRenglonHaber;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].conRenglonHaber = value;
               }
	          }
        public bool IsconRenglonHaberNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsconRenglonHaberNull();
             }
	        }
        public String CuentaHaber {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["CuentaHaber"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].CuentaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].CuentaHaber = value;
               }
	          }
        public bool IsCuentaHaberNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsCuentaHaberNull();
             }
	        }
        public String DescripcionCuentaHaber {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["DescripcionCuentaHaber"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCuentaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCuentaHaber = value;
               }
	          }
        public bool IsDescripcionCuentaHaberNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDescripcionCuentaHaberNull();
             }
	        }
        public String Centro1Haber {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Centro1Haber"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Centro1Haber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Centro1Haber = value;
               }
	          }
        public bool IsCentro1HaberNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsCentro1HaberNull();
             }
	        }
        public String DescripcionCentro1Haber {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["DescripcionCentro1Haber"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCentro1Haber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCentro1Haber = value;
               }
	          }
        public bool IsDescripcionCentro1HaberNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDescripcionCentro1HaberNull();
             }
	        }
        public String Centro2Haber {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Centro2Haber"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Centro2Haber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Centro2Haber = value;
               }
	          }
        public bool IsCentro2HaberNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsCentro2HaberNull();
             }
	        }
        public String DescripcionCentro2Haber {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["DescripcionCentro2Haber"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCentro2Haber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].DescripcionCentro2Haber = value;
               }
	          }
        public bool IsDescripcionCentro2HaberNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDescripcionCentro2HaberNull();
             }
	        }
        public String ClaseHaber {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["ClaseHaber"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].ClaseHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].ClaseHaber = value;
               }
	          }
        public bool IsClaseHaberNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsClaseHaberNull();
             }
	        }
        public Decimal ImporteContableHaber {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["ImporteContableHaber"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].ImporteContableHaber;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].ImporteContableHaber = value;
               }
	          }
        public bool IsImporteContableHaberNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsImporteContableHaberNull();
             }
	        }
        public String Despacho_Id {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Despacho_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Despacho_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Despacho_Id = value;
               }
	          }
        public bool IsDespacho_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsDespacho_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviCuerpoDS );
     }
     public stkMoviCuerpoActionExchange() : base( "stkMoviCuerpo" ) {
     }

     public stkMoviCuerpoActionExchange(stkMoviCuerpoActionEnum.EnumstkMoviCuerpoAction pAccion) : base(stkMoviCuerpoActionEnum.GetAccionstkMoviCuerpoAction(pAccion)) {
     }

     public stkMoviCuerpoActionExchange(stkMoviCuerpoActionEnum.EnumstkMoviCuerpoAction pAccion, StockCommon.stkMoviCuerpoDS pdsParam) : base(stkMoviCuerpoActionEnum.GetAccionstkMoviCuerpoAction(pAccion), pdsParam) {
     }

     public stkMoviCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviCuerpoDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviCuerpoDS)mParam;
	        }
     }
  }
}
