﻿namespace Resources
{
	using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Resources;
    using System.Runtime.Loader;
    using System.Text.RegularExpressions;

    public interface ILocalizer
    {
		string Culture { get; set; }

		Text Text { get; }

        string GetString(Type category, string resourceKey);

        string GetString(string category, string resourceKey);

        string GetString(Type category, string resourceKey, string culture);

        string GetString(string category, string resourceKey, string culture);
    }

    public class Localizer : ILocalizer
    {
        private const string DefaultCulture = "zh-TW";
        private static readonly Lazy<Dictionary<string, ResourceManager>> _resources = new Lazy<Dictionary<string, ResourceManager>>(LoadResourceManager);
		private static string _assemblyPath;
        private string _culture;
        private Text _text;

		public Localizer() {
			_assemblyPath = Assembly.GetEntryAssembly().Location;
		}

		public Localizer(string assemblyPath) {
			_assemblyPath = assemblyPath;
		}
            
        #region ILocalizer

		public string Culture
        {
            get
            {
                if (string.IsNullOrEmpty(_culture))
                {
                    _culture = DefaultCulture;
                }
                return _culture;
            }
            set
            {
                var culture = value;
                if (Regex.IsMatch(culture, @"^[A-Za-z]{2}-[A-Za-z]{2}$"))
                {
                    _culture = culture;
                }
                else
                {
                    _culture = DefaultCulture;
                }
            }
        }

		public Text Text { get { if (_text == null) { _text = new Text(this); } return _text; } }

        public string GetString(Type category, string resourceKey)
        {
            return GetString(category.Name.ToString(), resourceKey);
        }

        public string GetString(string category, string resourceKey)
        {
            return GetString(category, resourceKey, _culture);
        }

        public string GetString(Type category, string resourceKey, string culture)
        {
            return GetString(category.Name.ToString(), resourceKey, culture);
        }

        public string GetString(string category, string resourceKey, string culture)
        {
            var resource = GetResource($"{category}.{culture}") ?? GetResource($"{category}.{DefaultCulture}");
            if (resource == null)
            {
                return resourceKey;
            }
            else
            {
                return resource.GetString(resourceKey);
            }
        }

        #endregion ILocalizer

        #region Private Methods

        private static Dictionary<string, ResourceManager> LoadResourceManager()
        {
            var directory = Path.GetDirectoryName(_assemblyPath);
            var files = Directory.GetFiles(directory, "*.resources.dll", SearchOption.AllDirectories);
            
            var resources = new Dictionary<string, ResourceManager>(StringComparer.CurrentCultureIgnoreCase);
            foreach (var file in files)
            {
                var culture = Path.GetFileName(Path.GetDirectoryName(file));
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file);
                foreach(var resourceName in assembly.GetManifestResourceNames().Select(s=> Regex.Replace(s, ".resources$", "")))
                {
                    var category = Regex.Match(resourceName, $".*Resources\\.(.*)\\.{culture}").Groups[1].Value;
                    var resourceManager = new ResourceManager(resourceName, assembly);
                    resources.Add($"{category}.{culture}", resourceManager);
                }
            }

            return resources;
        }

        private ResourceManager GetResource(string key)
        {
            if (_resources.Value.Keys.Contains(key))
            {
                return _resources.Value[key];
            }
            return null;
        }

        #endregion
    }

    public abstract class ResourceBase
    {
        protected ResourceBase(ILocalizer localizer)
        {
            Localizer = localizer;
        }

        protected ILocalizer Localizer { get; private set; }

        protected string GetString(string resourceKey)
        {
            return Localizer.GetString(GetType(), resourceKey);
        }
    }

    public class Text : ResourceBase
    {
        public Text(ILocalizer localizer) : base(localizer)
        {
        }

		public string KKday_CopyRight { get { return GetString("KKday_CopyRight"); } }

		public string Add { get { return GetString("Add"); } }

		public string Update { get { return GetString("Update"); } }

		public string Edit { get { return GetString("Edit"); } }

		public string Delete { get { return GetString("Delete"); } }

		public string Company_Title { get { return GetString("Company_Title"); } }

		public string Company_Search_Name { get { return GetString("Company_Search_Name"); } }

		public string Company_Search_Country { get { return GetString("Company_Search_Country"); } }

		public string Company_Search_Status { get { return GetString("Company_Search_Status"); } }

		public string Company_Search_Sorting { get { return GetString("Company_Search_Sorting"); } }

		public string Company_Search_Button { get { return GetString("Company_Search_Button"); } }

		public string Company_List_Col_Name { get { return GetString("Company_List_Col_Name"); } }

		public string Company_List_Col_Promo { get { return GetString("Company_List_Col_Promo"); } }
    }
}
