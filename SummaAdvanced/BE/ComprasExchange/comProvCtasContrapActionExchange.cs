using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange
{
    // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comProvCtasContrapActionExchange : Framework.Core.Exchange
    {

        public Int64 Proveed_Id
        {
            get
            {
                if (((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value)
                {
                    return ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Proveed_Id;
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                InitParam();
                ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Proveed_Id = value;
            }
        }
        public bool IsProveed_IdNull
        {
            get
            {
                return mParam == null || ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].IsProveed_IdNull();
            }
        }
        public String Cuenta_Id
        {
            get
            {
                if (((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value)
                {
                    return ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Cuenta_Id;
                }
                else
                {
                    return "";
                }
            }

            set
            {
                InitParam();
                ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Cuenta_Id = value;
            }
        }
        public bool IsCuenta_IdNull
        {
            get
            {
                return mParam == null || ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].IsCuenta_IdNull();
            }
        }
        public String DescripcionCuentas
        {
            get
            {
                if (((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value)
                {
                    return ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].DescripcionCuentas;
                }
                else
                {
                    return "";
                }
            }

            set
            {
                InitParam();
                ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].DescripcionCuentas = value;
            }
        }
        public bool IsDescripcionCuentasNull
        {
            get
            {
                return mParam == null || ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].IsDescripcionCuentasNull();
            }
        }
        public String Centro1_Id
        {
            get
            {
                if (((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value)
                {
                    return ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Centro1_Id;
                }
                else
                {
                    return "";
                }
            }

            set
            {
                InitParam();
                ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Centro1_Id = value;
            }
        }
        public bool IsCentro1_IdNull
        {
            get
            {
                return mParam == null || ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].IsCentro1_IdNull();
            }
        }
        public String DescripcionCentro1
        {
            get
            {
                if (((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value)
                {
                    return ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].DescripcionCentro1;
                }
                else
                {
                    return "";
                }
            }

            set
            {
                InitParam();
                ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].DescripcionCentro1 = value;
            }
        }
        public bool IsDescripcionCentro1Null
        {
            get
            {
                return mParam == null || ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].IsDescripcionCentro1Null();
            }
        }
        public String Centro2_Id
        {
            get
            {
                if (((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value)
                {
                    return ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Centro2_Id;
                }
                else
                {
                    return "";
                }
            }

            set
            {
                InitParam();
                ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Centro2_Id = value;
            }
        }
        public bool IsCentro2_IdNull
        {
            get
            {
                return mParam == null || ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].IsCentro2_IdNull();
            }
        }
        public String DescripcionCentro2
        {
            get
            {
                if (((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value)
                {
                    return ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].DescripcionCentro2;
                }
                else
                {
                    return "";
                }
            }

            set
            {
                InitParam();
                ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].DescripcionCentro2 = value;
            }
        }
        public bool IsDescripcionCentro2Null
        {
            get
            {
                return mParam == null || ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].IsDescripcionCentro2Null();
            }
        }
        public String Detalle
        {
            get
            {
                if (((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0]["Detalle"] != DBNull.Value)
                {
                    return ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Detalle;
                }
                else
                {
                    return "";
                }
            }

            set
            {
                InitParam();
                ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Detalle = value;
            }
        }
        public bool IsDetalleNull
        {
            get
            {
                return mParam == null || ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].IsDetalleNull();
            }
        }
        public Boolean Existe
        {
            get
            {
                if (((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0]["Existe"] != DBNull.Value)
                {
                    return ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Existe;
                }
                else
                {
                    return false;
                }
            }

            set
            {
                InitParam();
                ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].Existe = value;
            }
        }
        public bool IsExisteNull
        {
            get
            {
                return mParam == null || ((ComprasCommon.comProvCtasContrapDS)mParam).Principal[0].IsExisteNull();
            }
        }

        protected override Type GetParamType()
        {
            return typeof(ComprasCommon.comProvCtasContrapDS);
        }
        public comProvCtasContrapActionExchange() : base("comProvCtasContrap")
        {
        }

        public comProvCtasContrapActionExchange(comProvCtasContrapActionEnum.EnumcomProvCtasContrapAction pAccion) : base(comProvCtasContrapActionEnum.GetAccioncomProvCtasContrapAction(pAccion))
        {
        }

        public comProvCtasContrapActionExchange(comProvCtasContrapActionEnum.EnumcomProvCtasContrapAction pAccion, ComprasCommon.comProvCtasContrapDS pdsParam) : base(comProvCtasContrapActionEnum.GetAccioncomProvCtasContrapAction(pAccion), pdsParam)
        {
        }

        public comProvCtasContrapActionExchange(Exchange pExch) : base()
        {
            this.Action = pExch.Action;
            this.mParam = new ComprasCommon.comProvCtasContrapDS();
            this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
            this.mParam.AcceptChanges();
        }

        /// <summary>
        /// El DataSet con los parámetros.
        /// </summary>
        public ComprasCommon.comProvCtasContrapDS Param
        {
            get
            {
                InitParam();
                return (ComprasCommon.comProvCtasContrapDS)mParam;
            }
        }
    }
}
