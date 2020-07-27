using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Xunit;

namespace TeamsHook.NET.Tests
{
    public class NewtonsoftTests
    {
        [Fact]
        public void JsonTestMessageCard()
        {
            MessageCard card = new MessageCard()
            {
                Title = "Test",
                Summary = "Summary",
                Text = "<h1>This is the text of the card</h1>",
                PotentialAction = new List<MessageAction>()
                {
                    new ActionCard()
                    {
                        Name = "Set Date",
                        Inputs = new List<Input>()
                        {
                            new DateInput()
                            {
                                Id = "DueDate",
                                IsRequired = false,
                                Title = "Select a date"
                            }
                        }
                    },
                    new OpenUriAction()
                    {
                        Name = "Open an URI",
                        Targets = new HashSet<Target>()
                        {
                            new Target()
                            {
                                OS = TargetOS.@default,
                                Uri = "https://hengesbach.com"
                            }
                        }
                    }
                },
                Sections = new List<Section>()
                {
                    new Section()
                    {
                        Title = "SectionTitle",
                        Text = "SectionText",
                        ActivityText = "11 Vorgänge gefunden",
                        ActivitySubtitle = DateTime.Now.ToString("G"),
                        ActivityTitle = "Offene FE",
                        Facts = new List<MessageFact>()
                        {
                            new MessageFact("Fact1","Value1234234"),
                            new MessageFact("Fact2","Value2"),
                            new MessageFact("Fact3","Value3")
                        },
                    },
                    new Section()
                    {
                        Title = "SectionTitle",
                        Text = "<table bordercolor='black' border= '2'><thead><tr style = 'background-color : Teal; color: White'><th>Task</th><th>Status</th><th>Start Time</th><th>End Time</th></tr></thead></thead><tbody ><tr><td>xxx</td><td>yyy</td><td>14:25</td></tr><tr><td>xxx</td><td>yyy</td><td>15:25</td><td>16:25</td></tr></tbody></table>",
                        ActivityText = "11 Vorgänge gefunden",
                        ActivitySubtitle = DateTime.Now.ToString("G"),
                        ActivityTitle = "Offene FE",
                        Facts = new List<MessageFact>()
                        {
                            new MessageFact("Fact1","Value1234234"),
                            new MessageFact("Fact2","Value2"),
                            new MessageFact("Fact3","Value3")
                        },
                        PotentialAction = new List<MessageAction>()
                        {
                            new OpenUriAction()
                            {
                                Name = "Section Action",
                                Targets = new HashSet<Target>()
                                {
                                    new Target(){ OS = TargetOS.@default, Uri = "https://steam.com"}
                                }
                            }
                        }
                    }
                }
            };
            var json = JsonConvert.SerializeObject(card,Formatting.Indented, new TeamsNewtonsoftSerializationOptions());
            string expectedJson = "";
            Assert.True(json == expectedJson);
        }
    }
}