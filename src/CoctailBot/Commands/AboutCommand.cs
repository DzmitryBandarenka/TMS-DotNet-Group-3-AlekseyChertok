﻿using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using CoctailBot.Interfaces;

namespace CoctailBot.Commands
{
   
        /// <inheritdoc cref="ITelegramCommand"/>
        public class AboutCommand : ITelegramCommand
        {
            /// <inheritdoc/>
            public string Name { get; } = About.Link;

            /// <inheritdoc/>
            public async Task Execute(Message message, ITelegramBotClient client)
            {
                var chatId = message.Chat.Id;
                await client.SendTextMessageAsync(chatId, $"\U0001F389 {About.Message} \U0001F449 {About.ShortLink} \U0001F448");
            }

            /// <inheritdoc/>
            public bool Contains(Message message) => message.Type != MessageType.Text ? false : message.Text.Contains(Name);
        }
    
}
