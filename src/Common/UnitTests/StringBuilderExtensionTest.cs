// ------------------------------------------------------------------------------
// Copyright (c) 2014 Microsoft Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// ------------------------------------------------------------------------------

namespace Microsoft.Live.UnitTests
{
    using System;
    using System.Text;

#if NETFX_CORE
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
#elif WINDOWS_PHONE || WEB || DESKTOP
    using Microsoft.VisualStudio.TestTools.UnitTesting;
#else
#error This platform needs to be handled.
#endif

    [TestClass]
    public class StringBuilderExtensionTest
    {
        [TestMethod]
        public void TestAppendUrlPathStringEmpty()
        {
            var sb = new StringBuilder("/some/path");

            Assert.AreEqual(sb, sb.AppendUrlPath(string.Empty));

            Assert.AreEqual("/some/path/", sb.ToString());
        }

        [TestMethod]
        public void TestAppendUrlPathNull()
        {
            var sb = new StringBuilder("/some/path");

            Assert.AreEqual(sb, sb.AppendUrlPath(null));

            Assert.AreEqual("/some/path", sb.ToString());
        }

        [TestMethod]
        public void TestAppendUrlPathBasePathIsEmpty()
        {
            var sb = new StringBuilder();

            Assert.AreEqual(sb, sb.AppendUrlPath("some/path"));

            Assert.AreEqual("some/path", sb.ToString());
        }

        [TestMethod]
        public void TestAppendUrlPathBasePathEndsInForwardSlashAppendedPathBeginsWithForwardSlash()
        {
            var sb = new StringBuilder("/some/");

            Assert.AreEqual(sb, sb.AppendUrlPath("/path"));

            Assert.AreEqual("/some/path", sb.ToString());
        }

        [TestMethod]
        public void TestAppendUrlPathBasePathDoesNotEndInForwardSlashAppendedPathBeginsWithForwardSlash()
        {
            var sb = new StringBuilder("/some");

            Assert.AreEqual(sb, sb.AppendUrlPath("/path"));

            Assert.AreEqual("/some/path", sb.ToString());
        }

        [TestMethod]
        public void TestAppendUrlPathBasePathDoesNotEndInForwardSlashAppendedPathDoesNotBeginWithForwardSlash()
        {
            var sb = new StringBuilder("/some");

            Assert.AreEqual(sb, sb.AppendUrlPath("path"));

            Assert.AreEqual("/some/path", sb.ToString());
        }

        [TestMethod]
        public void TestAppendQueryParameter()
        {
            var sb = new StringBuilder("/some/path?");

            Assert.AreEqual(sb, sb.AppendQueryParam("key", "value"));

            Assert.AreEqual("/some/path?key=value", sb.ToString());
        }
    }
}
