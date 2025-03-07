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
    public class venListaCoeficienteActionExchange : Framework.Core.Exchange{

        public String Lista {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["Lista"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Lista;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Lista = value;
               }
	          }
        public bool IsListaNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsListaNull();
             }
	        }
        public Int32 Version {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["Version"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Version;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Version = value;
               }
	          }
        public bool IsVersionNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsVersionNull();
             }
	        }
        public Decimal Coeficiente {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["Coeficiente"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Coeficiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Coeficiente = value;
               }
	          }
        public bool IsCoeficienteNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsCoeficienteNull();
             }
	        }
        public Int32 Decimales {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["Decimales"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Decimales;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Decimales = value;
               }
	          }
        public bool IsDecimalesNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsDecimalesNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String ProductoDesde {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venListaCoeficienteDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venListaCoeficienteDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venListaCoeficienteDS );
     }
     public venListaCoeficienteActionExchange() : base( "venListaCoeficiente" ) {
     }

     public venListaCoeficienteActionExchange(venListaCoeficienteActionEnum.EnumvenListaCoeficienteAction pAccion) : base(venListaCoeficienteActionEnum.GetAccionvenListaCoeficienteAction(pAccion)) {
     }

     public venListaCoeficienteActionExchange(venListaCoeficienteActionEnum.EnumvenListaCoeficienteAction pAccion, VentasCommon.venListaCoeficienteDS pdsParam) : base(venListaCoeficienteActionEnum.GetAccionvenListaCoeficienteAction(pAccion), pdsParam) {
     }

     public venListaCoeficienteActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venListaCoeficienteDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venListaCoeficienteDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venListaCoeficienteDS)mParam;
	        }
     }
  }
}
