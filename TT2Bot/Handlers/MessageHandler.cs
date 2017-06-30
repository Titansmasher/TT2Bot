﻿using Discord.WebSocket;
using System.Threading.Tasks;
using TitanBot.Commands;
using TitanBot.DiscordHandlers;
using TitanBot.Logging;

namespace TT2Bot.Handlers
{
    class MessageHandler : DiscordHandlerBase
    {
        private readonly ICommandService CommandService;

        public MessageHandler(DiscordSocketClient client, ILogger logger, ICommandService commandService) : base(client, logger)
        {
            CommandService = commandService;

            Client.MessageReceived += MessageRecieved;
        }

        private async Task MessageRecieved(SocketMessage msg)
        {
            await Logger.LogAsync(LogSeverity.Verbose, LogType.Message, msg.ToString(), "MessageHandler");
            if (msg is SocketUserMessage message && message.Content.Contains("👋"))
                try
                {
                    await message.AddReactionAsync(new Discord.Emoji("👋"));
                }
                catch { }
        }
    }
}
