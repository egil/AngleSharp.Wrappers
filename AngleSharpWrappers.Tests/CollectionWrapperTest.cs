using System.Linq;
using AngleSharp.Css.Dom;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Io.Dom;
using AngleSharp.Media.Dom;
using Moq;
using Shouldly;
using Xunit;

namespace AngleSharpWrappers
{
    public class CollectionWrapperTest
    {
        public WrapperFactory Factory { get; } = new WrapperFactory();


        [Fact(DisplayName = "NodeListWrapper Items returned by Enumerators are wrapped")]
        public void Test005()
        {
            var colMock = new Mock<INodeList>();
            var elm1 = new Mock<INode>().Object;
            var elm2 = new Mock<INode>().Object;
            colMock.SetupGet(x => x[0]).Returns(elm1);
            colMock.SetupGet(x => x[1]).Returns(elm2);
            colMock.SetupGet(x => x.Length).Returns(2);

            var sut = Factory.Wrap(() => colMock.Object);

            sut.ShouldAllBe(
                x => x.ShouldBeOfType<NodeWrapper>().WrappedObject.ShouldBe(elm1),
                x => x.ShouldBeOfType<NodeWrapper>().WrappedObject.ShouldBe(elm2)
            );
            ((System.Collections.IEnumerable)sut).Cast<object>().ShouldAllBe(
                x => x.ShouldBeOfType<NodeWrapper>().WrappedObject.ShouldBe(elm1),
                x => x.ShouldBeOfType<NodeWrapper>().WrappedObject.ShouldBe(elm2)
            );
        }

    }
}
