using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;
using Shouldly;
using Xunit;

namespace AngleSharpWrappers
{
    public class QuerySelectorTests
    {
        public WrapperFactory Factory { get; } = new WrapperFactory();

        [Fact]
        public void MyTestMethod()
        {
            using var parser = new HtmlParser();
            var nodes = parser.Parse("<div><p>first</p><p>last</p></div>");
            var wrapped = Factory.Wrap(() => nodes);

            wrapped.QuerySelectorAll("div > *:last-child")
                .Single()
                .TextContent.ShouldBe("last");
        }
    }
}
