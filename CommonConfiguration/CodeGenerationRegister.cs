using System.Reflection;
using Mapster;
using Models;

namespace CommonConfiguration
{
    public class CodeGenerationRegister : ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            config.AdaptTo("[name]Dto")
                .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "Domain");

            config.GenerateMapper("[name]Mapper")
                .ForType<Computer>();
        }
    }
}
