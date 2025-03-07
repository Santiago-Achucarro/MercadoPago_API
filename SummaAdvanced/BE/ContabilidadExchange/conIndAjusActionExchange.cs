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
    public class conIndAjusActionExchange : Framework.Core.Exchange{

        public String Indice_Id {
            get {
                if(((ContabilidadCommon.conIndAjusDS)mParam).Principal[0]["Indice_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].Indice_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].Indice_Id = value;
               }
	          }
        public bool IsIndice_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].IsIndice_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conIndAjusDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int16 Ejercicio {
            get {
                if(((ContabilidadCommon.conIndAjusDS)mParam).Principal[0]["Ejercicio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].Ejercicio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].Ejercicio = value;
               }
	          }
        public bool IsEjercicioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].IsEjercicioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conIndAjusDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conIndAjusDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conIndAjusDS );
     }
     public conIndAjusActionExchange() : base( "conIndAjus" ) {
     }

     public conIndAjusActionExchange(conIndAjusActionEnum.EnumconIndAjusAction pAccion) : base(conIndAjusActionEnum.GetAccionconIndAjusAction(pAccion)) {
     }

     public conIndAjusActionExchange(conIndAjusActionEnum.EnumconIndAjusAction pAccion, ContabilidadCommon.conIndAjusDS pdsParam) : base(conIndAjusActionEnum.GetAccionconIndAjusAction(pAccion), pdsParam) {
     }

     public conIndAjusActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conIndAjusDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conIndAjusDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conIndAjusDS)mParam;
	        }
     }
  }
}
