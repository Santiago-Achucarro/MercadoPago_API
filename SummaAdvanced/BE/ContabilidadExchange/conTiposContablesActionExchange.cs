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
    public class conTiposContablesActionExchange : Framework.Core.Exchange{

        public String Tipo_Id {
            get {
                if(((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0]["Tipo_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Tipo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Tipo_Id = value;
               }
	          }
        public bool IsTipo_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].IsTipo_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Rubro_Balance {
            get {
                if(((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0]["Rubro_Balance"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Rubro_Balance;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Rubro_Balance = value;
               }
	          }
        public bool IsRubro_BalanceNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].IsRubro_BalanceNull();
             }
	        }
        public String DescripcionSituPatri {
            get {
                if(((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0]["DescripcionSituPatri"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].DescripcionSituPatri;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].DescripcionSituPatri = value;
               }
	          }
        public bool IsDescripcionSituPatriNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].IsDescripcionSituPatriNull();
             }
	        }
        public String Destino {
            get {
                if(((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0]["Destino"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Destino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Destino = value;
               }
	          }
        public bool IsDestinoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].IsDestinoNull();
             }
	        }
        public String Corriente {
            get {
                if(((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0]["Corriente"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Corriente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Corriente = value;
               }
	          }
        public bool IsCorrienteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].IsCorrienteNull();
             }
	        }
        public Boolean Reservado {
            get {
                if(((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0]["Reservado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Reservado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Reservado = value;
               }
	          }
        public bool IsReservadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].IsReservadoNull();
             }
	        }
        public String Rubro_Id {
            get {
                if(((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0]["Rubro_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Rubro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Rubro_Id = value;
               }
	          }
        public bool IsRubro_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].IsRubro_IdNull();
             }
	        }
        public String DescripcionRubros {
            get {
                if(((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0]["DescripcionRubros"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].DescripcionRubros;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].DescripcionRubros = value;
               }
	          }
        public bool IsDescripcionRubrosNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].IsDescripcionRubrosNull();
             }
	        }
        public String DescripcionUsu {
            get {
                if(((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0]["DescripcionUsu"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].DescripcionUsu;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].DescripcionUsu = value;
               }
	          }
        public bool IsDescripcionUsuNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].IsDescripcionUsuNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conTiposContablesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conTiposContablesDS );
     }
     public conTiposContablesActionExchange() : base( "conTiposContables" ) {
     }

     public conTiposContablesActionExchange(conTiposContablesActionEnum.EnumconTiposContablesAction pAccion) : base(conTiposContablesActionEnum.GetAccionconTiposContablesAction(pAccion)) {
     }

     public conTiposContablesActionExchange(conTiposContablesActionEnum.EnumconTiposContablesAction pAccion, ContabilidadCommon.conTiposContablesDS pdsParam) : base(conTiposContablesActionEnum.GetAccionconTiposContablesAction(pAccion), pdsParam) {
     }

     public conTiposContablesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conTiposContablesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conTiposContablesDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conTiposContablesDS)mParam;
	        }
     }
  }
}
