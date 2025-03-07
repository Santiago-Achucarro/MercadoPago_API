using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesteoExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class espstkColorTestActionExchange : Framework.Core.Exchange{

        public Int32 espstkColorTest {
            get {
                if(((TestCommon.espstkColorTestDS)mParam).Principal[0]["espstkColorTest"] != DBNull.Value  ){
                    return ((TestCommon.espstkColorTestDS)mParam).Principal[0].espstkColorTest;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TestCommon.espstkColorTestDS)mParam).Principal[0].espstkColorTest = value;
               }
	          }
        public bool IsespstkColorTestNull {
             get {
                 return mParam==null || ((TestCommon.espstkColorTestDS)mParam).Principal[0].IsespstkColorTestNull();
             }
	        }
        public String Color_Id {
            get {
                if(((TestCommon.espstkColorTestDS)mParam).Principal[0]["Color_Id"] != DBNull.Value  ){
                    return ((TestCommon.espstkColorTestDS)mParam).Principal[0].Color_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TestCommon.espstkColorTestDS)mParam).Principal[0].Color_Id = value;
               }
	          }
        public bool IsColor_IdNull {
             get {
                 return mParam==null || ((TestCommon.espstkColorTestDS)mParam).Principal[0].IsColor_IdNull();
             }
	        }
        public String Color_Id_Nueva {
            get {
                if(((TestCommon.espstkColorTestDS)mParam).Principal[0]["Color_Id_Nueva"] != DBNull.Value  ){
                    return ((TestCommon.espstkColorTestDS)mParam).Principal[0].Color_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TestCommon.espstkColorTestDS)mParam).Principal[0].Color_Id_Nueva = value;
               }
	          }
        public bool IsColor_Id_NuevaNull {
             get {
                 return mParam==null || ((TestCommon.espstkColorTestDS)mParam).Principal[0].IsColor_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TestCommon.espstkColorTestDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TestCommon.espstkColorTestDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TestCommon.espstkColorTestDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TestCommon.espstkColorTestDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((TestCommon.espstkColorTestDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((TestCommon.espstkColorTestDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TestCommon.espstkColorTestDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((TestCommon.espstkColorTestDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TestCommon.espstkColorTestDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TestCommon.espstkColorTestDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TestCommon.espstkColorTestDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TestCommon.espstkColorTestDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((TestCommon.espstkColorTestDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((TestCommon.espstkColorTestDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TestCommon.espstkColorTestDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((TestCommon.espstkColorTestDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TestCommon.espstkColorTestDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TestCommon.espstkColorTestDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TestCommon.espstkColorTestDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TestCommon.espstkColorTestDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TestCommon.espstkColorTestDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TestCommon.espstkColorTestDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TestCommon.espstkColorTestDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TestCommon.espstkColorTestDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TestCommon.espstkColorTestDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TestCommon.espstkColorTestDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TestCommon.espstkColorTestDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TestCommon.espstkColorTestDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TestCommon.espstkColorTestDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TestCommon.espstkColorTestDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TestCommon.espstkColorTestDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TestCommon.espstkColorTestDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TestCommon.espstkColorTestDS );
     }
     public espstkColorTestActionExchange() : base( "espstkColorTest" ) {
     }

     public espstkColorTestActionExchange(espstkColorTestActionEnum.EnumespstkColorTestAction pAccion) : base(espstkColorTestActionEnum.GetAccionespstkColorTestAction(pAccion)) {
     }

     public espstkColorTestActionExchange(espstkColorTestActionEnum.EnumespstkColorTestAction pAccion, TestCommon.espstkColorTestDS pdsParam) : base(espstkColorTestActionEnum.GetAccionespstkColorTestAction(pAccion), pdsParam) {
     }

     public espstkColorTestActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TestCommon.espstkColorTestDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TestCommon.espstkColorTestDS Param{
	        get{
			    InitParam();
			    return (TestCommon.espstkColorTestDS)mParam;
	        }
     }
  }
}
