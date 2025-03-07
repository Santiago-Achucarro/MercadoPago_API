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
    public class stkNotasCreditoXDevolucionActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Segmento_IdNC {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento_IdNC"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento_IdNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento_IdNC = value;
               }
	          }
        public bool IsSegmento_IdNCNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento_IdNCNull();
             }
	        }
        public Int32 Segmento1NNC {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento1NNC"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento1NNC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento1NNC = value;
               }
	          }
        public bool IsSegmento1NNCNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento1NNCNull();
             }
	        }
        public Int32 Segmento2NNC {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento2NNC"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento2NNC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento2NNC = value;
               }
	          }
        public bool IsSegmento2NNCNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento2NNCNull();
             }
	        }
        public Int32 Segmento3NNC {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento3NNC"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento3NNC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento3NNC = value;
               }
	          }
        public bool IsSegmento3NNCNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento3NNCNull();
             }
	        }
        public Int32 Segmento4NNC {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento4NNC"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento4NNC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento4NNC = value;
               }
	          }
        public bool IsSegmento4NNCNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento4NNCNull();
             }
	        }
        public String Segmento1CNC {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento1CNC"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento1CNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento1CNC = value;
               }
	          }
        public bool IsSegmento1CNCNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento1CNCNull();
             }
	        }
        public String Segmento2CNC {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento2CNC"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento2CNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento2CNC = value;
               }
	          }
        public bool IsSegmento2CNCNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento2CNCNull();
             }
	        }
        public String Segmento3CNC {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento3CNC"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento3CNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento3CNC = value;
               }
	          }
        public bool IsSegmento3CNCNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento3CNCNull();
             }
	        }
        public String Segmento4CNC {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Segmento4CNC"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento4CNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Segmento4CNC = value;
               }
	          }
        public bool IsSegmento4CNCNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSegmento4CNCNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String Centro2_Id {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public Decimal Dato1 {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Dato1"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Dato1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Dato1 = value;
               }
	          }
        public bool IsDato1Null {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsDato1Null();
             }
	        }
        public Decimal Dato2 {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Dato2"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Dato2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Dato2 = value;
               }
	          }
        public bool IsDato2Null {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsDato2Null();
             }
	        }
        public Decimal Dato3 {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Dato3"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Dato3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Dato3 = value;
               }
	          }
        public bool IsDato3Null {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsDato3Null();
             }
	        }
        public Decimal Comision1 {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Comision1"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Comision1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Comision1 = value;
               }
	          }
        public bool IsComision1Null {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsComision1Null();
             }
	        }
        public Decimal Comision2 {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Comision2"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Comision2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Comision2 = value;
               }
	          }
        public bool IsComision2Null {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsComision2Null();
             }
	        }
        public Decimal Bonificacion1 {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Bonificacion1"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Bonificacion1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Bonificacion1 = value;
               }
	          }
        public bool IsBonificacion1Null {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsBonificacion1Null();
             }
	        }
        public Decimal Bonificacion2 {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Bonificacion2"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Bonificacion2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Bonificacion2 = value;
               }
	          }
        public bool IsBonificacion2Null {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsBonificacion2Null();
             }
	        }
        public Decimal Bonificacion3 {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Bonificacion3"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Bonificacion3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Bonificacion3 = value;
               }
	          }
        public bool IsBonificacion3Null {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsBonificacion3Null();
             }
	        }
        public Decimal Bonificacion4 {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Bonificacion4"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Bonificacion4;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Bonificacion4 = value;
               }
	          }
        public bool IsBonificacion4Null {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsBonificacion4Null();
             }
	        }
        public Decimal Bonificacion5 {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Bonificacion5"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Bonificacion5;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Bonificacion5 = value;
               }
	          }
        public bool IsBonificacion5Null {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsBonificacion5Null();
             }
	        }
        public Boolean CobraAbasto {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["CobraAbasto"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].CobraAbasto;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].CobraAbasto = value;
               }
	          }
        public bool IsCobraAbastoNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsCobraAbastoNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public Decimal SubTotalBonif {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["SubTotalBonif"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].SubTotalBonif;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].SubTotalBonif = value;
               }
	          }
        public bool IsSubTotalBonifNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSubTotalBonifNull();
             }
	        }
        public Decimal SubTotal {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["SubTotal"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].SubTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].SubTotal = value;
               }
	          }
        public bool IsSubTotalNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSubTotalNull();
             }
	        }
        public String CondPagoCli_Id {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["CondPagoCli_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].CondPagoCli_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].CondPagoCli_Id = value;
               }
	          }
        public bool IsCondPagoCli_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsCondPagoCli_IdNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Boolean CambioFijo {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["CambioFijo"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].CambioFijo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].CambioFijo = value;
               }
	          }
        public bool IsCambioFijoNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsCambioFijoNull();
             }
	        }
        public Int32 ComprobanteDesde {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["ComprobanteDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].ComprobanteDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].ComprobanteDesde = value;
               }
	          }
        public bool IsComprobanteDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsComprobanteDesdeNull();
             }
	        }
        public Int32 TipoPago {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["TipoPago"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].TipoPago;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].TipoPago = value;
               }
	          }
        public bool IsTipoPagoNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsTipoPagoNull();
             }
	        }
        public String Incoterm_Id {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Incoterm_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Incoterm_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Incoterm_Id = value;
               }
	          }
        public bool IsIncoterm_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsIncoterm_IdNull();
             }
	        }
        public Decimal Saldo {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Saldo"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Saldo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Saldo = value;
               }
	          }
        public bool IsSaldoNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSaldoNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Decimal CambioMonedaOriginal {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["CambioMonedaOriginal"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].CambioMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].CambioMonedaOriginal = value;
               }
	          }
        public bool IsCambioMonedaOriginalNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsCambioMonedaOriginalNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public String Observaciones {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String CondFisc_Id {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["CondFisc_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].CondFisc_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].CondFisc_Id = value;
               }
	          }
        public bool IsCondFisc_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsCondFisc_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkNotasCreditoXDevolucionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkNotasCreditoXDevolucionDS );
     }
     public stkNotasCreditoXDevolucionActionExchange() : base( "stkNotasCreditoXDevolucion" ) {
     }

     public stkNotasCreditoXDevolucionActionExchange(stkNotasCreditoXDevolucionActionEnum.EnumstkNotasCreditoXDevolucionAction pAccion) : base(stkNotasCreditoXDevolucionActionEnum.GetAccionstkNotasCreditoXDevolucionAction(pAccion)) {
     }

     public stkNotasCreditoXDevolucionActionExchange(stkNotasCreditoXDevolucionActionEnum.EnumstkNotasCreditoXDevolucionAction pAccion, StockCommon.stkNotasCreditoXDevolucionDS pdsParam) : base(stkNotasCreditoXDevolucionActionEnum.GetAccionstkNotasCreditoXDevolucionAction(pAccion), pdsParam) {
     }

     public stkNotasCreditoXDevolucionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkNotasCreditoXDevolucionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkNotasCreditoXDevolucionDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkNotasCreditoXDevolucionDS)mParam;
	        }
     }
  }
}
