using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality.Editor;

namespace QuietWell.Editor
{
	/// <summary>
	/// Defines a Duality editor plugin.
	/// </summary>
    public class QuietWellEditorPlugin : EditorPlugin
	{
		public override string Id
		{
			get { return "QuietWellEditorPlugin"; }
		}
	}
}
