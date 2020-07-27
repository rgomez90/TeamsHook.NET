using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Xunit;

namespace TeamsHook.NET.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void JsonTestActionsMessageCard()
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
            var json = JsonSerializer.Serialize(card, TeamsHookSystemTextSerializationOptions.Instance);
            string expectedJson = "";
            Assert.True(json == expectedJson);
        }

        [Fact]
        public async Task JsonTestMessageCardClient()
        {
            const string UriWebhook = @"https://outlook.office.com/webhook/d3470767-e202-4f22-8251-a42d92916355@4cccefa5-026f-4183-ba9d-ca1ff6e6bb59/IncomingWebhook/ba9e479c10b540a2bdffe7a1493879d3/e2d090c3-7509-4c54-a95f-678a5af6d85b";

            var opt = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter()}
            };

            MessageCard card = new MessageCard()
            {
                Title = "Test",
                Summary = "Summary",
                Sections = new List<Section>()
                {
                    new Section()
                    {
                        Title = "SectionTitle",
                        Text = "SectionText",
                        Facts = new List<MessageFact>()
                        {
                            new MessageFact("Fact1","Value1234234"),
                            new MessageFact("Fact2","Value2"),
                            new MessageFact("Fact3","Value3")
                        }
                    }
                }
            };
            var json = JsonSerializer.Serialize(card, opt);
            using var client = new HttpClient();
            var response = await client.PostAsync(UriWebhook, new StringContent(json, Encoding.UTF8, "application/json"));
            var content = await response.Content.ReadAsStringAsync();
        }

        [Fact]
        public void JsonTestMessageCard()
        {
            MessageCard card = new MessageCard()
            {
                Title = "Test",
                Summary = "Summary",
                Sections = new List<Section>()
                {
                    new Section()
                    {
                        Title = "SectionTitle",
                        Text = "SectionText",
                        Facts = new List<MessageFact>()
                        {
                            new MessageFact("Fact1","Value1234234"),
                            new MessageFact("Fact2","Value2"),
                            new MessageFact("Fact3","Value3")
                        }
                    }
                }
            };
            var json = JsonSerializer.Serialize(card, TeamsHookSystemTextSerializationOptions.Instance);
            string expectedJson = "";
            Assert.True(json == expectedJson);
        }
    }
}
