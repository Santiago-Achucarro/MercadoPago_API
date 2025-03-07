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
    public class venGeneraRemitoFacturaActionExchange : Framework.Core.Exchange{

        public Int32 venReparto {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["venReparto"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].venReparto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].venReparto = value;
               }
	          }
        public bool IsvenRepartoNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsvenRepartoNull();
             }
	        }
        public String Segmento_Id_Fact {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento_Id_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento_Id_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento_Id_Fact = value;
               }
	          }
        public bool IsSegmento_Id_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento_Id_FactNull();
             }
	        }
        public Int32 Segmento1N_Fact {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento1N_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1N_Fact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1N_Fact = value;
               }
	          }
        public bool IsSegmento1N_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento1N_FactNull();
             }
	        }
        public Int32 Segmento2N_Fact {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento2N_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2N_Fact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2N_Fact = value;
               }
	          }
        public bool IsSegmento2N_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento2N_FactNull();
             }
	        }
        public Int32 Segmento3N_Fact {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento3N_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3N_Fact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3N_Fact = value;
               }
	          }
        public bool IsSegmento3N_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento3N_FactNull();
             }
	        }
        public Int32 Segmento4N_Fact {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento4N_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4N_Fact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4N_Fact = value;
               }
	          }
        public bool IsSegmento4N_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento4N_FactNull();
             }
	        }
        public String Segmento1C_Fact {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento1C_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1C_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1C_Fact = value;
               }
	          }
        public bool IsSegmento1C_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento1C_FactNull();
             }
	        }
        public String Segmento2C_Fact {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento2C_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2C_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2C_Fact = value;
               }
	          }
        public bool IsSegmento2C_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento2C_FactNull();
             }
	        }
        public String Segmento3C_Fact {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento3C_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3C_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3C_Fact = value;
               }
	          }
        public bool IsSegmento3C_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento3C_FactNull();
             }
	        }
        public String Segmento4C_Fact {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento4C_Fact"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4C_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4C_Fact = value;
               }
	          }
        public bool IsSegmento4C_FactNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento4C_FactNull();
             }
	        }
        public String Segmento_Id_Rem {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento_Id_Rem"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento_Id_Rem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento_Id_Rem = value;
               }
	          }
        public bool IsSegmento_Id_RemNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento_Id_RemNull();
             }
	        }
        public Int32 Segmento1N_Rem {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento1N_Rem"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1N_Rem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1N_Rem = value;
               }
	          }
        public bool IsSegmento1N_RemNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento1N_RemNull();
             }
	        }
        public Int32 Segmento2N_Rem {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento2N_Rem"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2N_Rem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2N_Rem = value;
               }
	          }
        public bool IsSegmento2N_RemNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento2N_RemNull();
             }
	        }
        public Int32 Segmento3N_Rem {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento3N_Rem"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3N_Rem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3N_Rem = value;
               }
	          }
        public bool IsSegmento3N_RemNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento3N_RemNull();
             }
	        }
        public Int32 Segmento4N_Rem {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento4N_Rem"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4N_Rem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4N_Rem = value;
               }
	          }
        public bool IsSegmento4N_RemNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento4N_RemNull();
             }
	        }
        public String Segmento1C_Rem {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento1C_Rem"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1C_Rem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1C_Rem = value;
               }
	          }
        public bool IsSegmento1C_RemNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento1C_RemNull();
             }
	        }
        public String Segmento2C_Rem {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento2C_Rem"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2C_Rem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2C_Rem = value;
               }
	          }
        public bool IsSegmento2C_RemNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento2C_RemNull();
             }
	        }
        public String Segmento3C_Rem {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento3C_Rem"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3C_Rem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3C_Rem = value;
               }
	          }
        public bool IsSegmento3C_RemNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento3C_RemNull();
             }
	        }
        public String Segmento4C_Rem {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento4C_Rem"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4C_Rem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4C_Rem = value;
               }
	          }
        public bool IsSegmento4C_RemNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento4C_RemNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Boolean Cerrado {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Cerrado"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Cerrado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Cerrado = value;
               }
	          }
        public bool IsCerradoNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsCerradoNull();
             }
	        }
        public Boolean Automatico {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Automatico"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Automatico;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Automatico = value;
               }
	          }
        public bool IsAutomaticoNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsAutomaticoNull();
             }
	        }
        public String RemitoFactura {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["RemitoFactura"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].RemitoFactura;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].RemitoFactura = value;
               }
	          }
        public bool IsRemitoFacturaNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsRemitoFacturaNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDeposito {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["DescripcionDeposito"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].DescripcionDeposito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].DescripcionDeposito = value;
               }
	          }
        public bool IsDescripcionDepositoNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsDescripcionDepositoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venGeneraRemitoFacturaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venGeneraRemitoFacturaDS );
     }
     public venGeneraRemitoFacturaActionExchange() : base( "venGeneraRemitoFactura" ) {
     }

     public venGeneraRemitoFacturaActionExchange(venGeneraRemitoFacturaActionEnum.EnumvenGeneraRemitoFacturaAction pAccion) : base(venGeneraRemitoFacturaActionEnum.GetAccionvenGeneraRemitoFacturaAction(pAccion)) {
     }

     public venGeneraRemitoFacturaActionExchange(venGeneraRemitoFacturaActionEnum.EnumvenGeneraRemitoFacturaAction pAccion, VentasCommon.venGeneraRemitoFacturaDS pdsParam) : base(venGeneraRemitoFacturaActionEnum.GetAccionvenGeneraRemitoFacturaAction(pAccion), pdsParam) {
     }

     public venGeneraRemitoFacturaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venGeneraRemitoFacturaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venGeneraRemitoFacturaActionExchange(VentasCommon.venGeneraRemitoFacturaDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venGeneraRemitoFacturaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venGeneraRemitoFacturaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venGeneraRemitoFacturaDS)mParam;
	        }
     }
  }
}
