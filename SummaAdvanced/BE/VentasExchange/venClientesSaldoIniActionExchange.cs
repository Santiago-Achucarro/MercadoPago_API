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
    public class venClientesSaldoIniActionExchange : Framework.Core.Exchange{

        public String ClienteDesde {
            get {
                if(((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public String ClienteHasta_Nueva {
            get {
                if(((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0]["ClienteHasta_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].ClienteHasta_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].ClienteHasta_Nueva = value;
               }
	          }
        public bool IsClienteHasta_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].IsClienteHasta_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Archivo {
            get {
                if(((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0]["Archivo"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].Archivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].Archivo = value;
               }
	          }
        public bool IsArchivoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].IsArchivoNull();
             }
	        }
        public Int32 ClienteActual {
            get {
                if(((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0]["ClienteActual"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].ClienteActual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].ClienteActual = value;
               }
	          }
        public bool IsClienteActualNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].IsClienteActualNull();
             }
	        }
        public String Termino {
            get {
                if(((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0]["Termino"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].Termino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].Termino = value;
               }
	          }
        public bool IsTerminoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].IsTerminoNull();
             }
	        }
        public String Mensaje {
            get {
                if(((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0]["Mensaje"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].Mensaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].Mensaje = value;
               }
	          }
        public bool IsMensajeNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].IsMensajeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesSaldoIniDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venClientesSaldoIniDS );
     }
     public venClientesSaldoIniActionExchange() : base( "venClientesSaldoIni" ) {
     }

     public venClientesSaldoIniActionExchange(venClientesSaldoIniActionEnum.EnumvenClientesSaldoIniAction pAccion) : base(venClientesSaldoIniActionEnum.GetAccionvenClientesSaldoIniAction(pAccion)) {
     }

     public venClientesSaldoIniActionExchange(venClientesSaldoIniActionEnum.EnumvenClientesSaldoIniAction pAccion, VentasCommon.venClientesSaldoIniDS pdsParam) : base(venClientesSaldoIniActionEnum.GetAccionvenClientesSaldoIniAction(pAccion), pdsParam) {
     }

     public venClientesSaldoIniActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venClientesSaldoIniDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venClientesSaldoIniDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venClientesSaldoIniDS)mParam;
	        }
     }
  }
}
