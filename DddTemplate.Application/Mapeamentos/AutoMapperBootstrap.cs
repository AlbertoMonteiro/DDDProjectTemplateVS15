using System;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace $safeprojectname$.Mapeamentos
{
    public static class AutoMapperBootstrap
    {
        private static readonly Assembly CurrentAssembly = typeof(AutoMapperBootstrap).Assembly;
        private static readonly Type ProfileType = typeof(Profile);

        public static void InicializaMapas() => Mapper.Initialize(ConfiguraAutoMapper);

        private static void ConfiguraAutoMapper(IMapperConfiguration mapperConfiguration)
            => CurrentAssembly.GetTypes()
                .Where(t => t.IsAssignableFrom(ProfileType))
                .Select(Activator.CreateInstance)
                .Cast<Profile>()
                .ToList()
                .ForEach(mapperConfiguration.AddProfile);
    }
}
