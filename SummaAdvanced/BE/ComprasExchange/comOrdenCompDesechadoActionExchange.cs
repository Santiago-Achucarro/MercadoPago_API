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
    public class comOrdenCompDesechadoActionExchange : Framework.Core.Exchange{

        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompDesechadoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOrdenCompDesechadoDS );
     }
     public comOrdenCompDesechadoActionExchange() : base( "comOrdenCompDesechado" ) {
     }

     public comOrdenCompDesechadoActionExchange(comOrdenCompDesechadoActionEnum.EnumcomOrdenCompDesechadoAction pAccion) : base(comOrdenCompDesechadoActionEnum.GetAccioncomOrdenCompDesechadoAction(pAccion)) {
     }

     public comOrdenCompDesechadoActionExchange(comOrdenCompDesechadoActionEnum.EnumcomOrdenCompDesechadoAction pAccion, ComprasCommon.comOrdenCompDesechadoDS pdsParam) : base(comOrdenCompDesechadoActionEnum.GetAccioncomOrdenCompDesechadoAction(pAccion), pdsParam) {
     }

     public comOrdenCompDesechadoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOrdenCompDesechadoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOrdenCompDesechadoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOrdenCompDesechadoDS)mParam;
	        }
     }
  }
}
