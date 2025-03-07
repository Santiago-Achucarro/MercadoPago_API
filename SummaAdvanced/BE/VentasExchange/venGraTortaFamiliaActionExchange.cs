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
    public class venGraTortaFamiliaActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public DateTime FechaHasta_Nueva {
            get {
                if(((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0]["FechaHasta_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].FechaHasta_Nueva;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].FechaHasta_Nueva = value;
               }
	          }
        public bool IsFechaHasta_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].IsFechaHasta_NuevaNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String SucursalDesde {
            get {
                if(((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venGraTortaFamiliaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venGraTortaFamiliaDS );
     }
     public venGraTortaFamiliaActionExchange() : base( "venGraTortaFamilia" ) {
     }

     public venGraTortaFamiliaActionExchange(venGraTortaFamiliaActionEnum.EnumvenGraTortaFamiliaAction pAccion) : base(venGraTortaFamiliaActionEnum.GetAccionvenGraTortaFamiliaAction(pAccion)) {
     }

     public venGraTortaFamiliaActionExchange(venGraTortaFamiliaActionEnum.EnumvenGraTortaFamiliaAction pAccion, VentasCommon.venGraTortaFamiliaDS pdsParam) : base(venGraTortaFamiliaActionEnum.GetAccionvenGraTortaFamiliaAction(pAccion), pdsParam) {
     }

     public venGraTortaFamiliaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venGraTortaFamiliaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venGraTortaFamiliaActionExchange(VentasCommon.venGraTortaFamiliaDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venGraTortaFamiliaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venGraTortaFamiliaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venGraTortaFamiliaDS)mParam;
	        }
     }
  }
}
