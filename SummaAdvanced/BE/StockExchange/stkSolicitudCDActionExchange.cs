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
    public class stkSolicitudCDActionExchange : Framework.Core.Exchange{

        public Int64 stkSolicitudCD {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["stkSolicitudCD"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].stkSolicitudCD;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].stkSolicitudCD = value;
               }
	          }
        public bool IsstkSolicitudCDNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsstkSolicitudCDNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Estado {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Apellido_y_Nombres {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Apellido_y_Nombres"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Apellido_y_Nombres;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Apellido_y_Nombres = value;
               }
	          }
        public bool IsApellido_y_NombresNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsApellido_y_NombresNull();
             }
	        }
        public String Observaciones {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkSolicitudCDDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkSolicitudCDDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkSolicitudCDDS );
     }
     public stkSolicitudCDActionExchange() : base( "stkSolicitudCD" ) {
     }

     public stkSolicitudCDActionExchange(stkSolicitudCDActionEnum.EnumstkSolicitudCDAction pAccion) : base(stkSolicitudCDActionEnum.GetAccionstkSolicitudCDAction(pAccion)) {
     }

     public stkSolicitudCDActionExchange(stkSolicitudCDActionEnum.EnumstkSolicitudCDAction pAccion, StockCommon.stkSolicitudCDDS pdsParam) : base(stkSolicitudCDActionEnum.GetAccionstkSolicitudCDAction(pAccion), pdsParam) {
     }

     public stkSolicitudCDActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkSolicitudCDDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkSolicitudCDActionExchange(StockCommon.stkSolicitudCDDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkSolicitudCDDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkSolicitudCDDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkSolicitudCDDS)mParam;
	        }
     }
  }
}
