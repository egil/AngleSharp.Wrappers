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
        [Fact]
        public void MyTestMethod()
        {
            using var parser = new HtmlParser();
            var nodes = parser.Parse("<div><p>first</p><p>last</p></div>");
            var wrapped = new NodeListWrapper(nodes, () => nodes);

            //nodes.QuerySelectorAll("div > *:last-child")
            //    .Single()
            //    .TextContent.ShouldBe("last");

            wrapped.QuerySelectorAll("div > *:last-child")
                .Single()
                .TextContent.ShouldBe("last");
        }
    }
}
