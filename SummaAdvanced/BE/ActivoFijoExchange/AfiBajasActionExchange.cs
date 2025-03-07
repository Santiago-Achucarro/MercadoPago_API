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
    public class AfiBajasActionExchange : Framework.Core.Exchange{

        public Int32 AfiActivoFijo {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["AfiActivoFijo"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].AfiActivoFijo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].AfiActivoFijo = value;
               }
	          }
        public bool IsAfiActivoFijoNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsAfiActivoFijoNull();
             }
	        }
        public String ActivoFijo_Id {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["ActivoFijo_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].ActivoFijo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].ActivoFijo_Id = value;
               }
	          }
        public bool IsActivoFijo_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsActivoFijo_IdNull();
             }
	        }
        public String ActivoFijo_Id_Nueva {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["ActivoFijo_Id_Nueva"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].ActivoFijo_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].ActivoFijo_Id_Nueva = value;
               }
	          }
        public bool IsActivoFijo_Id_NuevaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsActivoFijo_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public DateTime FechaAlta {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["FechaAlta"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].FechaAlta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].FechaAlta = value;
               }
	          }
        public bool IsFechaAltaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsFechaAltaNull();
             }
	        }
        public DateTime FechaIniDepre {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["FechaIniDepre"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].FechaIniDepre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].FechaIniDepre = value;
               }
	          }
        public bool IsFechaIniDepreNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsFechaIniDepreNull();
             }
	        }
        public DateTime FechaBaja {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["FechaBaja"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].FechaBaja;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].FechaBaja = value;
               }
	          }
        public bool IsFechaBajaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsFechaBajaNull();
             }
	        }
        public Decimal ValorInicial {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["ValorInicial"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].ValorInicial;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].ValorInicial = value;
               }
	          }
        public bool IsValorInicialNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsValorInicialNull();
             }
	        }
        public Decimal ValorFiscal {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["ValorFiscal"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].ValorFiscal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].ValorFiscal = value;
               }
	          }
        public bool IsValorFiscalNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsValorFiscalNull();
             }
	        }
        public Int32 VidaUtil {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["VidaUtil"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].VidaUtil;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].VidaUtil = value;
               }
	          }
        public bool IsVidaUtilNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsVidaUtilNull();
             }
	        }
        public Int32 VidaUtilRestante {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["VidaUtilRestante"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].VidaUtilRestante;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].VidaUtilRestante = value;
               }
	          }
        public bool IsVidaUtilRestanteNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsVidaUtilRestanteNull();
             }
	        }
        public Decimal PorResidual {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["PorResidual"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].PorResidual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].PorResidual = value;
               }
	          }
        public bool IsPorResidualNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsPorResidualNull();
             }
	        }
        public Decimal AmortAcumulada {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["AmortAcumulada"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].AmortAcumulada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].AmortAcumulada = value;
               }
	          }
        public bool IsAmortAcumuladaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsAmortAcumuladaNull();
             }
	        }
        public String Rubro_Id {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["Rubro_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Rubro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Rubro_Id = value;
               }
	          }
        public bool IsRubro_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsRubro_IdNull();
             }
	        }
        public String DescripcionRubros {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["DescripcionRubros"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].DescripcionRubros;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].DescripcionRubros = value;
               }
	          }
        public bool IsDescripcionRubrosNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsDescripcionRubrosNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public String CtaValorOrigen_Id {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["CtaValorOrigen_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].CtaValorOrigen_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].CtaValorOrigen_Id = value;
               }
	          }
        public bool IsCtaValorOrigen_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsCtaValorOrigen_IdNull();
             }
	        }
        public String DescripcionCuentasOrigen {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["DescripcionCuentasOrigen"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].DescripcionCuentasOrigen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].DescripcionCuentasOrigen = value;
               }
	          }
        public bool IsDescripcionCuentasOrigenNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsDescripcionCuentasOrigenNull();
             }
	        }
        public String CtaAmortAcum_Id {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["CtaAmortAcum_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].CtaAmortAcum_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].CtaAmortAcum_Id = value;
               }
	          }
        public bool IsCtaAmortAcum_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsCtaAmortAcum_IdNull();
             }
	        }
        public String DescripcionCtaAmortAcum_Id {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["DescripcionCtaAmortAcum_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].DescripcionCtaAmortAcum_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].DescripcionCtaAmortAcum_Id = value;
               }
	          }
        public bool IsDescripcionCtaAmortAcum_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsDescripcionCtaAmortAcum_IdNull();
             }
	        }
        public String CtaAmortizacion {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["CtaAmortizacion"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].CtaAmortizacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].CtaAmortizacion = value;
               }
	          }
        public bool IsCtaAmortizacionNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsCtaAmortizacionNull();
             }
	        }
        public String DescripcionCtaAmortizacion {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["DescripcionCtaAmortizacion"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].DescripcionCtaAmortizacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].DescripcionCtaAmortizacion = value;
               }
	          }
        public bool IsDescripcionCtaAmortizacionNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsDescripcionCtaAmortizacionNull();
             }
	        }
        public String Tipo {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public Decimal ValorInicialSI {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["ValorInicialSI"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].ValorInicialSI;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].ValorInicialSI = value;
               }
	          }
        public bool IsValorInicialSINull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsValorInicialSINull();
             }
	        }
        public Decimal AmortAcumSI {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["AmortAcumSI"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].AmortAcumSI;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].AmortAcumSI = value;
               }
	          }
        public bool IsAmortAcumSINull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsAmortAcumSINull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime FechaCarga {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["FechaCarga"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].FechaCarga;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].FechaCarga = value;
               }
	          }
        public bool IsFechaCargaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsFechaCargaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean TieneMovimientos {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["TieneMovimientos"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].TieneMovimientos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].TieneMovimientos = value;
               }
	          }
        public bool IsTieneMovimientosNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsTieneMovimientosNull();
             }
	        }
        public Int64 AsientoOrigen {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["AsientoOrigen"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].AsientoOrigen;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].AsientoOrigen = value;
               }
	          }
        public bool IsAsientoOrigenNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsAsientoOrigenNull();
             }
	        }
        public Int32 RenglonOrigen {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["RenglonOrigen"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].RenglonOrigen;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].RenglonOrigen = value;
               }
	          }
        public bool IsRenglonOrigenNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsRenglonOrigenNull();
             }
	        }
        public String Origen {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["Origen"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Origen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Origen = value;
               }
	          }
        public bool IsOrigenNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsOrigenNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiBajasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ActivoFijoCommon.AfiBajasDS );
     }
     public AfiBajasActionExchange() : base( "AfiBajas" ) {
     }

     public AfiBajasActionExchange(AfiBajasActionEnum.EnumAfiBajasAction pAccion) : base(AfiBajasActionEnum.GetAccionAfiBajasAction(pAccion)) {
     }

     public AfiBajasActionExchange(AfiBajasActionEnum.EnumAfiBajasAction pAccion, ActivoFijoCommon.AfiBajasDS pdsParam) : base(AfiBajasActionEnum.GetAccionAfiBajasAction(pAccion), pdsParam) {
     }

     public AfiBajasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ActivoFijoCommon.AfiBajasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ActivoFijoCommon.AfiBajasDS Param{
	        get{
			    InitParam();
			    return (ActivoFijoCommon.AfiBajasDS)mParam;
	        }
     }
  }
}
