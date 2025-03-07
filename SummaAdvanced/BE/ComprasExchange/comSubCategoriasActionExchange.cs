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
    public class comSubCategoriasActionExchange : Framework.Core.Exchange{

        public Int32 comSubCategorias {
            get {
                if(((ComprasCommon.comSubCategoriasDS)mParam).Principal[0]["comSubCategorias"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].comSubCategorias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].comSubCategorias = value;
               }
	          }
        public bool IscomSubCategoriasNull {
             get {
                 return mParam==null || ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].IscomSubCategoriasNull();
             }
	        }
        public String SubCategoria_Id {
            get {
                if(((ComprasCommon.comSubCategoriasDS)mParam).Principal[0]["SubCategoria_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].SubCategoria_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].SubCategoria_Id = value;
               }
	          }
        public bool IsSubCategoria_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].IsSubCategoria_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comSubCategoriasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Categoria_Id {
            get {
                if(((ComprasCommon.comSubCategoriasDS)mParam).Principal[0]["Categoria_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].Categoria_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].Categoria_Id = value;
               }
	          }
        public bool IsCategoria_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].IsCategoria_IdNull();
             }
	        }
        public String DescripcionCategorias {
            get {
                if(((ComprasCommon.comSubCategoriasDS)mParam).Principal[0]["DescripcionCategorias"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].DescripcionCategorias;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].DescripcionCategorias = value;
               }
	          }
        public bool IsDescripcionCategoriasNull {
             get {
                 return mParam==null || ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].IsDescripcionCategoriasNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comSubCategoriasDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comSubCategoriasDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comSubCategoriasDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comSubCategoriasDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comSubCategoriasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comSubCategoriasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comSubCategoriasDS );
     }
     public comSubCategoriasActionExchange() : base( "comSubCategorias" ) {
     }

     public comSubCategoriasActionExchange(comSubCategoriasActionEnum.EnumcomSubCategoriasAction pAccion) : base(comSubCategoriasActionEnum.GetAccioncomSubCategoriasAction(pAccion)) {
     }

     public comSubCategoriasActionExchange(comSubCategoriasActionEnum.EnumcomSubCategoriasAction pAccion, ComprasCommon.comSubCategoriasDS pdsParam) : base(comSubCategoriasActionEnum.GetAccioncomSubCategoriasAction(pAccion), pdsParam) {
     }

     public comSubCategoriasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comSubCategoriasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comSubCategoriasDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comSubCategoriasDS)mParam;
	        }
     }
  }
}
