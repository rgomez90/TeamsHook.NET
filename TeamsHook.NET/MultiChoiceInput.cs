using System.Collections.Generic;

namespace TeamsHook.NET
{
    public class MultiChoiceInput : Input
    {
        public MultiChoiceInput() : base(MessageInputType.MultiChoiceInput)
        {
        }

        public IList<Choice> Choices { get; set; } = new List<Choice>();
        public bool IsMultiSelect { get; set; }
        public string Style { get; set; }
    }
}