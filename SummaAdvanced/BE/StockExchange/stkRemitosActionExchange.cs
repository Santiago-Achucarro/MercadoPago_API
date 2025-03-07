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
    public class stkRemitosActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListasPrecios {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["DescripcionListasPrecios"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].DescripcionListasPrecios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].DescripcionListasPrecios = value;
               }
	          }
        public bool IsDescripcionListasPreciosNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsDescripcionListasPreciosNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public Int32 HojaRuta_Id {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["HojaRuta_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].HojaRuta_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].HojaRuta_Id = value;
               }
	          }
        public bool IsHojaRuta_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsHojaRuta_IdNull();
             }
	        }
        public String HojaRuta {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["HojaRuta"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].HojaRuta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].HojaRuta = value;
               }
	          }
        public bool IsHojaRutaNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsHojaRutaNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String DescripcionFormaEntrega {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["DescripcionFormaEntrega"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].DescripcionFormaEntrega;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].DescripcionFormaEntrega = value;
               }
	          }
        public bool IsDescripcionFormaEntregaNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsDescripcionFormaEntregaNull();
             }
	        }
        public String Camion_Id {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["Camion_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].Camion_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].Camion_Id = value;
               }
	          }
        public bool IsCamion_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsCamion_IdNull();
             }
	        }
        public String Remolque1 {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["Remolque1"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].Remolque1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].Remolque1 = value;
               }
	          }
        public bool IsRemolque1Null {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsRemolque1Null();
             }
	        }
        public String Remolque2 {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["Remolque2"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].Remolque2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].Remolque2 = value;
               }
	          }
        public bool IsRemolque2Null {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsRemolque2Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkRemitosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkRemitosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemitosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkRemitosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkRemitosDS );
     }
     public stkRemitosActionExchange() : base( "stkRemitos" ) {
     }

     public stkRemitosActionExchange(stkRemitosActionEnum.EnumstkRemitosAction pAccion) : base(stkRemitosActionEnum.GetAccionstkRemitosAction(pAccion)) {
     }

     public stkRemitosActionExchange(stkRemitosActionEnum.EnumstkRemitosAction pAccion, StockCommon.stkRemitosDS pdsParam) : base(stkRemitosActionEnum.GetAccionstkRemitosAction(pAccion), pdsParam) {
     }

     public stkRemitosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkRemitosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkRemitosActionExchange(StockCommon.stkRemitosDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkRemitosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkRemitosDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkRemitosDS)mParam;
	        }
     }
  }
}
