using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;
using Moq;
using Xunit;
using Shouldly;
using AngleSharp.Html.Dom;

namespace AngleSharpWrappers
{
    public class ElementWrapperTest
    {
        public static IEnumerable<object[]> GetInterfaceMethods(Type type) => type.GetInterfaceMethods().Select(x => new[] { x });

        public WrapperFactory Factory { get; } = new WrapperFactory();


        [Theory(DisplayName = "Forwards all method and property calls to wrapped node")]
        [MemberData(nameof(GetInterfaceMethods), typeof(IElement))]
        public void Test001(MethodInfo method)
        {
            var elmMock = new Mock<IElement>();
            var sut = (ElementWrapper)Factory.Wrap(() => elmMock.Object);
            var args = method.CreateMethodArguments();

            method.Invoke(sut, args);

            var inv = elmMock.Invocations[0];
            inv.Arguments.ShouldBe(args);
            inv.Method.ShouldBe(method);
        }

        [Fact(DisplayName = "Wrapped node is internally available")]
        public void Test002()
        {
            var elmMock = Mock.Of<IElement>();

            var sut = (ElementWrapper)Factory.Wrap(() => elmMock);

            sut.WrappedObject.ShouldBe(elmMock);
        }

        [Fact(DisplayName = "Wrapper refreshes wrapped node after MarkAsStale is called")]
        public void Test003()
        {
            IElement elm = Mock.Of<IElement>();
            var sut = (ElementWrapper)Factory.Wrap(() => elm);
            var firstWrapped = sut.WrappedObject;

            sut.MarkAsStale();
            elm = Mock.Of<IElement>();

            sut.WrappedObject.ShouldNotBe(firstWrapped);
        }

        [Fact(DisplayName = "When a wrapped node is no longer available, accessing methods or properties throws ElementNoLongerAvailableException")]
        public void Test004()
        {
            IElement? elm = Mock.Of<IElement>();
            var sut = (ElementWrapper)Factory.Wrap(() => elm);

            sut.MarkAsStale();
            elm = null;

            Should.Throw<NodeNoLongerAvailableException>(() => sut.WrappedObject);
        }

        [Fact(DisplayName = "When a method or property on an wrapped node returns an INode, it is wrapped")]
        public void Test005()
        {
            var elmMock = new Mock<IElement>();
            var elmParent = Mock.Of<IElement>();
            elmMock.SetupGet(x => x.ParentElement).Returns(elmParent);
            var sut = (ElementWrapper)Factory.Wrap(() => elmMock.Object);

            var parent = sut.ParentElement;

            parent.ShouldBeOfType<ElementWrapper>().WrappedObject.ShouldBe(elmParent);
        }

        [Fact(DisplayName = "The same wrapper is used every time")]
        public void Test006()
        {
            var elmMock = new Mock<IElement>();
            var parentElm = Mock.Of<IElement>();
            elmMock.SetupGet(x => x.ParentElement).Returns(() => parentElm);
            var sut = (ElementWrapper)Factory.Wrap(() => elmMock.Object);

            sut.ParentElement.ShouldBeSameAs(sut.ParentElement);
        }

        [Fact(DisplayName = "Nested wrappers also gets marked as stale when the parent does")]
        public void Test007()
        {
            var elmMock = new Mock<IElement>();
            elmMock.SetupGet(x => x.ParentElement).Returns(() => new Mock<IElement>().Object);
            var sut = (ElementWrapper)Factory.Wrap(() => elmMock.Object);
            var parentElementWrapper = ((ElementWrapper)sut.ParentElement);
            var initialWrappedParentNode = parentElementWrapper.WrappedObject;

            Factory.MarkAsStale();

            initialWrappedParentNode.ShouldNotBeSameAs(parentElementWrapper.WrappedObject);
        }
    }
}
