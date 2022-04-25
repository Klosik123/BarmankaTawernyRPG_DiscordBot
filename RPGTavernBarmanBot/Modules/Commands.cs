using System;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Xml.Linq;
using RPGTavernBarman.Data;
using System.Reflection;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace RPGTavernBarman.Modules
{
    public partial class Commands : ModuleBase<SocketCommandContext>
    {
        /*private ApplicationDbContext _dataBase;
        public Commands(ApplicationDbContext dataBase)
        {
            _dataBase = dataBase;
        }
        */
        [Command("BotInfo")]
        private async Task botInfo()
        {
            var Bot = new EmbedAuthorBuilder()
                    .WithName("Barmanka Tawerny RPG#7032")
                    .WithIconUrl("https://cdn.discordapp.com/attachments/907688885352529921/964221919316566106/23b23c38d0d96d9d23884dfc52bca758.jpg");
            var Fields = new EmbedFieldBuilder()
                    .WithName("Informacje Autorze")
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
            
            var MGHelp = new EmbedFieldBuilder()
                    .WithName("Komendy dla Mistrzów gry")
                    .WithValue("&stwórzGre [nazwa] [system] - dodaje nową rozgrywke" + Environment.NewLine + "&dodaj [gracz] - dodaje gracza do rozgrywki" + Environment.NewLine + "&Lista [nazwa rozgrywki] - wyświetla graczy");
            
            var Footer = new EmbedFooterBuilder()
                .WithIconUrl("https://cdn.discordapp.com/attachments/907688885352529921/964223858498482267/milk-and-mocha-bear-couple.gif")
                .WithText("Z miłości do RPG <3");

            var embeda = new EmbedBuilder()
                    .WithTitle("Komendy")
                    .WithColor(new Color(153, 51, 153))
                    .WithAuthor(Bot)
                    .WithFields(Fields)
                    //.WithFields(MGHelp)
                    .WithFooter(Footer);

            await ReplyAsync(embed: embeda.Build());
        }
        
    }
}