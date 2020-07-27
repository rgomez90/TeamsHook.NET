using System.Collections.Generic;

namespace TeamsHook.NET
{
    public class HttpPostAction : MessageAction
    {
        public HttpPostAction() : base(MessageActionType.HttpPOST)
        {
        }

        public string Body { get; set; }
        public string BodyContentType { get; set; }
        public IList<HttpActionHeader> Headers { get; set; }
        public string Name { get; set; }
        public string Target { get; set; }
    }
}