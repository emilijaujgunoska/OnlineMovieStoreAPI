

namespace OnlineMovieStore.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.IdentityModel.Tokens;
    using OnlineMovieStore.Entities;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Metrics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DataSeed
    {
        #region Seed Method
        public static void Seed(ModelBuilder builder, string username, byte[] passwordHash, byte[] passwordSalt)
        {

            Guid userId = Guid.NewGuid();

            #region User Admin Seed
            builder.Entity<User>().HasData(new User
            {
                Id = userId,
                Username = username,
                Email = "team.three@smx.com.mk",
                City = "Skopje",
                Country = "Macedonia",
                Address = "/",
                UserCreated = DateTime.Now,
                Description = " Admin User ",
                Phone = "+389 78/438313",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                IsAdmin = true,


            });

            #endregion

            #region Category Seed Data

            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Animation"

                },
                new Category
                {
                    Id = 2,
                    Name = "Fiction"
                },
                new Category
                {
                    Id = 3,
                    Name = "Action"
                },
                new Category

                {
                    Id = 4,
                    Name = "Crime"
                },
                new Category
                {
                    Id = 5,
                    Name = "Adventure"
                },
                new Category
                {
                    Id = 6,
                    Name = "SciFi"
                },
                new Category
                {
                    Id = 7,
                    Name = "Drama"
                },
                new Category
                {
                    Id = 8,
                    Name = "Horror"
                },
                new Category
                {
                    Id = 9,
                    Name = "Thrillers"
                },
                new Category
                {
                    Id = 10,
                    Name = "Comedy"
                });

            #endregion
            #region Actor Seed Data
            builder.Entity<Actor>().HasData(
                new Actor
                {
                    Id =1 ,
                    Name = "Johnny Depp",
                    Biography = "Johnny Depp is an American actor and musician who was born " +
                    "on June 9, 1963 in Owensboro, Kentucky123. He is known for his eclectic " +
                    "and unconventional film choices, such as Edward Scissorhands, Sweeney Todd," +
                    " and Pirates of the Caribbean24. He has won a Golden Globe Award and a " +
                    "Screen Actors Guild Award, and has been nominated for three " +
                    "Academy Awards and two BAFTA awards3",
                    Country = "USA",
                    MovieAwards = "Johnny Depp has received numerous award nominations and has " +
                    "won several awards for his acting work. Some of his notable awards " +
                    "include the Screen Actors Guild Award for Outstanding Performance by a " +
                    "Male Actor in a Leading Role for \"Pirates of the Caribbean: The Curse of " +
                    "the Black Pearl\" (2004), the Golden Globe Award for Best Actor in a " +
                    "Motion Picture - Musical or Comedy for \"Sweeney Todd: The Demon Barber of " +
                    "Fleet Street\" (2007), and the People's Choice Award for Favorite Movie Icon (2017)." +
                    " He has also won MTV Movie Awards, Kids' Choice Awards, and other awards. " +
                    "Depp has been nominated three times for the Academy Award for Best Actor",
                    IsLeadActor = true,
                    IsPopular = true,
                },
                new Actor { 
                Id = 2,
                    Name = "Helena Bonham Carter",
                    Biography = "Helena Bonham Carter is a British actress born on " +
                    "May 26, 1966 in London, England. She is known for her versatile " +
                    "and successful roles in various genres, especially period pieces " +
                    "and fantasy films. She is the great-granddaughter of former " +
                    "British Prime Minister H.H. Asquith.\r\n\r\nSome of her notable " +
                    "films include A Room with a View (1985), The Wings of the Dove (1997), " +
                    "Fight Club (1999), Harry Potter series (2007-2011), " +
                    "The King’s Speech (2010), and The Crown (2019-2020).",
                    Country = "UK",
                    MovieAwards = "Academy Awards: She has been nominated for two Academy Awards," +
                    " including Best Actress in a Leading Role for her performance in " +
                    "“The Wings of the Dove” in 1998 and Best Performance by an Actress in " +
                    "a Supporting Role for her performance in “The King’s Speech” in 2011." +
                    "\r\nBAFTA Awards: She won the BAFTA Film Award for Best Supporting Actress " +
                    "for her performance in “The King’s Speech” in 2011. She has also received " +
                    "several other nominations, including Best Actress in a Leading Role for " +
                    "“The Wings of the Dove” in 1997 and Best Actress in a Supporting Role for " +
                    "“Howards End” in 1992.\r\nGolden Globe Awards: She has been nominated " +
                    "for nine Golden Globe Awards, including Best Actress in a " +
                    "Motion Picture – Drama for “The Wings of the Dove” in 1997 and Best Supporting " +
                    "Actress – Motion Picture for “The King’s Speech” in 2010.\r\nPrimetime" +
                    " Emmy Awards: She has been nominated for five Primetime Emmy Awards, " +
                    "including Outstanding Supporting Actress in a Drama Series for her role as " +
                    "Princess Margaret in “The Crown” in 2020 and 2021, and Outstanding " +
                    "Lead Actress in a Miniseries or a Movie for her role as Elizabeth" +
                    " Taylor in “Burton and Taylor” in 2014.\r\nScreen Actors Guild Awards: " +
                    "She has won two Screen Actors Guild Awards, both for Outstanding " +
                    "Performance by an Ensemble in a Drama Series for her role as " +
                    "Princess Margaret in “The Crown” in 2020 and 2021.",
                    IsLeadActor = true,
                    IsPopular = true,
                    },
                new Actor
                {
                    Id = 3,
                    Name = "Emily Watson",
                    Biography = "Emily Watson was born and raised in London, the " +
                    "daughter of Katharine (Venables), an English teacher, and Richard Watson, " +
                    "an architect. After a self-described sheltered upbringing, " +
                    "Watson attended university for three years in Bristol, studying " +
                    "English literature. She applied to drama school and was " +
                    "rejected on her first attempt.\r\n\r\nAfter three years of" +
                    " working in clerical and waitress jobs she was finally accepted." +
                    " In 1992, she took a position with the Royal Shakespeare " +
                    "Company where she met her future husband, Jack Waters. " +
                    "Continuing stage work, Watson landed her first screen" +
                    " role as Bess McNeill in Breaking the Waves (1996) after Helena " +
                    "Bonham Carter pulled out of the role. For this initial foray into movies," +
                    " Watson was nominated for an Academy Award. She continued to gain " +
                    "success in Britain in the leading roles in Metroland (1997) and The" +
                    " Mill on the Floss (1997), but her first popular film in the" +
                    " United States came in 1997 when she played Daniel Day-Lewis's " +
                    "long-suffering love interest in The Boxer (1997).\r\n\r\nIn the" +
                    " next two years she won critical acclaim for her portrayal of " +
                    "cellist Jacqueline du Pré in Hilary and Jackie (1998) and " +
                    "landed a small part in the ensemble cast of Tim Robbins's Cradle " +
                    "Will Rock (1999). Critical acclaim and North American success" +
                    " came together for Watson in 1999 with the release of Angela's" +
                    " Ashes (1999), the film adaptation of Frank McCourt's bestselling " +
                    "book of the same name. She achieved top billing as Angela McCourt," +
                    " the hardworking mother of several children and wife of a " +
                    "drunken husband in depression-era Ireland. After less-celebrated " +
                    "roles in 2000's Trixie (2000) and The Luzhin Defence (2000), " +
                    "Watson again returned to an ensemble cast in Robert Altman's " +
                    "Gosford Park (2001).\r\n\r\nWatson's status as a leading" +
                    " actress in major Hollywood productions was cemented in " +
                    "2002 with her roles in Red Dragon (2002), the third installment" +
                    " of Thomas Harris' Hannibal Lechter series; the futuristic" +
                    " Equilibrium (2002); and, most notably, in Paul Thomas Anderson's " +
                    "Punch-Drunk Love (2002), playing opposite Adam Sandler. " +
                    "While returning to the stage in 2002 and 2003 on both sides of the " +
                    "Atlantic, Watson has expressed interest in again working " +
                    "with Anderson. Emily Watson lives in London, England, UK, with her husband, Jack Waters.",
                    Country = "UK",
                    MovieAwards = "Academy Awards: She has been nominated for two Academy Awards, " +
                    "including Best Actress in a Leading Role for her performance in “Breaking the Waves”" +
                    " in 1997 and “Hilary and Jackie” in 1999.\r\nBAFTA Awards: She won the BAFTA TV Award " +
                    "for Best Leading Actress for her performance in “Appropriate Adult” in 2012. She has" +
                    " also received several other nominations, including Best Performance by an Actress in a " +
                    "Leading Role for “Breaking the Waves” in 1997, “Hilary and Jackie” in 1999, and “Angela’s " +
                    "Ashes” in 2000.\r\nGolden Globe Awards: She has been nominated for five Golden Globe Awards," +
                    " including Best Performance by an Actress in a Motion Picture – Drama for “Breaking the Waves”" +
                    " in 1997 and “Hilary and Jackie” in 1999, Best Performance by an Actress in a Miniseries or " +
                    "Motion Picture Made for Television for “Appropriate Adult” in 2012, and Best Performance by " +
                    "an Actress in a Supporting Role in a Series, Limited Series or Motion Picture Made for " +
                    "Television for “Chernobyl” in 2020.\r\nPrimetime Emmy Awards: She has been nominated for a " +
                    "Primetime Emmy Award for Outstanding Supporting Actress in a Limited Series or Movie for" +
                    " her role as Ulana Khomyuk in “Chernobyl” in 2019.\r\nScreen Actors Guild Awards: She has " +
                    "been nominated for two Screen Actors Guild Awards, including Outstanding Performance by " +
                    "a Female Actor in a Television Movie or Limited Series for her role as Ulana Khomyuk in" +
                    " “Chernobyl” in 2020 and Outstanding Performance by a Cast in a Motion Picture for " +
                    "her role as Beryl Wilde in “The Theory of Everything” in 2015.",
                    IsLeadActor = true,
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 4,
                    Name = "",
                    Biography = "",
                    Country = "",
                    MovieAwards = "",
                    IsLeadActor = true,
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 5,
                    Name = "",
                    Biography = "",
                    Country = "",
                    MovieAwards = "",
                    IsLeadActor = true,
                    IsPopular = true,
                },
                new Actor
                {
                    Id =6 ,
                    Name = "",
                    Biography = "",
                    Country = "",
                    MovieAwards = "",
                    IsLeadActor = true,
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 7,
                    Name = "",
                    Biography = "",
                    Country = "",
                    MovieAwards = "",
                    IsLeadActor = true,
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 8,
                    Name = "",
                    Biography = "",
                    Country = "",
                    MovieAwards = "",
                    IsLeadActor = true,
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 9,
                    Name = "",
                    Biography = "",
                    Country = "",
                    MovieAwards = "",
                    IsLeadActor = true,
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 10,
                    Name = "",
                    Biography = "",
                    Country = "",
                    MovieAwards = "",
                    IsLeadActor = true,
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 11,
                    Name = "",
                    Biography = "",
                    Country = "",
                    MovieAwards = "",
                    IsLeadActor = true,
                    IsPopular = true,
                }

                );

            #endregion
        }

        #endregion
    }
}
