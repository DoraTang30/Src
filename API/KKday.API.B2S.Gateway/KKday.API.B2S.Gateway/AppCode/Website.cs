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


    private Website()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void Init(IConfiguration configuration)
    {
        this.Configuration = configuration;

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

        // var logRepository = LogManager.GetRepository(System.Reflection.Assembly.GetEntryAssembly());
        Array.ForEach(repository.GetAppenders(), appender =>
        {
            // Check appsetting.json => log4net.Appender.Name is "RollingFile"
            if (appender.Name.Equals("RollingFile") &&
                 appender.GetType() == typeof(log4net.Appender.RollingFileAppender))
            {
                Console.WriteLine(appender.Name);
                ((log4net.Appender.RollingFileAppender)appender).File = Configuration["LOG4NET.FILE_PATHE:RollingFile"];
                ((log4net.Appender.RollingFileAppender)appender).ActivateOptions();
            }
        });
    }

  

}