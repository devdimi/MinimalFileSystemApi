using NUnit.Framework;
using SampleProject;
using SimpleFileSystemAbstraction;
using System.Linq;

namespace SimpleFileSystemAbstractionTests
{
    [TestFixture]
    public class StripEmptyLinesTest
    {
        [Test]
        public void TestStripEmptyLines()
        {
            var text = new[] {
            "First Line",
            string.Empty,
            "Second Line ...",
            "Thrid line"};

            MockReader lineReader = new MockReader(text);
            CollectingWriter writer = new CollectingWriter();
            StripEmptyLines stripEmptyLines = new StripEmptyLines();
            stripEmptyLines.Process(lineReader, writer);

            Assert.False(writer.Lines.Any(line => string.IsNullOrEmpty(line)), "Empty line detected");
        }
    }
}