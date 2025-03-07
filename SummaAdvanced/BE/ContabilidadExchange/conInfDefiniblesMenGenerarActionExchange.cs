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
    public class conInfDefiniblesMenGenerarActionExchange : Framework.Core.Exchange{

        public Int32 Fila {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Fila"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Fila;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Fila = value;
               }
	          }
        public bool IsFilaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsFilaNull();
             }
	        }
        public String Tipo {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public Int32 Nivel {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Nivel"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Nivel;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Nivel = value;
               }
	          }
        public bool IsNivelNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsNivelNull();
             }
	        }
        public String Titulo {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Titulo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Titulo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Titulo = value;
               }
	          }
        public bool IsTituloNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsTituloNull();
             }
	        }
        public Boolean InvierteSigno {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["InvierteSigno"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].InvierteSigno;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].InvierteSigno = value;
               }
	          }
        public bool IsInvierteSignoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsInvierteSignoNull();
             }
	        }
        public String Fuente {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Fuente"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Fuente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Fuente = value;
               }
	          }
        public bool IsFuenteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsFuenteNull();
             }
	        }
        public Decimal Per01 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per01"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per01;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per01 = value;
               }
	          }
        public bool IsPer01Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer01Null();
             }
	        }
        public Decimal Per02 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per02"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per02;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per02 = value;
               }
	          }
        public bool IsPer02Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer02Null();
             }
	        }
        public Decimal Per03 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per03"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per03;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per03 = value;
               }
	          }
        public bool IsPer03Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer03Null();
             }
	        }
        public Decimal Per04 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per04"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per04;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per04 = value;
               }
	          }
        public bool IsPer04Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer04Null();
             }
	        }
        public Decimal Per05 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per05"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per05;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per05 = value;
               }
	          }
        public bool IsPer05Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer05Null();
             }
	        }
        public Decimal Per06 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per06"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per06;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per06 = value;
               }
	          }
        public bool IsPer06Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer06Null();
             }
	        }
        public Decimal Per07 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per07"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per07;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per07 = value;
               }
	          }
        public bool IsPer07Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer07Null();
             }
	        }
        public Decimal Per08 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per08"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per08;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per08 = value;
               }
	          }
        public bool IsPer08Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer08Null();
             }
	        }
        public Decimal Per09 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per09"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per09;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per09 = value;
               }
	          }
        public bool IsPer09Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer09Null();
             }
	        }
        public Decimal Per10 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per10"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per10;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per10 = value;
               }
	          }
        public bool IsPer10Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer10Null();
             }
	        }
        public Decimal Per11 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per11"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per11;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per11 = value;
               }
	          }
        public bool IsPer11Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer11Null();
             }
	        }
        public Decimal Per12 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per12"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per12;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per12 = value;
               }
	          }
        public bool IsPer12Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer12Null();
             }
	        }
        public Decimal Per13 {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Per13"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per13;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Per13 = value;
               }
	          }
        public bool IsPer13Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsPer13Null();
             }
	        }
        public Decimal Total {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conInfDefiniblesMenGenerarDS );
     }
     public conInfDefiniblesMenGenerarActionExchange() : base( "conInfDefiniblesMenGenerar" ) {
     }

     public conInfDefiniblesMenGenerarActionExchange(conInfDefiniblesMenGenerarActionEnum.EnumconInfDefiniblesMenGenerarAction pAccion) : base(conInfDefiniblesMenGenerarActionEnum.GetAccionconInfDefiniblesMenGenerarAction(pAccion)) {
     }

     public conInfDefiniblesMenGenerarActionExchange(conInfDefiniblesMenGenerarActionEnum.EnumconInfDefiniblesMenGenerarAction pAccion, ContabilidadCommon.conInfDefiniblesMenGenerarDS pdsParam) : base(conInfDefiniblesMenGenerarActionEnum.GetAccionconInfDefiniblesMenGenerarAction(pAccion), pdsParam) {
     }

     public conInfDefiniblesMenGenerarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conInfDefiniblesMenGenerarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conInfDefiniblesMenGenerarDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conInfDefiniblesMenGenerarDS)mParam;
	        }
     }
  }
}
