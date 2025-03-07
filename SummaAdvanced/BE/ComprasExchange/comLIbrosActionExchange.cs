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
    public class comLIbrosActionExchange : Framework.Core.Exchange{

        public Int32 comLibros {
            get {
                if(((ComprasCommon.comLIbrosDS)mParam).Principal[0]["comLibros"] != DBNull.Value  ){
                    return ((ComprasCommon.comLIbrosDS)mParam).Principal[0].comLibros;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLIbrosDS)mParam).Principal[0].comLibros = value;
               }
	          }
        public bool IscomLibrosNull {
             get {
                 return mParam==null || ((ComprasCommon.comLIbrosDS)mParam).Principal[0].IscomLibrosNull();
             }
	        }
        public Boolean PTodasLasEmpresas {
            get {
                if(((ComprasCommon.comLIbrosDS)mParam).Principal[0]["PTodasLasEmpresas"] != DBNull.Value  ){
                    return ((ComprasCommon.comLIbrosDS)mParam).Principal[0].PTodasLasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLIbrosDS)mParam).Principal[0].PTodasLasEmpresas = value;
               }
	          }
        public bool IsPTodasLasEmpresasNull {
             get {
                 return mParam==null || ((ComprasCommon.comLIbrosDS)mParam).Principal[0].IsPTodasLasEmpresasNull();
             }
	        }
        public String Libro_Id {
            get {
                if(((ComprasCommon.comLIbrosDS)mParam).Principal[0]["Libro_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comLIbrosDS)mParam).Principal[0].Libro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLIbrosDS)mParam).Principal[0].Libro_Id = value;
               }
	          }
        public bool IsLibro_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comLIbrosDS)mParam).Principal[0].IsLibro_IdNull();
             }
	        }
        public String Libro_Id_Nuevo {
            get {
                if(((ComprasCommon.comLIbrosDS)mParam).Principal[0]["Libro_Id_Nuevo"] != DBNull.Value  ){
                    return ((ComprasCommon.comLIbrosDS)mParam).Principal[0].Libro_Id_Nuevo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLIbrosDS)mParam).Principal[0].Libro_Id_Nuevo = value;
               }
	          }
        public bool IsLibro_Id_NuevoNull {
             get {
                 return mParam==null || ((ComprasCommon.comLIbrosDS)mParam).Principal[0].IsLibro_Id_NuevoNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comLIbrosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comLIbrosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLIbrosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comLIbrosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comLIbrosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comLIbrosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLIbrosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comLIbrosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comLIbrosDS );
     }
     public comLIbrosActionExchange() : base( "comLIbros" ) {
     }

     public comLIbrosActionExchange(comLIbrosActionEnum.EnumcomLIbrosAction pAccion) : base(comLIbrosActionEnum.GetAccioncomLIbrosAction(pAccion)) {
     }

     public comLIbrosActionExchange(comLIbrosActionEnum.EnumcomLIbrosAction pAccion, ComprasCommon.comLIbrosDS pdsParam) : base(comLIbrosActionEnum.GetAccioncomLIbrosAction(pAccion), pdsParam) {
     }

     public comLIbrosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comLIbrosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comLIbrosDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comLIbrosDS)mParam;
	        }
     }
  }
}
