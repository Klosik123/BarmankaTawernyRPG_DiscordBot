using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTavernBarmanBot.Modules
{
    public partial class Commands : ModuleBase<SocketCommandContext>
    {
        Random rnd = new Random();
        [Command("Kostka")]
        private async Task dice(int k)
        {
            await Context.Client.SetGameAsync("DnD", "https://cthulhucorp.eu", ActivityType.Playing);

            var controler = k + 1;
            var result = rnd.Next(1, controler);

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
                Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=SSUOTz3oWEQ");
                Context.Channel.SendMessageAsync("https://www.youtube.com/watch?v=ETrhmFC_1TA");
                Context.Channel.SendMessageAsync("https://i.pinimg.com/280x280_RS/2b/ba/8a/2bba8a6b37fe04414e74065d46de9040.jpg");
            }
        }
    }
}
