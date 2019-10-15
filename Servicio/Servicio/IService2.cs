using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService2" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        void guardar(string nom, int c1, int c2, int c3, int c4, int c5);
        [OperationContract]
        string[] buscar(string nom);
        [OperationContract]
        float promedio(float c1, float c2, float c3, float c4, float c5);  
    }
}
