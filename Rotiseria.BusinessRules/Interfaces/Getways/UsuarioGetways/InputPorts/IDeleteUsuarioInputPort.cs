﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts
{
    public interface IDeleteUsuarioInputPort
    {
        Task Handle(int idUsuario);
    }
}
