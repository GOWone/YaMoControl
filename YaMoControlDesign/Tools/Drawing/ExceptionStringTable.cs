using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace YaMoControlDesign.Tools.Drawing
{
    [CompilerGenerated]
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal class ExceptionStringTable
    {
        private static ResourceManager ResourceMan;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture { get; set; }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (ReferenceEquals(ResourceMan, null))
                {
                    var manager = new ResourceManager("Microsoft.Expression.Drawing.ExceptionStringTable",
                        typeof(ExceptionStringTable).Assembly);
                    ResourceMan = manager;
                }

                return ResourceMan;
            }
        }

        internal static string TypeNotSupported =>
            ResourceManager.GetString("TypeNotSupported", Culture);
    }
}
