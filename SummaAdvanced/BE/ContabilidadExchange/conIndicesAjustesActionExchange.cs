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
    public class conIndicesAjustesActionExchange : Framework.Core.Exchange{

        public Int32 conIndicesAjuste {
            get {
                if(((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0]["conIndicesAjuste"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].conIndicesAjuste;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].conIndicesAjuste = value;
               }
	          }
        public bool IsconIndicesAjusteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].IsconIndicesAjusteNull();
             }
	        }
        public String Indice_Id {
            get {
                if(((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0]["Indice_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].Indice_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].Indice_Id = value;
               }
	          }
        public bool IsIndice_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].IsIndice_IdNull();
             }
	        }
        public String Indice_Id_Nueva {
            get {
                if(((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0]["Indice_Id_Nueva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].Indice_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].Indice_Id_Nueva = value;
               }
	          }
        public bool IsIndice_Id_NuevaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].IsIndice_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conIndicesAjustesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conIndicesAjustesDS );
     }
     public conIndicesAjustesActionExchange() : base( "conIndicesAjustes" ) {
     }

     public conIndicesAjustesActionExchange(conIndicesAjustesActionEnum.EnumconIndicesAjustesAction pAccion) : base(conIndicesAjustesActionEnum.GetAccionconIndicesAjustesAction(pAccion)) {
     }

     public conIndicesAjustesActionExchange(conIndicesAjustesActionEnum.EnumconIndicesAjustesAction pAccion, ContabilidadCommon.conIndicesAjustesDS pdsParam) : base(conIndicesAjustesActionEnum.GetAccionconIndicesAjustesAction(pAccion), pdsParam) {
     }

     public conIndicesAjustesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conIndicesAjustesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conIndicesAjustesDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conIndicesAjustesDS)mParam;
	        }
     }
  }
}
