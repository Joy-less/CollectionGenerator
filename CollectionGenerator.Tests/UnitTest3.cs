using System.Collections.Immutable;

namespace CollectionGenerator.Tests;

public partial class UnitTest3 {
    [AddTo("MyCollection")]
    public static readonly string TestString = "Hello";

    public static readonly ImmutableArray<string> MyCollection;

    [Fact]
    public void Test1() {
        MyCollection.ShouldBe(["Hello"]);
    }

    static UnitTest3() {
        UnitTest3_AddTo(ref MyCollection);
    }
}