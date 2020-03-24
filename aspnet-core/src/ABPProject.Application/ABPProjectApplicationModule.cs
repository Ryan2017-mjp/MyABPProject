using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPProject.Authorization;

namespace ABPProject
{
    [DependsOn(
        typeof(ABPProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
