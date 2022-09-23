using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace extendedClipboardTools
{
    /// <summary>
    /// ExtendToolDefineSheet to ClipboardTool
    /// </summary>
    class ClipboardToolCompiler
    {
        const string nl = "\r\n";

        /// <summary>
        /// Createor
        /// </summary>
        /// <param name="defines"></param>
        public bool CreateTools(IEnumerable<ExtendToolDefineSheet> defines)
        {
            var script = @"using System;
                           using System.Collections.Generic;
                           using System.Linq;
                           using System.Text;
                           using System.Text.RegularExpressions;
                           using System.Windows.Forms;

                           namespace extendedClipboardTools
                           {" + nl;

            Defines = defines.ToList();

            foreach(var def in Defines)
            {
                //nameがクラス名の要件を満たさないとダメなのだがそれのチェックをどこでやるかは未定。
                script += defToScript(def);
            }
            script += "}" + nl;
  
            //for debug
            File.WriteAllText(PathExtension.ApplicationPathFile("lastCompiledScript.cs"), script);

            //parameter
            var p = new CompilerParameters();
            p.GenerateExecutable = false;   //create lib
            p.GenerateInMemory = true;      //create on memory
            //references
            p.ReferencedAssemblies.Add("System.dll");
            p.ReferencedAssemblies.Add("System.Core.dll");
            p.ReferencedAssemblies.Add("System.Data.dll");
            p.ReferencedAssemblies.Add("System.Drawing.dll");
            p.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            p.ReferencedAssemblies.Add(System.Windows.Forms.Application.ExecutablePath);    //and me

            //compiler
            var compiler = new CSharpCodeProvider();
            var result = compiler.CompileAssemblyFromSource(p, script);

            //errorCheck
            string ErrorMessage = "";
            foreach(var msg in result.Errors)
            {
                ErrorMessage += msg.ToString() + nl;
            }
            //for debug
            File.WriteAllText(PathExtension.ApplicationPathFile("lastCompileError.txt"), ErrorMessage);

            //getTools
            if (!result.Errors.HasErrors)
            {
                Assembly = result.CompiledAssembly;
                return true;
            }
            else
            {
                Assembly = null;
                return false;
            }
        }

        /// <summary>
        /// clipboard tool names in assembly
        /// </summary>
        public List<ExtendToolDefineSheet> Defines { get; private set; }

        /// <summary>
        /// CompileError
        /// </summary>
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Assembly
        /// </summary>
        public System.Reflection.Assembly Assembly { get; private set; }

        /// <summary>
        /// Enumerate tools by Names order
        /// </summary>
        public IEnumerable<IClipboardTool> ClipboardTools
        {
            get
            {
                if (Assembly != null)
                {
                    foreach (var def in Defines)
                    {
                        var tool = Assembly.CreateInstance($"extendedClipboardTools.{def.Name}") as ClipboardTool;
                        if (tool != null)
                        {
                            tool.Define = def;
                            tool.Enable = true;
                            yield return tool;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// DefineSheet to clipboard-tool class source code
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        private string defToScript(ExtendToolDefineSheet sheet)
        {
            var cls = $"class {sheet.Name} : ClipboardTool {nl}";
            cls += "{ \r\n";

            //global script
            if (sheet.GlobalScript != null)
            {
                cls += sheet.GlobalScript + nl;
            }

            //constractor
            cls += $"public {sheet.Name}(){nl}";
            cls += "{" + nl;
            cls += $"\tName = @\"{sheet.FaceName}\";{nl}";
            cls += $"\tDescription = @\"{sheet.Description}\";{nl}";
            var cont = sheet.Continuous ? "true" : "false";
            cls += $"\tContinuous = {cont};{nl}";
            cls += "}" + nl;

            //prepare
            if (sheet.PrepareScript != null)
            {
                cls += "public override void Prepare(){" + nl;
                cls += sheet.PrepareScript + nl;
                cls += "}" + nl;
            }

            //check
            if (sheet.CheckerScript != null)
            {
                cls += "public override bool Checker(string opt){ " + nl;
                cls += sheet.CheckerScript + nl;
                cls += "}" + nl;
            }

            //action
            if (sheet.ActionScript != null)
            {
                cls += "public override void Action(string opt){ " + nl;
                cls += sheet.ActionScript + nl;
                cls += "}" + nl;
            }

            //finishaction
            if (sheet.FinishActionScript != null)
            {
                cls += "public override void FinishAction(string opt){ " + nl;
                cls += sheet.FinishActionScript + nl;
                cls += "}" + nl;

            }

            cls += "}" + nl;
            return cls;
        }
    }
}
