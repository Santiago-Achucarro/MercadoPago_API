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
    public class stkCOTArActionExchange : Framework.Core.Exchange{

        public Int32 stkHojaDeRuta {
            get {
                if(((StockCommon.stkCOTArDS)mParam).Principal[0]["stkHojaDeRuta"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArDS)mParam).Principal[0].stkHojaDeRuta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArDS)mParam).Principal[0].stkHojaDeRuta = value;
               }
	          }
        public bool IsstkHojaDeRutaNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArDS)mParam).Principal[0].IsstkHojaDeRutaNull();
             }
	        }
        public Int32 genProvincias {
            get {
                if(((StockCommon.stkCOTArDS)mParam).Principal[0]["genProvincias"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArDS)mParam).Principal[0].genProvincias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArDS)mParam).Principal[0].genProvincias = value;
               }
	          }
        public bool IsgenProvinciasNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArDS)mParam).Principal[0].IsgenProvinciasNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((StockCommon.stkCOTArDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkCOTArDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((StockCommon.stkCOTArDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal Peso {
            get {
                if(((StockCommon.stkCOTArDS)mParam).Principal[0]["Peso"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArDS)mParam).Principal[0].Peso;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArDS)mParam).Principal[0].Peso = value;
               }
	          }
        public bool IsPesoNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArDS)mParam).Principal[0].IsPesoNull();
             }
	        }
        public String COT {
            get {
                if(((StockCommon.stkCOTArDS)mParam).Principal[0]["COT"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArDS)mParam).Principal[0].COT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArDS)mParam).Principal[0].COT = value;
               }
	          }
        public bool IsCOTNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArDS)mParam).Principal[0].IsCOTNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkCOTArDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkCOTArDS );
     }
     public stkCOTArActionExchange() : base( "stkCOTAr" ) {
     }

     public stkCOTArActionExchange(stkCOTArActionEnum.EnumstkCOTArAction pAccion) : base(stkCOTArActionEnum.GetAccionstkCOTArAction(pAccion)) {
     }

     public stkCOTArActionExchange(stkCOTArActionEnum.EnumstkCOTArAction pAccion, StockCommon.stkCOTArDS pdsParam) : base(stkCOTArActionEnum.GetAccionstkCOTArAction(pAccion), pdsParam) {
     }

     public stkCOTArActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkCOTArDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkCOTArDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkCOTArDS)mParam;
	        }
     }
  }
}
