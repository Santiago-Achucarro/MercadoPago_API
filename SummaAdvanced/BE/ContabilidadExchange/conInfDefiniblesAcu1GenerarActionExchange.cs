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
    public class conInfDefiniblesAcu1GenerarActionExchange : Framework.Core.Exchange{

        public Int32 Fila {
            get {
                if(((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0]["Fila"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Fila;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Fila = value;
               }
	          }
        public bool IsFilaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].IsFilaNull();
             }
	        }
        public String Tipo {
            get {
                if(((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public Int32 Nivel {
            get {
                if(((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0]["Nivel"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Nivel;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Nivel = value;
               }
	          }
        public bool IsNivelNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].IsNivelNull();
             }
	        }
        public String Titulo {
            get {
                if(((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0]["Titulo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Titulo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Titulo = value;
               }
	          }
        public bool IsTituloNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].IsTituloNull();
             }
	        }
        public Boolean InvierteSigno {
            get {
                if(((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0]["InvierteSigno"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].InvierteSigno;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].InvierteSigno = value;
               }
	          }
        public bool IsInvierteSignoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].IsInvierteSignoNull();
             }
	        }
        public String Fuente {
            get {
                if(((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0]["Fuente"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Fuente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Fuente = value;
               }
	          }
        public bool IsFuenteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].IsFuenteNull();
             }
	        }
        public Decimal MesAct {
            get {
                if(((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0]["MesAct"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].MesAct;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].MesAct = value;
               }
	          }
        public bool IsMesActNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].IsMesActNull();
             }
	        }
        public Decimal MesAnt {
            get {
                if(((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0]["MesAnt"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].MesAnt;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].MesAnt = value;
               }
	          }
        public bool IsMesAntNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].IsMesAntNull();
             }
	        }
        public Decimal AcuAct {
            get {
                if(((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0]["AcuAct"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].AcuAct;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].AcuAct = value;
               }
	          }
        public bool IsAcuActNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].IsAcuActNull();
             }
	        }
        public Decimal AcuAnt {
            get {
                if(((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0]["AcuAnt"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].AcuAnt;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].AcuAnt = value;
               }
	          }
        public bool IsAcuAntNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].IsAcuAntNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conInfDefiniblesAcu1GenerarDS );
     }
     public conInfDefiniblesAcu1GenerarActionExchange() : base( "conInfDefiniblesAcu1Generar" ) {
     }

     public conInfDefiniblesAcu1GenerarActionExchange(conInfDefiniblesAcu1GenerarActionEnum.EnumconInfDefiniblesAcu1GenerarAction pAccion) : base(conInfDefiniblesAcu1GenerarActionEnum.GetAccionconInfDefiniblesAcu1GenerarAction(pAccion)) {
     }

     public conInfDefiniblesAcu1GenerarActionExchange(conInfDefiniblesAcu1GenerarActionEnum.EnumconInfDefiniblesAcu1GenerarAction pAccion, ContabilidadCommon.conInfDefiniblesAcu1GenerarDS pdsParam) : base(conInfDefiniblesAcu1GenerarActionEnum.GetAccionconInfDefiniblesAcu1GenerarAction(pAccion), pdsParam) {
     }

     public conInfDefiniblesAcu1GenerarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conInfDefiniblesAcu1GenerarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conInfDefiniblesAcu1GenerarDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conInfDefiniblesAcu1GenerarDS)mParam;
	        }
     }
  }
}
