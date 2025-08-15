namespace lib_classes.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Program_Runs_To_Completion()
        {
            Assert.DoesNotThrow(() => Program.Main(Array.Empty<string>())); 
        }
    }
}