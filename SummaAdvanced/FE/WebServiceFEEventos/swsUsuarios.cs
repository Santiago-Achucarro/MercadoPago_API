using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Chilkat;
using Framework.Core;

namespace WebServiceFEEventos
{
    public class swsUsuarios
    {
        [Generalidades.QFuncion_AccionDescargarFila]
        public Generalidades.DescargaArchivoDS DescargarKey(WebServiceCommon.swsUsuariosDS pCommonDS, WebServiceCommon.swsUsuariosDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            string Password = CreatePassword(50);
            WebServiceDAL.swsUsuarios.ActuPass(pCommonDS.Usuarios[pIndice].Usuario_Id, Password, cmd.ConnectionString);
            
            
            RSACryptoServiceProvider Provider = new RSACryptoServiceProvider();
            Chilkat.Pfx pfx = new Chilkat.Pfx();
            Chilkat.PublicKey pubk = new Chilkat.PublicKey();
            bool res = true;
            res = pubk.LoadXml(Provider.ToXmlString(true));
            Chilkat.PrivateKey privk = new Chilkat.PrivateKey();
            res = privk.LoadXml(Provider.ToXmlString(true));

            res = pfx.AddPrivateKey(privk, new CertChain());
            Chilkat.Cert cert = new Cert();
            res = cert.LoadFromBinary(pubk.GetDer(false));
            res = cert.SetPrivateKey(privk);
            
            res = pfx.AddCert(cert, false);
            
            var bin = pfx.ToBinary(Password);
            
            return Generalidades.Archivos.ConvertirADatasetDownload(pCommonDS.Usuarios[pIndice].Usuario_Id+".key", pCommonDS.Usuarios[pIndice].Usuario_Id + ".key", false, ".key", Convert.ToBase64String(bin));

        }
        private string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            System.Text.StringBuilder res = new System.Text.StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }

    
}
