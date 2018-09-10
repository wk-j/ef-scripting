#! "netcoreapp2.1"

#r "nuget:Microsoft.Extensions.DependencyInjection,2.1.1"
#r "nuget:Npgsql.EntityFrameworkCore.PostgreSQL,2.1.1"

using System;
using Microsoft.Extensions.DependencyInjection;


var collection = new ServiceCollection();