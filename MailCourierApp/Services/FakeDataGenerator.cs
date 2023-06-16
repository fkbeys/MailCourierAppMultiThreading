﻿using MailCourierApp.Models;

namespace MailCourierApp.Services
{
    public class FakeDataGenerator
    {
        public static IEnumerable<MailObject> CreateMails(int number)
        {
            number = number <= 1 ? 2 : number;

            Bogus.Faker<MailObject> faker = new Bogus.Faker<MailObject>().
                RuleFor(a => a.to, b => b.Internet.Email()).
                RuleFor(c => c.providerType, d => MailType.Smtp).
                RuleFor(e => e.from, f => "fkbeys@gmail.com");

            return faker.Generate(number);
        }


    }
}
