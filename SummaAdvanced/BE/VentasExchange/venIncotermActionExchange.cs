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
    public class venIncotermActionExchange : Framework.Core.Exchange{

        public Int32 venIncoterm_int {
            get {
                if(((VentasCommon.venIncotermDS)mParam).Principal[0]["venIncoterm_int"] != DBNull.Value  ){
                    return ((VentasCommon.venIncotermDS)mParam).Principal[0].venIncoterm_int;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIncotermDS)mParam).Principal[0].venIncoterm_int = value;
               }
	          }
        public bool IsvenIncoterm_intNull {
             get {
                 return mParam==null || ((VentasCommon.venIncotermDS)mParam).Principal[0].IsvenIncoterm_intNull();
             }
	        }
        public String Incoterm_Id {
            get {
                if(((VentasCommon.venIncotermDS)mParam).Principal[0]["Incoterm_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venIncotermDS)mParam).Principal[0].Incoterm_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIncotermDS)mParam).Principal[0].Incoterm_Id = value;
               }
	          }
        public bool IsIncoterm_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venIncotermDS)mParam).Principal[0].IsIncoterm_IdNull();
             }
	        }
        public String Incoterm_Id_Nueva {
            get {
                if(((VentasCommon.venIncotermDS)mParam).Principal[0]["Incoterm_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venIncotermDS)mParam).Principal[0].Incoterm_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIncotermDS)mParam).Principal[0].Incoterm_Id_Nueva = value;
               }
	          }
        public bool IsIncoterm_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venIncotermDS)mParam).Principal[0].IsIncoterm_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venIncotermDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venIncotermDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIncotermDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venIncotermDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venIncotermDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venIncotermDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venIncotermDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venIncotermDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venIncotermDS );
     }
     public venIncotermActionExchange() : base( "venIncoterm" ) {
     }

     public venIncotermActionExchange(venIncotermActionEnum.EnumvenIncotermAction pAccion) : base(venIncotermActionEnum.GetAccionvenIncotermAction(pAccion)) {
     }

     public venIncotermActionExchange(venIncotermActionEnum.EnumvenIncotermAction pAccion, VentasCommon.venIncotermDS pdsParam) : base(venIncotermActionEnum.GetAccionvenIncotermAction(pAccion), pdsParam) {
     }

     public venIncotermActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venIncotermDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venIncotermDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venIncotermDS)mParam;
	        }
     }
  }
}
