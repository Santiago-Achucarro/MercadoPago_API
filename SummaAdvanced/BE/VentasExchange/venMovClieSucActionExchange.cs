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
    public class venMovClieSucActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovClieSucDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovClieSucDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovClieSucDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovClieSucDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int64 genEntidades {
            get {
                if(((VentasCommon.venMovClieSucDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((VentasCommon.venMovClieSucDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovClieSucDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((VentasCommon.venMovClieSucDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.venMovClieSucDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovClieSucDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovClieSucDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovClieSucDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String NombreFantasia {
            get {
                if(((VentasCommon.venMovClieSucDS)mParam).Principal[0]["NombreFantasia"] != DBNull.Value  ){
                    return ((VentasCommon.venMovClieSucDS)mParam).Principal[0].NombreFantasia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovClieSucDS)mParam).Principal[0].NombreFantasia = value;
               }
	          }
        public bool IsNombreFantasiaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovClieSucDS)mParam).Principal[0].IsNombreFantasiaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovClieSucDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovClieSucDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovClieSucDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovClieSucDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovClieSucDS );
     }
     public venMovClieSucActionExchange() : base( "venMovClieSuc" ) {
     }

     public venMovClieSucActionExchange(venMovClieSucActionEnum.EnumvenMovClieSucAction pAccion) : base(venMovClieSucActionEnum.GetAccionvenMovClieSucAction(pAccion)) {
     }

     public venMovClieSucActionExchange(venMovClieSucActionEnum.EnumvenMovClieSucAction pAccion, VentasCommon.venMovClieSucDS pdsParam) : base(venMovClieSucActionEnum.GetAccionvenMovClieSucAction(pAccion), pdsParam) {
     }

     public venMovClieSucActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovClieSucDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovClieSucDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovClieSucDS)mParam;
	        }
     }
  }
}
