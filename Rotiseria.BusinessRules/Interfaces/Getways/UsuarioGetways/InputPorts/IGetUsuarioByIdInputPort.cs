using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts
{
    public interface IGetUsuarioByIdInputPort
    {
        Task Handle(int idActor);

    }
}
