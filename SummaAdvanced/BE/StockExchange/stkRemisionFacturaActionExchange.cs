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
    public class stkRemisionFacturaActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String DescripcionSubTipoMov {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["DescripcionSubTipoMov"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].DescripcionSubTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].DescripcionSubTipoMov = value;
               }
	          }
        public bool IsDescripcionSubTipoMovNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsDescripcionSubTipoMovNull();
             }
	        }
        public DateTime FechaFactura {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["FechaFactura"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].FechaFactura;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].FechaFactura = value;
               }
	          }
        public bool IsFechaFacturaNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsFechaFacturaNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String NombreFantasia {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["NombreFantasia"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].NombreFantasia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].NombreFantasia = value;
               }
	          }
        public bool IsNombreFantasiaNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsNombreFantasiaNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListasPrecios {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["DescripcionListasPrecios"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].DescripcionListasPrecios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].DescripcionListasPrecios = value;
               }
	          }
        public bool IsDescripcionListasPreciosNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsDescripcionListasPreciosNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String DescripcionVendedores {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["DescripcionVendedores"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].DescripcionVendedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].DescripcionVendedores = value;
               }
	          }
        public bool IsDescripcionVendedoresNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsDescripcionVendedoresNull();
             }
	        }
        public String Observaciones {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public String Segmento_IdRem {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento_IdRem"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento_IdRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento_IdRem = value;
               }
	          }
        public bool IsSegmento_IdRemNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento_IdRemNull();
             }
	        }
        public Int32 Segmento1NRem {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento1NRem"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento1NRem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento1NRem = value;
               }
	          }
        public bool IsSegmento1NRemNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento1NRemNull();
             }
	        }
        public Int32 Segmento2NRem {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento2NRem"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento2NRem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento2NRem = value;
               }
	          }
        public bool IsSegmento2NRemNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento2NRemNull();
             }
	        }
        public Int32 Segmento3NRem {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento3NRem"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento3NRem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento3NRem = value;
               }
	          }
        public bool IsSegmento3NRemNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento3NRemNull();
             }
	        }
        public Int32 Segmento4NRem {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento4NRem"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento4NRem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento4NRem = value;
               }
	          }
        public bool IsSegmento4NRemNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento4NRemNull();
             }
	        }
        public String Segmento1CRem {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento1CRem"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento1CRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento1CRem = value;
               }
	          }
        public bool IsSegmento1CRemNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento1CRemNull();
             }
	        }
        public String Segmento2CRem {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento2CRem"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento2CRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento2CRem = value;
               }
	          }
        public bool IsSegmento2CRemNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento2CRemNull();
             }
	        }
        public String Segmento3CRem {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento3CRem"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento3CRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento3CRem = value;
               }
	          }
        public bool IsSegmento3CRemNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento3CRemNull();
             }
	        }
        public String Segmento4CRem {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Segmento4CRem"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento4CRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Segmento4CRem = value;
               }
	          }
        public bool IsSegmento4CRemNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsSegmento4CRemNull();
             }
	        }
        public String ArchivoPDFRem {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["ArchivoPDFRem"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].ArchivoPDFRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].ArchivoPDFRem = value;
               }
	          }
        public bool IsArchivoPDFRemNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsArchivoPDFRemNull();
             }
	        }
        public String ArchivoXMLRem {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["ArchivoXMLRem"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].ArchivoXMLRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].ArchivoXMLRem = value;
               }
	          }
        public bool IsArchivoXMLRemNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsArchivoXMLRemNull();
             }
	        }
        public String Tipomov {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Tipomov"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Tipomov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Tipomov = value;
               }
	          }
        public bool IsTipomovNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsTipomovNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String DescripcionFormaEntrega {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["DescripcionFormaEntrega"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].DescripcionFormaEntrega;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].DescripcionFormaEntrega = value;
               }
	          }
        public bool IsDescripcionFormaEntregaNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsDescripcionFormaEntregaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkRemisionFacturaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkRemisionFacturaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkRemisionFacturaDS );
     }
     public stkRemisionFacturaActionExchange() : base( "stkRemisionFactura" ) {
     }

     public stkRemisionFacturaActionExchange(stkRemisionFacturaActionEnum.EnumstkRemisionFacturaAction pAccion) : base(stkRemisionFacturaActionEnum.GetAccionstkRemisionFacturaAction(pAccion)) {
     }

     public stkRemisionFacturaActionExchange(stkRemisionFacturaActionEnum.EnumstkRemisionFacturaAction pAccion, StockCommon.stkRemisionFacturaDS pdsParam) : base(stkRemisionFacturaActionEnum.GetAccionstkRemisionFacturaAction(pAccion), pdsParam) {
     }

     public stkRemisionFacturaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkRemisionFacturaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkRemisionFacturaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkRemisionFacturaDS)mParam;
	        }
     }
  }
}
