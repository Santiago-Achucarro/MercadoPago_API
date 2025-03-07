using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TtExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesMercadoPagoActionExchange : Framework.Core.Exchange{

        public Int32 tesMercadoPago {
            get {
                if(((TtCommon.tesMercadoPagoDS)mParam).Principal[0]["tesMercadoPago"] != DBNull.Value  ){
                    return ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].tesMercadoPago;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].tesMercadoPago = value;
               }
	          }
        public bool IstesMercadoPagoNull {
             get {
                 return mParam==null || ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].IstesMercadoPagoNull();
             }
	        }
        public String MercadoPago_Id {
            get {
                if(((TtCommon.tesMercadoPagoDS)mParam).Principal[0]["MercadoPago_Id"] != DBNull.Value  ){
                    return ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].MercadoPago_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].MercadoPago_Id = value;
               }
	          }
        public bool IsMercadoPago_IdNull {
             get {
                 return mParam==null || ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].IsMercadoPago_IdNull();
             }
	        }
        public String MercadoPago_Id_Nueva {
            get {
                if(((TtCommon.tesMercadoPagoDS)mParam).Principal[0]["MercadoPago_Id_Nueva"] != DBNull.Value  ){
                    return ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].MercadoPago_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].MercadoPago_Id_Nueva = value;
               }
	          }
        public bool IsMercadoPago_Id_NuevaNull {
             get {
                 return mParam==null || ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].IsMercadoPago_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TtCommon.tesMercadoPagoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((TtCommon.tesMercadoPagoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TtCommon.tesMercadoPagoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((TtCommon.tesMercadoPagoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TtCommon.tesMercadoPagoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TtCommon.tesMercadoPagoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TtCommon.tesMercadoPagoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TtCommon.tesMercadoPagoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TtCommon.tesMercadoPagoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TtCommon.tesMercadoPagoDS );
     }
     public tesMercadoPagoActionExchange() : base( "tesMercadoPago" ) {
     }

     public tesMercadoPagoActionExchange(tesMercadoPagoActionEnum.EnumtesMercadoPagoAction pAccion) : base(tesMercadoPagoActionEnum.GetAcciontesMercadoPagoAction(pAccion)) {
     }

     public tesMercadoPagoActionExchange(tesMercadoPagoActionEnum.EnumtesMercadoPagoAction pAccion, TtCommon.tesMercadoPagoDS pdsParam) : base(tesMercadoPagoActionEnum.GetAcciontesMercadoPagoAction(pAccion), pdsParam) {
     }

     public tesMercadoPagoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TtCommon.tesMercadoPagoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesMercadoPagoActionExchange(TtCommon.tesMercadoPagoDS pDS) : base() {
     this.Action = "";
     this.mParam = new TtCommon.tesMercadoPagoDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TtCommon.tesMercadoPagoDS Param{
	        get{
			    InitParam();
			    return (TtCommon.tesMercadoPagoDS)mParam;
	        }
     }
  }
}
