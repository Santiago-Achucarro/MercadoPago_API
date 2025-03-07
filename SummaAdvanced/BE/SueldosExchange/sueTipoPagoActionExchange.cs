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
    public class sueTipoPagoActionExchange : Framework.Core.Exchange{

        public Int32 sueTipoPago {
            get {
                if(((SueldosCommon.sueTipoPagoDS)mParam).Principal[0]["sueTipoPago"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].sueTipoPago;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].sueTipoPago = value;
               }
	          }
        public bool IssueTipoPagoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].IssueTipoPagoNull();
             }
	        }
        public String TipoPago_Id {
            get {
                if(((SueldosCommon.sueTipoPagoDS)mParam).Principal[0]["TipoPago_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].TipoPago_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].TipoPago_Id = value;
               }
	          }
        public bool IsTipoPago_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].IsTipoPago_IdNull();
             }
	        }
        public String TipoPago_Id_Nueva {
            get {
                if(((SueldosCommon.sueTipoPagoDS)mParam).Principal[0]["TipoPago_Id_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].TipoPago_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].TipoPago_Id_Nueva = value;
               }
	          }
        public bool IsTipoPago_Id_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].IsTipoPago_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueTipoPagoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.sueTipoPagoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.sueTipoPagoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.sueTipoPagoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((SueldosCommon.sueTipoPagoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((SueldosCommon.sueTipoPagoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueTipoPagoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTipoPagoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueTipoPagoDS );
     }
     public sueTipoPagoActionExchange() : base( "sueTipoPago" ) {
     }

     public sueTipoPagoActionExchange(sueTipoPagoActionEnum.EnumsueTipoPagoAction pAccion) : base(sueTipoPagoActionEnum.GetAccionsueTipoPagoAction(pAccion)) {
     }

     public sueTipoPagoActionExchange(sueTipoPagoActionEnum.EnumsueTipoPagoAction pAccion, SueldosCommon.sueTipoPagoDS pdsParam) : base(sueTipoPagoActionEnum.GetAccionsueTipoPagoAction(pAccion), pdsParam) {
     }

     public sueTipoPagoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueTipoPagoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueTipoPagoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueTipoPagoDS)mParam;
	        }
     }
  }
}
