// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Matthew Ward" email="mrward@users.sourceforge.net"/>
//     <version>$Revision$</version>
// </file>

using System;
using ICSharpCode.PythonBinding;
using NUnit.Framework;

namespace PythonBinding.Tests.Designer
{
	[TestFixture]
	public class PythonCodeBuilderTests
	{
		PythonCodeBuilder codeBuilder;
		
		[SetUp]
		public void Init()
		{
			codeBuilder = new PythonCodeBuilder();
			codeBuilder.IndentString = "\t";
		}
		
		[Test]
		public void AppendNewLine()
		{
			codeBuilder.AppendLine();
			Assert.AreEqual("\r\n", codeBuilder.ToString());
		}
		
		[Test]
		public void AppendText()
		{
			codeBuilder.Append("abc");
			Assert.AreEqual("abc", codeBuilder.ToString());
		}
		
		[Test]
		public void AppendIndentedText()
		{
			codeBuilder.IncreaseIndent();
			codeBuilder.AppendIndented("abc");
			Assert.AreEqual("\tabc", codeBuilder.ToString());
		}
		
		[Test]
		public void IncreaseIndentTwice()
		{
			codeBuilder.IncreaseIndent();
			codeBuilder.IncreaseIndent();
			codeBuilder.AppendIndented("abc");
			Assert.AreEqual("\t\tabc", codeBuilder.ToString());
		}
		
		[Test]
		public void DecreaseIndent()
		{
			codeBuilder.IncreaseIndent();
			codeBuilder.AppendIndented("abc");
			codeBuilder.AppendLine();
			codeBuilder.DecreaseIndent();			
			codeBuilder.AppendIndented("abc");
			Assert.AreEqual("\tabc\r\nabc", codeBuilder.ToString());
		}
		
		[Test]
		public void AppendIndentedLine()
		{
			codeBuilder.IncreaseIndent();
			codeBuilder.AppendIndentedLine("abc");
			Assert.AreEqual("\tabc\r\n", codeBuilder.ToString());
		}
	}
}
