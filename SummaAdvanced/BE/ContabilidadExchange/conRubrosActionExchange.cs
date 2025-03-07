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
    public class conRubrosActionExchange : Framework.Core.Exchange{

        public String Rubro_Id {
            get {
                if(((ContabilidadCommon.conRubrosDS)mParam).Principal[0]["Rubro_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].Rubro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].Rubro_Id = value;
               }
	          }
        public bool IsRubro_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].IsRubro_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conRubrosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Tipo {
            get {
                if(((ContabilidadCommon.conRubrosDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conRubrosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubrosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conRubrosDS );
     }
     public conRubrosActionExchange() : base( "conRubros" ) {
     }

     public conRubrosActionExchange(conRubrosActionEnum.EnumconRubrosAction pAccion) : base(conRubrosActionEnum.GetAccionconRubrosAction(pAccion)) {
     }

     public conRubrosActionExchange(conRubrosActionEnum.EnumconRubrosAction pAccion, ContabilidadCommon.conRubrosDS pdsParam) : base(conRubrosActionEnum.GetAccionconRubrosAction(pAccion), pdsParam) {
     }

     public conRubrosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conRubrosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conRubrosDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conRubrosDS)mParam;
	        }
     }
  }
}
