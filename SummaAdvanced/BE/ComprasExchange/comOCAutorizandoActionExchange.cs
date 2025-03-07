using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comOCAutorizandoActionExchange : Framework.Core.Exchange{

        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Int32 Secuencia {
            get {
                if(((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0]["Secuencia"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].Secuencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].Secuencia = value;
               }
	          }
        public bool IsSecuenciaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].IsSecuenciaNull();
             }
	        }
        public String NivelAuto_Id {
            get {
                if(((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0]["NivelAuto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].NivelAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].NivelAuto_Id = value;
               }
	          }
        public bool IsNivelAuto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].IsNivelAuto_IdNull();
             }
	        }
        public String DescripcionNivelesAuto {
            get {
                if(((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0]["DescripcionNivelesAuto"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].DescripcionNivelesAuto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].DescripcionNivelesAuto = value;
               }
	          }
        public bool IsDescripcionNivelesAutoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].IsDescripcionNivelesAutoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String TipoApro {
            get {
                if(((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0]["TipoApro"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].TipoApro;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].TipoApro = value;
               }
	          }
        public bool IsTipoAproNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].IsTipoAproNull();
             }
	        }
        public String ResultadoFormula {
            get {
                if(((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0]["ResultadoFormula"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].ResultadoFormula;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].ResultadoFormula = value;
               }
	          }
        public bool IsResultadoFormulaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].IsResultadoFormulaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCAutorizandoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOCAutorizandoDS );
     }
     public comOCAutorizandoActionExchange() : base( "comOCAutorizando" ) {
     }

     public comOCAutorizandoActionExchange(comOCAutorizandoActionEnum.EnumcomOCAutorizandoAction pAccion) : base(comOCAutorizandoActionEnum.GetAccioncomOCAutorizandoAction(pAccion)) {
     }

     public comOCAutorizandoActionExchange(comOCAutorizandoActionEnum.EnumcomOCAutorizandoAction pAccion, ComprasCommon.comOCAutorizandoDS pdsParam) : base(comOCAutorizandoActionEnum.GetAccioncomOCAutorizandoAction(pAccion), pdsParam) {
     }

     public comOCAutorizandoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOCAutorizandoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOCAutorizandoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOCAutorizandoDS)mParam;
	        }
     }
  }
}
