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
    public class genMensajesPantallaActionExchange : Framework.Core.Exchange{

        public Int32 genMensajes {
            get {
                if(((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0]["genMensajes"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].genMensajes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].genMensajes = value;
               }
	          }
        public bool IsgenMensajesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].IsgenMensajesNull();
             }
	        }
        public String Mensaje {
            get {
                if(((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0]["Mensaje"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].Mensaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].Mensaje = value;
               }
	          }
        public bool IsMensajeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].IsMensajeNull();
             }
	        }
        public DateTime Leido {
            get {
                if(((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0]["Leido"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].Leido;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].Leido = value;
               }
	          }
        public bool IsLeidoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].IsLeidoNull();
             }
	        }
        public String Remitente {
            get {
                if(((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0]["Remitente"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].Remitente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].Remitente = value;
               }
	          }
        public bool IsRemitenteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].IsRemitenteNull();
             }
	        }
        public String DescripcionRemitente {
            get {
                if(((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0]["DescripcionRemitente"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].DescripcionRemitente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].DescripcionRemitente = value;
               }
	          }
        public bool IsDescripcionRemitenteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].IsDescripcionRemitenteNull();
             }
	        }
        public String Destino {
            get {
                if(((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0]["Destino"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].Destino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].Destino = value;
               }
	          }
        public bool IsDestinoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].IsDestinoNull();
             }
	        }
        public String DescripcionDestino {
            get {
                if(((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0]["DescripcionDestino"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].DescripcionDestino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].DescripcionDestino = value;
               }
	          }
        public bool IsDescripcionDestinoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].IsDescripcionDestinoNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesPantallaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genMensajesPantallaDS );
     }
     public genMensajesPantallaActionExchange() : base( "genMensajesPantalla" ) {
     }

     public genMensajesPantallaActionExchange(genMensajesPantallaActionEnum.EnumgenMensajesPantallaAction pAccion) : base(genMensajesPantallaActionEnum.GetAcciongenMensajesPantallaAction(pAccion)) {
     }

     public genMensajesPantallaActionExchange(genMensajesPantallaActionEnum.EnumgenMensajesPantallaAction pAccion, GeneralesCommon.genMensajesPantallaDS pdsParam) : base(genMensajesPantallaActionEnum.GetAcciongenMensajesPantallaAction(pAccion), pdsParam) {
     }

     public genMensajesPantallaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genMensajesPantallaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genMensajesPantallaDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genMensajesPantallaDS)mParam;
	        }
     }
  }
}
