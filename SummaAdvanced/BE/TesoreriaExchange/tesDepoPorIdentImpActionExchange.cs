using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesDepoPorIdentImpActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String DescripcionImpuestos {
            get {
                if(((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0]["DescripcionImpuestos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].DescripcionImpuestos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].DescripcionImpuestos = value;
               }
	          }
        public bool IsDescripcionImpuestosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].IsDescripcionImpuestosNull();
             }
	        }
        public Decimal BaseImponible {
            get {
                if(((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0]["BaseImponible"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].BaseImponible;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].BaseImponible = value;
               }
	          }
        public bool IsBaseImponibleNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].IsBaseImponibleNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepoPorIdentImpDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesDepoPorIdentImpDS );
     }
     public tesDepoPorIdentImpActionExchange() : base( "tesDepoPorIdentImp" ) {
     }

     public tesDepoPorIdentImpActionExchange(tesDepoPorIdentImpActionEnum.EnumtesDepoPorIdentImpAction pAccion) : base(tesDepoPorIdentImpActionEnum.GetAcciontesDepoPorIdentImpAction(pAccion)) {
     }

     public tesDepoPorIdentImpActionExchange(tesDepoPorIdentImpActionEnum.EnumtesDepoPorIdentImpAction pAccion, TesoreriaCommon.tesDepoPorIdentImpDS pdsParam) : base(tesDepoPorIdentImpActionEnum.GetAcciontesDepoPorIdentImpAction(pAccion), pdsParam) {
     }

     public tesDepoPorIdentImpActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesDepoPorIdentImpDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesDepoPorIdentImpActionExchange(TesoreriaCommon.tesDepoPorIdentImpDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesDepoPorIdentImpDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesDepoPorIdentImpDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesDepoPorIdentImpDS)mParam;
	        }
     }
  }
}
