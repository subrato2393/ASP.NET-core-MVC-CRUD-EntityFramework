using Autofac;
using CRUDAppEFCore.Context;
using CRUDAppEFCore.Models;
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
           .WithParameter("connectionString", _connectionString).AsSelf();

            builder.RegisterType<StudentModel>().AsSelf();
        }
    }
}
