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
    public class afiResponsablesActionExchange : Framework.Core.Exchange{

        public Int32 afiResponsables {
            get {
                if(((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0]["afiResponsables"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].afiResponsables;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].afiResponsables = value;
               }
	          }
        public bool IsafiResponsablesNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].IsafiResponsablesNull();
             }
	        }
        public String Responsable_Id {
            get {
                if(((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0]["Responsable_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Responsable_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Responsable_Id = value;
               }
	          }
        public bool IsResponsable_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].IsResponsable_IdNull();
             }
	        }
        public String Responsable_Id_Nueva {
            get {
                if(((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0]["Responsable_Id_Nueva"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Responsable_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Responsable_Id_Nueva = value;
               }
	          }
        public bool IsResponsable_Id_NuevaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].IsResponsable_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 afiResponsables_Nueva {
            get {
                if(((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0]["afiResponsables_Nueva"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].afiResponsables_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].afiResponsables_Nueva = value;
               }
	          }
        public bool IsafiResponsables_NuevaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].IsafiResponsables_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.afiResponsablesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ActivoFijoCommon.afiResponsablesDS );
     }
     public afiResponsablesActionExchange() : base( "afiResponsables" ) {
     }

     public afiResponsablesActionExchange(afiResponsablesActionEnum.EnumafiResponsablesAction pAccion) : base(afiResponsablesActionEnum.GetAccionafiResponsablesAction(pAccion)) {
     }

     public afiResponsablesActionExchange(afiResponsablesActionEnum.EnumafiResponsablesAction pAccion, ActivoFijoCommon.afiResponsablesDS pdsParam) : base(afiResponsablesActionEnum.GetAccionafiResponsablesAction(pAccion), pdsParam) {
     }

     public afiResponsablesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ActivoFijoCommon.afiResponsablesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ActivoFijoCommon.afiResponsablesDS Param{
	        get{
			    InitParam();
			    return (ActivoFijoCommon.afiResponsablesDS)mParam;
	        }
     }
  }
}
