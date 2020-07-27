using System.Collections.Generic;

namespace TeamsHook.NET
{
    public class Section
    {
        public string ActivityImage { get; set; }
        public string ActivitySubtitle { get; set; }
        public string ActivityText { get; set; }
        public string ActivityTitle { get; set; }
        public IList<MessageFact> Facts { get; set; }
        public string HeroImage { get; set; }
        public IList<MessageImage> Images { get; set; }
        public IList<MessageAction> PotentialAction { get; set; }
        public bool StartGroup { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
    }
}