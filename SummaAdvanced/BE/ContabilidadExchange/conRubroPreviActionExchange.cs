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
    public class conRubroPreviActionExchange : Framework.Core.Exchange{

        public String RubroPrevi_Id {
            get {
                if(((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0]["RubroPrevi_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].RubroPrevi_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].RubroPrevi_Id = value;
               }
	          }
        public bool IsRubroPrevi_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].IsRubroPrevi_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String ActivoPasivo {
            get {
                if(((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0]["ActivoPasivo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].ActivoPasivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].ActivoPasivo = value;
               }
	          }
        public bool IsActivoPasivoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].IsActivoPasivoNull();
             }
	        }
        public Boolean Corriente {
            get {
                if(((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0]["Corriente"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].Corriente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].Corriente = value;
               }
	          }
        public bool IsCorrienteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].IsCorrienteNull();
             }
	        }
        public Int32 Orden {
            get {
                if(((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0]["Orden"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].Orden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].Orden = value;
               }
	          }
        public bool IsOrdenNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].IsOrdenNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conRubroPreviDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conRubroPreviDS );
     }
     public conRubroPreviActionExchange() : base( "conRubroPrevi" ) {
     }

     public conRubroPreviActionExchange(conRubroPreviActionEnum.EnumconRubroPreviAction pAccion) : base(conRubroPreviActionEnum.GetAccionconRubroPreviAction(pAccion)) {
     }

     public conRubroPreviActionExchange(conRubroPreviActionEnum.EnumconRubroPreviAction pAccion, ContabilidadCommon.conRubroPreviDS pdsParam) : base(conRubroPreviActionEnum.GetAccionconRubroPreviAction(pAccion), pdsParam) {
     }

     public conRubroPreviActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conRubroPreviDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conRubroPreviDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conRubroPreviDS)mParam;
	        }
     }
  }
}
