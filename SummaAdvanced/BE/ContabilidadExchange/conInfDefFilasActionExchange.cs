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
    public class conInfDefFilasActionExchange : Framework.Core.Exchange{

        public String Informe_Id {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["Informe_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Informe_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Informe_Id = value;
               }
	          }
        public bool IsInforme_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsInforme_IdNull();
             }
	        }
        public Int32 Fila {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["Fila"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Fila;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Fila = value;
               }
	          }
        public bool IsFilaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsFilaNull();
             }
	        }
        public Int32 Nivel {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["Nivel"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Nivel;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Nivel = value;
               }
	          }
        public bool IsNivelNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsNivelNull();
             }
	        }
        public String Titulo {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["Titulo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Titulo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Titulo = value;
               }
	          }
        public bool IsTituloNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsTituloNull();
             }
	        }
        public String Tipo {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public String Fuente {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["Fuente"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Fuente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Fuente = value;
               }
	          }
        public bool IsFuenteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsFuenteNull();
             }
	        }
        public Boolean InvierteSigno {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["InvierteSigno"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].InvierteSigno;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].InvierteSigno = value;
               }
	          }
        public bool IsInvierteSignoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsInvierteSignoNull();
             }
	        }
        public String Centro1Desde {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["Centro1Desde"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Centro1Desde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Centro1Desde = value;
               }
	          }
        public bool IsCentro1DesdeNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsCentro1DesdeNull();
             }
	        }
        public String Centro1Hasta {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["Centro1Hasta"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Centro1Hasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Centro1Hasta = value;
               }
	          }
        public bool IsCentro1HastaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsCentro1HastaNull();
             }
	        }
        public String Centro2Desde {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["Centro2Desde"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Centro2Desde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Centro2Desde = value;
               }
	          }
        public bool IsCentro2DesdeNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsCentro2DesdeNull();
             }
	        }
        public String Centro2Hasta {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["Centro2Hasta"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Centro2Hasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Centro2Hasta = value;
               }
	          }
        public bool IsCentro2HastaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsCentro2HastaNull();
             }
	        }
        public Int32 conInfDefinibles {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["conInfDefinibles"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].conInfDefinibles;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].conInfDefinibles = value;
               }
	          }
        public bool IsconInfDefiniblesNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsconInfDefiniblesNull();
             }
	        }
        public Int32 FilaMan {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["FilaMan"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].FilaMan;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].FilaMan = value;
               }
	          }
        public bool IsFilaManNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsFilaManNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conInfDefFilasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conInfDefFilasDS );
     }
     public conInfDefFilasActionExchange() : base( "conInfDefFilas" ) {
     }

     public conInfDefFilasActionExchange(conInfDefFilasActionEnum.EnumconInfDefFilasAction pAccion) : base(conInfDefFilasActionEnum.GetAccionconInfDefFilasAction(pAccion)) {
     }

     public conInfDefFilasActionExchange(conInfDefFilasActionEnum.EnumconInfDefFilasAction pAccion, ContabilidadCommon.conInfDefFilasDS pdsParam) : base(conInfDefFilasActionEnum.GetAccionconInfDefFilasAction(pAccion), pdsParam) {
     }

     public conInfDefFilasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conInfDefFilasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conInfDefFilasDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conInfDefFilasDS)mParam;
	        }
     }
  }
}
