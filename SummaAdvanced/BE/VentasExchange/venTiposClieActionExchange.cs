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
    public class venTiposClieActionExchange : Framework.Core.Exchange{

        public Int32 venTiposClie {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["venTiposClie"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].venTiposClie;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].venTiposClie = value;
               }
	          }
        public bool IsvenTiposClieNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsvenTiposClieNull();
             }
	        }
        public String TipoClie_Id {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["TipoClie_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].TipoClie_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].TipoClie_Id = value;
               }
	          }
        public bool IsTipoClie_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsTipoClie_IdNull();
             }
	        }
        public String TipoClie_Id_Nueva {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["TipoClie_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].TipoClie_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].TipoClie_Id_Nueva = value;
               }
	          }
        public bool IsTipoClie_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsTipoClie_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venTiposClieDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venTiposClieDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venTiposClieDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venTiposClieDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venTiposClieDS );
     }
     public venTiposClieActionExchange() : base( "venTiposClie" ) {
     }

     public venTiposClieActionExchange(venTiposClieActionEnum.EnumvenTiposClieAction pAccion) : base(venTiposClieActionEnum.GetAccionvenTiposClieAction(pAccion)) {
     }

     public venTiposClieActionExchange(venTiposClieActionEnum.EnumvenTiposClieAction pAccion, VentasCommon.venTiposClieDS pdsParam) : base(venTiposClieActionEnum.GetAccionvenTiposClieAction(pAccion), pdsParam) {
     }

     public venTiposClieActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venTiposClieDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venTiposClieDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venTiposClieDS)mParam;
	        }
     }
  }
}
