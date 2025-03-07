using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueRecibosActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String DescripcionNomina {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["DescripcionNomina"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].DescripcionNomina;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].DescripcionNomina = value;
               }
	          }
        public bool IsDescripcionNominaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsDescripcionNominaNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Decena {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Decena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Decena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Decena = value;
               }
	          }
        public bool IsDecenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsDecenaNull();
             }
	        }
        public Int32 Quincena {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Quincena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Quincena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Quincena = value;
               }
	          }
        public bool IsQuincenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsQuincenaNull();
             }
	        }
        public Int32 Semana {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Semana"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Semana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Semana = value;
               }
	          }
        public bool IsSemanaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSemanaNull();
             }
	        }
        public Int32 Vez {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Vez"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Vez;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Vez = value;
               }
	          }
        public bool IsVezNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsVezNull();
             }
	        }
        public DateTime FechaPago {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["FechaPago"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].FechaPago;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].FechaPago = value;
               }
	          }
        public bool IsFechaPagoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsFechaPagoNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String Nombre {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Nombre"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Nombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Nombre = value;
               }
	          }
        public bool IsNombreNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsNombreNull();
             }
	        }
        public DateTime FechaIngreso {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["FechaIngreso"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].FechaIngreso;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].FechaIngreso = value;
               }
	          }
        public bool IsFechaIngresoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsFechaIngresoNull();
             }
	        }
        public Decimal SDI {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["SDI"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].SDI;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].SDI = value;
               }
	          }
        public bool IsSDINull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSDINull();
             }
	        }
        public Decimal SD {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["SD"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].SD;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].SD = value;
               }
	          }
        public bool IsSDNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsSDNull();
             }
	        }
        public Int32 DiasPagados {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["DiasPagados"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].DiasPagados;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].DiasPagados = value;
               }
	          }
        public bool IsDiasPagadosNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsDiasPagadosNull();
             }
	        }
        public Decimal Neto {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Neto"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Neto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Neto = value;
               }
	          }
        public bool IsNetoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsNetoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueRecibosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueRecibosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueRecibosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueRecibosDS );
     }
     public sueRecibosActionExchange() : base( "sueRecibos" ) {
     }

     public sueRecibosActionExchange(sueRecibosActionEnum.EnumsueRecibosAction pAccion) : base(sueRecibosActionEnum.GetAccionsueRecibosAction(pAccion)) {
     }

     public sueRecibosActionExchange(sueRecibosActionEnum.EnumsueRecibosAction pAccion, SueldosCommon.sueRecibosDS pdsParam) : base(sueRecibosActionEnum.GetAccionsueRecibosAction(pAccion), pdsParam) {
     }

     public sueRecibosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueRecibosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueRecibosDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueRecibosDS)mParam;
	        }
     }
  }
}
