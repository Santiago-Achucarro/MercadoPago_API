using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesIdTarjetasTipoActionExchange : Framework.Core.Exchange{

        public Int32 tesIdTarjetasTipo {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["tesIdTarjetasTipo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].tesIdTarjetasTipo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].tesIdTarjetasTipo = value;
               }
	          }
        public bool IstesIdTarjetasTipoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IstesIdTarjetasTipoNull();
             }
	        }
        public String TipoTarjeta {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["TipoTarjeta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].TipoTarjeta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].TipoTarjeta = value;
               }
	          }
        public bool IsTipoTarjetaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IsTipoTarjetaNull();
             }
	        }
        public String TipoTarjeta_Nueva {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["TipoTarjeta_Nueva"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].TipoTarjeta_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].TipoTarjeta_Nueva = value;
               }
	          }
        public bool IsTipoTarjeta_NuevaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IsTipoTarjeta_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Clase {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdTarjetasTipoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesIdTarjetasTipoDS );
     }
     public tesIdTarjetasTipoActionExchange() : base( "tesIdTarjetasTipo" ) {
     }

     public tesIdTarjetasTipoActionExchange(tesIdTarjetasTipoActionEnum.EnumtesIdTarjetasTipoAction pAccion) : base(tesIdTarjetasTipoActionEnum.GetAcciontesIdTarjetasTipoAction(pAccion)) {
     }

     public tesIdTarjetasTipoActionExchange(tesIdTarjetasTipoActionEnum.EnumtesIdTarjetasTipoAction pAccion, TesoreriaCommon.tesIdTarjetasTipoDS pdsParam) : base(tesIdTarjetasTipoActionEnum.GetAcciontesIdTarjetasTipoAction(pAccion), pdsParam) {
     }

     public tesIdTarjetasTipoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesIdTarjetasTipoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesIdTarjetasTipoActionExchange(TesoreriaCommon.tesIdTarjetasTipoDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesIdTarjetasTipoDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesIdTarjetasTipoDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesIdTarjetasTipoDS)mParam;
	        }
     }
  }
}
