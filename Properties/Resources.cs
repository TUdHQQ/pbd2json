﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace pbd2json.Properties{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources{
		internal Resources(){}
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager{
			get{
				if (Resources.resourceMan == null){
					Resources.resourceMan = new ResourceManager("pbd2json.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture{
			get{
				return Resources.resourceCulture;
			}
			set{
				Resources.resourceCulture = value;
			}
		}

		internal static byte[] pbd2json{
			get{
				return (byte[])Resources.ResourceManager.GetObject("pbd2json", Resources.resourceCulture);
			}
		}

		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;
	}
}
