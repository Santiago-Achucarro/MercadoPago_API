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
    public class provarGlobalesActionExchange : Framework.Core.Exchange{

        public Int16 Variable_Id {
            get {
                if(((ProduccionCommon.provarGlobalesDS)mParam).Principal[0]["Variable_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].Variable_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].Variable_Id = value;
               }
	          }
        public bool IsVariable_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].IsVariable_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ProduccionCommon.provarGlobalesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Decimal Valor {
            get {
                if(((ProduccionCommon.provarGlobalesDS)mParam).Principal[0]["Valor"] != DBNull.Value  ){
                    return ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].Valor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].Valor = value;
               }
	          }
        public bool IsValorNull {
             get {
                 return mParam==null || ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].IsValorNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.provarGlobalesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.provarGlobalesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.provarGlobalesDS );
     }
     public provarGlobalesActionExchange() : base( "provarGlobales" ) {
     }

     public provarGlobalesActionExchange(provarGlobalesActionEnum.EnumprovarGlobalesAction pAccion) : base(provarGlobalesActionEnum.GetAccionprovarGlobalesAction(pAccion)) {
     }

     public provarGlobalesActionExchange(provarGlobalesActionEnum.EnumprovarGlobalesAction pAccion, ProduccionCommon.provarGlobalesDS pdsParam) : base(provarGlobalesActionEnum.GetAccionprovarGlobalesAction(pAccion), pdsParam) {
     }

     public provarGlobalesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.provarGlobalesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.provarGlobalesDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.provarGlobalesDS)mParam;
	        }
     }
  }
}
