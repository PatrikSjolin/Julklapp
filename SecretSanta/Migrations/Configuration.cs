namespace SecretSanta.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SecretSanta.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SecretSanta.Models.ApplicationDbContext context)
        {
            context.Database.ExecuteSqlCommand("delete from Members");
            context.Database.ExecuteSqlCommand("delete from Groups");

            context.Groups.Add(new Models.Group
            {
                Id = Guid.NewGuid(),
                Members = new System.Collections.Generic.List<Models.Member>
                {
                    new Models.Member
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Patrik",
                        LastName = "Sjölin",
                        HasGotPresent = false,
                        Receiver = null
                    },
                    new Models.Member
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Josefine",
                        LastName = "Sjölin",
                        HasGotPresent = false,
                        Receiver = null
                    },
                    new Models.Member
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Rut",
                        LastName = "Casselbrant Ludwig",
                        HasGotPresent = false,
                        Receiver = null
                    },
                     new Models.Member
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Peter",
                        LastName = "Ludwig",
                        HasGotPresent = false,
                        Receiver = null
                    },
                    new Models.Member
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Gustav",
                        LastName = "Casselbrant",
                        HasGotPresent = false,
                        Receiver = null
                    },
                    new Models.Member
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Åsa",
                        LastName = "Casselbrant",
                        HasGotPresent = false,
                        Receiver = null
                    },
                    new Models.Member
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Madelene",
                        LastName = "Casselbrant",
                        HasGotPresent = false,
                        Receiver = null
                    },
                    new Models.Member
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Paul",
                        LastName = "Laverty",
                        HasGotPresent = false,
                        Receiver = null
                    },
                },
                Name = "Jul på Skärvallsgatan",
                Budget = 500
            });
            //context.Groups.Add(new Models.Group
            //{
            //    Id = Guid.NewGuid(),
            //    Members = new System.Collections.Generic.List<Models.Member>
            //    {
            //        new Models.Member
            //        {
            //            Id = Guid.NewGuid(),
            //            FirstName = "Bertil",
            //            LastName = "Casselbrant",
            //            HasGotPresent = false,
            //            Receiver = null
            //        },
            //         new Models.Member
            //        {
            //            Id = Guid.NewGuid(),
            //            FirstName = "Ruth",
            //            LastName = "Casselbrant",
            //            HasGotPresent = false,
            //            Receiver = null
            //        },
            //         new Models.Member
            //        {
            //            Id = Guid.NewGuid(),
            //            FirstName = "Michael",
            //            LastName = "Casselbrant",
            //            HasGotPresent = false,
            //            Receiver = null
            //        },
            //           new Models.Member
            //        {
            //            Id = Guid.NewGuid(),
            //            FirstName = "Birgitta",
            //            LastName = "Dumont",
            //            HasGotPresent = false,
            //            Receiver = null
            //        },
            //              new Models.Member
            //        {
            //            Id = Guid.NewGuid(),
            //            FirstName = "Gustav",
            //            LastName = "Casselbrant",
            //            HasGotPresent = false,
            //            Receiver = null
            //        },
            //                 new Models.Member
            //        {
            //            Id = Guid.NewGuid(),
            //            FirstName = "Åsa",
            //            LastName = "Casselbrant",
            //            HasGotPresent = false,
            //            Receiver = null
            //        },
            //                    new Models.Member
            //        {
            //            Id = Guid.NewGuid(),
            //            FirstName = "Madelene",
            //            LastName = "Casselbrant",
            //            HasGotPresent = false,
            //            Receiver = null
            //        },
            //        new Models.Member
            //        {
            //            Id = Guid.NewGuid(),
            //            FirstName = "Josefine",
            //            LastName = "Casselbrant",
            //            HasGotPresent = false,
            //            Receiver = null
            //        },
            //        new Models.Member
            //        {
            //            Id = Guid.NewGuid(),
            //            FirstName = "Patrik",
            //            LastName = "Sjölin",
            //            HasGotPresent = false,
            //            Receiver = null
            //        },
            //    },
            //    Name = "Jul med Michael",
            //    Budget = 300
            //});
            context.SaveChanges();
        }
    }
}
