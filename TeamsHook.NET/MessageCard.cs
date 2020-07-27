using System;
using System.Collections.Generic;

namespace TeamsHook.NET
{
    public class MessageCard : TeamsCard
    {
        public MessageCard() : base(CardType.MessageCard)
        {
        }

        public Guid CorrelationId { get; set; }
        public string[] ExpectedActors { get; set; }
        public bool HideOriginalBody { get; set; }
        public string Originator { get; set; }
        public IList<MessageAction> PotentialAction { get; set; }
        public IList<Section> Sections { get; set; }
        public string Summary { get; set; }
        public string Text { get; set; }
        public string ThemeColor { get; set; }
        public string Title { get; set; }
    }
}