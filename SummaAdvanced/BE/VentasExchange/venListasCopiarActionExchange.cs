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
    public class venListasCopiarActionExchange : Framework.Core.Exchange{

        public String Lista {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["Lista"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Lista;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Lista = value;
               }
	          }
        public bool IsListaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsListaNull();
             }
	        }
        public Int32 Version {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["Version"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Version;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Version = value;
               }
	          }
        public bool IsVersionNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsVersionNull();
             }
	        }
        public String Lista_Ap {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["Lista_Ap"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Lista_Ap;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Lista_Ap = value;
               }
	          }
        public bool IsLista_ApNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsLista_ApNull();
             }
	        }
        public Int32 Version_Ap {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["Version_Ap"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Version_Ap;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Version_Ap = value;
               }
	          }
        public bool IsVersion_ApNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsVersion_ApNull();
             }
	        }
        public Decimal Coeficiente {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["Coeficiente"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Coeficiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Coeficiente = value;
               }
	          }
        public bool IsCoeficienteNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsCoeficienteNull();
             }
	        }
        public Int32 Decimales {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["Decimales"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Decimales;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Decimales = value;
               }
	          }
        public bool IsDecimalesNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsDecimalesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Descripcion_Ap {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["Descripcion_Ap"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Descripcion_Ap;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].Descripcion_Ap = value;
               }
	          }
        public bool IsDescripcion_ApNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsDescripcion_ApNull();
             }
	        }
        public String ProductoDesde {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public DateTime VigenciaDesde {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["VigenciaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].VigenciaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].VigenciaDesde = value;
               }
	          }
        public bool IsVigenciaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsVigenciaDesdeNull();
             }
	        }
        public DateTime VigenciaHasta {
            get {
                if(((VentasCommon.venListasCopiarDS)mParam).Principal[0]["VigenciaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListasCopiarDS)mParam).Principal[0].VigenciaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasCopiarDS)mParam).Principal[0].VigenciaHasta = value;
               }
	          }
        public bool IsVigenciaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasCopiarDS)mParam).Principal[0].IsVigenciaHastaNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venListasCopiarDS );
     }
     public venListasCopiarActionExchange() : base( "venListasCopiar" ) {
     }

     public venListasCopiarActionExchange(venListasCopiarActionEnum.EnumvenListasCopiarAction pAccion) : base(venListasCopiarActionEnum.GetAccionvenListasCopiarAction(pAccion)) {
     }

     public venListasCopiarActionExchange(venListasCopiarActionEnum.EnumvenListasCopiarAction pAccion, VentasCommon.venListasCopiarDS pdsParam) : base(venListasCopiarActionEnum.GetAccionvenListasCopiarAction(pAccion), pdsParam) {
     }

     public venListasCopiarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venListasCopiarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venListasCopiarDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venListasCopiarDS)mParam;
	        }
     }
  }
}
