using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ImpExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class espstkColorImpActionExchange : Framework.Core.Exchange{

        public Int32 espstkColorImp {
            get {
                if(((ImpCommon.espstkColorImpDS)mParam).Principal[0]["espstkColorImp"] != DBNull.Value  ){
                    return ((ImpCommon.espstkColorImpDS)mParam).Principal[0].espstkColorImp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkColorImpDS)mParam).Principal[0].espstkColorImp = value;
               }
	          }
        public bool IsespstkColorImpNull {
             get {
                 return mParam==null || ((ImpCommon.espstkColorImpDS)mParam).Principal[0].IsespstkColorImpNull();
             }
	        }
        public String Color_Id {
            get {
                if(((ImpCommon.espstkColorImpDS)mParam).Principal[0]["Color_Id"] != DBNull.Value  ){
                    return ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Color_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Color_Id = value;
               }
	          }
        public bool IsColor_IdNull {
             get {
                 return mParam==null || ((ImpCommon.espstkColorImpDS)mParam).Principal[0].IsColor_IdNull();
             }
	        }
        public String Color_Id_Nueva {
            get {
                if(((ImpCommon.espstkColorImpDS)mParam).Principal[0]["Color_Id_Nueva"] != DBNull.Value  ){
                    return ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Color_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Color_Id_Nueva = value;
               }
	          }
        public bool IsColor_Id_NuevaNull {
             get {
                 return mParam==null || ((ImpCommon.espstkColorImpDS)mParam).Principal[0].IsColor_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ImpCommon.espstkColorImpDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ImpCommon.espstkColorImpDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ImpCommon.espstkColorImpDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ImpCommon.espstkColorImpDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkColorImpDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ImpCommon.espstkColorImpDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ImpCommon.espstkColorImpDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ImpCommon.espstkColorImpDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ImpCommon.espstkColorImpDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ImpCommon.espstkColorImpDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ImpCommon.espstkColorImpDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ImpCommon.espstkColorImpDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ImpCommon.espstkColorImpDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ImpCommon.espstkColorImpDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkColorImpDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ImpCommon.espstkColorImpDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ImpCommon.espstkColorImpDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ImpCommon.espstkColorImpDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpCommon.espstkColorImpDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkColorImpDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpCommon.espstkColorImpDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpCommon.espstkColorImpDS );
     }
     public espstkColorImpActionExchange() : base( "espstkColorImp" ) {
     }

     public espstkColorImpActionExchange(espstkColorImpActionEnum.EnumespstkColorImpAction pAccion) : base(espstkColorImpActionEnum.GetAccionespstkColorImpAction(pAccion)) {
     }

     public espstkColorImpActionExchange(espstkColorImpActionEnum.EnumespstkColorImpAction pAccion, ImpCommon.espstkColorImpDS pdsParam) : base(espstkColorImpActionEnum.GetAccionespstkColorImpAction(pAccion), pdsParam) {
     }

     public espstkColorImpActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpCommon.espstkColorImpDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpCommon.espstkColorImpDS Param{
	        get{
			    InitParam();
			    return (ImpCommon.espstkColorImpDS)mParam;
	        }
     }
  }
}
