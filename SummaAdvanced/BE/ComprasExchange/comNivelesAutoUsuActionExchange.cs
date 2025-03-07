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
    public class comNivelesAutoUsuActionExchange : Framework.Core.Exchange{

        public String Usuario_Id {
            get {
                if(((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String NivelAuto_Id {
            get {
                if(((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0]["NivelAuto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].NivelAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].NivelAuto_Id = value;
               }
	          }
        public bool IsNivelAuto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].IsNivelAuto_IdNull();
             }
	        }
        public String DescripcioncomNivelesAuto {
            get {
                if(((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0]["DescripcioncomNivelesAuto"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].DescripcioncomNivelesAuto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].DescripcioncomNivelesAuto = value;
               }
	          }
        public bool IsDescripcioncomNivelesAutoNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].IsDescripcioncomNivelesAutoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comNivelesAutoUsuDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comNivelesAutoUsuDS );
     }
     public comNivelesAutoUsuActionExchange() : base( "comNivelesAutoUsu" ) {
     }

     public comNivelesAutoUsuActionExchange(comNivelesAutoUsuActionEnum.EnumcomNivelesAutoUsuAction pAccion) : base(comNivelesAutoUsuActionEnum.GetAccioncomNivelesAutoUsuAction(pAccion)) {
     }

     public comNivelesAutoUsuActionExchange(comNivelesAutoUsuActionEnum.EnumcomNivelesAutoUsuAction pAccion, ComprasCommon.comNivelesAutoUsuDS pdsParam) : base(comNivelesAutoUsuActionEnum.GetAccioncomNivelesAutoUsuAction(pAccion), pdsParam) {
     }

     public comNivelesAutoUsuActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comNivelesAutoUsuDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comNivelesAutoUsuDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comNivelesAutoUsuDS)mParam;
	        }
     }
  }
}
