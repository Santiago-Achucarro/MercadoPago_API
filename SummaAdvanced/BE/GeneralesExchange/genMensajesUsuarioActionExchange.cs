using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genMensajesUsuarioActionExchange : Framework.Core.Exchange{

        public Int32 genUsuarios {
            get {
                if(((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0]["genUsuarios"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].genUsuarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].genUsuarios = value;
               }
	          }
        public bool IsgenUsuariosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].IsgenUsuariosNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Usuario_id {
            get {
                if(((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0]["Usuario_id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].Usuario_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].Usuario_id = value;
               }
	          }
        public bool IsUsuario_idNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].IsUsuario_idNull();
             }
	        }
        public Boolean Pendientes {
            get {
                if(((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0]["Pendientes"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].Pendientes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].Pendientes = value;
               }
	          }
        public bool IsPendientesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].IsPendientesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesUsuarioDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genMensajesUsuarioDS );
     }
     public genMensajesUsuarioActionExchange() : base( "genMensajesUsuario" ) {
     }

     public genMensajesUsuarioActionExchange(genMensajesUsuarioActionEnum.EnumgenMensajesUsuarioAction pAccion) : base(genMensajesUsuarioActionEnum.GetAcciongenMensajesUsuarioAction(pAccion)) {
     }

     public genMensajesUsuarioActionExchange(genMensajesUsuarioActionEnum.EnumgenMensajesUsuarioAction pAccion, GeneralesCommon.genMensajesUsuarioDS pdsParam) : base(genMensajesUsuarioActionEnum.GetAcciongenMensajesUsuarioAction(pAccion), pdsParam) {
     }

     public genMensajesUsuarioActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genMensajesUsuarioDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genMensajesUsuarioDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genMensajesUsuarioDS)mParam;
	        }
     }
  }
}
