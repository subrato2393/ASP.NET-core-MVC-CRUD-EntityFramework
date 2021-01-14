using Autofac;
using Crud.Foundation.Contexts;
using Crud.Foundation.Repository;
using Crud.Foundation.Services;
using Crud.Foundation.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Foundation
{
    public class FoundationModule:Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FoundationModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CrudDbContext>()
                 .WithParameter("connectionString", _connectionString)
                 .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                 .InstancePerLifetimeScope();

            builder.RegisterType<StudentService>().As<IStudentService>().InstancePerLifetimeScope();
            builder.RegisterType<StudentUnitOfWork>().As<IStudentUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<StudentRepository>().As<IStudentRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DepartmentRepository>().As<IDepartmentRepository>().InstancePerLifetimeScope();
        }
    }
}
