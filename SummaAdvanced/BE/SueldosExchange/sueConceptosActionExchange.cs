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
    public class sueConceptosActionExchange : Framework.Core.Exchange{

        public Int32 sueConceptos {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["sueConceptos"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].sueConceptos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].sueConceptos = value;
               }
	          }
        public bool IssueConceptosNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IssueConceptosNull();
             }
	        }
        public Int32 Concepto_Id {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Concepto_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Concepto_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Concepto_Id = value;
               }
	          }
        public bool IsConcepto_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsConcepto_IdNull();
             }
	        }
        public Int32 Concepto_Id_Nueva {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Concepto_Id_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Concepto_Id_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Concepto_Id_Nueva = value;
               }
	          }
        public bool IsConcepto_Id_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsConcepto_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Formula {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Formula"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Formula;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Formula = value;
               }
	          }
        public bool IsFormulaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsFormulaNull();
             }
	        }
        public Boolean LlevaDato {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["LlevaDato"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].LlevaDato;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].LlevaDato = value;
               }
	          }
        public bool IsLlevaDatoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsLlevaDatoNull();
             }
	        }
        public String CuentaDebe {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["CuentaDebe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].CuentaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].CuentaDebe = value;
               }
	          }
        public bool IsCuentaDebeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsCuentaDebeNull();
             }
	        }
        public String DescripcionCuentaDebe {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["DescripcionCuentaDebe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionCuentaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionCuentaDebe = value;
               }
	          }
        public bool IsDescripcionCuentaDebeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsDescripcionCuentaDebeNull();
             }
	        }
        public String CuentaHaber {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["CuentaHaber"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].CuentaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].CuentaHaber = value;
               }
	          }
        public bool IsCuentaHaberNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsCuentaHaberNull();
             }
	        }
        public String DescripcionCuentaHaber {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["DescripcionCuentaHaber"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionCuentaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionCuentaHaber = value;
               }
	          }
        public bool IsDescripcionCuentaHaberNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsDescripcionCuentaHaberNull();
             }
	        }
        public String SubCuentaDebe {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["SubCuentaDebe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].SubCuentaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].SubCuentaDebe = value;
               }
	          }
        public bool IsSubCuentaDebeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsSubCuentaDebeNull();
             }
	        }
        public String DescripcionSubCuentasDebe {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["DescripcionSubCuentasDebe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionSubCuentasDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionSubCuentasDebe = value;
               }
	          }
        public bool IsDescripcionSubCuentasDebeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsDescripcionSubCuentasDebeNull();
             }
	        }
        public String SubCuentaHaber {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["SubCuentaHaber"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].SubCuentaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].SubCuentaHaber = value;
               }
	          }
        public bool IsSubCuentaHaberNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsSubCuentaHaberNull();
             }
	        }
        public String DescripcionSubCuentasHaber {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["DescripcionSubCuentasHaber"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionSubCuentasHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionSubCuentasHaber = value;
               }
	          }
        public bool IsDescripcionSubCuentasHaberNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsDescripcionSubCuentasHaberNull();
             }
	        }
        public Boolean Retroactivo {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Retroactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Retroactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Retroactivo = value;
               }
	          }
        public bool IsRetroactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsRetroactivoNull();
             }
	        }
        public Boolean Extraordinario {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Extraordinario"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Extraordinario;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Extraordinario = value;
               }
	          }
        public bool IsExtraordinarioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsExtraordinarioNull();
             }
	        }
        public String TipoPercepcion {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["TipoPercepcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].TipoPercepcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].TipoPercepcion = value;
               }
	          }
        public bool IsTipoPercepcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsTipoPercepcionNull();
             }
	        }
        public String DescripcionTipoPercepcion {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["DescripcionTipoPercepcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionTipoPercepcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionTipoPercepcion = value;
               }
	          }
        public bool IsDescripcionTipoPercepcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsDescripcionTipoPercepcionNull();
             }
	        }
        public String TipoDeduccion {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["TipoDeduccion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].TipoDeduccion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].TipoDeduccion = value;
               }
	          }
        public bool IsTipoDeduccionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsTipoDeduccionNull();
             }
	        }
        public String DescripcionTipoDeduccion {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["DescripcionTipoDeduccion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionTipoDeduccion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionTipoDeduccion = value;
               }
	          }
        public bool IsDescripcionTipoDeduccionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsDescripcionTipoDeduccionNull();
             }
	        }
        public String TipoOtro {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["TipoOtro"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].TipoOtro;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].TipoOtro = value;
               }
	          }
        public bool IsTipoOtroNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsTipoOtroNull();
             }
	        }
        public String DescripcionTipoOtro {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["DescripcionTipoOtro"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionTipoOtro;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionTipoOtro = value;
               }
	          }
        public bool IsDescripcionTipoOtroNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsDescripcionTipoOtroNull();
             }
	        }
        public String TipoHora {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["TipoHora"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].TipoHora;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].TipoHora = value;
               }
	          }
        public bool IsTipoHoraNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsTipoHoraNull();
             }
	        }
        public String TipoIncapacidad {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["TipoIncapacidad"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].TipoIncapacidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].TipoIncapacidad = value;
               }
	          }
        public bool IsTipoIncapacidadNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsTipoIncapacidadNull();
             }
	        }
        public Boolean EsExento {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["EsExento"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].EsExento;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].EsExento = value;
               }
	          }
        public bool IsEsExentoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsEsExentoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Int16 Signo {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Signo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Signo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Signo = value;
               }
	          }
        public bool IsSignoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsSignoNull();
             }
	        }
        public Int16 ColumnaRecibo {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["ColumnaRecibo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].ColumnaRecibo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].ColumnaRecibo = value;
               }
	          }
        public bool IsColumnaReciboNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsColumnaReciboNull();
             }
	        }
        public String Observacion {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Observacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Observacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Observacion = value;
               }
	          }
        public bool IsObservacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsObservacionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueConceptosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConceptosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConceptosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueConceptosDS );
     }
     public sueConceptosActionExchange() : base( "sueConceptos" ) {
     }

     public sueConceptosActionExchange(sueConceptosActionEnum.EnumsueConceptosAction pAccion) : base(sueConceptosActionEnum.GetAccionsueConceptosAction(pAccion)) {
     }

     public sueConceptosActionExchange(sueConceptosActionEnum.EnumsueConceptosAction pAccion, SueldosCommon.sueConceptosDS pdsParam) : base(sueConceptosActionEnum.GetAccionsueConceptosAction(pAccion), pdsParam) {
     }

     public sueConceptosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueConceptosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueConceptosDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueConceptosDS)mParam;
	        }
     }
  }
}
