using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesRengMoviRetProvActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Decimal Exencion {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Exencion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Exencion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Exencion = value;
               }
	          }
        public bool IsExencionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsExencionNull();
             }
	        }
        public Decimal BaseImponible {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["BaseImponible"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].BaseImponible;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].BaseImponible = value;
               }
	          }
        public bool IsBaseImponibleNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsBaseImponibleNull();
             }
	        }
        public Decimal Acum {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Acum"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Acum;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Acum = value;
               }
	          }
        public bool IsAcumNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsAcumNull();
             }
	        }
        public Decimal TRet {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["TRet"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].TRet;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].TRet = value;
               }
	          }
        public bool IsTRetNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsTRetNull();
             }
	        }
        public Decimal AcumTot {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["AcumTot"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].AcumTot;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].AcumTot = value;
               }
	          }
        public bool IsAcumTotNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsAcumTotNull();
             }
	        }
        public Int64 comMovProv {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String NombreArchivo {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["NombreArchivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].NombreArchivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].NombreArchivo = value;
               }
	          }
        public bool IsNombreArchivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsNombreArchivoNull();
             }
	        }
        public String PDF {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["PDF"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].PDF;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].PDF = value;
               }
	          }
        public bool IsPDFNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsPDFNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviRetProvDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesRengMoviRetProvDS );
     }
     public tesRengMoviRetProvActionExchange() : base( "tesRengMoviRetProv" ) {
     }

     public tesRengMoviRetProvActionExchange(tesRengMoviRetProvActionEnum.EnumtesRengMoviRetProvAction pAccion) : base(tesRengMoviRetProvActionEnum.GetAcciontesRengMoviRetProvAction(pAccion)) {
     }

     public tesRengMoviRetProvActionExchange(tesRengMoviRetProvActionEnum.EnumtesRengMoviRetProvAction pAccion, TesoreriaCommon.tesRengMoviRetProvDS pdsParam) : base(tesRengMoviRetProvActionEnum.GetAcciontesRengMoviRetProvAction(pAccion), pdsParam) {
     }

     public tesRengMoviRetProvActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesRengMoviRetProvDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesRengMoviRetProvDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesRengMoviRetProvDS)mParam;
	        }
     }
  }
}
