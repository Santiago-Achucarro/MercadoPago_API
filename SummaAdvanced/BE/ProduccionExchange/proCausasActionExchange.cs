using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proCausasActionExchange : Framework.Core.Exchange{

        public Int32 proCausas {
            get {
                if(((ProduccionCommon.proCausasDS)mParam).Principal[0]["proCausas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCausasDS)mParam).Principal[0].proCausas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCausasDS)mParam).Principal[0].proCausas = value;
               }
	          }
        public bool IsproCausasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCausasDS)mParam).Principal[0].IsproCausasNull();
             }
	        }
        public String Causa_Id {
            get {
                if(((ProduccionCommon.proCausasDS)mParam).Principal[0]["Causa_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCausasDS)mParam).Principal[0].Causa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCausasDS)mParam).Principal[0].Causa_Id = value;
               }
	          }
        public bool IsCausa_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCausasDS)mParam).Principal[0].IsCausa_IdNull();
             }
	        }
        public String Causa_Id_Nueva {
            get {
                if(((ProduccionCommon.proCausasDS)mParam).Principal[0]["Causa_Id_Nueva"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCausasDS)mParam).Principal[0].Causa_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCausasDS)mParam).Principal[0].Causa_Id_Nueva = value;
               }
	          }
        public bool IsCausa_Id_NuevaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCausasDS)mParam).Principal[0].IsCausa_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ProduccionCommon.proCausasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCausasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCausasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCausasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ProduccionCommon.proCausasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCausasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCausasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCausasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ProduccionCommon.proCausasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCausasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCausasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCausasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ProduccionCommon.proCausasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCausasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCausasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCausasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ProduccionCommon.proCausasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCausasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCausasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCausasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proCausasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proCausasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proCausasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proCausasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proCausasDS );
     }
     public proCausasActionExchange() : base( "proCausas" ) {
     }

     public proCausasActionExchange(proCausasActionEnum.EnumproCausasAction pAccion) : base(proCausasActionEnum.GetAccionproCausasAction(pAccion)) {
     }

     public proCausasActionExchange(proCausasActionEnum.EnumproCausasAction pAccion, ProduccionCommon.proCausasDS pdsParam) : base(proCausasActionEnum.GetAccionproCausasAction(pAccion), pdsParam) {
     }

     public proCausasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proCausasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proCausasDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proCausasDS)mParam;
	        }
     }
  }
}
