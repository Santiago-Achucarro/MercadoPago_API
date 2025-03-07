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
    public class QueBonifActionExchange : Framework.Core.Exchange{

        public Int32 Prioridad {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["Prioridad"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].Prioridad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].Prioridad = value;
               }
	          }
        public bool IsPrioridadNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsPrioridadNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public String Bonificacion {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["Bonificacion"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].Bonificacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].Bonificacion = value;
               }
	          }
        public bool IsBonificacionNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsBonificacionNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 SucursalClie {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["SucursalClie"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].SucursalClie;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].SucursalClie = value;
               }
	          }
        public bool IsSucursalClieNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsSucursalClieNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Sucursal {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public String ProductoDesde {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public String TipoProductoDesde {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["TipoProductoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].TipoProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].TipoProductoDesde = value;
               }
	          }
        public bool IsTipoProductoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsTipoProductoDesdeNull();
             }
	        }
        public String TipoProductoHasta {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["TipoProductoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].TipoProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].TipoProductoHasta = value;
               }
	          }
        public bool IsTipoProductoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsTipoProductoHastaNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Int32 venBonifTemporal {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["venBonifTemporal"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].venBonifTemporal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].venBonifTemporal = value;
               }
	          }
        public bool IsvenBonifTemporalNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsvenBonifTemporalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.QueBonifDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.QueBonifDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.QueBonifDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.QueBonifDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.QueBonifDS );
     }
     public QueBonifActionExchange() : base( "QueBonif" ) {
     }

     public QueBonifActionExchange(QueBonifActionEnum.EnumQueBonifAction pAccion) : base(QueBonifActionEnum.GetAccionQueBonifAction(pAccion)) {
     }

     public QueBonifActionExchange(QueBonifActionEnum.EnumQueBonifAction pAccion, VentasCommon.QueBonifDS pdsParam) : base(QueBonifActionEnum.GetAccionQueBonifAction(pAccion), pdsParam) {
     }

     public QueBonifActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.QueBonifDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public QueBonifActionExchange(VentasCommon.QueBonifDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.QueBonifDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.QueBonifDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.QueBonifDS)mParam;
	        }
     }
  }
}
