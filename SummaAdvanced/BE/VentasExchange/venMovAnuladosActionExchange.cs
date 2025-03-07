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
    public class venMovAnuladosActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((VentasCommon.venMovAnuladosDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.venMovAnuladosDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((VentasCommon.venMovAnuladosDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.venMovAnuladosDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public String PDF {
            get {
                if(((VentasCommon.venMovAnuladosDS)mParam).Principal[0]["PDF"] != DBNull.Value  ){
                    return ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].PDF;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].PDF = value;
               }
	          }
        public bool IsPDFNull {
             get {
                 return mParam==null || ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].IsPDFNull();
             }
	        }
        public String NombreArchivo {
            get {
                if(((VentasCommon.venMovAnuladosDS)mParam).Principal[0]["NombreArchivo"] != DBNull.Value  ){
                    return ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].NombreArchivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].NombreArchivo = value;
               }
	          }
        public bool IsNombreArchivoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].IsNombreArchivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovAnuladosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovAnuladosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovAnuladosDS );
     }
     public venMovAnuladosActionExchange() : base( "venMovAnulados" ) {
     }

     public venMovAnuladosActionExchange(venMovAnuladosActionEnum.EnumvenMovAnuladosAction pAccion) : base(venMovAnuladosActionEnum.GetAccionvenMovAnuladosAction(pAccion)) {
     }

     public venMovAnuladosActionExchange(venMovAnuladosActionEnum.EnumvenMovAnuladosAction pAccion, VentasCommon.venMovAnuladosDS pdsParam) : base(venMovAnuladosActionEnum.GetAccionvenMovAnuladosAction(pAccion), pdsParam) {
     }

     public venMovAnuladosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovAnuladosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovAnuladosDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovAnuladosDS)mParam;
	        }
     }
  }
}
