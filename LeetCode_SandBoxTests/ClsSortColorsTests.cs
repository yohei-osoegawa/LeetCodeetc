using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace Tests {
    [TestClass()]
    public class ClsSortColorsTests {
        [TestMethod()]
        public void SortColorsTest() {
            var jsonInp = "[2,0,2,1,1,0]";
            var input = JsonSerializer.Deserialize<int[]>(jsonInp);

            var expected = JsonSerializer.Deserialize<int[]>("[0,0,1,1,2,2]");
            new ClsSortColors().SortColors(input);

            input.Should().BeEquivalentTo(expected, option => option.WithStrictOrdering());
        }

        [TestMethod()]
        public void SortColorsTest2() {
            var jsonInp = "[2,0,1]";
            var input = JsonSerializer.Deserialize<int[]>(jsonInp);

            var expected = JsonSerializer.Deserialize<int[]>("[0,1,2]");
            new ClsSortColors().SortColors(input);

            input.Should().BeEquivalentTo(expected, option => option.WithStrictOrdering());
        }
    }
}