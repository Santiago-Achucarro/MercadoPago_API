using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkCausasMoviActionExchange : Framework.Core.Exchange{

        public Int32 stkCausasMovi {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["stkCausasMovi"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].stkCausasMovi;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].stkCausasMovi = value;
               }
	          }
        public bool IsstkCausasMoviNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsstkCausasMoviNull();
             }
	        }
        public String Causa_Id {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["Causa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Causa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Causa_Id = value;
               }
	          }
        public bool IsCausa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsCausa_IdNull();
             }
	        }
        public String Causa_Id_Nueva {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["Causa_Id_Nueva"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Causa_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Causa_Id_Nueva = value;
               }
	          }
        public bool IsCausa_Id_NuevaNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsCausa_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String EntSalAmb {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["EntSalAmb"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].EntSalAmb;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].EntSalAmb = value;
               }
	          }
        public bool IsEntSalAmbNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsEntSalAmbNull();
             }
	        }
        public String UsuarioAutorizado {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["UsuarioAutorizado"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].UsuarioAutorizado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].UsuarioAutorizado = value;
               }
	          }
        public bool IsUsuarioAutorizadoNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsUsuarioAutorizadoNull();
             }
	        }
        public String DescripcionUsuarioAutorizado {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["DescripcionUsuarioAutorizado"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].DescripcionUsuarioAutorizado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].DescripcionUsuarioAutorizado = value;
               }
	          }
        public bool IsDescripcionUsuarioAutorizadoNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsDescripcionUsuarioAutorizadoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkCausasMoviDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCausasMoviDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkCausasMoviDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkCausasMoviDS );
     }
     public stkCausasMoviActionExchange() : base( "stkCausasMovi" ) {
     }

     public stkCausasMoviActionExchange(stkCausasMoviActionEnum.EnumstkCausasMoviAction pAccion) : base(stkCausasMoviActionEnum.GetAccionstkCausasMoviAction(pAccion)) {
     }

     public stkCausasMoviActionExchange(stkCausasMoviActionEnum.EnumstkCausasMoviAction pAccion, StockCommon.stkCausasMoviDS pdsParam) : base(stkCausasMoviActionEnum.GetAccionstkCausasMoviAction(pAccion), pdsParam) {
     }

     public stkCausasMoviActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkCausasMoviDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkCausasMoviDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkCausasMoviDS)mParam;
	        }
     }
  }
}
