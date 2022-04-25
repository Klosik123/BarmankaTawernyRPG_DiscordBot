using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGTavernBarman.Models;
using RPGTavernBarman.Data;
using Discord;
using System.Xml.Linq;

namespace RPGTavernBarman.Modules
{
    public partial class Commands : ModuleBase<SocketCommandContext>
    {
        /*
         To się zrobi kiedyś jak mi się będzie chaiło no cóż tak
        [Command("stwórzGre")]
        private async Task gameCreate(string name, string system)
        {
            var game = new Games()
            {
                Name = name,
                System = system,
                GameColor = "153, 51, 153",
                GameMaster = Context.Message.Author.Mention,
                ServerDiscordId = Context.Guild.Id.ToString()
            };
            _dataBase.Add<Games>(game);
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
  */
    }
}
