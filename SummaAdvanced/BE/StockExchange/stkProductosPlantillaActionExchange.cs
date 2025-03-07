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
    public class stkProductosPlantillaActionExchange : Framework.Core.Exchange{

        public Int32 stkProductosPlantilla {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["stkProductosPlantilla"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].stkProductosPlantilla;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].stkProductosPlantilla = value;
               }
	          }
        public bool IsstkProductosPlantillaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsstkProductosPlantillaNull();
             }
	        }
        public String Plantilla_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Plantilla_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Plantilla_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Plantilla_Id = value;
               }
	          }
        public bool IsPlantilla_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsPlantilla_IdNull();
             }
	        }
        public String Plantilla_Id_Nueva {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Plantilla_Id_Nueva"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Plantilla_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Plantilla_Id_Nueva = value;
               }
	          }
        public bool IsPlantilla_Id_NuevaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsPlantilla_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public String MedidaAlterna {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["MedidaAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].MedidaAlterna;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].MedidaAlterna = value;
               }
	          }
        public bool IsMedidaAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsMedidaAlternaNull();
             }
	        }
        public String DescripcionMedidaAlterna {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionMedidaAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionMedidaAlterna;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionMedidaAlterna = value;
               }
	          }
        public bool IsDescripcionMedidaAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionMedidaAlternaNull();
             }
	        }
        public Decimal FactorAlterna {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["FactorAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].FactorAlterna;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].FactorAlterna = value;
               }
	          }
        public bool IsFactorAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsFactorAlternaNull();
             }
	        }
        public String Clase {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public String ClaseAlterna {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["ClaseAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].ClaseAlterna;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].ClaseAlterna = value;
               }
	          }
        public bool IsClaseAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsClaseAlternaNull();
             }
	        }
        public String Tipo_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Tipo_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Tipo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Tipo_Id = value;
               }
	          }
        public bool IsTipo_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsTipo_IdNull();
             }
	        }
        public String DescripcionTipos {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionTipos"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionTipos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionTipos = value;
               }
	          }
        public bool IsDescripcionTiposNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionTiposNull();
             }
	        }
        public String Familia_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Familia_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Familia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Familia_Id = value;
               }
	          }
        public bool IsFamilia_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsFamilia_IdNull();
             }
	        }
        public String DescripcionFamilias {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionFamilias"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionFamilias;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionFamilias = value;
               }
	          }
        public bool IsDescripcionFamiliasNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionFamiliasNull();
             }
	        }
        public String Grupo_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String DescripcionGrupos {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionGrupos"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionGrupos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionGrupos = value;
               }
	          }
        public bool IsDescripcionGruposNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionGruposNull();
             }
	        }
        public Boolean TrabajaPorLotes {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["TrabajaPorLotes"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].TrabajaPorLotes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].TrabajaPorLotes = value;
               }
	          }
        public bool IsTrabajaPorLotesNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsTrabajaPorLotesNull();
             }
	        }
        public Boolean conVencimiento {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["conVencimiento"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].conVencimiento;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].conVencimiento = value;
               }
	          }
        public bool IsconVencimientoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsconVencimientoNull();
             }
	        }
        public Boolean Serializable {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Serializable"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Serializable;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Serializable = value;
               }
	          }
        public bool IsSerializableNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsSerializableNull();
             }
	        }
        public Boolean UsaDespachoImportacion {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["UsaDespachoImportacion"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].UsaDespachoImportacion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].UsaDespachoImportacion = value;
               }
	          }
        public bool IsUsaDespachoImportacionNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsUsaDespachoImportacionNull();
             }
	        }
        public String UMCompra_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["UMCompra_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].UMCompra_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].UMCompra_Id = value;
               }
	          }
        public bool IsUMCompra_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsUMCompra_IdNull();
             }
	        }
        public String DescripcionUMCompra {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionUMCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionUMCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionUMCompra = value;
               }
	          }
        public bool IsDescripcionUMCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionUMCompraNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String UMVenta_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["UMVenta_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].UMVenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].UMVenta_Id = value;
               }
	          }
        public bool IsUMVenta_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsUMVenta_IdNull();
             }
	        }
        public String DescripcionUMVenta {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionUMVenta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionUMVenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionUMVenta = value;
               }
	          }
        public bool IsDescripcionUMVentaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionUMVentaNull();
             }
	        }
        public String CtaCompra {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CtaCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaCompra = value;
               }
	          }
        public bool IsCtaCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCtaCompraNull();
             }
	        }
        public String DescripcionCtaCompra {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCtaCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaCompra = value;
               }
	          }
        public bool IsDescripcionCtaCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCtaCompraNull();
             }
	        }
        public String CtaAjuInventario {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CtaAjuInventario"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaAjuInventario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaAjuInventario = value;
               }
	          }
        public bool IsCtaAjuInventarioNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCtaAjuInventarioNull();
             }
	        }
        public String DescripcionCtaAjuInventario {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCtaAjuInventario"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaAjuInventario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaAjuInventario = value;
               }
	          }
        public bool IsDescripcionCtaAjuInventarioNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCtaAjuInventarioNull();
             }
	        }
        public String CtaVenta {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CtaVenta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaVenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaVenta = value;
               }
	          }
        public bool IsCtaVentaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCtaVentaNull();
             }
	        }
        public String DescripcionCtaVenta {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCtaVenta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaVenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaVenta = value;
               }
	          }
        public bool IsDescripcionCtaVentaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCtaVentaNull();
             }
	        }
        public String CtaCredito {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CtaCredito"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaCredito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaCredito = value;
               }
	          }
        public bool IsCtaCreditoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCtaCreditoNull();
             }
	        }
        public String DescripcionCtaCredito {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCtaCredito"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaCredito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaCredito = value;
               }
	          }
        public bool IsDescripcionCtaCreditoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCtaCreditoNull();
             }
	        }
        public String CtaDescuento {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CtaDescuento"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaDescuento;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaDescuento = value;
               }
	          }
        public bool IsCtaDescuentoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCtaDescuentoNull();
             }
	        }
        public String DescripcionCtaDescuento {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCtaDescuento"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaDescuento;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaDescuento = value;
               }
	          }
        public bool IsDescripcionCtaDescuentoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCtaDescuentoNull();
             }
	        }
        public String CtaCosto {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CtaCosto"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaCosto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaCosto = value;
               }
	          }
        public bool IsCtaCostoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCtaCostoNull();
             }
	        }
        public String DescripcionCtaCosto {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCtaCosto"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaCosto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaCosto = value;
               }
	          }
        public bool IsDescripcionCtaCostoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCtaCostoNull();
             }
	        }
        public String CtaVentasExt {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CtaVentasExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaVentasExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaVentasExt = value;
               }
	          }
        public bool IsCtaVentasExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCtaVentasExtNull();
             }
	        }
        public String DescripcionCtaVentasExt {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCtaVentasExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaVentasExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaVentasExt = value;
               }
	          }
        public bool IsDescripcionCtaVentasExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCtaVentasExtNull();
             }
	        }
        public String CtaCreditoExt {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CtaCreditoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaCreditoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaCreditoExt = value;
               }
	          }
        public bool IsCtaCreditoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCtaCreditoExtNull();
             }
	        }
        public String DescripcionCtaCreditoExt {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCtaCreditoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaCreditoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaCreditoExt = value;
               }
	          }
        public bool IsDescripcionCtaCreditoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCtaCreditoExtNull();
             }
	        }
        public String CtaDescuentoExt {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CtaDescuentoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaDescuentoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaDescuentoExt = value;
               }
	          }
        public bool IsCtaDescuentoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCtaDescuentoExtNull();
             }
	        }
        public String DescripcionCtaDescuentoExt {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCtaDescuentoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaDescuentoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaDescuentoExt = value;
               }
	          }
        public bool IsDescripcionCtaDescuentoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCtaDescuentoExtNull();
             }
	        }
        public String CtaCostoExt {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CtaCostoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaCostoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaCostoExt = value;
               }
	          }
        public bool IsCtaCostoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCtaCostoExtNull();
             }
	        }
        public String DescripcionCtaCostoExt {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCtaCostoExt"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaCostoExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaCostoExt = value;
               }
	          }
        public bool IsDescripcionCtaCostoExtNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCtaCostoExtNull();
             }
	        }
        public Decimal MargenExceso {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["MargenExceso"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].MargenExceso;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].MargenExceso = value;
               }
	          }
        public bool IsMargenExcesoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsMargenExcesoNull();
             }
	        }
        public Int16 TiempoEntrega {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["TiempoEntrega"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].TiempoEntrega;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].TiempoEntrega = value;
               }
	          }
        public bool IsTiempoEntregaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsTiempoEntregaNull();
             }
	        }
        public Boolean Acepta_Ventas {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Acepta_Ventas"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Acepta_Ventas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Acepta_Ventas = value;
               }
	          }
        public bool IsAcepta_VentasNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsAcepta_VentasNull();
             }
	        }
        public String CFVenta_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CFVenta_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CFVenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CFVenta_Id = value;
               }
	          }
        public bool IsCFVenta_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCFVenta_IdNull();
             }
	        }
        public String DescripcionCondFisVenta {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCondFisVenta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCondFisVenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCondFisVenta = value;
               }
	          }
        public bool IsDescripcionCondFisVentaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCondFisVentaNull();
             }
	        }
        public Boolean Acepta_Compras {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Acepta_Compras"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Acepta_Compras;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Acepta_Compras = value;
               }
	          }
        public bool IsAcepta_ComprasNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsAcepta_ComprasNull();
             }
	        }
        public String CFComp_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CFComp_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CFComp_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CFComp_Id = value;
               }
	          }
        public bool IsCFComp_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCFComp_IdNull();
             }
	        }
        public String DescripcionCondFisCompra {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCondFisCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCondFisCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCondFisCompra = value;
               }
	          }
        public bool IsDescripcionCondFisCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCondFisCompraNull();
             }
	        }
        public Boolean Acepta_Comis_Vta {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Acepta_Comis_Vta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Acepta_Comis_Vta;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Acepta_Comis_Vta = value;
               }
	          }
        public bool IsAcepta_Comis_VtaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsAcepta_Comis_VtaNull();
             }
	        }
        public Int16 DiasGarantia {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DiasGarantia"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DiasGarantia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DiasGarantia = value;
               }
	          }
        public bool IsDiasGarantiaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDiasGarantiaNull();
             }
	        }
        public String CodigoFiscal {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CodigoFiscal"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CodigoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CodigoFiscal = value;
               }
	          }
        public bool IsCodigoFiscalNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCodigoFiscalNull();
             }
	        }
        public String FraccionArancelaria {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["FraccionArancelaria"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].FraccionArancelaria;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].FraccionArancelaria = value;
               }
	          }
        public bool IsFraccionArancelariaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsFraccionArancelariaNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String CtaConsumo {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["CtaConsumo"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaConsumo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].CtaConsumo = value;
               }
	          }
        public bool IsCtaConsumoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsCtaConsumoNull();
             }
	        }
        public String DescripcionCtaConsumo {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["DescripcionCtaConsumo"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaConsumo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].DescripcionCtaConsumo = value;
               }
	          }
        public bool IsDescripcionCtaConsumoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsDescripcionCtaConsumoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkProductosPlantillaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosPlantillaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkProductosPlantillaDS );
     }
     public stkProductosPlantillaActionExchange() : base( "stkProductosPlantilla" ) {
     }

     public stkProductosPlantillaActionExchange(stkProductosPlantillaActionEnum.EnumstkProductosPlantillaAction pAccion) : base(stkProductosPlantillaActionEnum.GetAccionstkProductosPlantillaAction(pAccion)) {
     }

     public stkProductosPlantillaActionExchange(stkProductosPlantillaActionEnum.EnumstkProductosPlantillaAction pAccion, StockCommon.stkProductosPlantillaDS pdsParam) : base(stkProductosPlantillaActionEnum.GetAccionstkProductosPlantillaAction(pAccion), pdsParam) {
     }

     public stkProductosPlantillaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkProductosPlantillaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkProductosPlantillaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkProductosPlantillaDS)mParam;
	        }
     }
  }
}
