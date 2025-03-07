using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ImpuestosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class impSifereActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((ImpuestosCommon.impSifereDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impSifereDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impSifereDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impSifereDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((ImpuestosCommon.impSifereDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impSifereDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impSifereDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impSifereDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((ImpuestosCommon.impSifereDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impSifereDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impSifereDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impSifereDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impSifereDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impSifereDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impSifereDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impSifereDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impSifereDS );
     }
     public impSifereActionExchange() : base( "impSifere" ) {
     }

     public impSifereActionExchange(impSifereActionEnum.EnumimpSifereAction pAccion) : base(impSifereActionEnum.GetAccionimpSifereAction(pAccion)) {
     }

     public impSifereActionExchange(impSifereActionEnum.EnumimpSifereAction pAccion, ImpuestosCommon.impSifereDS pdsParam) : base(impSifereActionEnum.GetAccionimpSifereAction(pAccion), pdsParam) {
     }

     public impSifereActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impSifereDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impSifereDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impSifereDS)mParam;
	        }
     }
  }
}
