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
    public class venIndicadoresActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Tipo {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public String Titulo {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["Titulo"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].Titulo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].Titulo = value;
               }
	          }
        public bool IsTituloNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsTituloNull();
             }
	        }
        public String VendedorDesde {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["VendedorDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].VendedorDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].VendedorDesde = value;
               }
	          }
        public bool IsVendedorDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsVendedorDesdeNull();
             }
	        }
        public String VendedorHasta {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["VendedorHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].VendedorHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].VendedorHasta = value;
               }
	          }
        public bool IsVendedorHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsVendedorHastaNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public String ProductoDesde {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public Decimal VentaTotal {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["VentaTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].VentaTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].VentaTotal = value;
               }
	          }
        public bool IsVentaTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsVentaTotalNull();
             }
	        }
        public Decimal VentaAnioAnt {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["VentaAnioAnt"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].VentaAnioAnt;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].VentaAnioAnt = value;
               }
	          }
        public bool IsVentaAnioAntNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsVentaAnioAntNull();
             }
	        }
        public Decimal VentaPerioAnt {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["VentaPerioAnt"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].VentaPerioAnt;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].VentaPerioAnt = value;
               }
	          }
        public bool IsVentaPerioAntNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsVentaPerioAntNull();
             }
	        }
        public String SucursalDesde {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venIndicadoresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venIndicadoresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIndicadoresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venIndicadoresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venIndicadoresDS );
     }
     public venIndicadoresActionExchange() : base( "venIndicadores" ) {
     }

     public venIndicadoresActionExchange(venIndicadoresActionEnum.EnumvenIndicadoresAction pAccion) : base(venIndicadoresActionEnum.GetAccionvenIndicadoresAction(pAccion)) {
     }

     public venIndicadoresActionExchange(venIndicadoresActionEnum.EnumvenIndicadoresAction pAccion, VentasCommon.venIndicadoresDS pdsParam) : base(venIndicadoresActionEnum.GetAccionvenIndicadoresAction(pAccion), pdsParam) {
     }

     public venIndicadoresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venIndicadoresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venIndicadoresActionExchange(VentasCommon.venIndicadoresDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venIndicadoresDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venIndicadoresDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venIndicadoresDS)mParam;
	        }
     }
  }
}
