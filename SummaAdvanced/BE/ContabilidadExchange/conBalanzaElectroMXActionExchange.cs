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
    public class conBalanzaElectroMXActionExchange : Framework.Core.Exchange{

        public Int32 Anio {
            get {
                if(((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Nivel {
            get {
                if(((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0]["Nivel"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].Nivel;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].Nivel = value;
               }
	          }
        public bool IsNivelNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].IsNivelNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBalanzaElectroMXDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conBalanzaElectroMXDS );
     }
     public conBalanzaElectroMXActionExchange() : base( "conBalanzaElectroMX" ) {
     }

     public conBalanzaElectroMXActionExchange(conBalanzaElectroMXActionEnum.EnumconBalanzaElectroMXAction pAccion) : base(conBalanzaElectroMXActionEnum.GetAccionconBalanzaElectroMXAction(pAccion)) {
     }

     public conBalanzaElectroMXActionExchange(conBalanzaElectroMXActionEnum.EnumconBalanzaElectroMXAction pAccion, ContabilidadCommon.conBalanzaElectroMXDS pdsParam) : base(conBalanzaElectroMXActionEnum.GetAccionconBalanzaElectroMXAction(pAccion), pdsParam) {
     }

     public conBalanzaElectroMXActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conBalanzaElectroMXDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conBalanzaElectroMXDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conBalanzaElectroMXDS)mParam;
	        }
     }
  }
}
