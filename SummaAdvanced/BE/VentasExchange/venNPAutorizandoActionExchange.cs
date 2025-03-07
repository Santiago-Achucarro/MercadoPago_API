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
    public class venNPAutorizandoActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venNPAutorizandoDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Int32 Secuencia {
            get {
                if(((VentasCommon.venNPAutorizandoDS)mParam).Principal[0]["Secuencia"] != DBNull.Value  ){
                    return ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].Secuencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].Secuencia = value;
               }
	          }
        public bool IsSecuenciaNull {
             get {
                 return mParam==null || ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].IsSecuenciaNull();
             }
	        }
        public String NivelAuto_Id {
            get {
                if(((VentasCommon.venNPAutorizandoDS)mParam).Principal[0]["NivelAuto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].NivelAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].NivelAuto_Id = value;
               }
	          }
        public bool IsNivelAuto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].IsNivelAuto_IdNull();
             }
	        }
        public String DescripcioncomNivelesAuto {
            get {
                if(((VentasCommon.venNPAutorizandoDS)mParam).Principal[0]["DescripcioncomNivelesAuto"] != DBNull.Value  ){
                    return ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].DescripcioncomNivelesAuto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].DescripcioncomNivelesAuto = value;
               }
	          }
        public bool IsDescripcioncomNivelesAutoNull {
             get {
                 return mParam==null || ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].IsDescripcioncomNivelesAutoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venNPAutorizandoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venNPAutorizandoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venNPAutorizandoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String TipoApro {
            get {
                if(((VentasCommon.venNPAutorizandoDS)mParam).Principal[0]["TipoApro"] != DBNull.Value  ){
                    return ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].TipoApro;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].TipoApro = value;
               }
	          }
        public bool IsTipoAproNull {
             get {
                 return mParam==null || ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].IsTipoAproNull();
             }
	        }
        public String ResultadoFormula {
            get {
                if(((VentasCommon.venNPAutorizandoDS)mParam).Principal[0]["ResultadoFormula"] != DBNull.Value  ){
                    return ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].ResultadoFormula;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].ResultadoFormula = value;
               }
	          }
        public bool IsResultadoFormulaNull {
             get {
                 return mParam==null || ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].IsResultadoFormulaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venNPAutorizandoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venNPAutorizandoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venNPAutorizandoDS );
     }
     public venNPAutorizandoActionExchange() : base( "venNPAutorizando" ) {
     }

     public venNPAutorizandoActionExchange(venNPAutorizandoActionEnum.EnumvenNPAutorizandoAction pAccion) : base(venNPAutorizandoActionEnum.GetAccionvenNPAutorizandoAction(pAccion)) {
     }

     public venNPAutorizandoActionExchange(venNPAutorizandoActionEnum.EnumvenNPAutorizandoAction pAccion, VentasCommon.venNPAutorizandoDS pdsParam) : base(venNPAutorizandoActionEnum.GetAccionvenNPAutorizandoAction(pAccion), pdsParam) {
     }

     public venNPAutorizandoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venNPAutorizandoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venNPAutorizandoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venNPAutorizandoDS)mParam;
	        }
     }
  }
}
