using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conSituPatriActionExchange : Framework.Core.Exchange{

        public String Rubro_Balance {
            get {
                if(((ContabilidadCommon.conSituPatriDS)mParam).Principal[0]["Rubro_Balance"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].Rubro_Balance;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].Rubro_Balance = value;
               }
	          }
        public bool IsRubro_BalanceNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].IsRubro_BalanceNull();
             }
	        }
        public String Rubro_Id {
            get {
                if(((ContabilidadCommon.conSituPatriDS)mParam).Principal[0]["Rubro_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].Rubro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].Rubro_Id = value;
               }
	          }
        public bool IsRubro_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].IsRubro_IdNull();
             }
	        }
        public String DescripcionRubros {
            get {
                if(((ContabilidadCommon.conSituPatriDS)mParam).Principal[0]["DescripcionRubros"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].DescripcionRubros;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].DescripcionRubros = value;
               }
	          }
        public bool IsDescripcionRubrosNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].IsDescripcionRubrosNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conSituPatriDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Orden {
            get {
                if(((ContabilidadCommon.conSituPatriDS)mParam).Principal[0]["Orden"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].Orden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].Orden = value;
               }
	          }
        public bool IsOrdenNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].IsOrdenNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conSituPatriDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSituPatriDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conSituPatriDS );
     }
     public conSituPatriActionExchange() : base( "conSituPatri" ) {
     }

     public conSituPatriActionExchange(conSituPatriActionEnum.EnumconSituPatriAction pAccion) : base(conSituPatriActionEnum.GetAccionconSituPatriAction(pAccion)) {
     }

     public conSituPatriActionExchange(conSituPatriActionEnum.EnumconSituPatriAction pAccion, ContabilidadCommon.conSituPatriDS pdsParam) : base(conSituPatriActionEnum.GetAccionconSituPatriAction(pAccion), pdsParam) {
     }

     public conSituPatriActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conSituPatriDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conSituPatriDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conSituPatriDS)mParam;
	        }
     }
  }
}
