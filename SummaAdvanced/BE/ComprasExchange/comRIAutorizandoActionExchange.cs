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
    public class comRIAutorizandoActionExchange : Framework.Core.Exchange{

        public Int32 comReqInterno {
            get {
                if(((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0]["comReqInterno"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].comReqInterno;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].comReqInterno = value;
               }
	          }
        public bool IscomReqInternoNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].IscomReqInternoNull();
             }
	        }
        public Int32 Secuencia {
            get {
                if(((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0]["Secuencia"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].Secuencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].Secuencia = value;
               }
	          }
        public bool IsSecuenciaNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].IsSecuenciaNull();
             }
	        }
        public String NivelAuto_Id {
            get {
                if(((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0]["NivelAuto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].NivelAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].NivelAuto_Id = value;
               }
	          }
        public bool IsNivelAuto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].IsNivelAuto_IdNull();
             }
	        }
        public String DescripcionNivelesAuto {
            get {
                if(((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0]["DescripcionNivelesAuto"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].DescripcionNivelesAuto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].DescripcionNivelesAuto = value;
               }
	          }
        public bool IsDescripcionNivelesAutoNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].IsDescripcionNivelesAutoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String TipoApro {
            get {
                if(((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0]["TipoApro"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].TipoApro;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].TipoApro = value;
               }
	          }
        public bool IsTipoAproNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].IsTipoAproNull();
             }
	        }
        public String ResultadoFormula {
            get {
                if(((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0]["ResultadoFormula"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].ResultadoFormula;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].ResultadoFormula = value;
               }
	          }
        public bool IsResultadoFormulaNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].IsResultadoFormulaNull();
             }
	        }
        public Int32 genUsuarios {
            get {
                if(((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0]["genUsuarios"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].genUsuarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].genUsuarios = value;
               }
	          }
        public bool IsgenUsuariosNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].IsgenUsuariosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIAutorizandoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comRIAutorizandoDS );
     }
     public comRIAutorizandoActionExchange() : base( "comRIAutorizando" ) {
     }

     public comRIAutorizandoActionExchange(comRIAutorizandoActionEnum.EnumcomRIAutorizandoAction pAccion) : base(comRIAutorizandoActionEnum.GetAccioncomRIAutorizandoAction(pAccion)) {
     }

     public comRIAutorizandoActionExchange(comRIAutorizandoActionEnum.EnumcomRIAutorizandoAction pAccion, ComprasCommon.comRIAutorizandoDS pdsParam) : base(comRIAutorizandoActionEnum.GetAccioncomRIAutorizandoAction(pAccion), pdsParam) {
     }

     public comRIAutorizandoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comRIAutorizandoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comRIAutorizandoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comRIAutorizandoDS)mParam;
	        }
     }
  }
}
