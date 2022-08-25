// See https://aka.ms/new-console-template for more information

using ConsoleApp3;

new EmailMessage()
    .From("Рома")
    .To("Катя")
    .SetSubject("Новое сообщение")
    .AddBody("Давай")
    .AddBody("Научимся")
    .AddBody("Строить")
    .Send();