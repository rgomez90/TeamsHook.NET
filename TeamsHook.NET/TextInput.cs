namespace TeamsHook.NET
{
    public class TextInput : Input
    {
        public TextInput() : base(MessageInputType.TextInput)
        {
        }

        public bool IsMultiline { get; set; }
        public bool MaxLength { get; set; }
    }

    public enum MessageInputType
    {
        TextInput,
        DateInput,
        MultiChoiceInput
    }
}