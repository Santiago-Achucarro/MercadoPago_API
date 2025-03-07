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
    public class espstkTalleImpActionExchange : Framework.Core.Exchange{

        public Int32 espstkTalleImp {
            get {
                if(((ImpCommon.espstkTalleImpDS)mParam).Principal[0]["espstkTalleImp"] != DBNull.Value  ){
                    return ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].espstkTalleImp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].espstkTalleImp = value;
               }
	          }
        public bool IsespstkTalleImpNull {
             get {
                 return mParam==null || ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].IsespstkTalleImpNull();
             }
	        }
        public String Talle_Id {
            get {
                if(((ImpCommon.espstkTalleImpDS)mParam).Principal[0]["Talle_Id"] != DBNull.Value  ){
                    return ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Talle_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Talle_Id = value;
               }
	          }
        public bool IsTalle_IdNull {
             get {
                 return mParam==null || ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].IsTalle_IdNull();
             }
	        }
        public String Talle_Id_Nueva {
            get {
                if(((ImpCommon.espstkTalleImpDS)mParam).Principal[0]["Talle_Id_Nueva"] != DBNull.Value  ){
                    return ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Talle_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Talle_Id_Nueva = value;
               }
	          }
        public bool IsTalle_Id_NuevaNull {
             get {
                 return mParam==null || ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].IsTalle_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ImpCommon.espstkTalleImpDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ImpCommon.espstkTalleImpDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ImpCommon.espstkTalleImpDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ImpCommon.espstkTalleImpDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ImpCommon.espstkTalleImpDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ImpCommon.espstkTalleImpDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ImpCommon.espstkTalleImpDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpCommon.espstkTalleImpDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpCommon.espstkTalleImpDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpCommon.espstkTalleImpDS );
     }
     public espstkTalleImpActionExchange() : base( "espstkTalleImp" ) {
     }

     public espstkTalleImpActionExchange(espstkTalleImpActionEnum.EnumespstkTalleImpAction pAccion) : base(espstkTalleImpActionEnum.GetAccionespstkTalleImpAction(pAccion)) {
     }

     public espstkTalleImpActionExchange(espstkTalleImpActionEnum.EnumespstkTalleImpAction pAccion, ImpCommon.espstkTalleImpDS pdsParam) : base(espstkTalleImpActionEnum.GetAccionespstkTalleImpAction(pAccion), pdsParam) {
     }

     public espstkTalleImpActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpCommon.espstkTalleImpDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpCommon.espstkTalleImpDS Param{
	        get{
			    InitParam();
			    return (ImpCommon.espstkTalleImpDS)mParam;
	        }
     }
  }
}
