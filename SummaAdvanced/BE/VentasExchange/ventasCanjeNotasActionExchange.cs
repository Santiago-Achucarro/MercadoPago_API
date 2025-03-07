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
    public class ventasCanjeNotasActionExchange : Framework.Core.Exchange{

        public String SucursalEmpr {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["SucursalEmpr"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].SucursalEmpr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].SucursalEmpr = value;
               }
	          }
        public bool IsSucursalEmprNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsSucursalEmprNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String CondFiscal_Id {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["CondFiscal_Id"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].CondFiscal_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].CondFiscal_Id = value;
               }
	          }
        public bool IsCondFiscal_IdNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsCondFiscal_IdNull();
             }
	        }
        public String UsoCfdi {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["UsoCfdi"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].UsoCfdi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].UsoCfdi = value;
               }
	          }
        public bool IsUsoCfdiNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsUsoCfdiNull();
             }
	        }
        public String FormaPago {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["FormaPago"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].FormaPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].FormaPago = value;
               }
	          }
        public bool IsFormaPagoNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsFormaPagoNull();
             }
	        }
        public Boolean PorNota {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["PorNota"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].PorNota;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].PorNota = value;
               }
	          }
        public bool IsPorNotaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsPorNotaNull();
             }
	        }
        public Decimal Total {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public String CFVenta_Id {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["CFVenta_Id"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].CFVenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].CFVenta_Id = value;
               }
	          }
        public bool IsCFVenta_IdNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsCFVenta_IdNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String ArchivoPDF {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["ArchivoPDF"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].ArchivoPDF;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].ArchivoPDF = value;
               }
	          }
        public bool IsArchivoPDFNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsArchivoPDFNull();
             }
	        }
        public String ArchivoXML {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["ArchivoXML"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].ArchivoXML;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].ArchivoXML = value;
               }
	          }
        public bool IsArchivoXMLNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsArchivoXMLNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.ventasCanjeNotasDS );
     }
     public ventasCanjeNotasActionExchange() : base( "ventasCanjeNotas" ) {
     }

     public ventasCanjeNotasActionExchange(ventasCanjeNotasActionEnum.EnumventasCanjeNotasAction pAccion) : base(ventasCanjeNotasActionEnum.GetAccionventasCanjeNotasAction(pAccion)) {
     }

     public ventasCanjeNotasActionExchange(ventasCanjeNotasActionEnum.EnumventasCanjeNotasAction pAccion, VentasCommon.ventasCanjeNotasDS pdsParam) : base(ventasCanjeNotasActionEnum.GetAccionventasCanjeNotasAction(pAccion), pdsParam) {
     }

     public ventasCanjeNotasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.ventasCanjeNotasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public ventasCanjeNotasActionExchange(VentasCommon.ventasCanjeNotasDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.ventasCanjeNotasDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.ventasCanjeNotasDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.ventasCanjeNotasDS)mParam;
	        }
     }
  }
}
