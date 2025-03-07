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
    public class AfiCentrosActionExchange : Framework.Core.Exchange{

        public Int32 ActivoFijo_Id {
            get {
                if(((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0]["ActivoFijo_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].ActivoFijo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].ActivoFijo_Id = value;
               }
	          }
        public bool IsActivoFijo_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].IsActivoFijo_IdNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiCentrosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ActivoFijoCommon.AfiCentrosDS );
     }
     public AfiCentrosActionExchange() : base( "AfiCentros" ) {
     }

     public AfiCentrosActionExchange(AfiCentrosActionEnum.EnumAfiCentrosAction pAccion) : base(AfiCentrosActionEnum.GetAccionAfiCentrosAction(pAccion)) {
     }

     public AfiCentrosActionExchange(AfiCentrosActionEnum.EnumAfiCentrosAction pAccion, ActivoFijoCommon.AfiCentrosDS pdsParam) : base(AfiCentrosActionEnum.GetAccionAfiCentrosAction(pAccion), pdsParam) {
     }

     public AfiCentrosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ActivoFijoCommon.AfiCentrosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ActivoFijoCommon.AfiCentrosDS Param{
	        get{
			    InitParam();
			    return (ActivoFijoCommon.AfiCentrosDS)mParam;
	        }
     }
  }
}
