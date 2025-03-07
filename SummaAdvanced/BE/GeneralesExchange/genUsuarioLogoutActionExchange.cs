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
    public class genUsuarioLogoutActionExchange : Framework.Core.Exchange{

        public Int32 genUsuario {
            get {
                if(((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0]["genUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0].genUsuario;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0].genUsuario = value;
               }
	          }
        public bool IsgenUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0].IsgenUsuarioNull();
             }
	        }
        public String Token {
            get {
                if(((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0]["Token"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0].Token;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0].Token = value;
               }
	          }
        public bool IsTokenNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0].IsTokenNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLogoutDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genUsuarioLogoutDS );
     }
     public genUsuarioLogoutActionExchange() : base( "genUsuarioLogout" ) {
     }

     public genUsuarioLogoutActionExchange(genUsuarioLogoutActionEnum.EnumgenUsuarioLogoutAction pAccion) : base(genUsuarioLogoutActionEnum.GetAcciongenUsuarioLogoutAction(pAccion)) {
     }

     public genUsuarioLogoutActionExchange(genUsuarioLogoutActionEnum.EnumgenUsuarioLogoutAction pAccion, GeneralesCommon.genUsuarioLogoutDS pdsParam) : base(genUsuarioLogoutActionEnum.GetAcciongenUsuarioLogoutAction(pAccion), pdsParam) {
     }

     public genUsuarioLogoutActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genUsuarioLogoutDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genUsuarioLogoutDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genUsuarioLogoutDS)mParam;
	        }
     }
  }
}
