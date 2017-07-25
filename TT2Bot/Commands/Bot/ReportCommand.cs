﻿using Discord;
using System;
using System.Threading.Tasks;
using TitanBot.Commands;
using TitanBot.Util;

namespace TT2Bot.Commands.Bot
{
    [Description("Allows you to make suggestions and feature requests for me!")]
    class ReportCommand : TT2Command
    {
        [Call]
        [Usage("Sends a suggestion to my home guild.")]
        public async Task ReportAsync([Dense]string message)
        {
            var bugChannel = Client.GetChannel(TT2Global.BotBugChannel) as IMessageChannel;

            if (bugChannel == null)
            {
                await ReplyAsync("I could not find where I need to send the bug report! Please try again later.", ReplyType.Error);
                return;
            }

            var builder = new EmbedBuilder
            {
                Author = new EmbedAuthorBuilder
                {
                    Name = $"{Author.Username}#{Author.Discriminator}",
                    IconUrl = Author.GetAvatarUrl()
                },
                Timestamp = DateTime.Now,
                Color = System.Drawing.Color.IndianRed.ToDiscord()
            }
            .AddField("Bug report", message)
            .AddInlineField(Guild?.Name ?? Author.Username, Guild?.Id ?? Author.Id)
            .AddInlineField(Channel.Name, Channel.Id);
            await Replier.Reply(bugChannel)
                         .WithEmbedable(Embedable.FromEmbed(builder))
                         .SendAsync();
            await ReplyAsync("Bug report sent", ReplyType.Success);
        }
    }
}
