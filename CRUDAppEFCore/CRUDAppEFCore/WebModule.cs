using Autofac;
using CRUDAppEFCore.Context;
using CRUDAppEFCore.Models;
using CRUDAppEFCore.Repository;
using CRUDAppEFCore.Services;
using CRUDAppEFCore.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppEFCore
{
    public class WebModule:Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public WebModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CrudDbContext>()
           .WithParameter("connectionString", _connectionString).SingleInstance();

            //builder.RegisterType<StudentModel>().AsSelf();
            builder.RegisterType<StudentService>().As<IStudentService>().InstancePerLifetimeScope();
            builder.RegisterType<StudentUnitOfWork>().As<IStudentUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<StudentRepository>().As<IStudentRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DepartmentRepository>().As<IDepartmentRepository>().InstancePerLifetimeScope();
        }
    }
}
