using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace KSKExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class espParaAutorizarKSKActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int64 tesMovimientos {
            get {
                if(((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public String Causa {
            get {
                if(((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0]["Causa"] != DBNull.Value  ){
                    return ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Causa;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Causa = value;
               }
	          }
        public bool IsCausaNull {
             get {
                 return mParam==null || ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].IsCausaNull();
             }
	        }
        public String Estado {
            get {
                if(((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((KSKCommon.espParaAutorizarKSKDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.espParaAutorizarKSKDS );
     }
     public espParaAutorizarKSKActionExchange() : base( "espParaAutorizarKSK" ) {
     }

     public espParaAutorizarKSKActionExchange(espParaAutorizarKSKActionEnum.EnumespParaAutorizarKSKAction pAccion) : base(espParaAutorizarKSKActionEnum.GetAccionespParaAutorizarKSKAction(pAccion)) {
     }

     public espParaAutorizarKSKActionExchange(espParaAutorizarKSKActionEnum.EnumespParaAutorizarKSKAction pAccion, KSKCommon.espParaAutorizarKSKDS pdsParam) : base(espParaAutorizarKSKActionEnum.GetAccionespParaAutorizarKSKAction(pAccion), pdsParam) {
     }

     public espParaAutorizarKSKActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.espParaAutorizarKSKDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.espParaAutorizarKSKDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.espParaAutorizarKSKDS)mParam;
	        }
     }
  }
}
