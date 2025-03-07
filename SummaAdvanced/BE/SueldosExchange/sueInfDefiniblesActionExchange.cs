using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueInfDefiniblesActionExchange : Framework.Core.Exchange{

        public Int32 sueInfDefinibles {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["sueInfDefinibles"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].sueInfDefinibles;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].sueInfDefinibles = value;
               }
	          }
        public bool IssueInfDefiniblesNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IssueInfDefiniblesNull();
             }
	        }
        public String Informe_Id {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Informe_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Informe_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Informe_Id = value;
               }
	          }
        public bool IsInforme_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsInforme_IdNull();
             }
	        }
        public String Informe_Id_Nueva {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Informe_Id_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Informe_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Informe_Id_Nueva = value;
               }
	          }
        public bool IsInforme_Id_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsInforme_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String AgrupadoPor {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["AgrupadoPor"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].AgrupadoPor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].AgrupadoPor = value;
               }
	          }
        public bool IsAgrupadoPorNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsAgrupadoPorNull();
             }
	        }
        public String TamanioHoja {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["TamanioHoja"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].TamanioHoja;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].TamanioHoja = value;
               }
	          }
        public bool IsTamanioHojaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsTamanioHojaNull();
             }
	        }
        public String DescripcionTamanioHoja {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["DescripcionTamanioHoja"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].DescripcionTamanioHoja;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].DescripcionTamanioHoja = value;
               }
	          }
        public bool IsDescripcionTamanioHojaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsDescripcionTamanioHojaNull();
             }
	        }
        public Boolean Horizontal {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Horizontal"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Horizontal;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Horizontal = value;
               }
	          }
        public bool IsHorizontalNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsHorizontalNull();
             }
	        }
        public String Um {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Um"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Um;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Um = value;
               }
	          }
        public bool IsUmNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsUmNull();
             }
	        }
        public Int32 LegajoDesde {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["LegajoDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].LegajoDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].LegajoDesde = value;
               }
	          }
        public bool IsLegajoDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsLegajoDesdeNull();
             }
	        }
        public Int32 LegajoHasta {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["LegajoHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].LegajoHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].LegajoHasta = value;
               }
	          }
        public bool IsLegajoHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsLegajoHastaNull();
             }
	        }
        public String SucursalDesde {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public String ConvenioDesde {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["ConvenioDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].ConvenioDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].ConvenioDesde = value;
               }
	          }
        public bool IsConvenioDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsConvenioDesdeNull();
             }
	        }
        public String ConvenioHasta {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["ConvenioHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].ConvenioHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].ConvenioHasta = value;
               }
	          }
        public bool IsConvenioHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsConvenioHastaNull();
             }
	        }
        public Int32 AnchoNombre {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["AnchoNombre"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].AnchoNombre;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].AnchoNombre = value;
               }
	          }
        public bool IsAnchoNombreNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsAnchoNombreNull();
             }
	        }
        public String Centro1Desde {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Centro1Desde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Centro1Desde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Centro1Desde = value;
               }
	          }
        public bool IsCentro1DesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsCentro1DesdeNull();
             }
	        }
        public String Centro1Hasta {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Centro1Hasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Centro1Hasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Centro1Hasta = value;
               }
	          }
        public bool IsCentro1HastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsCentro1HastaNull();
             }
	        }
        public String Centro2Desde {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Centro2Desde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Centro2Desde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Centro2Desde = value;
               }
	          }
        public bool IsCentro2DesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsCentro2DesdeNull();
             }
	        }
        public String Centro2Hasta {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Centro2Hasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Centro2Hasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Centro2Hasta = value;
               }
	          }
        public bool IsCentro2HastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsCentro2HastaNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueInfDefiniblesDS );
     }
     public sueInfDefiniblesActionExchange() : base( "sueInfDefinibles" ) {
     }

     public sueInfDefiniblesActionExchange(sueInfDefiniblesActionEnum.EnumsueInfDefiniblesAction pAccion) : base(sueInfDefiniblesActionEnum.GetAccionsueInfDefiniblesAction(pAccion)) {
     }

     public sueInfDefiniblesActionExchange(sueInfDefiniblesActionEnum.EnumsueInfDefiniblesAction pAccion, SueldosCommon.sueInfDefiniblesDS pdsParam) : base(sueInfDefiniblesActionEnum.GetAccionsueInfDefiniblesAction(pAccion), pdsParam) {
     }

     public sueInfDefiniblesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueInfDefiniblesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueInfDefiniblesDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueInfDefiniblesDS)mParam;
	        }
     }
  }
}
