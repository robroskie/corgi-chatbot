using System;
using Discord.Commands;

namespace corgi_chatbot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Hai");
        }
    }
}

