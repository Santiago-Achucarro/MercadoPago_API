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
    public class venCondFiscalActionExchange : Framework.Core.Exchange{

        public Int32 venCondFiscal {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].venCondFiscal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].venCondFiscal = value;
               }
	          }
        public bool IsvenCondFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsvenCondFiscalNull();
             }
	        }
        public String CondFisc_Id {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].CondFisc_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].CondFisc_Id = value;
               }
	          }
        public bool IsCondFisc_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsCondFisc_IdNull();
             }
	        }
        public String CondFisc_Id_Nueva {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].CondFisc_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].CondFisc_Id_Nueva = value;
               }
	          }
        public bool IsCondFisc_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsCondFisc_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Letra {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Letra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Letra = value;
               }
	          }
        public bool IsLetraNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsLetraNull();
             }
	        }
        public Boolean AplicaFactCredito {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].AplicaFactCredito;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].AplicaFactCredito = value;
               }
	          }
        public bool IsAplicaFactCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsAplicaFactCreditoNull();
             }
	        }
        public String Letra_Rf {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Letra_Rf;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Letra_Rf = value;
               }
	          }
        public bool IsLetra_RfNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsLetra_RfNull();
             }
	        }
        public Boolean Discrimina {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Discrimina;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Discrimina = value;
               }
	          }
        public bool IsDiscriminaNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsDiscriminaNull();
             }
	        }
        public Boolean FacturaElectronica {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].FacturaElectronica;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].FacturaElectronica = value;
               }
	          }
        public bool IsFacturaElectronicaNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsFacturaElectronicaNull();
             }
	        }
        public String CodigoFiscal {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].CodigoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].CodigoFiscal = value;
               }
	          }
        public bool IsCodigoFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsCodigoFiscalNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if( HasParam ){
                    return ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscalDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscalDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCondFiscalDS );
     }
     public venCondFiscalActionExchange() : base( "venCondFiscal" ) {
     }

     public venCondFiscalActionExchange(venCondFiscalActionEnum.EnumvenCondFiscalAction pAccion) : base(venCondFiscalActionEnum.GetAccionvenCondFiscalAction(pAccion)) {
     }

     public venCondFiscalActionExchange(venCondFiscalActionEnum.EnumvenCondFiscalAction pAccion, VentasCommon.venCondFiscalDS pdsParam) : base(venCondFiscalActionEnum.GetAccionvenCondFiscalAction(pAccion), pdsParam) {
     }

     public venCondFiscalActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCondFiscalDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCondFiscalDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCondFiscalDS)mParam;
	        }
     }
  }
}
