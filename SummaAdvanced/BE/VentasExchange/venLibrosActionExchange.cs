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
    public class venLibrosActionExchange : Framework.Core.Exchange{

        public Int32 venLibros {
            get {
                if(((VentasCommon.venLibrosDS)mParam).Principal[0]["venLibros"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosDS)mParam).Principal[0].venLibros;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosDS)mParam).Principal[0].venLibros = value;
               }
	          }
        public bool IsvenLibrosNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosDS)mParam).Principal[0].IsvenLibrosNull();
             }
	        }
        public String Libro_Id {
            get {
                if(((VentasCommon.venLibrosDS)mParam).Principal[0]["Libro_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosDS)mParam).Principal[0].Libro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosDS)mParam).Principal[0].Libro_Id = value;
               }
	          }
        public bool IsLibro_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosDS)mParam).Principal[0].IsLibro_IdNull();
             }
	        }
        public String Libro_Id_Nuevo {
            get {
                if(((VentasCommon.venLibrosDS)mParam).Principal[0]["Libro_Id_Nuevo"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosDS)mParam).Principal[0].Libro_Id_Nuevo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosDS)mParam).Principal[0].Libro_Id_Nuevo = value;
               }
	          }
        public bool IsLibro_Id_NuevoNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosDS)mParam).Principal[0].IsLibro_Id_NuevoNull();
             }
	        }
        public Boolean PTodasLasEmpresas {
            get {
                if(((VentasCommon.venLibrosDS)mParam).Principal[0]["PTodasLasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosDS)mParam).Principal[0].PTodasLasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosDS)mParam).Principal[0].PTodasLasEmpresas = value;
               }
	          }
        public bool IsPTodasLasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosDS)mParam).Principal[0].IsPTodasLasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venLibrosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venLibrosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venLibrosDS );
     }
     public venLibrosActionExchange() : base( "venLibros" ) {
     }

     public venLibrosActionExchange(venLibrosActionEnum.EnumvenLibrosAction pAccion) : base(venLibrosActionEnum.GetAccionvenLibrosAction(pAccion)) {
     }

     public venLibrosActionExchange(venLibrosActionEnum.EnumvenLibrosAction pAccion, VentasCommon.venLibrosDS pdsParam) : base(venLibrosActionEnum.GetAccionvenLibrosAction(pAccion), pdsParam) {
     }

     public venLibrosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venLibrosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venLibrosDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venLibrosDS)mParam;
	        }
     }
  }
}
