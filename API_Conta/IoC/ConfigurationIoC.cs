using Adaptador.Interfaces;
using Adaptador.Map;
using Aplicacao.Interface;
using Aplicacao.Servico;
using Autofac;
using Core.Interface.Repositorio;
using Core.Interface.Servico;
using Repositorio.RepositorioConta;
using Servico.Servicos;

namespace IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC SERVICE
            builder.RegisterType<ServicoConta>().As<IServicoConta>();
                        #endregion

            #region IOC REPOSITORY
            builder.RegisterType<RepositorioConta>().As<IRepositorioConta>();
            #endregion

            #region IOC MAPPER
            builder.RegisterType<MapperConta>().As<IMapperConta>();
            #endregion

            #region IOC APPLICATION
           builder.RegisterType<AplicacaoConta>().As<IAplicacaoConta>();
            #endregion
            #region IOC VALIDATOR
            //builder.RegisterType<ValidacaoConciliacao>().As<IValidacaoConciliacao>();
            
            #endregion
        }
    }
}
