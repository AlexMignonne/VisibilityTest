using CommonLibrary.Messages;

namespace TestArch.Shared
{
    public sealed class TestCommand :
        Command<string>
    {
        public TestCommand(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}