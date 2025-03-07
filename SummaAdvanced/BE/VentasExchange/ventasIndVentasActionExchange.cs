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
    public class ventasIndVentasActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public DateTime FechaHasta_Nueva {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["FechaHasta_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].FechaHasta_Nueva;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].FechaHasta_Nueva = value;
               }
	          }
        public bool IsFechaHasta_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsFechaHasta_NuevaNull();
             }
	        }
        public String VendedorDesde {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["VendedorDesde"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].VendedorDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].VendedorDesde = value;
               }
	          }
        public bool IsVendedorDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsVendedorDesdeNull();
             }
	        }
        public String VendedorHasta {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["VendedorHasta"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].VendedorHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].VendedorHasta = value;
               }
	          }
        public bool IsVendedorHastaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsVendedorHastaNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public String ProductoDesde {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Decimal VentaTotal {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["VentaTotal"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].VentaTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].VentaTotal = value;
               }
	          }
        public bool IsVentaTotalNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsVentaTotalNull();
             }
	        }
        public Decimal VentaMismoPerAnioAnt {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["VentaMismoPerAnioAnt"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].VentaMismoPerAnioAnt;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].VentaMismoPerAnioAnt = value;
               }
	          }
        public bool IsVentaMismoPerAnioAntNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsVentaMismoPerAnioAntNull();
             }
	        }
        public Decimal VentaPerAnterior {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["VentaPerAnterior"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].VentaPerAnterior;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].VentaPerAnterior = value;
               }
	          }
        public bool IsVentaPerAnteriorNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsVentaPerAnteriorNull();
             }
	        }
        public String SucursalDesde {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.ventasIndVentasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.ventasIndVentasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.ventasIndVentasDS );
     }
     public ventasIndVentasActionExchange() : base( "ventasIndVentas" ) {
     }

     public ventasIndVentasActionExchange(ventasIndVentasActionEnum.EnumventasIndVentasAction pAccion) : base(ventasIndVentasActionEnum.GetAccionventasIndVentasAction(pAccion)) {
     }

     public ventasIndVentasActionExchange(ventasIndVentasActionEnum.EnumventasIndVentasAction pAccion, VentasCommon.ventasIndVentasDS pdsParam) : base(ventasIndVentasActionEnum.GetAccionventasIndVentasAction(pAccion), pdsParam) {
     }

     public ventasIndVentasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.ventasIndVentasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public ventasIndVentasActionExchange(VentasCommon.ventasIndVentasDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.ventasIndVentasDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.ventasIndVentasDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.ventasIndVentasDS)mParam;
	        }
     }
  }
}
