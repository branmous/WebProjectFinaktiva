using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Model.Interfaces
{
    public interface IMapperDependency
    {
        IMapper GetMapper();
    }
}
