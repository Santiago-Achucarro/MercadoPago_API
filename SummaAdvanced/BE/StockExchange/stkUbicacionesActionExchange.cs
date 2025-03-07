using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkUbicacionesActionExchange : Framework.Core.Exchange{

        public Int32 stkUbicaciones {
            get {
                if(((StockCommon.stkUbicacionesDS)mParam).Principal[0]["stkUbicaciones"] != DBNull.Value  ){
                    return ((StockCommon.stkUbicacionesDS)mParam).Principal[0].stkUbicaciones;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbicacionesDS)mParam).Principal[0].stkUbicaciones = value;
               }
	          }
        public bool IsstkUbicacionesNull {
             get {
                 return mParam==null || ((StockCommon.stkUbicacionesDS)mParam).Principal[0].IsstkUbicacionesNull();
             }
	        }
        public String Ubicacion_Id {
            get {
                if(((StockCommon.stkUbicacionesDS)mParam).Principal[0]["Ubicacion_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Ubicacion_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Ubicacion_Id = value;
               }
	          }
        public bool IsUbicacion_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUbicacionesDS)mParam).Principal[0].IsUbicacion_IdNull();
             }
	        }
        public String Ubicacion_Id_Nueva {
            get {
                if(((StockCommon.stkUbicacionesDS)mParam).Principal[0]["Ubicacion_Id_Nueva"] != DBNull.Value  ){
                    return ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Ubicacion_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Ubicacion_Id_Nueva = value;
               }
	          }
        public bool IsUbicacion_Id_NuevaNull {
             get {
                 return mParam==null || ((StockCommon.stkUbicacionesDS)mParam).Principal[0].IsUbicacion_Id_NuevaNull();
             }
	        }
        public Decimal Capacidad {
            get {
                if(((StockCommon.stkUbicacionesDS)mParam).Principal[0]["Capacidad"] != DBNull.Value  ){
                    return ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Capacidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Capacidad = value;
               }
	          }
        public bool IsCapacidadNull {
             get {
                 return mParam==null || ((StockCommon.stkUbicacionesDS)mParam).Principal[0].IsCapacidadNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkUbicacionesDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUbicacionesDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((StockCommon.stkUbicacionesDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((StockCommon.stkUbicacionesDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbicacionesDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((StockCommon.stkUbicacionesDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((StockCommon.stkUbicacionesDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((StockCommon.stkUbicacionesDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkUbicacionesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbicacionesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkUbicacionesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkUbicacionesDS );
     }
     public stkUbicacionesActionExchange() : base( "stkUbicaciones" ) {
     }

     public stkUbicacionesActionExchange(stkUbicacionesActionEnum.EnumstkUbicacionesAction pAccion) : base(stkUbicacionesActionEnum.GetAccionstkUbicacionesAction(pAccion)) {
     }

     public stkUbicacionesActionExchange(stkUbicacionesActionEnum.EnumstkUbicacionesAction pAccion, StockCommon.stkUbicacionesDS pdsParam) : base(stkUbicacionesActionEnum.GetAccionstkUbicacionesAction(pAccion), pdsParam) {
     }

     public stkUbicacionesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkUbicacionesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkUbicacionesActionExchange(StockCommon.stkUbicacionesDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkUbicacionesDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkUbicacionesDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkUbicacionesDS)mParam;
	        }
     }
  }
}
