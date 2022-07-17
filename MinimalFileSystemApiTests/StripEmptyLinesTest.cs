using MinimalFileSystemApi;
using NUnit.Framework;
using SampleProject;
using System.IO;
using System.Linq;

namespace MinimalFileSystemApiTests
{
    [TestFixture]
    public class StripEmptyLinesTest
    {
        [Test]
        public void TestStripEmptyLinesVirtual()
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

        [Test]
        public void TestStripEmptyLinesPhysical()
        {
            using (TemporayFile inputFile = new TemporayFile())
            {
                File.WriteAllLines(inputFile.FileName, 
                    new[] {
                    "First Line",
                    string.Empty,
                    "Third line",
                    "Fourth line"
                    });

                using(TemporayFile outputFile = new TemporayFile())
                {
                    StripEmptyLines stripEmptyLines = new StripEmptyLines();
                    using(LineReader reader = new LineReader(inputFile.FileName))
                    {
                        using(LineWriter writer = new LineWriter(outputFile.FileName))
                        {
                            stripEmptyLines.Process(reader, writer);
                        }
                    }

                    var lines = File.ReadAllLines(outputFile.FileName);
                    Assert.False(lines.Any(line => string.IsNullOrEmpty(line)), "Empty line detected");
                }
            }
        }
    }
}