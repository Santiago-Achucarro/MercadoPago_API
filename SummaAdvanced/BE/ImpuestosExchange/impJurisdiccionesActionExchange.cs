using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ImpuestosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class impJurisdiccionesActionExchange : Framework.Core.Exchange{

        public Int32 impJurisdicciones {
            get {
                if(((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0]["impJurisdicciones"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].impJurisdicciones;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].impJurisdicciones = value;
               }
	          }
        public bool IsimpJurisdiccionesNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].IsimpJurisdiccionesNull();
             }
	        }
        public String Juris_Id {
            get {
                if(((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0]["Juris_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Juris_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Juris_Id = value;
               }
	          }
        public bool IsJuris_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].IsJuris_IdNull();
             }
	        }
        public String Juris_Id_Nueva {
            get {
                if(((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0]["Juris_Id_Nueva"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Juris_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Juris_Id_Nueva = value;
               }
	          }
        public bool IsJuris_Id_NuevaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].IsJuris_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impJurisdiccionesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impJurisdiccionesDS );
     }
     public impJurisdiccionesActionExchange() : base( "impJurisdicciones" ) {
     }

     public impJurisdiccionesActionExchange(impJurisdiccionesActionEnum.EnumimpJurisdiccionesAction pAccion) : base(impJurisdiccionesActionEnum.GetAccionimpJurisdiccionesAction(pAccion)) {
     }

     public impJurisdiccionesActionExchange(impJurisdiccionesActionEnum.EnumimpJurisdiccionesAction pAccion, ImpuestosCommon.impJurisdiccionesDS pdsParam) : base(impJurisdiccionesActionEnum.GetAccionimpJurisdiccionesAction(pAccion), pdsParam) {
     }

     public impJurisdiccionesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impJurisdiccionesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impJurisdiccionesDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impJurisdiccionesDS)mParam;
	        }
     }
  }
}
