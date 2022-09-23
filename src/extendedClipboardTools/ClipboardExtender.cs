using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace extendedClipboardTools
{
    /// <summary>
    /// [Singleton]
    /// Extender manager
    /// </summary>
    class ClipboardExtender
    {
        /// <summary>
        /// Singleton Object
        /// </summary>
        public static readonly ClipboardExtender Instance = new ClipboardExtender();

        /// <summary>
        /// loaded tools
        /// </summary>
        private List<IClipboardTool> tools;

        /// <summary>
        /// loaded assemblies
        /// </summary>
        private List<Assembly> assemblies = new List<Assembly>();

        /// <summary>
        /// [private] constructor
        /// </summary>
        private ClipboardExtender()
        {
            tools = new List<IClipboardTool>();

            LoadExternalTools();

            foreach (var tool in tools)
            {
                tool.Prepare();
            }
        }

        /// <summary>
        /// Loaded Tools
        /// </summary>
        public IEnumerable<IClipboardTool> Tools { get { return tools; } }

        /// <summary>
        /// load clipboard tools from define sheet(tool/*.xml)
        /// </summary>
        private void LoadExternalTools()
        {
            //enumerate define sheets
            var files = new List<ExtendToolDefineSheet>();
            var path = Path.Combine(PathExtension.ApplicationPath, "tool");
            foreach(var file in Directory.GetFiles(path, "*.xml"))
            {
                var def = ExtendToolDefineSheet.CreateFromFile(file);
                if (def != null)
                {
                    files.Add(def);
                }
            }

            //create assembly
            var compiler = new ClipboardToolCompiler();
            if (compiler.CreateTools(files))
            {
                //get clipboard tools in assembly
                assemblies.Add(compiler.Assembly);
                tools.AddRange(compiler.ClipboardTools);
            }

        }

    }
}
