using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Model.Interfaces
{
    public class MapperClient : IMapperDependency
    {
        public MapperClient()
        {
        }

        #region IMapperDependency implementation

        public AutoMapper.IMapper GetMapper()
        {
            return LocalConfig.Mapper;
        }

        #endregion
    }
}
