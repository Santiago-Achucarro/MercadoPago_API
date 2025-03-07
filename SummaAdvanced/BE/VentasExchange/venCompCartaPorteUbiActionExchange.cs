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
    public class venCompCartaPorteUbiActionExchange : Framework.Core.Exchange{

        public Int64 venmovimientos {
            get {
                if(((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0]["venmovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].venmovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].venmovimientos = value;
               }
	          }
        public bool IsvenmovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].IsvenmovimientosNull();
             }
	        }
        public Int32 Ubicacion {
            get {
                if(((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0]["Ubicacion"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].Ubicacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].Ubicacion = value;
               }
	          }
        public bool IsUbicacionNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].IsUbicacionNull();
             }
	        }
        public String TipoEstacion {
            get {
                if(((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0]["TipoEstacion"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].TipoEstacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].TipoEstacion = value;
               }
	          }
        public bool IsTipoEstacionNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].IsTipoEstacionNull();
             }
	        }
        public Decimal DistanciaRecorrida {
            get {
                if(((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0]["DistanciaRecorrida"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].DistanciaRecorrida;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].DistanciaRecorrida = value;
               }
	          }
        public bool IsDistanciaRecorridaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].IsDistanciaRecorridaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteUbiDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCompCartaPorteUbiDS );
     }
     public venCompCartaPorteUbiActionExchange() : base( "venCompCartaPorteUbi" ) {
     }

     public venCompCartaPorteUbiActionExchange(venCompCartaPorteUbiActionEnum.EnumvenCompCartaPorteUbiAction pAccion) : base(venCompCartaPorteUbiActionEnum.GetAccionvenCompCartaPorteUbiAction(pAccion)) {
     }

     public venCompCartaPorteUbiActionExchange(venCompCartaPorteUbiActionEnum.EnumvenCompCartaPorteUbiAction pAccion, VentasCommon.venCompCartaPorteUbiDS pdsParam) : base(venCompCartaPorteUbiActionEnum.GetAccionvenCompCartaPorteUbiAction(pAccion), pdsParam) {
     }

     public venCompCartaPorteUbiActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCompCartaPorteUbiDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venCompCartaPorteUbiActionExchange(VentasCommon.venCompCartaPorteUbiDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venCompCartaPorteUbiDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCompCartaPorteUbiDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCompCartaPorteUbiDS)mParam;
	        }
     }
  }
}
