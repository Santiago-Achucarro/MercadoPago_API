using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venSubTipoMovActionExchange : Framework.Core.Exchange{

        public Int32 venSubTipoMov {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["venSubTipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].venSubTipoMov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].venSubTipoMov = value;
               }
	          }
        public bool IsvenSubTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsvenSubTipoMovNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String SubTipoMov_Id_Nueva {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["SubTipoMov_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].SubTipoMov_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].SubTipoMov_Id_Nueva = value;
               }
	          }
        public bool IsSubTipoMov_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsSubTipoMov_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Int16 Signo {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Signo"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Signo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Signo = value;
               }
	          }
        public bool IsSignoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsSignoNull();
             }
	        }
        public String TipoMovResumido {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["TipoMovResumido"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].TipoMovResumido;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].TipoMovResumido = value;
               }
	          }
        public bool IsTipoMovResumidoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsTipoMovResumidoNull();
             }
	        }
        public String venTipoMov {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["venTipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].venTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].venTipoMov = value;
               }
	          }
        public bool IsvenTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsvenTipoMovNull();
             }
	        }
        public String DescripcionTipoMov {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["DescripcionTipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionTipoMov = value;
               }
	          }
        public bool IsDescripcionTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsDescripcionTipoMovNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean MueveStock {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["MueveStock"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].MueveStock;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].MueveStock = value;
               }
	          }
        public bool IsMueveStockNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsMueveStockNull();
             }
	        }
        public Boolean EsVentaContado {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["EsVentaContado"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].EsVentaContado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].EsVentaContado = value;
               }
	          }
        public bool IsEsVentaContadoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsEsVentaContadoNull();
             }
	        }
        public Boolean AdmiteDevolucion {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["AdmiteDevolucion"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AdmiteDevolucion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AdmiteDevolucion = value;
               }
	          }
        public bool IsAdmiteDevolucionNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsAdmiteDevolucionNull();
             }
	        }
        public Boolean ModificaPrecio {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ModificaPrecio"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModificaPrecio;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModificaPrecio = value;
               }
	          }
        public bool IsModificaPrecioNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsModificaPrecioNull();
             }
	        }
        public Boolean Reservado {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Reservado"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Reservado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Reservado = value;
               }
	          }
        public bool IsReservadoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsReservadoNull();
             }
	        }
        public Boolean GeneraRemito {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["GeneraRemito"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].GeneraRemito;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].GeneraRemito = value;
               }
	          }
        public bool IsGeneraRemitoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsGeneraRemitoNull();
             }
	        }
        public String SegmentoRemito_Id {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["SegmentoRemito_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].SegmentoRemito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].SegmentoRemito_Id = value;
               }
	          }
        public bool IsSegmentoRemito_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsSegmentoRemito_IdNull();
             }
	        }
        public String DescripcionSegmentos {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["DescripcionSegmentos"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionSegmentos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionSegmentos = value;
               }
	          }
        public bool IsDescripcionSegmentosNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsDescripcionSegmentosNull();
             }
	        }
        public Boolean NCxDevolucion {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["NCxDevolucion"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].NCxDevolucion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].NCxDevolucion = value;
               }
	          }
        public bool IsNCxDevolucionNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsNCxDevolucionNull();
             }
	        }
        public String UsuarioAutorizado {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["UsuarioAutorizado"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].UsuarioAutorizado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].UsuarioAutorizado = value;
               }
	          }
        public bool IsUsuarioAutorizadoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsUsuarioAutorizadoNull();
             }
	        }
        public String DescripcionUsuarioAutorizado {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["DescripcionUsuarioAutorizado"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionUsuarioAutorizado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionUsuarioAutorizado = value;
               }
	          }
        public bool IsDescripcionUsuarioAutorizadoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsDescripcionUsuarioAutorizadoNull();
             }
	        }
        public Boolean AdmiteBoniRenglon {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["AdmiteBoniRenglon"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AdmiteBoniRenglon;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AdmiteBoniRenglon = value;
               }
	          }
        public bool IsAdmiteBoniRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsAdmiteBoniRenglonNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Boolean PideCambio {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PideCambio"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideCambio;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideCambio = value;
               }
	          }
        public bool IsPideCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPideCambioNull();
             }
	        }
        public Boolean ModFecha {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ModFecha"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModFecha;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModFecha = value;
               }
	          }
        public bool IsModFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsModFechaNull();
             }
	        }
        public Boolean ModCondPago {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ModCondPago"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModCondPago;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModCondPago = value;
               }
	          }
        public bool IsModCondPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsModCondPagoNull();
             }
	        }
        public Boolean ModVendedor {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ModVendedor"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModVendedor;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModVendedor = value;
               }
	          }
        public bool IsModVendedorNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsModVendedorNull();
             }
	        }
        public Boolean ModCobrador {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ModCobrador"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModCobrador;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModCobrador = value;
               }
	          }
        public bool IsModCobradorNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsModCobradorNull();
             }
	        }
        public Boolean PideObervaciones {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PideObervaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideObervaciones;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideObervaciones = value;
               }
	          }
        public bool IsPideObervacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPideObervacionesNull();
             }
	        }
        public Int16 CantidadCopias {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["CantidadCopias"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].CantidadCopias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].CantidadCopias = value;
               }
	          }
        public bool IsCantidadCopiasNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsCantidadCopiasNull();
             }
	        }
        public Boolean ModDeposito {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ModDeposito"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModDeposito;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModDeposito = value;
               }
	          }
        public bool IsModDepositoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsModDepositoNull();
             }
	        }
        public Boolean ModListaPrecios {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ModListaPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModListaPrecios;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModListaPrecios = value;
               }
	          }
        public bool IsModListaPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsModListaPreciosNull();
             }
	        }
        public Boolean PideFechaEntrega {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PideFechaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideFechaEntrega;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideFechaEntrega = value;
               }
	          }
        public bool IsPideFechaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPideFechaEntregaNull();
             }
	        }
        public Boolean PideObsReng {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PideObsReng"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideObsReng;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideObsReng = value;
               }
	          }
        public bool IsPideObsRengNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPideObsRengNull();
             }
	        }
        public String CtaDefecto {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["CtaDefecto"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].CtaDefecto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].CtaDefecto = value;
               }
	          }
        public bool IsCtaDefectoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsCtaDefectoNull();
             }
	        }
        public String DescripcionCtaDefecto {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["DescripcionCtaDefecto"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionCtaDefecto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionCtaDefecto = value;
               }
	          }
        public bool IsDescripcionCtaDefectoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsDescripcionCtaDefectoNull();
             }
	        }
        public Boolean ModCtaDefecto {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ModCtaDefecto"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModCtaDefecto;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModCtaDefecto = value;
               }
	          }
        public bool IsModCtaDefectoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsModCtaDefectoNull();
             }
	        }
        public Boolean ModCentro1 {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ModCentro1"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModCentro1;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModCentro1 = value;
               }
	          }
        public bool IsModCentro1Null {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsModCentro1Null();
             }
	        }
        public Boolean ModCentro2 {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ModCentro2"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModCentro2;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModCentro2 = value;
               }
	          }
        public bool IsModCentro2Null {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsModCentro2Null();
             }
	        }
        public Boolean PideOtrosCargos {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PideOtrosCargos"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideOtrosCargos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideOtrosCargos = value;
               }
	          }
        public bool IsPideOtrosCargosNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPideOtrosCargosNull();
             }
	        }
        public String CtaOtrosCargos {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["CtaOtrosCargos"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].CtaOtrosCargos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].CtaOtrosCargos = value;
               }
	          }
        public bool IsCtaOtrosCargosNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsCtaOtrosCargosNull();
             }
	        }
        public String DescripcionCtaOtrosCargos {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["DescripcionCtaOtrosCargos"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionCtaOtrosCargos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionCtaOtrosCargos = value;
               }
	          }
        public bool IsDescripcionCtaOtrosCargosNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsDescripcionCtaOtrosCargosNull();
             }
	        }
        public Boolean PermModCtaOtCar {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PermModCtaOtCar"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PermModCtaOtCar;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PermModCtaOtCar = value;
               }
	          }
        public bool IsPermModCtaOtCarNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPermModCtaOtCarNull();
             }
	        }
        public Boolean FechaEntregaporRen {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["FechaEntregaporRen"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].FechaEntregaporRen;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].FechaEntregaporRen = value;
               }
	          }
        public bool IsFechaEntregaporRenNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsFechaEntregaporRenNull();
             }
	        }
        public Boolean AdmiteFactsinEntr {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["AdmiteFactsinEntr"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AdmiteFactsinEntr;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AdmiteFactsinEntr = value;
               }
	          }
        public bool IsAdmiteFactsinEntrNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsAdmiteFactsinEntrNull();
             }
	        }
        public Boolean ModiUniMed {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ModiUniMed"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModiUniMed;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ModiUniMed = value;
               }
	          }
        public bool IsModiUniMedNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsModiUniMedNull();
             }
	        }
        public Boolean AfectaComVenta {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["AfectaComVenta"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AfectaComVenta;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AfectaComVenta = value;
               }
	          }
        public bool IsAfectaComVentaNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsAfectaComVentaNull();
             }
	        }
        public Boolean AfectaComCobra {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["AfectaComCobra"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AfectaComCobra;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AfectaComCobra = value;
               }
	          }
        public bool IsAfectaComCobraNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsAfectaComCobraNull();
             }
	        }
        public Int16 MaxCantItems {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["MaxCantItems"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].MaxCantItems;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].MaxCantItems = value;
               }
	          }
        public bool IsMaxCantItemsNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsMaxCantItemsNull();
             }
	        }
        public Boolean EsPorDifPrecio {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["EsPorDifPrecio"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].EsPorDifPrecio;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].EsPorDifPrecio = value;
               }
	          }
        public bool IsEsPorDifPrecioNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsEsPorDifPrecioNull();
             }
	        }
        public Boolean AfectaEstadistica {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["AfectaEstadistica"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AfectaEstadistica;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].AfectaEstadistica = value;
               }
	          }
        public bool IsAfectaEstadisticaNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsAfectaEstadisticaNull();
             }
	        }
        public String ClaveAcceso {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["ClaveAcceso"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ClaveAcceso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].ClaveAcceso = value;
               }
	          }
        public bool IsClaveAccesoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsClaveAccesoNull();
             }
	        }
        public Boolean EsPorDifCambio {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["EsPorDifCambio"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].EsPorDifCambio;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].EsPorDifCambio = value;
               }
	          }
        public bool IsEsPorDifCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsEsPorDifCambioNull();
             }
	        }
        public String TipoPrecioForm {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["TipoPrecioForm"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].TipoPrecioForm;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].TipoPrecioForm = value;
               }
	          }
        public bool IsTipoPrecioFormNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsTipoPrecioFormNull();
             }
	        }
        public Boolean SoloImpuestos {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["SoloImpuestos"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].SoloImpuestos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].SoloImpuestos = value;
               }
	          }
        public bool IsSoloImpuestosNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsSoloImpuestosNull();
             }
	        }
        public String CodigoFormulario {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["CodigoFormulario"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].CodigoFormulario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].CodigoFormulario = value;
               }
	          }
        public bool IsCodigoFormularioNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsCodigoFormularioNull();
             }
	        }
        public Boolean BajoCosto {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["BajoCosto"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].BajoCosto;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].BajoCosto = value;
               }
	          }
        public bool IsBajoCostoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsBajoCostoNull();
             }
	        }
        public Boolean Administrativa {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Administrativa"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Administrativa;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Administrativa = value;
               }
	          }
        public bool IsAdministrativaNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsAdministrativaNull();
             }
	        }
        public Boolean PideReferencia {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PideReferencia"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideReferencia;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideReferencia = value;
               }
	          }
        public bool IsPideReferenciaNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPideReferenciaNull();
             }
	        }
        public Boolean PideOrdenCompra {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PideOrdenCompra"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideOrdenCompra;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideOrdenCompra = value;
               }
	          }
        public bool IsPideOrdenCompraNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPideOrdenCompraNull();
             }
	        }
        public Boolean PideCongelarCambio {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PideCongelarCambio"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideCongelarCambio;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideCongelarCambio = value;
               }
	          }
        public bool IsPideCongelarCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPideCongelarCambioNull();
             }
	        }
        public Boolean PideMarcaReserva {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PideMarcaReserva"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideMarcaReserva;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideMarcaReserva = value;
               }
	          }
        public bool IsPideMarcaReservaNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPideMarcaReservaNull();
             }
	        }
        public Boolean PermiteSoloEntrega {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PermiteSoloEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PermiteSoloEntrega;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PermiteSoloEntrega = value;
               }
	          }
        public bool IsPermiteSoloEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPermiteSoloEntregaNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean PidePredial {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PidePredial"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PidePredial;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PidePredial = value;
               }
	          }
        public bool IsPidePredialNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPidePredialNull();
             }
	        }
        public Boolean PideCodProd {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PideCodProd"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideCodProd;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideCodProd = value;
               }
	          }
        public bool IsPideCodProdNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPideCodProdNull();
             }
	        }
        public Boolean PideComExpoMX {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PideComExpoMX"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideComExpoMX;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PideComExpoMX = value;
               }
	          }
        public bool IsPideComExpoMXNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPideComExpoMXNull();
             }
	        }
        public String CodigoFiscal {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["CodigoFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].CodigoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].CodigoFiscal = value;
               }
	          }
        public bool IsCodigoFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsCodigoFiscalNull();
             }
	        }
        public String Reporte_Id {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Reporte_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Reporte_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Reporte_Id = value;
               }
	          }
        public bool IsReporte_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsReporte_IdNull();
             }
	        }
        public String DescripcionReporte {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["DescripcionReporte"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionReporte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionReporte = value;
               }
	          }
        public bool IsDescripcionReporteNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsDescripcionReporteNull();
             }
	        }
        public String EsquemaAuto_Id {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["EsquemaAuto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].EsquemaAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].EsquemaAuto_Id = value;
               }
	          }
        public bool IsEsquemaAuto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsEsquemaAuto_IdNull();
             }
	        }
        public String DescripcionEsquemaAuto {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["DescripcionEsquemaAuto"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionEsquemaAuto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].DescripcionEsquemaAuto = value;
               }
	          }
        public bool IsDescripcionEsquemaAutoNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsDescripcionEsquemaAutoNull();
             }
	        }
        public Boolean PorCotizacion {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["PorCotizacion"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PorCotizacion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].PorCotizacion = value;
               }
	          }
        public bool IsPorCotizacionNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsPorCotizacionNull();
             }
	        }
        public Boolean UsaCartaPorte {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["UsaCartaPorte"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].UsaCartaPorte;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].UsaCartaPorte = value;
               }
	          }
        public bool IsUsaCartaPorteNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsUsaCartaPorteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venSubTipoMovDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venSubTipoMovDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venSubTipoMovDS );
     }
     public venSubTipoMovActionExchange() : base( "venSubTipoMov" ) {
     }

     public venSubTipoMovActionExchange(venSubTipoMovActionEnum.EnumvenSubTipoMovAction pAccion) : base(venSubTipoMovActionEnum.GetAccionvenSubTipoMovAction(pAccion)) {
     }

     public venSubTipoMovActionExchange(venSubTipoMovActionEnum.EnumvenSubTipoMovAction pAccion, VentasCommon.venSubTipoMovDS pdsParam) : base(venSubTipoMovActionEnum.GetAccionvenSubTipoMovAction(pAccion), pdsParam) {
     }

     public venSubTipoMovActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venSubTipoMovDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venSubTipoMovActionExchange(VentasCommon.venSubTipoMovDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venSubTipoMovDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venSubTipoMovDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venSubTipoMovDS)mParam;
	        }
     }
  }
}
