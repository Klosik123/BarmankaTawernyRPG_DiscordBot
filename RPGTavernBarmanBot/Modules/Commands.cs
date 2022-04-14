using System;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Xml.Linq;
using System.Reflection;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace RPGTavernBarman.Modules
{

    public class Commands : ModuleBase<SocketCommandContext>
    {
        Random rnd = new Random();
        [Command("BotInfo")]
        private async Task botInfo()
        {
            var Bot = new EmbedAuthorBuilder()
                    .WithName("Barmanka Tawerny RPG#7032")
                    .WithIconUrl("https://cdn.discordapp.com/attachments/907688885352529921/964221919316566106/23b23c38d0d96d9d23884dfc52bca758.jpg");
            var Fields = new EmbedFieldBuilder()
                    .WithName("Informache Autorze")
                    .WithValue("Autor: Hubert Kozak" + Environment.NewLine + "Kontakt: Klosik#6067");
            var Footer = new EmbedFooterBuilder()
                .WithIconUrl("https://cdn.discordapp.com/attachments/907688885352529921/964223858498482267/milk-and-mocha-bear-couple.gif")
                .WithText("Z miłości do RPG <3");
            var embeda = new EmbedBuilder()
                    .WithTitle("Informacje o bocie")
                    .WithColor(new Color(153, 51, 153))
                    .WithAuthor(Bot)
                    .WithFields(Fields)
                    .WithFooter(Footer);
            await ReplyAsync(embed: embeda.Build());
        }

        [Command("Pomoc")]
        private async Task help()
        {
            var Bot = new EmbedAuthorBuilder()
                    .WithName("Barmanka Tawerny RPG#7032")
                    .WithIconUrl("https://cdn.discordapp.com/attachments/907688885352529921/964221919316566106/23b23c38d0d96d9d23884dfc52bca758.jpg");

            var Fields = new EmbedFieldBuilder()
                    .WithName("Podstawowe Komendy")
                    .WithValue("&Pomoc - wyświetla podstawowe komendy" + Environment.NewLine + "&Kostka [ilośc ścianek] - rzuca kostką o danej ilości ścianek" + Environment.NewLine + "&BotInfo - wyświetla informacje o bocie");

            var Footer = new EmbedFooterBuilder()
                .WithIconUrl("https://cdn.discordapp.com/attachments/907688885352529921/964223858498482267/milk-and-mocha-bear-couple.gif")
                .WithText("Z miłości do RPG <3");

            var embeda = new EmbedBuilder()
                    .WithTitle("Komendy")
                    .WithColor(new Color(153, 51, 153))
                    .WithAuthor(Bot)
                    .WithFields(Fields)
                    .WithFooter(Footer);

            await ReplyAsync(embed: embeda.Build());
        }

        [Command("Kostka")]
        private async Task dice(int k)
        {
            var controler = k + 1;
            var result = rnd.Next(1 ,controler);

            var Bot = new EmbedAuthorBuilder()
                    .WithName("Barmanka Tawerny RPG#7032")
                    .WithIconUrl("https://cdn.discordapp.com/attachments/907688885352529921/964221919316566106/23b23c38d0d96d9d23884dfc52bca758.jpg");

            var Fields = new EmbedFieldBuilder()
                    .WithName("Wynik to:")
                    .WithValue($"{result}/{k.ToString()}");

            var Footer = new EmbedFooterBuilder()
                .WithIconUrl("https://cdn.discordapp.com/attachments/907688885352529921/964223858498482267/milk-and-mocha-bear-couple.gif")
                .WithText("Z miłości do RPG <3");

            var embeda = new EmbedBuilder()
                    .WithTitle($"Rzut gracza {Context.Message.Author} kostką k{k.ToString()}")
                    .WithColor(new Color(153, 51, 153))
                    .WithAuthor(Bot)
                    .WithFields(Fields)
                    .WithFooter(Footer);

            if (k != 2137)
            {
                await ReplyAsync(embed: embeda.Build());
            }
            else
            {
                Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=CGLLglu9jaI");
                Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=ETrhmFC_1TA");
                Context.Channel.SendMessageAsync("https://i.pinimg.com/280x280_RS/2b/ba/8a/2bba8a6b37fe04414e74065d46de9040.jpg");
            }
        }
    }
}