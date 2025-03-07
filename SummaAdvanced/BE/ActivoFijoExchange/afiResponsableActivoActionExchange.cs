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
    public class afiResponsableActivoActionExchange : Framework.Core.Exchange{

        public String Responsable_Id {
            get {
                if(((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0]["Responsable_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].Responsable_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].Responsable_Id = value;
               }
	          }
        public bool IsResponsable_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].IsResponsable_IdNull();
             }
	        }
        public String DescripcionResponsables {
            get {
                if(((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0]["DescripcionResponsables"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].DescripcionResponsables;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].DescripcionResponsables = value;
               }
	          }
        public bool IsDescripcionResponsablesNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].IsDescripcionResponsablesNull();
             }
	        }
        public String DescripcionResponsables_Nueva {
            get {
                if(((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0]["DescripcionResponsables_Nueva"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].DescripcionResponsables_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].DescripcionResponsables_Nueva = value;
               }
	          }
        public bool IsDescripcionResponsables_NuevaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].IsDescripcionResponsables_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String ActivoFijo_Id {
            get {
                if(((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0]["ActivoFijo_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].ActivoFijo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].ActivoFijo_Id = value;
               }
	          }
        public bool IsActivoFijo_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].IsActivoFijo_IdNull();
             }
	        }
        public String DescripcionActivoFijo {
            get {
                if(((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0]["DescripcionActivoFijo"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].DescripcionActivoFijo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].DescripcionActivoFijo = value;
               }
	          }
        public bool IsDescripcionActivoFijoNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].IsDescripcionActivoFijoNull();
             }
	        }
        public DateTime FechaAsignacion {
            get {
                if(((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0]["FechaAsignacion"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].FechaAsignacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].FechaAsignacion = value;
               }
	          }
        public bool IsFechaAsignacionNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].IsFechaAsignacionNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsableActivoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ActivoFijoCommon.afiResponsableActivoDS );
     }
     public afiResponsableActivoActionExchange() : base( "afiResponsableActivo" ) {
     }

     public afiResponsableActivoActionExchange(afiResponsableActivoActionEnum.EnumafiResponsableActivoAction pAccion) : base(afiResponsableActivoActionEnum.GetAccionafiResponsableActivoAction(pAccion)) {
     }

     public afiResponsableActivoActionExchange(afiResponsableActivoActionEnum.EnumafiResponsableActivoAction pAccion, ActivoFijoCommon.afiResponsableActivoDS pdsParam) : base(afiResponsableActivoActionEnum.GetAccionafiResponsableActivoAction(pAccion), pdsParam) {
     }

     public afiResponsableActivoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ActivoFijoCommon.afiResponsableActivoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ActivoFijoCommon.afiResponsableActivoDS Param{
	        get{
			    InitParam();
			    return (ActivoFijoCommon.afiResponsableActivoDS)mParam;
	        }
     }
  }
}
