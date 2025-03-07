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
    public class suePeriodicidadActionExchange : Framework.Core.Exchange{

        public String Periodo_Id {
            get {
                if(((SueldosCommon.suePeriodicidadDS)mParam).Principal[0]["Periodo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Periodo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Periodo_Id = value;
               }
	          }
        public bool IsPeriodo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].IsPeriodo_IdNull();
             }
	        }
        public String Periodo_Id_Nueva {
            get {
                if(((SueldosCommon.suePeriodicidadDS)mParam).Principal[0]["Periodo_Id_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Periodo_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Periodo_Id_Nueva = value;
               }
	          }
        public bool IsPeriodo_Id_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].IsPeriodo_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.suePeriodicidadDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Decimal Dias {
            get {
                if(((SueldosCommon.suePeriodicidadDS)mParam).Principal[0]["Dias"] != DBNull.Value  ){
                    return ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Dias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Dias = value;
               }
	          }
        public bool IsDiasNull {
             get {
                 return mParam==null || ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].IsDiasNull();
             }
	        }
        public DateTime FechaActiva {
            get {
                if(((SueldosCommon.suePeriodicidadDS)mParam).Principal[0]["FechaActiva"] != DBNull.Value  ){
                    return ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].FechaActiva;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].FechaActiva = value;
               }
	          }
        public bool IsFechaActivaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].IsFechaActivaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.suePeriodicidadDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((SueldosCommon.suePeriodicidadDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String CodFiscal {
            get {
                if(((SueldosCommon.suePeriodicidadDS)mParam).Principal[0]["CodFiscal"] != DBNull.Value  ){
                    return ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].CodFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].CodFiscal = value;
               }
	          }
        public bool IsCodFiscalNull {
             get {
                 return mParam==null || ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].IsCodFiscalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.suePeriodicidadDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.suePeriodicidadDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.suePeriodicidadDS );
     }
     public suePeriodicidadActionExchange() : base( "suePeriodicidad" ) {
     }

     public suePeriodicidadActionExchange(suePeriodicidadActionEnum.EnumsuePeriodicidadAction pAccion) : base(suePeriodicidadActionEnum.GetAccionsuePeriodicidadAction(pAccion)) {
     }

     public suePeriodicidadActionExchange(suePeriodicidadActionEnum.EnumsuePeriodicidadAction pAccion, SueldosCommon.suePeriodicidadDS pdsParam) : base(suePeriodicidadActionEnum.GetAccionsuePeriodicidadAction(pAccion), pdsParam) {
     }

     public suePeriodicidadActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.suePeriodicidadDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.suePeriodicidadDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.suePeriodicidadDS)mParam;
	        }
     }
  }
}
