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
    public class venConsEdoCtaClientesActionExchange : Framework.Core.Exchange{

        public String Cliente_Id {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 PendHist {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["PendHist"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].PendHist;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].PendHist = value;
               }
	          }
        public bool IsPendHistNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsPendHistNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Int32 Empresa {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Empresa"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Empresa;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Empresa = value;
               }
	          }
        public bool IsEmpresaNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsEmpresaNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public DateTime FechaAplicacion {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["FechaAplicacion"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].FechaAplicacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].FechaAplicacion = value;
               }
	          }
        public bool IsFechaAplicacionNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsFechaAplicacionNull();
             }
	        }
        public Boolean Consolidados {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Consolidados"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Consolidados;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Consolidados = value;
               }
	          }
        public bool IsConsolidadosNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsConsolidadosNull();
             }
	        }
        public String Cliente_Id1 {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Cliente_Id1"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Cliente_Id1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Cliente_Id1 = value;
               }
	          }
        public bool IsCliente_Id1Null {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsCliente_Id1Null();
             }
	        }
        public String RazonSocial1 {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["RazonSocial1"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].RazonSocial1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].RazonSocial1 = value;
               }
	          }
        public bool IsRazonSocial1Null {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsRazonSocial1Null();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String DireccionEntrega {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["DireccionEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].DireccionEntrega;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].DireccionEntrega = value;
               }
	          }
        public bool IsDireccionEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsDireccionEntregaNull();
             }
	        }
        public String DireccionFacturacion {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["DireccionFacturacion"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].DireccionFacturacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].DireccionFacturacion = value;
               }
	          }
        public bool IsDireccionFacturacionNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsDireccionFacturacionNull();
             }
	        }
        public String Telefonos {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Telefonos"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Telefonos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Telefonos = value;
               }
	          }
        public bool IsTelefonosNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsTelefonosNull();
             }
	        }
        public String EMail {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["EMail"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].EMail;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].EMail = value;
               }
	          }
        public bool IsEMailNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsEMailNull();
             }
	        }
        public String Cuit {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Cuit"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Cuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Cuit = value;
               }
	          }
        public bool IsCuitNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsCuitNull();
             }
	        }
        public String Fax {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Fax"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Fax;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Fax = value;
               }
	          }
        public bool IsFaxNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsFaxNull();
             }
	        }
        public String CobradorAsignado {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["CobradorAsignado"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].CobradorAsignado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].CobradorAsignado = value;
               }
	          }
        public bool IsCobradorAsignadoNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsCobradorAsignadoNull();
             }
	        }
        public String VendedorAsignado {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["VendedorAsignado"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].VendedorAsignado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].VendedorAsignado = value;
               }
	          }
        public bool IsVendedorAsignadoNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsVendedorAsignadoNull();
             }
	        }
        public String Zona_Id {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Zona_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Zona_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Zona_Id = value;
               }
	          }
        public bool IsZona_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsZona_IdNull();
             }
	        }
        public String TipoClie_Id {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["TipoClie_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].TipoClie_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].TipoClie_Id = value;
               }
	          }
        public bool IsTipoClie_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsTipoClie_IdNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListaPrecios {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["DescripcionListaPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].DescripcionListaPrecios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].DescripcionListaPrecios = value;
               }
	          }
        public bool IsDescripcionListaPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsDescripcionListaPreciosNull();
             }
	        }
        public DateTime FechaAlta {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["FechaAlta"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].FechaAlta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].FechaAlta = value;
               }
	          }
        public bool IsFechaAltaNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsFechaAltaNull();
             }
	        }
        public String Contactos {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Contactos"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Contactos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Contactos = value;
               }
	          }
        public bool IsContactosNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsContactosNull();
             }
	        }
        public String CondPagoCli_Id {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["CondPagoCli_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].CondPagoCli_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].CondPagoCli_Id = value;
               }
	          }
        public bool IsCondPagoCli_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsCondPagoCli_IdNull();
             }
	        }
        public String DescrioncionCondPago {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["DescrioncionCondPago"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].DescrioncionCondPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].DescrioncionCondPago = value;
               }
	          }
        public bool IsDescrioncionCondPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsDescrioncionCondPagoNull();
             }
	        }
        public Decimal Bonificacion1 {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Bonificacion1"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Bonificacion1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Bonificacion1 = value;
               }
	          }
        public bool IsBonificacion1Null {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsBonificacion1Null();
             }
	        }
        public Decimal Bonificacion2 {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Bonificacion2"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Bonificacion2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Bonificacion2 = value;
               }
	          }
        public bool IsBonificacion2Null {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsBonificacion2Null();
             }
	        }
        public Decimal Bonificacion3 {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Bonificacion3"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Bonificacion3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Bonificacion3 = value;
               }
	          }
        public bool IsBonificacion3Null {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsBonificacion3Null();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Decimal LimiteCredito {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["LimiteCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].LimiteCredito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].LimiteCredito = value;
               }
	          }
        public bool IsLimiteCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsLimiteCreditoNull();
             }
	        }
        public Decimal MontoRemitos {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["MontoRemitos"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].MontoRemitos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].MontoRemitos = value;
               }
	          }
        public bool IsMontoRemitosNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsMontoRemitosNull();
             }
	        }
        public Decimal Disponible {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Disponible"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Disponible;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Disponible = value;
               }
	          }
        public bool IsDisponibleNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsDisponibleNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venConsEdoCtaClientesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venConsEdoCtaClientesDS );
     }
     public venConsEdoCtaClientesActionExchange() : base( "venConsEdoCtaClientes" ) {
     }

     public venConsEdoCtaClientesActionExchange(venConsEdoCtaClientesActionEnum.EnumvenConsEdoCtaClientesAction pAccion) : base(venConsEdoCtaClientesActionEnum.GetAccionvenConsEdoCtaClientesAction(pAccion)) {
     }

     public venConsEdoCtaClientesActionExchange(venConsEdoCtaClientesActionEnum.EnumvenConsEdoCtaClientesAction pAccion, VentasCommon.venConsEdoCtaClientesDS pdsParam) : base(venConsEdoCtaClientesActionEnum.GetAccionvenConsEdoCtaClientesAction(pAccion), pdsParam) {
     }

     public venConsEdoCtaClientesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venConsEdoCtaClientesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venConsEdoCtaClientesDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venConsEdoCtaClientesDS)mParam;
	        }
     }
  }
}
