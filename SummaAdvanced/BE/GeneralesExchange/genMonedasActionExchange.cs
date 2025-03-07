using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genMonedasActionExchange : Framework.Core.Exchange{

        public Int32 genMonedas {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["genMonedas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].genMonedas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].genMonedas = value;
               }
	          }
        public bool IsgenMonedasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsgenMonedasNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String Moneda_Id_Nueva {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["Moneda_Id_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Moneda_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Moneda_Id_Nueva = value;
               }
	          }
        public bool IsMoneda_Id_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsMoneda_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Simbolo {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["Simbolo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Simbolo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Simbolo = value;
               }
	          }
        public bool IsSimboloNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsSimboloNull();
             }
	        }
        public String CodigoFiscal {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["CodigoFiscal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].CodigoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].CodigoFiscal = value;
               }
	          }
        public bool IsCodigoFiscalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsCodigoFiscalNull();
             }
	        }
        public String CtaFactaRecibir {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["CtaFactaRecibir"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].CtaFactaRecibir;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].CtaFactaRecibir = value;
               }
	          }
        public bool IsCtaFactaRecibirNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsCtaFactaRecibirNull();
             }
	        }
        public String DescripcionCtaFactaRecibir {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["DescripcionCtaFactaRecibir"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].DescripcionCtaFactaRecibir;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].DescripcionCtaFactaRecibir = value;
               }
	          }
        public bool IsDescripcionCtaFactaRecibirNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsDescripcionCtaFactaRecibirNull();
             }
	        }
        public String CtaFactaRecibirImp {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["CtaFactaRecibirImp"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].CtaFactaRecibirImp;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].CtaFactaRecibirImp = value;
               }
	          }
        public bool IsCtaFactaRecibirImpNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsCtaFactaRecibirImpNull();
             }
	        }
        public String DescripcionCtaFactaRecibirImp {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["DescripcionCtaFactaRecibirImp"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].DescripcionCtaFactaRecibirImp;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].DescripcionCtaFactaRecibirImp = value;
               }
	          }
        public bool IsDescripcionCtaFactaRecibirImpNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsDescripcionCtaFactaRecibirImpNull();
             }
	        }
        public Int32 CantidadDigitos {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["CantidadDigitos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].CantidadDigitos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].CantidadDigitos = value;
               }
	          }
        public bool IsCantidadDigitosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsCantidadDigitosNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genMonedasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMonedasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMonedasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genMonedasDS );
     }
     public genMonedasActionExchange() : base( "genMonedas" ) {
     }

     public genMonedasActionExchange(genMonedasActionEnum.EnumgenMonedasAction pAccion) : base(genMonedasActionEnum.GetAcciongenMonedasAction(pAccion)) {
     }

     public genMonedasActionExchange(genMonedasActionEnum.EnumgenMonedasAction pAccion, GeneralesCommon.genMonedasDS pdsParam) : base(genMonedasActionEnum.GetAcciongenMonedasAction(pAccion), pdsParam) {
     }

     public genMonedasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genMonedasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genMonedasDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genMonedasDS)mParam;
	        }
     }
  }
}
