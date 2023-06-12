using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();

            builder.RegisterType<BuildReporterManager>().As<IBuildReporterService>().SingleInstance();
            builder.RegisterType<EfBuildReporterDal>().As<IBuildReporterDal>().SingleInstance();

            builder.RegisterType<ColdVictimManager>().As<IColdVictimService>().SingleInstance();
            builder.RegisterType<EfColdVictimDal>().As<IColdVictimDal>().SingleInstance();

            builder.RegisterType<DebrisVictimManager>().As<IDebrisVictimService>().SingleInstance();
            builder.RegisterType<EfDebrisVictimDal>().As<IDebrisVictimDal>().SingleInstance();

            builder.RegisterType<FoodHelperManager>().As<IFoodHelperService>().SingleInstance();
            builder.RegisterType<EfFoodHelperDal>().As<IFoodHelperDal>().SingleInstance();

            builder.RegisterType<FoodVictimManager>().As<IFoodVictimService>().SingleInstance();
            builder.RegisterType<EfFoodVictimDal>().As<IFoodVictimDal>().SingleInstance();

            builder.RegisterType<HouseHelperManager>().As<IHouseHelperService>().SingleInstance();
            builder.RegisterType<EfHouseHelperDal>().As<IHouseHelperDal>().SingleInstance();

            builder.RegisterType<OperatorHelperManager>().As<IOperatorHelperService>().SingleInstance();
            builder.RegisterType<EfOperatorHelperDal>().As<IOperatorHelperDal>().SingleInstance();

            builder.RegisterType<TentHelperManager>().As<ITentHelperService>().SingleInstance();
            builder.RegisterType<EfTentHelperDal>().As<ITentHelperDal>().SingleInstance();

            builder.RegisterType<TransporterHelperManager>().As<ITransporterHelperService>().SingleInstance();
            builder.RegisterType<EfTransporterHelperDal>().As<ITransporterHelperDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<VictimManager>().As<IVictimService>().SingleInstance();
            builder.RegisterType<EfVictimDal>().As<IVictimDal>().SingleInstance();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>().SingleInstance();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}