using System.Collections.Immutable;

namespace CollectionGenerator.Tests;

public partial class UnitTest1 {
    [AddTo("MyCollection")]
    public static readonly string TestString1 = "Hello";
    [AddTo("MyCollection")]
    public static readonly string TestString2 = "World";

    public static readonly ImmutableArray<string> MyCollection;

    [Fact]
    public void Test1() {
        MyCollection.ShouldBe(["Hello", "World"]);
    }
}