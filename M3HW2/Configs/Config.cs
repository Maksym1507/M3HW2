using Autofac;
using M3HW2.Services.Abstractions;
using M3HW2.Services;

namespace M3HW2.Configs
{
    public class Config
    {
        public Config()
        {
            Builder = new ContainerBuilder();
        }

        private ContainerBuilder Builder { get; }

        public IContainer RegisterTypes()
        {
            Builder.RegisterType<AlphabetConfigurationService>().As<IAlphabetConfigurationService>();
            Builder.RegisterType<ContactService>().As<IContactService>();
            Builder.RegisterType<Starter>();
            return Builder.Build();
        }
    }
}
