using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueVarGlobalesActionExchange : Framework.Core.Exchange{

        public Int32 VarGlobal_Id {
            get {
                if(((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0]["VarGlobal_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].VarGlobal_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].VarGlobal_Id = value;
               }
	          }
        public bool IsVarGlobal_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].IsVarGlobal_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean PorEmpresa {
            get {
                if(((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0]["PorEmpresa"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].PorEmpresa;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].PorEmpresa = value;
               }
	          }
        public bool IsPorEmpresaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].IsPorEmpresaNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Codigo {
            get {
                if(((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0]["Codigo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].Codigo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].Codigo = value;
               }
	          }
        public bool IsCodigoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].IsCodigoNull();
             }
	        }
        public DateTime FechaCodigo {
            get {
                if(((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0]["FechaCodigo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].FechaCodigo;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].FechaCodigo = value;
               }
	          }
        public bool IsFechaCodigoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].IsFechaCodigoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVarGlobalesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueVarGlobalesDS );
     }
     public sueVarGlobalesActionExchange() : base( "sueVarGlobales" ) {
     }

     public sueVarGlobalesActionExchange(sueVarGlobalesActionEnum.EnumsueVarGlobalesAction pAccion) : base(sueVarGlobalesActionEnum.GetAccionsueVarGlobalesAction(pAccion)) {
     }

     public sueVarGlobalesActionExchange(sueVarGlobalesActionEnum.EnumsueVarGlobalesAction pAccion, SueldosCommon.sueVarGlobalesDS pdsParam) : base(sueVarGlobalesActionEnum.GetAccionsueVarGlobalesAction(pAccion), pdsParam) {
     }

     public sueVarGlobalesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueVarGlobalesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueVarGlobalesDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueVarGlobalesDS)mParam;
	        }
     }
  }
}
