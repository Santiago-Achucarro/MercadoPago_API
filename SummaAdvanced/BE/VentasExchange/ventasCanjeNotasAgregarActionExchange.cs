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
    public class ventasCanjeNotasAgregarActionExchange : Framework.Core.Exchange{

        public String SucursalEmpr {
            get {
                if(((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0]["SucursalEmpr"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].SucursalEmpr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].SucursalEmpr = value;
               }
	          }
        public bool IsSucursalEmprNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].IsSucursalEmprNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotasAgregarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.ventasCanjeNotasAgregarDS );
     }
     public ventasCanjeNotasAgregarActionExchange() : base( "ventasCanjeNotasAgregar" ) {
     }

     public ventasCanjeNotasAgregarActionExchange(ventasCanjeNotasAgregarActionEnum.EnumventasCanjeNotasAgregarAction pAccion) : base(ventasCanjeNotasAgregarActionEnum.GetAccionventasCanjeNotasAgregarAction(pAccion)) {
     }

     public ventasCanjeNotasAgregarActionExchange(ventasCanjeNotasAgregarActionEnum.EnumventasCanjeNotasAgregarAction pAccion, VentasCommon.ventasCanjeNotasAgregarDS pdsParam) : base(ventasCanjeNotasAgregarActionEnum.GetAccionventasCanjeNotasAgregarAction(pAccion), pdsParam) {
     }

     public ventasCanjeNotasAgregarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.ventasCanjeNotasAgregarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.ventasCanjeNotasAgregarDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.ventasCanjeNotasAgregarDS)mParam;
	        }
     }
  }
}
