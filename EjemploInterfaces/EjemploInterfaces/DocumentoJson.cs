using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploInterfaces
{
    public class DocumentoJson : IArchivosJson
    {
        public int NombreArchivo
        {
            get => default;
            set
            {
            }
        }

        public void Deserializar()
        {
            throw new NotImplementedException();
        }

        public void Escribir()
        {
            throw new NotImplementedException();
        }

        public void Leer()
        {
            throw new NotImplementedException();
        }

        public void Serializar()
        {
            throw new NotImplementedException();
        }
    }
}