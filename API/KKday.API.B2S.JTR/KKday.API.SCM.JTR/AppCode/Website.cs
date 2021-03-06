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

 

   
    //private string _CONTENT_EMAIL = "";
    //public string CONTENT_EMAIL
    //{
    //    get { return _CONTENT_EMAIL; }
    //}

    //private string _ORDER_URL = "";
    //public string ORDER_URL
    //{
    //    get { return _ORDER_URL; }
    //}

    //private string _PAY_URL = "";
    //public string PAY_URL
    //{
    //    get { return _PAY_URL; }
    //}




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

        //this._CONTENT_EMAIL = Configuration["CONTENT_EMAIL"];
        //this._ORDER_URL = Configuration["JTR_API_URL:ORDER_URL"];
        //this._PAY_URL = Configuration["JTR_API_URL:PAY_URL"];


        LoadLog4netConfig();

        logger.Info("StartUp....");
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