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
    public class venGraTortaVendedorActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public DateTime FechaHasta_Nueva {
            get {
                if(((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0]["FechaHasta_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].FechaHasta_Nueva;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].FechaHasta_Nueva = value;
               }
	          }
        public bool IsFechaHasta_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].IsFechaHasta_NuevaNull();
             }
	        }
        public String VendedorDesde {
            get {
                if(((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0]["VendedorDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].VendedorDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].VendedorDesde = value;
               }
	          }
        public bool IsVendedorDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].IsVendedorDesdeNull();
             }
	        }
        public String VendedorHasta {
            get {
                if(((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0]["VendedorHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].VendedorHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].VendedorHasta = value;
               }
	          }
        public bool IsVendedorHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].IsVendedorHastaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String SucursalDesde {
            get {
                if(((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaVendedorDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venGraTortaVendedorDS );
     }
     public venGraTortaVendedorActionExchange() : base( "venGraTortaVendedor" ) {
     }

     public venGraTortaVendedorActionExchange(venGraTortaVendedorActionEnum.EnumvenGraTortaVendedorAction pAccion) : base(venGraTortaVendedorActionEnum.GetAccionvenGraTortaVendedorAction(pAccion)) {
     }

     public venGraTortaVendedorActionExchange(venGraTortaVendedorActionEnum.EnumvenGraTortaVendedorAction pAccion, VentasCommon.venGraTortaVendedorDS pdsParam) : base(venGraTortaVendedorActionEnum.GetAccionvenGraTortaVendedorAction(pAccion), pdsParam) {
     }

     public venGraTortaVendedorActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venGraTortaVendedorDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venGraTortaVendedorActionExchange(VentasCommon.venGraTortaVendedorDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venGraTortaVendedorDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venGraTortaVendedorDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venGraTortaVendedorDS)mParam;
	        }
     }
  }
}
