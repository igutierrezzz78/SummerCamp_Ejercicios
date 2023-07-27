using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploInterfaces
{
    public interface IArchivosJson : IAlmacenamiento
    {
        void Deserializar();
        void Serializar();
    }

    public interface CopyOfIArchivosJson
    {
    }
}