using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ActivoFijoExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class AficonMovcontActionExchange : Framework.Core.Exchange{

        public Int64 conAsientos {
            get {
                if(((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0]["conAsientos"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].conAsientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].conAsientos = value;
               }
	          }
        public bool IsconAsientosNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].IsconAsientosNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Int32 Renglon_Nueva {
            get {
                if(((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0]["Renglon_Nueva"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].Renglon_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].Renglon_Nueva = value;
               }
	          }
        public bool IsRenglon_NuevaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].IsRenglon_NuevaNull();
             }
	        }
        public String DescripcionMovCont {
            get {
                if(((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0]["DescripcionMovCont"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].DescripcionMovCont;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].DescripcionMovCont = value;
               }
	          }
        public bool IsDescripcionMovContNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].IsDescripcionMovContNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String ActivoFijo_Id {
            get {
                if(((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0]["ActivoFijo_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].ActivoFijo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].ActivoFijo_Id = value;
               }
	          }
        public bool IsActivoFijo_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].IsActivoFijo_IdNull();
             }
	        }
        public String DescripcionActivoFijo {
            get {
                if(((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0]["DescripcionActivoFijo"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].DescripcionActivoFijo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].DescripcionActivoFijo = value;
               }
	          }
        public bool IsDescripcionActivoFijoNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].IsDescripcionActivoFijoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AficonMovcontDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ActivoFijoCommon.AficonMovcontDS );
     }
     public AficonMovcontActionExchange() : base( "AficonMovcont" ) {
     }

     public AficonMovcontActionExchange(AficonMovcontActionEnum.EnumAficonMovcontAction pAccion) : base(AficonMovcontActionEnum.GetAccionAficonMovcontAction(pAccion)) {
     }

     public AficonMovcontActionExchange(AficonMovcontActionEnum.EnumAficonMovcontAction pAccion, ActivoFijoCommon.AficonMovcontDS pdsParam) : base(AficonMovcontActionEnum.GetAccionAficonMovcontAction(pAccion), pdsParam) {
     }

     public AficonMovcontActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ActivoFijoCommon.AficonMovcontDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ActivoFijoCommon.AficonMovcontDS Param{
	        get{
			    InitParam();
			    return (ActivoFijoCommon.AficonMovcontDS)mParam;
	        }
     }
  }
}
