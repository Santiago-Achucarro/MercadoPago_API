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
    public class stkProductosActionExchange : Framework.Core.Exchange{

        public Int32 stkProductos {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["stkProductos"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].stkProductos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].stkProductos = value;
               }
	          }
        public bool IsstkProductosNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsstkProductosNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Producto_Id_Nueva {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Producto_Id_Nueva"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Producto_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Producto_Id_Nueva = value;
               }
	          }
        public bool IsProducto_Id_NuevaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsProducto_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String DescripcionDetallada {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionDetallada"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionDetallada;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionDetallada = value;
               }
	          }
        public bool IsDescripcionDetalladaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionDetalladaNull();
             }
	        }
        public String Description {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Description"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Description;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Description = value;
               }
	          }
        public bool IsDescriptionNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescriptionNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public String MedidaAlterna {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["MedidaAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].MedidaAlterna;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].MedidaAlterna = value;
               }
	          }
        public bool IsMedidaAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsMedidaAlternaNull();
             }
	        }
        public String DescripcionMedidaAlterna {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionMedidaAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionMedidaAlterna;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionMedidaAlterna = value;
               }
	          }
        public bool IsDescripcionMedidaAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionMedidaAlternaNull();
             }
	        }
        public Decimal FactorAlterna {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["FactorAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].FactorAlterna;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].FactorAlterna = value;
               }
	          }
        public bool IsFactorAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsFactorAlternaNull();
             }
	        }
        public String Clase {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public String ClaseAlterna {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["ClaseAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].ClaseAlterna;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].ClaseAlterna = value;
               }
	          }
        public bool IsClaseAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsClaseAlternaNull();
             }
	        }
        public String CodigoBarra {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CodigoBarra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CodigoBarra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CodigoBarra = value;
               }
	          }
        public bool IsCodigoBarraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCodigoBarraNull();
             }
	        }
        public String Tipo_Id {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Tipo_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Tipo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Tipo_Id = value;
               }
	          }
        public bool IsTipo_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsTipo_IdNull();
             }
	        }
        public String DescripcionTipos {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionTipos"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionTipos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionTipos = value;
               }
	          }
        public bool IsDescripcionTiposNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionTiposNull();
             }
	        }
        public String Familia_Id {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Familia_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Familia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Familia_Id = value;
               }
	          }
        public bool IsFamilia_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsFamilia_IdNull();
             }
	        }
        public String DescripcionFamilia {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionFamilia"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionFamilia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionFamilia = value;
               }
	          }
        public bool IsDescripcionFamiliaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionFamiliaNull();
             }
	        }
        public String Grupo_Id {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String DescripcionGrupo {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionGrupo"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionGrupo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionGrupo = value;
               }
	          }
        public bool IsDescripcionGrupoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionGrupoNull();
             }
	        }
        public Boolean TrabajaPorLotes {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["TrabajaPorLotes"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].TrabajaPorLotes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].TrabajaPorLotes = value;
               }
	          }
        public bool IsTrabajaPorLotesNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsTrabajaPorLotesNull();
             }
	        }
        public Boolean conVencimiento {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["conVencimiento"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].conVencimiento;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].conVencimiento = value;
               }
	          }
        public bool IsconVencimientoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsconVencimientoNull();
             }
	        }
        public Boolean Serializable {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Serializable"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Serializable;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Serializable = value;
               }
	          }
        public bool IsSerializableNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsSerializableNull();
             }
	        }
        public Boolean UsaDespachoImportacion {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["UsaDespachoImportacion"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].UsaDespachoImportacion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].UsaDespachoImportacion = value;
               }
	          }
        public bool IsUsaDespachoImportacionNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsUsaDespachoImportacionNull();
             }
	        }
        public String UmVenta {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["UmVenta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].UmVenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].UmVenta = value;
               }
	          }
        public bool IsUmVentaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsUmVentaNull();
             }
	        }
        public String DescripcionUmVenta {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionUmVenta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionUmVenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionUmVenta = value;
               }
	          }
        public bool IsDescripcionUmVentaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionUmVentaNull();
             }
	        }
        public Decimal CostoPromPond {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CostoPromPond"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CostoPromPond;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CostoPromPond = value;
               }
	          }
        public bool IsCostoPromPondNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCostoPromPondNull();
             }
	        }
        public Decimal CostoUltCompra {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CostoUltCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CostoUltCompra;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CostoUltCompra = value;
               }
	          }
        public bool IsCostoUltCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCostoUltCompraNull();
             }
	        }
        public Decimal CostoReposicion {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CostoReposicion"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CostoReposicion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CostoReposicion = value;
               }
	          }
        public bool IsCostoReposicionNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCostoReposicionNull();
             }
	        }
        public Decimal CostoStandard {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CostoStandard"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CostoStandard;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CostoStandard = value;
               }
	          }
        public bool IsCostoStandardNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCostoStandardNull();
             }
	        }
        public Decimal CostoUltimoCierre {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CostoUltimoCierre"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CostoUltimoCierre;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CostoUltimoCierre = value;
               }
	          }
        public bool IsCostoUltimoCierreNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCostoUltimoCierreNull();
             }
	        }
        public String MonedaUltCompra {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["MonedaUltCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].MonedaUltCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].MonedaUltCompra = value;
               }
	          }
        public bool IsMonedaUltCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsMonedaUltCompraNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public Decimal PrecioUltCompra {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["PrecioUltCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].PrecioUltCompra;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].PrecioUltCompra = value;
               }
	          }
        public bool IsPrecioUltCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsPrecioUltCompraNull();
             }
	        }
        public String UMCompra {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["UMCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].UMCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].UMCompra = value;
               }
	          }
        public bool IsUMCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsUMCompraNull();
             }
	        }
        public String DescripcionUMCompra {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionUMCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionUMCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionUMCompra = value;
               }
	          }
        public bool IsDescripcionUMCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionUMCompraNull();
             }
	        }
        public String CtaCompra {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CtaCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CtaCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CtaCompra = value;
               }
	          }
        public bool IsCtaCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCtaCompraNull();
             }
	        }
        public String DescripcionCtaCompra {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCtaCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaCompra = value;
               }
	          }
        public bool IsDescripcionCtaCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCtaCompraNull();
             }
	        }
        public String CtaAjuInventario {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CtaAjuInventario"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CtaAjuInventario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CtaAjuInventario = value;
               }
	          }
        public bool IsCtaAjuInventarioNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCtaAjuInventarioNull();
             }
	        }
        public String DescripcionCtaAjuInventario {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCtaAjuInventario"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaAjuInventario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaAjuInventario = value;
               }
	          }
        public bool IsDescripcionCtaAjuInventarioNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCtaAjuInventarioNull();
             }
	        }
        public String CtaVenta {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CtaVenta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CtaVenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CtaVenta = value;
               }
	          }
        public bool IsCtaVentaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCtaVentaNull();
             }
	        }
        public String DescripcionCtaVenta {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCtaVenta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaVenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaVenta = value;
               }
	          }
        public bool IsDescripcionCtaVentaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCtaVentaNull();
             }
	        }
        public String CtaCredito {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CtaCredito"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CtaCredito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CtaCredito = value;
               }
	          }
        public bool IsCtaCreditoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCtaCreditoNull();
             }
	        }
        public String DescripcionCtaCredito {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCtaCredito"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaCredito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaCredito = value;
               }
	          }
        public bool IsDescripcionCtaCreditoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCtaCreditoNull();
             }
	        }
        public String CtaDescuento {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CtaDescuento"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CtaDescuento;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CtaDescuento = value;
               }
	          }
        public bool IsCtaDescuentoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCtaDescuentoNull();
             }
	        }
        public String DescripcionCtaDescuento {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCtaDescuento"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaDescuento;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaDescuento = value;
               }
	          }
        public bool IsDescripcionCtaDescuentoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCtaDescuentoNull();
             }
	        }
        public String CtaCosto {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CtaCosto"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CtaCosto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CtaCosto = value;
               }
	          }
        public bool IsCtaCostoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCtaCostoNull();
             }
	        }
        public String DescripcionCtaCosto {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCtaCosto"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaCosto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaCosto = value;
               }
	          }
        public bool IsDescripcionCtaCostoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCtaCostoNull();
             }
	        }
        public String CtaVentaExt {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CtaVentaExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CtaVentaExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CtaVentaExt = value;
               }
	          }
        public bool IsCtaVentaExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCtaVentaExtNull();
             }
	        }
        public String DescripcionCtaVentaExt {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCtaVentaExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaVentaExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaVentaExt = value;
               }
	          }
        public bool IsDescripcionCtaVentaExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCtaVentaExtNull();
             }
	        }
        public String CtaCreditoExt {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CtaCreditoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CtaCreditoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CtaCreditoExt = value;
               }
	          }
        public bool IsCtaCreditoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCtaCreditoExtNull();
             }
	        }
        public String DescripcionCtaCreditoExt {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCtaCreditoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaCreditoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaCreditoExt = value;
               }
	          }
        public bool IsDescripcionCtaCreditoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCtaCreditoExtNull();
             }
	        }
        public String CtaDescuentoExt {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CtaDescuentoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CtaDescuentoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CtaDescuentoExt = value;
               }
	          }
        public bool IsCtaDescuentoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCtaDescuentoExtNull();
             }
	        }
        public String DescripcionCtaDescuentoExt {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCtaDescuentoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaDescuentoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaDescuentoExt = value;
               }
	          }
        public bool IsDescripcionCtaDescuentoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCtaDescuentoExtNull();
             }
	        }
        public String CtaCostoExt {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CtaCostoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CtaCostoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CtaCostoExt = value;
               }
	          }
        public bool IsCtaCostoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCtaCostoExtNull();
             }
	        }
        public String DescripcionCtaCostoExt {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCtaCostoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaCostoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaCostoExt = value;
               }
	          }
        public bool IsDescripcionCtaCostoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCtaCostoExtNull();
             }
	        }
        public DateTime Fcha_Ult_Compra {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Fcha_Ult_Compra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Fcha_Ult_Compra;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Fcha_Ult_Compra = value;
               }
	          }
        public bool IsFcha_Ult_CompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsFcha_Ult_CompraNull();
             }
	        }
        public Decimal MargenExceso {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["MargenExceso"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].MargenExceso;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].MargenExceso = value;
               }
	          }
        public bool IsMargenExcesoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsMargenExcesoNull();
             }
	        }
        public Int16 TiempoEntrega {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["TiempoEntrega"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].TiempoEntrega;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].TiempoEntrega = value;
               }
	          }
        public bool IsTiempoEntregaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsTiempoEntregaNull();
             }
	        }
        public Boolean Acepta_Ventas {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Acepta_Ventas"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Acepta_Ventas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Acepta_Ventas = value;
               }
	          }
        public bool IsAcepta_VentasNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsAcepta_VentasNull();
             }
	        }
        public String CFVenta_Id {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CFVenta_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CFVenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CFVenta_Id = value;
               }
	          }
        public bool IsCFVenta_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCFVenta_IdNull();
             }
	        }
        public String DescripcionCondFisVenta {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCondFisVenta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCondFisVenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCondFisVenta = value;
               }
	          }
        public bool IsDescripcionCondFisVentaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCondFisVentaNull();
             }
	        }
        public Boolean Acepta_Compras {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Acepta_Compras"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Acepta_Compras;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Acepta_Compras = value;
               }
	          }
        public bool IsAcepta_ComprasNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsAcepta_ComprasNull();
             }
	        }
        public String CFComp_Id {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CFComp_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CFComp_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CFComp_Id = value;
               }
	          }
        public bool IsCFComp_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCFComp_IdNull();
             }
	        }
        public String DescripcionCondFisCompra {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCondFisCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCondFisCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCondFisCompra = value;
               }
	          }
        public bool IsDescripcionCondFisCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCondFisCompraNull();
             }
	        }
        public Boolean Acepta_Comis_Vta {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Acepta_Comis_Vta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Acepta_Comis_Vta;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Acepta_Comis_Vta = value;
               }
	          }
        public bool IsAcepta_Comis_VtaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsAcepta_Comis_VtaNull();
             }
	        }
        public Int16 DiasGarantia {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DiasGarantia"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DiasGarantia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DiasGarantia = value;
               }
	          }
        public bool IsDiasGarantiaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDiasGarantiaNull();
             }
	        }
        public DateTime FechaUltModif {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["FechaUltModif"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].FechaUltModif;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].FechaUltModif = value;
               }
	          }
        public bool IsFechaUltModifNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsFechaUltModifNull();
             }
	        }
        public String ImagenExtension {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["ImagenExtension"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].ImagenExtension;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].ImagenExtension = value;
               }
	          }
        public bool IsImagenExtensionNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsImagenExtensionNull();
             }
	        }
        public String Imagen {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Imagen"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Imagen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Imagen = value;
               }
	          }
        public bool IsImagenNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsImagenNull();
             }
	        }
        public String CodigoFiscal {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CodigoFiscal"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CodigoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CodigoFiscal = value;
               }
	          }
        public bool IsCodigoFiscalNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCodigoFiscalNull();
             }
	        }
        public String FraccionArancelaria {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["FraccionArancelaria"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].FraccionArancelaria;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].FraccionArancelaria = value;
               }
	          }
        public bool IsFraccionArancelariaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsFraccionArancelariaNull();
             }
	        }
        public Boolean TieneMovimientos {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["TieneMovimientos"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].TieneMovimientos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].TieneMovimientos = value;
               }
	          }
        public bool IsTieneMovimientosNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsTieneMovimientosNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String CtaConsumo {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CtaConsumo"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CtaConsumo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CtaConsumo = value;
               }
	          }
        public bool IsCtaConsumoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCtaConsumoNull();
             }
	        }
        public String DescripcionCtaConsumo {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionCtaConsumo"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaConsumo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionCtaConsumo = value;
               }
	          }
        public bool IsDescripcionCtaConsumoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionCtaConsumoNull();
             }
	        }
        public String Plantilla_Id {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Plantilla_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Plantilla_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Plantilla_Id = value;
               }
	          }
        public bool IsPlantilla_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsPlantilla_IdNull();
             }
	        }
        public String DescripcionPlantilla {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["DescripcionPlantilla"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionPlantilla;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].DescripcionPlantilla = value;
               }
	          }
        public bool IsDescripcionPlantillaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsDescripcionPlantillaNull();
             }
	        }
        public String Observaciones {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String UrlProd {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["UrlProd"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].UrlProd;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].UrlProd = value;
               }
	          }
        public bool IsUrlProdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsUrlProdNull();
             }
	        }
        public String ClaveSTCC {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["ClaveSTCC"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].ClaveSTCC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].ClaveSTCC = value;
               }
	          }
        public bool IsClaveSTCCNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsClaveSTCCNull();
             }
	        }
        public Boolean MaterialPeligroso {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["MaterialPeligroso"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].MaterialPeligroso;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].MaterialPeligroso = value;
               }
	          }
        public bool IsMaterialPeligrosoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsMaterialPeligrosoNull();
             }
	        }
        public String CveMaterialPeligroso {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["CveMaterialPeligroso"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].CveMaterialPeligroso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].CveMaterialPeligroso = value;
               }
	          }
        public bool IsCveMaterialPeligrosoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsCveMaterialPeligrosoNull();
             }
	        }
        public String Embalaje {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Embalaje"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Embalaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Embalaje = value;
               }
	          }
        public bool IsEmbalajeNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsEmbalajeNull();
             }
	        }
        public Decimal PesoEnKg {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["PesoEnKg"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].PesoEnKg;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].PesoEnKg = value;
               }
	          }
        public bool IsPesoEnKgNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsPesoEnKgNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkProductosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkProductosDS );
     }
     public stkProductosActionExchange() : base( "stkProductos" ) {
     }

     public stkProductosActionExchange(stkProductosActionEnum.EnumstkProductosAction pAccion) : base(stkProductosActionEnum.GetAccionstkProductosAction(pAccion)) {
     }

     public stkProductosActionExchange(stkProductosActionEnum.EnumstkProductosAction pAccion, StockCommon.stkProductosDS pdsParam) : base(stkProductosActionEnum.GetAccionstkProductosAction(pAccion), pdsParam) {
     }

     public stkProductosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkProductosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkProductosActionExchange(StockCommon.stkProductosDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkProductosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkProductosDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkProductosDS)mParam;
	        }
     }
  }
}
