using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venConsultaFEActionExchange : Framework.Core.Exchange{

        public Int32 TipoComprobante_Id {
            get {
                if(((VentasCommon.venConsultaFEDS)mParam).Principal[0]["TipoComprobante_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venConsultaFEDS)mParam).Principal[0].TipoComprobante_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsultaFEDS)mParam).Principal[0].TipoComprobante_Id = value;
               }
	          }
        public bool IsTipoComprobante_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venConsultaFEDS)mParam).Principal[0].IsTipoComprobante_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venConsultaFEDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venConsultaFEDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String PtoVta {
            get {
                if(((VentasCommon.venConsultaFEDS)mParam).Principal[0]["PtoVta"] != DBNull.Value  ){
                    return ((VentasCommon.venConsultaFEDS)mParam).Principal[0].PtoVta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsultaFEDS)mParam).Principal[0].PtoVta = value;
               }
	          }
        public bool IsPtoVtaNull {
             get {
                 return mParam==null || ((VentasCommon.venConsultaFEDS)mParam).Principal[0].IsPtoVtaNull();
             }
	        }
        public Int64 Comprobante {
            get {
                if(((VentasCommon.venConsultaFEDS)mParam).Principal[0]["Comprobante"] != DBNull.Value  ){
                    return ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Comprobante;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Comprobante = value;
               }
	          }
        public bool IsComprobanteNull {
             get {
                 return mParam==null || ((VentasCommon.venConsultaFEDS)mParam).Principal[0].IsComprobanteNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venConsultaFEDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venConsultaFEDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Cuit {
            get {
                if(((VentasCommon.venConsultaFEDS)mParam).Principal[0]["Cuit"] != DBNull.Value  ){
                    return ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Cuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Cuit = value;
               }
	          }
        public bool IsCuitNull {
             get {
                 return mParam==null || ((VentasCommon.venConsultaFEDS)mParam).Principal[0].IsCuitNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.venConsultaFEDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venConsultaFEDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venConsultaFEDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venConsultaFEDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsultaFEDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venConsultaFEDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venConsultaFEDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venConsultaFEDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public String Resultado {
            get {
                if(((VentasCommon.venConsultaFEDS)mParam).Principal[0]["Resultado"] != DBNull.Value  ){
                    return ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Resultado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venConsultaFEDS)mParam).Principal[0].Resultado = value;
               }
	          }
        public bool IsResultadoNull {
             get {
                 return mParam==null || ((VentasCommon.venConsultaFEDS)mParam).Principal[0].IsResultadoNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venConsultaFEDS );
     }
     public venConsultaFEActionExchange() : base( "venConsultaFE" ) {
     }

     public venConsultaFEActionExchange(venConsultaFEActionEnum.EnumvenConsultaFEAction pAccion) : base(venConsultaFEActionEnum.GetAccionvenConsultaFEAction(pAccion)) {
     }

     public venConsultaFEActionExchange(venConsultaFEActionEnum.EnumvenConsultaFEAction pAccion, VentasCommon.venConsultaFEDS pdsParam) : base(venConsultaFEActionEnum.GetAccionvenConsultaFEAction(pAccion), pdsParam) {
     }

     public venConsultaFEActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venConsultaFEDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venConsultaFEActionExchange(VentasCommon.venConsultaFEDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venConsultaFEDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venConsultaFEDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venConsultaFEDS)mParam;
	        }
     }
  }
}
