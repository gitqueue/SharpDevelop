﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using ICSharpCode.SharpDevelop.Editor.CodeCompletion;

namespace ICSharpCode.PythonBinding
{
	public class PythonCodeCompletionItemProvider : CodeCompletionItemProvider
	{
		protected override DefaultCompletionItemList CreateCompletionItemList()
		{
			return new PythonCompletionItemList();
		}
	}
}
