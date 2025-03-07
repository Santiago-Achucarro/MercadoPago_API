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
    public class conInfDefCuentasActionExchange : Framework.Core.Exchange{

        public String Informe_Id {
            get {
                if(((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0]["Informe_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].Informe_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].Informe_Id = value;
               }
	          }
        public bool IsInforme_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].IsInforme_IdNull();
             }
	        }
        public Int32 Fila {
            get {
                if(((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0]["Fila"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].Fila;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].Fila = value;
               }
	          }
        public bool IsFilaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].IsFilaNull();
             }
	        }
        public String CuentaDesde {
            get {
                if(((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0]["CuentaDesde"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].CuentaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].CuentaDesde = value;
               }
	          }
        public bool IsCuentaDesdeNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].IsCuentaDesdeNull();
             }
	        }
        public String CuentaHasta {
            get {
                if(((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0]["CuentaHasta"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].CuentaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].CuentaHasta = value;
               }
	          }
        public bool IsCuentaHastaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].IsCuentaHastaNull();
             }
	        }
        public Int32 conInfDefinibles {
            get {
                if(((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0]["conInfDefinibles"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].conInfDefinibles;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].conInfDefinibles = value;
               }
	          }
        public bool IsconInfDefiniblesNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].IsconInfDefiniblesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefCuentasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conInfDefCuentasDS );
     }
     public conInfDefCuentasActionExchange() : base( "conInfDefCuentas" ) {
     }

     public conInfDefCuentasActionExchange(conInfDefCuentasActionEnum.EnumconInfDefCuentasAction pAccion) : base(conInfDefCuentasActionEnum.GetAccionconInfDefCuentasAction(pAccion)) {
     }

     public conInfDefCuentasActionExchange(conInfDefCuentasActionEnum.EnumconInfDefCuentasAction pAccion, ContabilidadCommon.conInfDefCuentasDS pdsParam) : base(conInfDefCuentasActionEnum.GetAccionconInfDefCuentasAction(pAccion), pdsParam) {
     }

     public conInfDefCuentasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conInfDefCuentasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conInfDefCuentasDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conInfDefCuentasDS)mParam;
	        }
     }
  }
}
