using AutoMapper;

namespace Infraestructure.Model.Interfaces
{
    public class LocalConfig
    {
        public static IMapper Mapper
        {
            get;
            set;
        }
    }
}
