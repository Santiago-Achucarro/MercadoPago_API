using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesCausasRechazoActionExchange : Framework.Core.Exchange{

        public Int32 tesCausasRechazo {
            get {
                if(((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0]["tesCausasRechazo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].tesCausasRechazo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].tesCausasRechazo = value;
               }
	          }
        public bool IstesCausasRechazoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].IstesCausasRechazoNull();
             }
	        }
        public String Causa_Id {
            get {
                if(((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0]["Causa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Causa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Causa_Id = value;
               }
	          }
        public bool IsCausa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].IsCausa_IdNull();
             }
	        }
        public String Causa_Id_Nueva {
            get {
                if(((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0]["Causa_Id_Nueva"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Causa_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Causa_Id_Nueva = value;
               }
	          }
        public bool IsCausa_Id_NuevaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].IsCausa_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean ParaTodasEmpresas {
            get {
                if(((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0]["ParaTodasEmpresas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].ParaTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].ParaTodasEmpresas = value;
               }
	          }
        public bool IsParaTodasEmpresasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].IsParaTodasEmpresasNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public DateTime FechaModificacion {
            get {
                if(((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0]["FechaModificacion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].FechaModificacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].FechaModificacion = value;
               }
	          }
        public bool IsFechaModificacionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].IsFechaModificacionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCausasRechazoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCausasRechazoDS );
     }
     public tesCausasRechazoActionExchange() : base( "tesCausasRechazo" ) {
     }

     public tesCausasRechazoActionExchange(tesCausasRechazoActionEnum.EnumtesCausasRechazoAction pAccion) : base(tesCausasRechazoActionEnum.GetAcciontesCausasRechazoAction(pAccion)) {
     }

     public tesCausasRechazoActionExchange(tesCausasRechazoActionEnum.EnumtesCausasRechazoAction pAccion, TesoreriaCommon.tesCausasRechazoDS pdsParam) : base(tesCausasRechazoActionEnum.GetAcciontesCausasRechazoAction(pAccion), pdsParam) {
     }

     public tesCausasRechazoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCausasRechazoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCausasRechazoDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCausasRechazoDS)mParam;
	        }
     }
  }
}
