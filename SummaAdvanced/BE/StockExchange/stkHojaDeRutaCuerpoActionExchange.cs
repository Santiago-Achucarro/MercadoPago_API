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
    public class stkHojaDeRutaCuerpoActionExchange : Framework.Core.Exchange{

        public Int32 stkHojaDeRuta {
            get {
                if(((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0]["stkHojaDeRuta"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].stkHojaDeRuta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].stkHojaDeRuta = value;
               }
	          }
        public bool IsstkHojaDeRutaNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].IsstkHojaDeRutaNull();
             }
	        }
        public Int64 conAsientos {
            get {
                if(((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0]["conAsientos"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].conAsientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].conAsientos = value;
               }
	          }
        public bool IsconAsientosNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].IsconAsientosNull();
             }
	        }
        public String Comprobante {
            get {
                if(((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0]["Comprobante"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].Comprobante;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].Comprobante = value;
               }
	          }
        public bool IsComprobanteNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].IsComprobanteNull();
             }
	        }
        public String HojaRuta {
            get {
                if(((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0]["HojaRuta"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].HojaRuta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].HojaRuta = value;
               }
	          }
        public bool IsHojaRutaNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].IsHojaRutaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkHojaDeRutaCuerpoDS );
     }
     public stkHojaDeRutaCuerpoActionExchange() : base( "stkHojaDeRutaCuerpo" ) {
     }

     public stkHojaDeRutaCuerpoActionExchange(stkHojaDeRutaCuerpoActionEnum.EnumstkHojaDeRutaCuerpoAction pAccion) : base(stkHojaDeRutaCuerpoActionEnum.GetAccionstkHojaDeRutaCuerpoAction(pAccion)) {
     }

     public stkHojaDeRutaCuerpoActionExchange(stkHojaDeRutaCuerpoActionEnum.EnumstkHojaDeRutaCuerpoAction pAccion, StockCommon.stkHojaDeRutaCuerpoDS pdsParam) : base(stkHojaDeRutaCuerpoActionEnum.GetAccionstkHojaDeRutaCuerpoAction(pAccion), pdsParam) {
     }

     public stkHojaDeRutaCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkHojaDeRutaCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkHojaDeRutaCuerpoDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkHojaDeRutaCuerpoDS)mParam;
	        }
     }
  }
}
