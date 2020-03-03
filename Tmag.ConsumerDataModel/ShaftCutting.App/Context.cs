using Tmag.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Diagnostics;
using ShaftCutting.App.Models;

namespace ShaftCutting.App
{
  public class Context : DbContext
  {
    private readonly string _connectionString;

    public Context()

    {
      this.Database.Migrate();
    }
    public Context(string connectionString)
    {
      _connectionString = connectionString;
      this.Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

      string pathToContentRoot = Directory.GetCurrentDirectory();
      string json = Path.Combine(pathToContentRoot, "appsettings.json");

      if (!File.Exists(json))
      {
        string pathToExe = Process.GetCurrentProcess().MainModule.FileName;
        pathToContentRoot = Path.GetDirectoryName(pathToExe);
      }

      IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
          .SetBasePath(pathToContentRoot)
          .AddJsonFile("appsettings.json");

      IConfiguration configuration = configurationBuilder.Build();

      optionsBuilder.UseSqlServer(configuration.GetConnectionString("MainDb"));
      //optionsBuilder.UseSqlServer(_connectionString);
    }

    public DbSet<ShaftCutTemplate> ShaftCutTemplates { get; set; }
  }
}
