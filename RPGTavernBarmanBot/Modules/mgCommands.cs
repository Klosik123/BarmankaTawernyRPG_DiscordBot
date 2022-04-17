using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGTavernBarmanBot.Models;
using RPGTavernBarmanBot.Data;
using Discord;
using System.Xml.Linq;

namespace RPGTavernBarmanBot.Modules
{
    public partial class Commands : ModuleBase<SocketCommandContext>
    {
        private ApplicationDbContext _dataBase;
        [Command("stwórzGre")]
        private async Task gameCreate(string name, string system)
        {
            var Game = new Models.Game()
            {
                Guid = new Guid(),
                Name = name,
                System = system,
                GameColor = "153, 51, 153",
                GameMaster = Context.Message.Author.Mention,
                ServerDiscordId = Context.Guild.Id.ToString()
            };
            _dataBase.Add<Models.Game>(Game);
            await _dataBase.SaveChangesAsync();

            var Bot = new EmbedAuthorBuilder()
                .WithName("Barmanka Tawerny RPG#7032")
                .WithIconUrl("https://cdn.discordapp.com/attachments/907688885352529921/964221919316566106/23b23c38d0d96d9d23884dfc52bca758.jpg");
            var embed = new EmbedBuilder()
                .WithTitle("Nowa rozgrywka założona!")
                .WithDescription($"Rozgrywka {name} w systemie {system} została prawidłowo dodana!")
                .WithColor(153, 51, 153)
                .WithAuthor(Bot);
            await ReplyAsync(embed: embed.Build());
        }

        [Command("Lista")]
        private async Task List()
        {
            var gamesGroup = _dataBase.Game.AsEnumerable();
            var Bot = new EmbedAuthorBuilder()
                .WithName("Barmanka Tawerny RPG#7032")
                .WithIconUrl("https://cdn.discordapp.com/attachments/907688885352529921/964221919316566106/23b23c38d0d96d9d23884dfc52bca758.jpg");
            var embed = new EmbedBuilder()
             .WithTitle("Lista aktualnych gier!")
             .WithColor(153, 51, 153)
             .WithAuthor(Bot);
            foreach (var game in gamesGroup)
            {
                var Field = new EmbedFieldBuilder()
                    .WithName("Nazwa" + game.Name)
                    .WithValue("Mistrz gry:" + game.GameMaster)
                    .WithValue("System:" + game.System)
                    .WithValue("Z " + game.Players.Count + " graczami");
                embed.AddField(Field);
            }
            await ReplyAsync(embed: embed.Build());
        }
    }
}
