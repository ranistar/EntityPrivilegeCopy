using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace EntityPrivilegeCopy
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Entity Privilege Copy Tool"),
        ExportMetadata("Description", "This tool allow you copy entity privilege on security role to other entity."),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "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"),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class MyPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MyPluginControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public MyPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}