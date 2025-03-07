using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genSegmentosActionExchange : Framework.Core.Exchange{

        public Int32 genSegmentos {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["genSegmentos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].genSegmentos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].genSegmentos = value;
               }
	          }
        public bool IsgenSegmentosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsgenSegmentosNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento_Id_Nueva {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Segmento_Id_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Segmento_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Segmento_Id_Nueva = value;
               }
	          }
        public bool IsSegmento_Id_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsSegmento_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Digitos1N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Digitos1N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos1N = value;
               }
	          }
        public bool IsDigitos1NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDigitos1NNull();
             }
	        }
        public Int32 Digitos2N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Digitos2N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos2N = value;
               }
	          }
        public bool IsDigitos2NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDigitos2NNull();
             }
	        }
        public Int32 Digitos3N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Digitos3N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos3N = value;
               }
	          }
        public bool IsDigitos3NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDigitos3NNull();
             }
	        }
        public Int32 Digitos4N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Digitos4N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos4N = value;
               }
	          }
        public bool IsDigitos4NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDigitos4NNull();
             }
	        }
        public Boolean TieneColumnaAutomatica {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["TieneColumnaAutomatica"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].TieneColumnaAutomatica;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].TieneColumnaAutomatica = value;
               }
	          }
        public bool IsTieneColumnaAutomaticaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsTieneColumnaAutomaticaNull();
             }
	        }
        public Int32 Digitos1C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Digitos1C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos1C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos1C = value;
               }
	          }
        public bool IsDigitos1CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDigitos1CNull();
             }
	        }
        public Int32 Digitos2C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Digitos2C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos2C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos2C = value;
               }
	          }
        public bool IsDigitos2CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDigitos2CNull();
             }
	        }
        public Int32 Digitos3C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Digitos3C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos3C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos3C = value;
               }
	          }
        public bool IsDigitos3CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDigitos3CNull();
             }
	        }
        public Int32 Digitos4C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Digitos4C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos4C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Digitos4C = value;
               }
	          }
        public bool IsDigitos4CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDigitos4CNull();
             }
	        }
        public Int16 Origen1N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Origen1N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen1N = value;
               }
	          }
        public bool IsOrigen1NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrigen1NNull();
             }
	        }
        public String DescripcionSegmentosOrigenes1N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["DescripcionSegmentosOrigenes1N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes1N;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes1N = value;
               }
	          }
        public bool IsDescripcionSegmentosOrigenes1NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDescripcionSegmentosOrigenes1NNull();
             }
	        }
        public Int16 Origen2N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Origen2N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen2N = value;
               }
	          }
        public bool IsOrigen2NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrigen2NNull();
             }
	        }
        public String DescripcionSegmentosOrigenes2N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["DescripcionSegmentosOrigenes2N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes2N;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes2N = value;
               }
	          }
        public bool IsDescripcionSegmentosOrigenes2NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDescripcionSegmentosOrigenes2NNull();
             }
	        }
        public Int16 Origen3N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Origen3N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen3N = value;
               }
	          }
        public bool IsOrigen3NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrigen3NNull();
             }
	        }
        public String DescripcionSegmentosOrigenes3N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["DescripcionSegmentosOrigenes3N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes3N;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes3N = value;
               }
	          }
        public bool IsDescripcionSegmentosOrigenes3NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDescripcionSegmentosOrigenes3NNull();
             }
	        }
        public Int16 Origen4N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Origen4N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen4N = value;
               }
	          }
        public bool IsOrigen4NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrigen4NNull();
             }
	        }
        public String DescripcionSegmentosOrigenes4N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["DescripcionSegmentosOrigenes4N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes4N;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes4N = value;
               }
	          }
        public bool IsDescripcionSegmentosOrigenes4NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDescripcionSegmentosOrigenes4NNull();
             }
	        }
        public Int16 Origen1C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Origen1C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen1C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen1C = value;
               }
	          }
        public bool IsOrigen1CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrigen1CNull();
             }
	        }
        public String DescripcionSegmentosOrigenes1C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["DescripcionSegmentosOrigenes1C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes1C = value;
               }
	          }
        public bool IsDescripcionSegmentosOrigenes1CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDescripcionSegmentosOrigenes1CNull();
             }
	        }
        public Int16 Origen2C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Origen2C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen2C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen2C = value;
               }
	          }
        public bool IsOrigen2CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrigen2CNull();
             }
	        }
        public String DescripcionSegmentosOrigenes2C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["DescripcionSegmentosOrigenes2C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes2C = value;
               }
	          }
        public bool IsDescripcionSegmentosOrigenes2CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDescripcionSegmentosOrigenes2CNull();
             }
	        }
        public Int16 Origen3C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Origen3C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen3C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen3C = value;
               }
	          }
        public bool IsOrigen3CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrigen3CNull();
             }
	        }
        public String DescripcionSegmentosOrigenes3C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["DescripcionSegmentosOrigenes3C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes3C = value;
               }
	          }
        public bool IsDescripcionSegmentosOrigenes3CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDescripcionSegmentosOrigenes3CNull();
             }
	        }
        public Int16 Origen4C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Origen4C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen4C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Origen4C = value;
               }
	          }
        public bool IsOrigen4CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrigen4CNull();
             }
	        }
        public String DescripcionSegmentosOrigenes4C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["DescripcionSegmentosOrigenes4C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionSegmentosOrigenes4C = value;
               }
	          }
        public bool IsDescripcionSegmentosOrigenes4CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDescripcionSegmentosOrigenes4CNull();
             }
	        }
        public Int16 Orden1N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Orden1N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden1N = value;
               }
	          }
        public bool IsOrden1NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrden1NNull();
             }
	        }
        public Int16 Orden2N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Orden2N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden2N = value;
               }
	          }
        public bool IsOrden2NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrden2NNull();
             }
	        }
        public Int16 Orden3N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Orden3N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden3N = value;
               }
	          }
        public bool IsOrden3NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrden3NNull();
             }
	        }
        public Int16 Orden4N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Orden4N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden4N = value;
               }
	          }
        public bool IsOrden4NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrden4NNull();
             }
	        }
        public Int16 Orden1C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Orden1C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden1C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden1C = value;
               }
	          }
        public bool IsOrden1CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrden1CNull();
             }
	        }
        public Int16 Orden2C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Orden2C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden2C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden2C = value;
               }
	          }
        public bool IsOrden2CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrden2CNull();
             }
	        }
        public Int16 Orden3C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Orden3C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden3C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden3C = value;
               }
	          }
        public bool IsOrden3CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrden3CNull();
             }
	        }
        public Int16 Orden4C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Orden4C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden4C;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Orden4C = value;
               }
	          }
        public bool IsOrden4CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsOrden4CNull();
             }
	        }
        public Boolean HabilitaEdicion {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["HabilitaEdicion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].HabilitaEdicion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].HabilitaEdicion = value;
               }
	          }
        public bool IsHabilitaEdicionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsHabilitaEdicionNull();
             }
	        }
        public String TamanioVariable {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["TamanioVariable"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].TamanioVariable;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].TamanioVariable = value;
               }
	          }
        public bool IsTamanioVariableNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsTamanioVariableNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Nombre1N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Nombre1N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre1N;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre1N = value;
               }
	          }
        public bool IsNombre1NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsNombre1NNull();
             }
	        }
        public String Nombre2N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Nombre2N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre2N;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre2N = value;
               }
	          }
        public bool IsNombre2NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsNombre2NNull();
             }
	        }
        public String Nombre3N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Nombre3N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre3N;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre3N = value;
               }
	          }
        public bool IsNombre3NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsNombre3NNull();
             }
	        }
        public String Nombre4N {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Nombre4N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre4N;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre4N = value;
               }
	          }
        public bool IsNombre4NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsNombre4NNull();
             }
	        }
        public String Nombre1C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Nombre1C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre1C = value;
               }
	          }
        public bool IsNombre1CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsNombre1CNull();
             }
	        }
        public String Nombre2C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Nombre2C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre2C = value;
               }
	          }
        public bool IsNombre2CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsNombre2CNull();
             }
	        }
        public String Nombre3C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Nombre3C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre3C = value;
               }
	          }
        public bool IsNombre3CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsNombre3CNull();
             }
	        }
        public String Nombre4C {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Nombre4C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Nombre4C = value;
               }
	          }
        public bool IsNombre4CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsNombre4CNull();
             }
	        }
        public Boolean EsSueldos {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["EsSueldos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].EsSueldos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].EsSueldos = value;
               }
	          }
        public bool IsEsSueldosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsEsSueldosNull();
             }
	        }
        public Boolean EmpiezaEnUno {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["EmpiezaEnUno"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].EmpiezaEnUno;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].EmpiezaEnUno = value;
               }
	          }
        public bool IsEmpiezaEnUnoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsEmpiezaEnUnoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genSegmentosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genSegmentosDS );
     }
     public genSegmentosActionExchange() : base( "genSegmentos" ) {
     }

     public genSegmentosActionExchange(genSegmentosActionEnum.EnumgenSegmentosAction pAccion) : base(genSegmentosActionEnum.GetAcciongenSegmentosAction(pAccion)) {
     }

     public genSegmentosActionExchange(genSegmentosActionEnum.EnumgenSegmentosAction pAccion, GeneralesCommon.genSegmentosDS pdsParam) : base(genSegmentosActionEnum.GetAcciongenSegmentosAction(pAccion), pdsParam) {
     }

     public genSegmentosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genSegmentosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genSegmentosActionExchange(GeneralesCommon.genSegmentosDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genSegmentosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genSegmentosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genSegmentosDS)mParam;
	        }
     }
  }
}
