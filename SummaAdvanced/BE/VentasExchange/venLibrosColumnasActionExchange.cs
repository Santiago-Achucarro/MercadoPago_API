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
    public class venLibrosColumnasActionExchange : Framework.Core.Exchange{

        public Int32 venLibros {
            get {
                if(((VentasCommon.venLibrosColumnasDS)mParam).Principal[0]["venLibros"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].venLibros;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].venLibros = value;
               }
	          }
        public bool IsvenLibrosNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].IsvenLibrosNull();
             }
	        }
        public String Libro_Id {
            get {
                if(((VentasCommon.venLibrosColumnasDS)mParam).Principal[0]["Libro_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].Libro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].Libro_Id = value;
               }
	          }
        public bool IsLibro_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].IsLibro_IdNull();
             }
	        }
        public String DescripcionLibros {
            get {
                if(((VentasCommon.venLibrosColumnasDS)mParam).Principal[0]["DescripcionLibros"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].DescripcionLibros;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].DescripcionLibros = value;
               }
	          }
        public bool IsDescripcionLibrosNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].IsDescripcionLibrosNull();
             }
	        }
        public Int32 Columna {
            get {
                if(((VentasCommon.venLibrosColumnasDS)mParam).Principal[0]["Columna"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].Columna;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].Columna = value;
               }
	          }
        public bool IsColumnaNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].IsColumnaNull();
             }
	        }
        public String Titulo {
            get {
                if(((VentasCommon.venLibrosColumnasDS)mParam).Principal[0]["Titulo"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].Titulo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].Titulo = value;
               }
	          }
        public bool IsTituloNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].IsTituloNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venLibrosColumnasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosColumnasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venLibrosColumnasDS );
     }
     public venLibrosColumnasActionExchange() : base( "venLibrosColumnas" ) {
     }

     public venLibrosColumnasActionExchange(venLibrosColumnasActionEnum.EnumvenLibrosColumnasAction pAccion) : base(venLibrosColumnasActionEnum.GetAccionvenLibrosColumnasAction(pAccion)) {
     }

     public venLibrosColumnasActionExchange(venLibrosColumnasActionEnum.EnumvenLibrosColumnasAction pAccion, VentasCommon.venLibrosColumnasDS pdsParam) : base(venLibrosColumnasActionEnum.GetAccionvenLibrosColumnasAction(pAccion), pdsParam) {
     }

     public venLibrosColumnasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venLibrosColumnasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venLibrosColumnasDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venLibrosColumnasDS)mParam;
	        }
     }
  }
}
