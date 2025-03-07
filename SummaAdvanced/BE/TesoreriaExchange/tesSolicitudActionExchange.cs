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
    public class tesSolicitudActionExchange : Framework.Core.Exchange{

        public Int64 tesSolicitud {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["tesSolicitud"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].tesSolicitud;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].tesSolicitud = value;
               }
	          }
        public bool IstesSolicitudNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IstesSolicitudNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Solicitante_Id {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Solicitante_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Solicitante_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Solicitante_Id = value;
               }
	          }
        public bool IsSolicitante_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsSolicitante_IdNull();
             }
	        }
        public String DescripcionSolicitantes {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["DescripcionSolicitantes"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].DescripcionSolicitantes;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].DescripcionSolicitantes = value;
               }
	          }
        public bool IsDescripcionSolicitantesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsDescripcionSolicitantesNull();
             }
	        }
        public String Causa {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Causa"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Causa;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Causa = value;
               }
	          }
        public bool IsCausaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsCausaNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public String Estado {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public String UsuarioAutorizo {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["UsuarioAutorizo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].UsuarioAutorizo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].UsuarioAutorizo = value;
               }
	          }
        public bool IsUsuarioAutorizoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsUsuarioAutorizoNull();
             }
	        }
        public String DescripcionUsuarioAutorizo {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["DescripcionUsuarioAutorizo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].DescripcionUsuarioAutorizo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].DescripcionUsuarioAutorizo = value;
               }
	          }
        public bool IsDescripcionUsuarioAutorizoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsDescripcionUsuarioAutorizoNull();
             }
	        }
        public DateTime FechaAutorizo {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["FechaAutorizo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].FechaAutorizo;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].FechaAutorizo = value;
               }
	          }
        public bool IsFechaAutorizoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsFechaAutorizoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime FechaCarga {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["FechaCarga"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].FechaCarga;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].FechaCarga = value;
               }
	          }
        public bool IsFechaCargaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsFechaCargaNull();
             }
	        }
        public String Cartera_id {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Cartera_id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Cartera_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Cartera_id = value;
               }
	          }
        public bool IsCartera_idNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsCartera_idNull();
             }
	        }
        public String DescripcionCartera {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["DescripcionCartera"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].DescripcionCartera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].DescripcionCartera = value;
               }
	          }
        public bool IsDescripcionCarteraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsDescripcionCarteraNull();
             }
	        }
        public Decimal Rendido {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Rendido"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Rendido;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Rendido = value;
               }
	          }
        public bool IsRendidoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsRendidoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesSolicitudDS );
     }
     public tesSolicitudActionExchange() : base( "tesSolicitud" ) {
     }

     public tesSolicitudActionExchange(tesSolicitudActionEnum.EnumtesSolicitudAction pAccion) : base(tesSolicitudActionEnum.GetAcciontesSolicitudAction(pAccion)) {
     }

     public tesSolicitudActionExchange(tesSolicitudActionEnum.EnumtesSolicitudAction pAccion, TesoreriaCommon.tesSolicitudDS pdsParam) : base(tesSolicitudActionEnum.GetAcciontesSolicitudAction(pAccion), pdsParam) {
     }

     public tesSolicitudActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesSolicitudDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesSolicitudDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesSolicitudDS)mParam;
	        }
     }
  }
}
