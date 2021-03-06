using System;
using System.Data;
using System.Configuration;
using System.Web;
using log4net;
using System.Net;
using System.Xml;
using System.IO;
using System.Collections;
using Microsoft.Extensions.Configuration;
using log4net.Config;
using System.Reflection;
using Npgsql;
/// <summary>
/// Summary description for Website
/// </summary>
/// 
public sealed class Website
{
    public static readonly Website Instance = new Website();

    // DI for Configuration (appsettings.cs)
    public IConfiguration Configuration { get; private set; }
    public IServiceProvider ServiceProvider { get; private set; }

    public readonly ILog logger = LogManager.GetLogger(typeof(Website));

    // Postgresql B2D DB 連線方式
    private string _B2D_DB = "";
    public string B2D_DB {
        get { return _B2D_DB; }
        }

    // 主機站台識別
    private string _stationID;
    public string StationID {
        get { return _stationID; }
    }

    private Website()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void Init(IConfiguration configuration)
    {
        this.Configuration = configuration;

        LoadB2DDBConfig();

        LoadLog4netConfig();

        logger.Debug("StartUp....");
    }

    private void LoadLog4netConfig()
    {
        var repository = LogManager.CreateRepository(Assembly.GetEntryAssembly(),
                typeof(log4net.Repository.Hierarchy.Hierarchy)
            );

        XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));

        log4net.GlobalContext.Properties["hostname"] = Environment.MachineName;
    }

    private void LoadB2DDBConfig() {
        Console.WriteLine($"pg連線字串：{Configuration["ConnectionStrings:PostgreSQL"]}");
        this._B2D_DB = Configuration["ConnectionStrings:PostgreSQL"];

        string szLog4NetCfgFile = string.Format("{0}\\log4net.config", Directory.GetCurrentDirectory());

        _stationID = Dns.GetHostName();

        NpgsqlConnection npg_conn = new NpgsqlConnection(_B2D_DB);
    }



}