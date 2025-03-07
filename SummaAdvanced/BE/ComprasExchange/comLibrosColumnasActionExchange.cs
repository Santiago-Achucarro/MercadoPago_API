using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comLibrosColumnasActionExchange : Framework.Core.Exchange{

        public Int32 comLibros {
            get {
                if(((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0]["comLibros"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].comLibros;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].comLibros = value;
               }
	          }
        public bool IscomLibrosNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].IscomLibrosNull();
             }
	        }
        public String Libro_Id {
            get {
                if(((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0]["Libro_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].Libro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].Libro_Id = value;
               }
	          }
        public bool IsLibro_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].IsLibro_IdNull();
             }
	        }
        public String DescripcionLIbros {
            get {
                if(((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0]["DescripcionLIbros"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].DescripcionLIbros;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].DescripcionLIbros = value;
               }
	          }
        public bool IsDescripcionLIbrosNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].IsDescripcionLIbrosNull();
             }
	        }
        public Int32 Columna {
            get {
                if(((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0]["Columna"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].Columna;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].Columna = value;
               }
	          }
        public bool IsColumnaNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].IsColumnaNull();
             }
	        }
        public String Titulo {
            get {
                if(((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0]["Titulo"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].Titulo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].Titulo = value;
               }
	          }
        public bool IsTituloNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].IsTituloNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosColumnasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comLibrosColumnasDS );
     }
     public comLibrosColumnasActionExchange() : base( "comLibrosColumnas" ) {
     }

     public comLibrosColumnasActionExchange(comLibrosColumnasActionEnum.EnumcomLibrosColumnasAction pAccion) : base(comLibrosColumnasActionEnum.GetAccioncomLibrosColumnasAction(pAccion)) {
     }

     public comLibrosColumnasActionExchange(comLibrosColumnasActionEnum.EnumcomLibrosColumnasAction pAccion, ComprasCommon.comLibrosColumnasDS pdsParam) : base(comLibrosColumnasActionEnum.GetAccioncomLibrosColumnasAction(pAccion), pdsParam) {
     }

     public comLibrosColumnasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comLibrosColumnasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comLibrosColumnasDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comLibrosColumnasDS)mParam;
	        }
     }
  }
}
