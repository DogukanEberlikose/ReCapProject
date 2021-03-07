﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();
            builder.RegisterType<ColorManager>().As<IColorService>();
            builder.RegisterType<EfColorDal>().As<IColorDal>();
            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
        }
    }
}