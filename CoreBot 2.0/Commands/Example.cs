using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace CoreBot.Commands
{
    public class Example : ModuleBase
    {
        [Command("Example")]
        public async Task ExampleCommand()
        {
            await ReplyAsync("This is an example command");
        }
    }
}
