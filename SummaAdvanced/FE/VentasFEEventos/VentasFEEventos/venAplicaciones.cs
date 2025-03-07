using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venAplicaciones
    {
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venAplicacionCobranzaDS Aplicar(VentasCommon.venAplicacionCobranzaDS exch,
   VentasCommon.venAplicacionCobranzaDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            decimal lMonto = exch.Principal[0].Saldo;
            lMonto -= exch.Cuerpo.Where(c => c.venMovimientos != exchNoPost.Cuerpo[pIndice].venMovimientos).Sum(c => c.Aplicar);
            if (lMonto > 0)
                // FM 12/01/2022 Siempre comparaba contra el primer comprobante aunque estuviera aplicando otro //
                exchNoPost.Cuerpo[pIndice].Aplicar = Math.Min(exchNoPost.Cuerpo[pIndice].Saldo, lMonto);

            return exchNoPost;
        }
    }
}
