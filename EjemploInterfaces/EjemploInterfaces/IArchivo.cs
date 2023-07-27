using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploInterfaces
{
    public interface IArchivo : IAlmacenamiento
    {
        int NombreArchivo { get; set; }
    }
}