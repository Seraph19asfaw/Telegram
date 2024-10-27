using Telegram.Bot;

var bot = new TelegramBotClient("7728880427:AAFOnNdOpFw9imBxkwtVnZKET-cbcjJVYIM");
var me = await bot.GetMeAsync();
Console.WriteLine($"Hello, World! I am user {me.Id} and my name is {me.FirstName}.");
