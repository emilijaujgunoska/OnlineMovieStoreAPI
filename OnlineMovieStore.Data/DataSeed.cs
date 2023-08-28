

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
                },
                 new Category
                 {
                     Id = 11,
                     Name = "Documentary"
                 }
                );

            #endregion

            #region Actor Seed Data
            builder.Entity<Actor>().HasData(
                new Actor
                {
                    Id = 1,
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
                    Name = "Mia Wasikowska",
                    Biography = "Mia is an Australian actress, born and raised in the country's capital," +
                    " Canberra. She is the daughter of photographers Marzena Wasikowska and John Reid. Her " +
                    "mother is Polish and her father is an Australian of British ancestry. She has an older " +
                    "sister, Jess, and a younger brother, Kai. At age eight, her family moved to Poland for " +
                    "a year.\r\n\r\nAt age nine, Mia took ballet classes with dreams of becoming a " +
                    "professional ballerina. However, an injury prevented this from happening and she quit" +
                    " at age fourteen. Mia turned to acting, having been excited by European and Australian" +
                    " cinema. She was attending Canberra High School, but left to pursue her career as an" +
                    " actor.\r\n\r\nShe had just turned 15 when she landed the role of Lilya in Suburban " +
                    "Mayhem (2006). Her breakthrough role came when she was cast as Alice in Tim Burton's " +
                    "Alice in Wonderland (2010).",
                    Country = "Australia",
                    MovieAwards = " Some of her notable awards include the Hollywood Breakthrough Award " +
                    "of Actress of the Year in 2010 for The Kids Are All Right and Alice in Wonderland, " +
                    "the Australian Film Institute International Award for Best Actress in 2010 for Alice in Wonderland, " +
                    "and the Teen Choice Award for Choice Movie: Rumble in 2010 for Alice in Wonderland",
                    IsLeadActor = true,
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 5,
                    Name = "Freddie Highmore",
                    Biography = "ore is an English actor who came to prominence for his roles in Five Children and " +
                    "It (2004), Finding Neverland (2004), and Charlie and the Chocolate Factory (2005).\r\n\r\nHe " +
                    "was born Alfred Thomas Highmore in Camden Town, London, England, to Sue (Latimer), a talent" +
                    " agent, and Edward Thomas Highmore, an actor. Highmore has a younger brother, Albert \"Bertie\" " +
                    "Highmore. He attended Highgate School, and later earned a double-first degree in Spanish and " +
                    "Arabic from Cambridge University's Emmanuel College.\r\n\r\nIn 1999, Highmore made his big " +
                    "screen debut in the comedy Women Talking Dirty (1999), portraying Helena Bonham Carter's son." +
                    " His next prominent role was in the family drama Two Brothers (2004). Highmore's breakout" +
                    " role came when he was cast in Finding Neverland (2004), alongside Johnny Depp and Kate Winslet. " +
                    "He was then cast in the title role of Charlie Bucket in Tim Burton's Charlie and the " +
                    "Chocolate Factory (2005), and was reportedly recommended by co-star Johnny Depp. Roles in A" +
                    " Good Year (2006) and Arthur and the Invisibles (2006) soon followed, before he portrayed " +
                    "the title role in August Rush (2007), opposite Keri Russell and Robin Williams.\r\n\r\nIn 2013, " +
                    "he began starring as the iconic Norman Bates in the drama thriller series Bates Motel (2013), " +
                    "alongside Vera Farmiga as his mother. Highmore received much acclaim for his performance " +
                    "throughout the series' run, and was nominated for multiple Saturn Awards and Critics' Choice " +
                    "Television Awards.\r\n\r\n2017- Stars in The Good Doctor as Shaun Murphy -a young autistic " +
                    "surgeon who has savant syndrome, relocates from a quiet country life to join the surgical unit" +
                    " at the prestigious San Jose St. Bonaventure Hospital. Shaun is alone in the world and" +
                    " unable to personally connect with those around him, but he finds his niche using his " +
                    "extraordinary medical skill and intuition to save lives and challenge the skepticism of his colleagues.",
                    Country = "UK",
                    MovieAwards = "This is a list of awards and nominations received by English actor Freddie " +
                    "Highmore. For Finding Neverland (2004) and Charlie and the Chocolate Factory (2005)," +
                    " he won the Critics' Choice Movie Award for Best Young Performer in two consecutive years." +
                    " For five seasons, Highmore starred as Norman Bates in the A&E drama-thriller series" +
                    " Bates Motel (2013–2017), for which he was thrice nominated for the Critics' Choice " +
                    "Television Award for Best Actor in a Drama Series. He made his screenwriting debut with " +
                    "the series, and in 2017 won a People's Choice Award for his performance. Also in 2017," +
                    " he began starring as Dr. Shaun Murphy in the ABC drama series The Good Doctor, on " +
                    "which he also serves as a producer. For the role, he received his first Golden Globe Award nomination.",
                    IsLeadActor = true,
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 6,
                    Name = "David Kelly",
                    Biography = "Born Dublin, Ireland on July 11 1929. Educated at Synge Street Catholic boys " +
                    "school. Started acting aged 8 in the Gaiety Theatre in Dublin. Playing everything from" +
                    " Beckett to Shakespeare, he has appeared in theatre, TV and film constantly since 1959. " +
                    "Awards include: Helen Hayes Award, Outstanding Supporting Performer, Non-Resident Production " +
                    "(1991) for \"The Playboy of the Western World\"; nominated for SAG Award, Outstanding " +
                    "Performance by a Male Actor in a Supporting Role (1999) for Waking Ned Devine (1998); " +
                    "ESB Lifetime Achievement award for work in the Irish theatre. He lived in Dublin, Ireland, " +
                    "where he died on 12 February 2012 at the age of 82. Children: Son, David. Daughter, Miriam.",
                    Country = "Ireland",
                    MovieAwards = "Kelly won a 1991 Helen Hayes Award for Outstanding Supporting Performer," +
                    " Non-Resident Production, for a Kennedy Center revival of The Playboy of the Western World. " +
                    "As well, he earned a Screen Actors Guild Award nomination for the 1998 film Waking Ned." +
                    "\r\n\r\nIn 2005, Kelly won the Irish Film & Television Academy's Lifetime Achievement Award," +
                    " in addition to earning a nomination for Best Supporting Actor for the film Charlie and the" +
                    " Chocolate Factory",
                    IsLeadActor = false,
                    IsPopular = true,
                },
               new Actor
               {
                   Id = 7,
                   Name = "Lily James",
                   Biography = "born on April 5, 1989, in Esher, Surrey, United Kingdom." +
                    " is an accomplished British actress known for her versatile roles and+" +
                    " captivating performances. From period dramas to contemporary comedies,+" +
                    " she has showcased her+" +
                    " exceptional talent and garnered a substantial fanbase across the globe.+" +
                    "\r\n\r\nJames attended the Guildhall School of Music and Drama,+" +
                    " where she honed her acting +" +
                    "skills and laid the foundation for her future success.+" +
                    " Her breakthrough came in 2012 when she was cast as Lady Rose MacClare +" +
                    "in the widely acclaimed television series \"Downton Abbey.\" Her portrayal +" +
                    "of the free-spirited and rebellious character" +
                    " earned her widespread recognition and set the stage for her burgeoning +" +
                    "career.\r\n\r\nIn 2015, Lily James reached new heights of fame with her +" +
                    "lead role as Cinderella in Disney's live-action  " +
                    "adaptation of the classic fairy tale. Her enchanting performance and undeniable+" +
                    " charm added a modern touch to the beloved character, solidifying her status as +" +
                    "a rising star in Hollywood.\r\n\r\nContinuing to impress audiences with her versatility, +" +
                    "James effortlessly transitioned between genres.",
                   Country = "UK",
                   MovieAwards = " Cinderella (2015):\r\n\r\n+" +
                    "Teen Choice Awards: Choice Movie Actress - Sci-Fi/Fantasy (Nominated)\r\nPride and Prejudice and Zombies (2016):\r\n\r\n+" +
                    "Teen Choice Awards: Choice Movie Actress - Comedy (Nominated)",
                   IsLeadActor = true,
                   IsPopular = true,
               },
new Actor
{
    Id = 8,
    Name = "Cate Blanchett",
    Biography = "Cate Blanchett, born on May 14, 1969, in Melbourne, Australia, is a remarkable actress known+" +
                    " for her extraordinary range and captivating on-screen presence. With an illustrious career spanning film,+" +
                    " theater, and international acclaim, she has solidified herself as one of the most talented and versatile+" +
                    " performers of her generation.\r\n\r\nBlanchett's journey in acting began in Australia, where she gained+" +
                    " recognition for her work in theater. Her breakthrough came in 1998 with the film \"Elizabeth,\" in which +" +
                    "she portrayed the iconic Queen Elizabeth I. This role not only garnered her critical acclaim but also+" +
                    " earned her the first of her multiple Academy Award nominations.\r\n\r\nHer chameleon-like ability to+" +
                    " inhabit diverse characters across various genres became a hallmark of her career. She effortlessly+" +
                    " transitioned from period dramas like \"The Aviator\" (2004) and \"Carol\" (2015) to fantasy epics +" +
                    "like \"The Lord of the Rings\" trilogy (2001-2003), where she portrayed the ethereal Galadriel.\r\n\r\n+" +
                    "Blanchett's dedication to her craft was evident in her portrayal of complex characters. +" +
                    "Her role in \"Blue Jasmine\" (2013) earned her the Academy Award for Best Actress,+" +
                    " showcasing her prowess in delving into intricate and emotionally charged roles.\r\n\r\nBeyond her+" +
                    " numerous accolades, Cate Blanchett's influence extended beyond the silver screen. She became known+" +
                    " for her advocacy for gender equality in the entertainment industry and her commitment to raising +" +
                    "awareness about important social and environmental issues.\r\n\r\nHer elegance and grace extended to +" +
                    "the world of fashion, where she became a red carpet icon renowned for her impeccable style choices. In +" +
                    "addition to her acting prowess, Blanchett's work as a cultural ambassador further solidified her as a+" +
                    " respected figure on the global stage.\r\n\r\nCate Blanchett's dedication to her craft, her ability +" +
                    "to seamlessly embody diverse characters, and her unwavering commitment to meaningful causes have made+" +
                    " her a timeless force in the world of acting. Her legacy continues to inspire both aspiring artists +" +
                    "and audiences around the world.",
    Country = "Australia",
    MovieAwards = "Academy Awards (Oscars):\r\n\r\n+" +
                    "Best Supporting Actress for \"The Aviator\" (2004)\r\n+" +
                    "Best Actress for \"Blue Jasmine\" (2013)\r\n+" +
                    "Golden Globe Awards:\r\n\r\n+" +
                    "Best Supporting Actress for \"The Aviator\" (2004)\r\n+" +
                    "Best Actress in a Motion Picture – Drama for \"Blue Jasmine\" (2013)\r\n+" +
                    "BAFTA Awards:\r\n\r\nBest Actress in a Leading Role for \"Blue Jasmine\" (2014)\r\n+" +
                    "Screen Actors Guild Awards (SAG Awards):\r\n\r\n+" +
                    "Outstanding Supporting Actress for \"The Aviator\" (2005)\r\n+" +
                    "Outstanding Actress in a Leading Role for \"Blue Jasmine\" (2014)",
    IsLeadActor = true,
    IsPopular = true,
},
new Actor
{
    Id = 9,
    Name = "Keira Christina Knightley",
    Biography = "Born on March 26, 1985, in London, England, Keira Christina Knightley is a British+" +
                    " actress renowned for her captivating performances and charismatic presence on both the big screen+" +
                    " and stage. From period dramas to contemporary tales, Knightley has showcased her versatile acting abilities, +" +
                    "earning her a prominent place in the world of entertainment.\r\n\r\nKnightley's journey in acting began at+" +
                    "a young age, and her breakthrough role came with \"Bend It Like Beckham\" (2002), a film that marked her+" +
                    " emergence as a rising star. However, it was her portrayal of Elizabeth Swann in the \"Pirates of the Caribbean\"+" +
                    " series (2003-2007) that catapulted her to international fame.\r\n\r\nHer magnetic performances in period pieces+" +
                    " like \"Pride & Prejudice\" (2005) and \"Atonement\" (2007) demonstrated her ability to bring depth and authenticity +" +
                    "to characters from various eras. These roles not only garnered critical acclaim but also earned her prestigious+" +
                    " award nominations, including an Academy Award nomination for \"Pride & Prejudice.\"\r\n\r\nKnightley's cinematic+" +
                    " choices reflected her desire to challenge herself with diverse roles. From her portrayal+" +
                    " of Joan Clarke in \"The Imitation Game\" (2014) to the enigmatic title character in \"Anna Karenina\" (2012), +" +
                    "she consistently breathed life into complex characters.\r\n\r\nHer stage presence was equally captivating, with +" +
                    "Knightley taking on roles in theatrical productions such as \"The Misanthrope\" (2009) and \"Thérèse Raquin\" (2015).+" +
                    " Her ability to seamlessly transition between stage and screen highlighted her versatility as an actress.\r\n\r\n+" +
                    "Off-screen, Knightley's commitment to promoting body positivity and gender equality showcased her influence beyond +" +
                    "the entertainment industry. She became an advocate for women's rights and used+" +
                    " her platform to speak out on important+ societal issues.\r\n\r\nWith a career+" +
                    " marked by dynamic performances and a strong voice for change,+" +
                    " Keira Knightley's legacy continues to shine brightly in the world of film and+" +
                    " advocacy. Her unique talent and dedication have left an indelible mark on both+" +
                    " the artistic landscape and the broader cultural conversation.",
    Country = "England",
    MovieAwards = "\"Pride & Prejudice\" (2005):\r\n\r\n+" +
                    "Academy Awards (Oscars): Nominated for Best Actress in a +" +
                    "Leading Role\r\nBAFTA Awards: Nominated for Best Actress+" +
                    " in a Leading Role\r\n\"Atonement\" (2007):\r\n\r\n+" +
                    "Academy Awards (Oscars): Nominated for Best Actress in a +" +
                    "Leading Role\r\nBAFTA Awards: Nominated for Best Actress in+" +
                    " a Leading Role\r\n\"The Imitation Game\" (2014):\r\n\r\n+" +
                    "Academy Awards (Oscars): Nominated for Best Supporting +" +
                    "Actress\r\nBAFTA Awards: Nominated for Best Supporting +" +
                    "Actress",
    IsLeadActor = true,
    IsPopular = true,
},
new Actor
{
    Id = 10,
    Name = "Jude Law",
    Biography = "Jude Law, born on December 29, 1972, in London, England, is a versatile+" +
                    " British actor known for his charismatic performances that span across film, +" +
                    "theater, and television. With a commanding presence and the ability to delve+" +
                    " into diverse roles, Law has solidified himself as a prominent figure in the+" +
                    " entertainment industry.\r\n\r\nLaw's journey in acting began in his youth,+" +
                    " and he gained recognition with his breakthrough role in the film \"The Talented +" +
                    "Mr. Ripley\" (1999), where his portrayal of the charming but mysterious+" +
                    " Dickie Greenleaf showcased his immense talent. He continued to impress+" +
                    " audiences with his roles in movies like \"Cold Mountain\" (2003), +" +
                    "\"Closer\" (2004), and \"Sherlock Holmes\" (2009).\r\n\r\nHis +" +
                    "captivating stage presence was equally notable, with performances in+" +
                    " productions such as \"Hamlet\" (2009), where he took on the iconic +" +
                    "titular role and garnered acclaim for his portrayal of the complex +" +
                    "character.\r\n\r\nLaw's chameleon-like ability to seamlessly transition+" +
                    " between different genres and characters made him a sought-after talent in+" +
                    " Hollywood. From dramatic roles to comedic ones, he showcased his+" +
                    " versatility in films like \"The Grand Budapest Hotel\" (2014) and +" +
                    "\"The Holiday\" (2006).\r\n\r\nThroughout his career, Law's dedication +" +
                    "to his craft was evident, and his performances consistently resonated+" +
                    " with audiences and critics alike. His willingness to take on challenging +" +
                    "and multifaceted characters showcased his commitment to pushing his artistic+" +
                    " boundaries.\r\n\r\nOff-screen, Law's charm and charisma extended to his personal +" +
                    "life, making him a well-regarded figure both in the entertainment industry and in+" +
                    " public perception.\r\n\r\nWith an impressive filmography and a reputation for+" +
                    " delivering compelling performances, Jude Law continues to captivate audiences+" +
                    " with his talent and versatility. His impact on both the big screen and stage +" +
                    "remains a testament to his enduring influence as an actor.",
    Country = "England",
    MovieAwards = "\"The Talented Mr. Ripley\" (1999):\r\n\r\n+" +
                    "BAFTA Awards: Nominated for Best Actor in a Leading +" +
                    "Role\r\n\"Cold Mountain\" (2003):\r\n\r\nAcademy Awards +" +
                    "(Oscars): Nominated for Best Actor in a +" +
                    "Leading Role\r\n\"The Holiday\" (2006):\r\n\r\n+" +
                    "Empire Awards: Nominated for Best Actor\r\n\"+" +
                    "Sherlock Holmes\" (2009):\r\n\r\nEmpire Awards: +" +
                    "Nominated for Best Actor",
    IsLeadActor = true,
    IsPopular = true,
},
new Actor
{
    Id = 11,
    Name = "Emily Watson",
    Biography = "Emily Watson, born on January 14, 1967, in London, +" +
                    "England, is a highly regarded British actress known for her+" +
                    " remarkable ability to convey complex emotions and bring +" +
                    "authenticity to her roles. Her captivating performances have +" +
                    "earned her acclaim in both film and television, showcasing her +" +
                    "remarkable range and dedication to her craft.\r\n\r\nWatson +" +
                    "first gained international recognition with her debut film role +" +
                    "in \"Breaking the Waves\" (1996), directed by Lars von Trier.+" +
                    " Her portrayal of a devout woman who undergoes emotional and+" +
                    " physical trials earned her an Academy Award nomination for Best+" +
                    " Actress in a Leading Role, establishing her as a force to be+" +
                    " reckoned with in the industry.\r\n\r\nThroughout her career, +" +
                    "Watson continued to take on challenging and diverse roles.+" +
                    " She embraced period dramas, such as \"Hilary and Jackie\"+" +
                    " (1998), where she played a renowned cellist, and \"Gosford+" +
                    " Park\" (2001), showcasing her ability to inhabit characters+" +
                    " from different eras.\r\n\r\nHer dedication to her craft led+" +
                    " to standout performances in films like \"Punch-Drunk Love\"+" +
                    " (2002), \"The Theory of Everything\" (2014), and \"Chernobyl\" +" +
                    "(2019), a television miniseries in which she portrayed a scientist+" +
                    " grappling with the aftermath of the nuclear disaster.\r\n\r\n+" +
                    "Watson's ability to portray complex emotions with depth and nuance+" +
                    " made her a sought-after talent, and her performances resonated with+" +
                    " both audiences and critics. Off-screen, her humility and commitment+" +
                    " to her art further endeared her to fans and peers alike.\r\n\r\nHer+" +
                    " enduring impact on the world of acting, as well as her talent for+" +
                    " infusing characters with authenticity and relatability, cement+" +
                    " Emily Watson's status as a respected and accomplished actress.+" +
                    " Her contributions to film and television continue to captivate and+" +
                    " inspire audiences around the world.",
    Country = "England",
    MovieAwards = "\"Breaking the Waves\" (1996):\r\n\r\nAcademy Awards +" +
                    "(Oscars): Nominated for Best Actress in a Leading Role\r\n\"Hilary+" +
                    " and Jackie\" (1998):\r\n\r\nAcademy Awards (Oscars): Nominated for +" +
                    "Best Actress in a Leading Role\r\n\"Gosford Park\" (2001):\r\n\r\nScreen+" +
                    " Actors Guild Awards (SAG Awards): Nominated as part of the ensemble+" +
                    " cast\r\n\"The Theory of Everything\" (2014):\r\n\r\nAcademy Awards +" +
                    "(Oscars): Nominated for Best Supporting Actress\r\n\"Chernobyl\" +" +
                    "(2019 - Television Miniseries):\r\n\r\nPrimetime Emmy Awards: +" +
                    "Nominated for Outstanding Supporting Actress in a Limited Series or +" +
                    "Movie",
    IsLeadActor = true,
    IsPopular = true,
},
new Actor
{
    Id = 12,
    Name = "Sophie Nélisse",
    Biography = "Sophie Nélisse, born on March 27, 2000,+" +
                     " in Windsor, Ontario, Canada, is a young and talented+" +
                     " actress who has already made a significant impact in the+" +
                     " world of film. Known for her natural presence and ability +" +
                     "to convey depth and emotion, Nélisse has quickly become a+" +
                     " rising star in the entertainment industry.\r\n\r\nHer +" +
                     "breakthrough role came in the film adaptation of Markus+" +
                     " Zusak's novel, \"The Book Thief\" (2013), where she portrayed+" +
                     " Liesel Meminger, a young girl growing up during World War II.+" +
                     " Her performance showcased her maturity beyond her years, earning+" +
                     " her critical acclaim and introducing her to a wider audience.+" +
                     "\r\n\r\nNélisse's talent and versatility were further demonstrated+" +
                     " in films like \"Monsieur Lazhar\" (2011), for which she received+" +
                     " acclaim for her portrayal of a troubled young student. Her +" +
                     "ability to navigate both drama and lighter fare was evident +" +
                     "in movies like \"The Great Gilly Hopkins\" (2015) and \"The +" +
                     "History of Love\" (2016).\r\n\r\nHer dedication to her craft+" +
                     " and her ease in immersing herself in diverse roles set her +" +
                     "apart as a young actress to watch. Nélisse's undeniable screen +" +
                     "presence and her ability to connect with audiences made her a+" +
                     " sought-after talent in the industry.\r\n\r\nAs her career +" +
                     "continues to evolve, Sophie Nélisse's natural talent, relatability,+" +
                     " and willingness to embrace challenging roles hint at a future filled+" +
                     " with more compelling performances and an enduring influence in the+" +
                     " world of film.",
    Country = "Canada",
    MovieAwards = "\"Monsieur Lazhar\" (2011):\r\n\r\nGenie Awards:+" +
                     " Winner for Best Supporting Actress\r\nJutra Awards: Winner for +" +
                     "Best Actress (Nominated as well)\r\n\"The Book Thief\" (2013):+" +
                     "\r\n\r\nPhoenix Film Critics Society Awards: Nominated for+" +
                     " Best Performance by a Youth in a Leading or Supporting Role - +" +
                     "Female\r\nYoung Artist Awards: Nominated for Best Performance in +" +
                     "a Feature Film - Leading Young Actress",
    IsLeadActor = true,
    IsPopular = true,
}
                );

            #endregion

            #region Director Seed Data
            builder.Entity<Director>().HasData(
                new Director
                {
                    Id = 1,
                    Name = "Tim Burton",
                    Biography = "Tim Burton is an American filmmaker, artist, and animator. He is" +
                    " known for his unique and darkly imaginative style in films such as Beetlejuice, " +
                    "Edward Scissorhands, The Nightmare Before Christmas, and more recently, " +
                    "Alice in Wonderland. His films have earned him both critical and commercial" +
                    " success, and he has become one of the most recognizable directors in the industry.",
                    Country = "America",
                    MovieAwards = "Best Art Direction: \"The Nightmare Before Christmas\"\r\nThe " +
                    "meticulously crafted stop-motion sets and characters in this dark fantasy musical " +
                    "create a visually stunning and immersive world.\n Best Director:" +
                    " \"Edward Scissorhands\"\r\nTim Burton's distinctive vision and direction" +
                    " bring out the poignant and bittersweet aspects of the story, turning a modern " +
                    "fairy tale into a cinematic masterpiece.\n Best Original Score:" +
                    " \"Edward Scissorhands\"\r\nComposer Danny Elfman's hauntingly beautiful " +
                    "score perfectly captures the whimsical and melancholic tone of the film," +
                    " enhancing its emotional impact.\n Best Art Direction: \"The Nightmare Before " +
                    "Christmas\"\r\nThe meticulously crafted stop-motion sets and characters in" +
                    " this dark fantasy musical create a visually stunning and immersive world." +
                    "\r\n\r\nBest Makeup and Hairstyling: \"Beetlejuice\"\r\nThe unique and " +
                    "imaginative character designs, especially for the supernatural entities," +
                    " showcase exceptional makeup and hairstyling creativity.\n Best Visual Effects:" +
                    " \"Corpse Bride\"\r\nThe seamless integration of stop-motion animation with visual " +
                    "effects in the realm of the living and the dead contributes to the film's macabre and enchanting atmosphere.",
                    IsPopular = true
                },
                new Director
                {
                    Id = 2,
                    Name = "Kenneth Branagh",
                    Biography = "Kenneth Charles Branagh was born on December 10, 1960, in Belfast," +
                    " Northern Ireland, to parents William Branagh, a plumber and carpenter, " +
                    "and Frances (Harper), both born in 1930. He has two siblings, William Branagh, " +
                    "Jr. (born 1955) and Joyce Branagh (born 1970). When he was nine, his family " +
                    "escaped The Troubles by moving to Reading, Berkshire, England. At 23, Branagh " +
                    "joined the Royal Shakespeare Company, where he took on starring roles in \"Henry" +
                    " V\" and \"Romeo and Juliet\". He soon found the RSC too large and impersonal" +
                    " and formed his own, the Renaissance Theatre Company, which now counts Prince " +
                    "Charles as one of its royal patrons. At 29, he directed Henry V (1989), where " +
                    "he also co-starred with his then-wife, Emma Thompson. The film brought him Best" +
                    " Actor and Best Director Oscar nominations. In 1993, he brought Shakespeare to" +
                    " mainstream audiences again with his hit adaptation of Much Ado About Nothing " +
                    "(1993), which featured an all-star cast that included, among others, Denzel" +
                    " Washington, Michael Keaton and Keanu Reeves. At 30, he published his" +
                    " autobiography and, at 34, he directed and starred as \"Victor Frankenstein\" " +
                    "in the big-budget adaptation of Mary Shelley's novel, Frankenstein (1994), " +
                    "with Robert De Niro as the monster himself. In 1996, Branagh wrote, directed" +
                    " and starred in a lavish adaptation of Hamlet (1996). His superb film acting" +
                    " work also includes a wide range of roles such as in Celebrity (1998), Wild Wild " +
                    "West (1999), The Road to El Dorado (2000), Valkyrie (2008) and his stunning " +
                    "portrayal of Laurence Olivier in My Week with Marilyn (2011), where once again " +
                    "he offered a great performance that was also nominated for an Academy Award.",
                    Country = "Ireland",
                    MovieAwards = "Best Director: \"Henry V\"\r\nKenneth Branagh's directorial debut " +
                    "and adaptation of Shakespeare's play earned him critical acclaim for his ability" +
                    " to breathe new life into classic material while maintaining its authenticity." +
                    "\r\n\r\nBest Actor in a Leading Role: \"Henry V\"\r\nIn addition to directing, " +
                    "Branagh's performance as the titular character showcased his talent as an actor," +
                    " capturing the complexities of King Henry's character.\r\n\r\nBest " +
                    "Adapted Screenplay: \"Much Ado About Nothing\"\r\nBranagh's adaptation of" +
                    " Shakespeare's beloved comedy demonstrated his skill in modernizing the" +
                    " language and making it accessible to contemporary audiences.\r\n\r\nBest " +
                    "Costume Design: \"Mary Shelley's Frankenstein\"\r\nThe film's period " +
                    "costumes captured the gothic atmosphere of the story, contributing to " +
                    "the film's visual authenticity and mood.\r\n\r\nBest Art Direction: " +
                    "\"Hamlet\"\r\nBranagh's grand and opulent adaptation of Shakespeare's " +
                    "\"Hamlet\" featured intricate set designs that brought the world of " +
                    "the play to life.\r\n\r\nBest Supporting Actress: Kate Winslet - " +
                    "\"Hamlet\"\r\nIn Branagh's version of \"Hamlet,\" Kate Winslet's " +
                    "portrayal of Ophelia stood out, showcasing her ability to convey deep emotion " +
                    "and vulnerability.\r\n\r\nBest Short Film (Live Action): \"Swan Song\"\r\nBranagh's " +
                    "short film tells the story of an aging hairdresser's final day at work and" +
                    " received praise for its poignant storytelling and Branagh's performance." +
                    "\r\n\r\nBest Director - Musical or Comedy: \"Much Ado About Nothing\"\r\nBranagh's " +
                    "witty and vibrant adaptation of the Shakespearean comedy earned recognition " +
                    "for his ability to balance humor and romance.",
                    IsPopular = true
                },
                new Director
                {
                    Id = 3,
                    Name = "Joe Wright",
                    Biography = "Joe Wright is an English film director. He is best known for Pride & " +
                    "Prejudice (2005), Atonement (2007), Anna Karenina (2012), and Darkest Hour (2017)" +
                    ".\r\n\r\nWright always had an interest in the arts, especially painting. " +
                    "He would also make films on his Super 8 camera as well as spend time in the " +
                    "evenings acting in a drama club. He began his career working at his parents'" +
                    " puppet theatre. He also took classes at the Anna Scher Theatre School and " +
                    "acted professionally on stage and camera.",
                    Country = "England",
                    MovieAwards = "Best Director: \"Atonement\"\r\nJoe Wright's direction of \"Atonement\"" +
                    " received widespread acclaim for its sweeping visuals, intricate storytelling, and the " +
                    "emotional impact it delivered.\r\n\r\nBest Adapted Screenplay: \"Pride & Prejudice\"\r\nWright's " +
                    "adaptation of Jane Austen's classic novel showcased his ability to capture the nuances of" +
                    " characters and their relationships in a period setting.\r\n\r\nBest Actress in a Leading Role:" +
                    " Keira Knightley - \"Pride & Prejudice\"\r\nKnightley's portrayal of Elizabeth Bennet in Wright's" +
                    " adaptation earned her critical praise for her spirited and captivating performance.\r\n\r\nBest Art " +
                    "Direction: \"Anna Karenina\"\r\nWright's bold decision to stage much of the film within a theater-like" +
                    " setting added a unique visual element, and the film's production design was highly regarded." +
                    "\r\n\r\nBest Original Score: \"Atonement\"\r\nDario Marianelli's evocative score for \"Atonement\" " +
                    "was recognized for its ability to enhance the film's emotional depth and atmosphere.\r\n\r\nBest " +
                    "Supporting Actor: Saoirse Ronan - \"Atonement\"\r\nRonan's breakout performance as Briony Tallis" +
                    " in \"Atonement\" showcased her talent and earned her nominations and praise.\r\n\r\nBest Costume" +
                    " Design: \"Anna Karenina\"\r\nThe film's costumes, designed by Jacqueline Durran, seamlessly " +
                    "integrated with the theatrical aesthetic and the period setting, contributing to the film's visual " +
                    "allure.\r\n\r\nBest Cinematography: \"Atonement\"\r\nThe visually stunning and meticulously crafted" +
                    " shots in \"Atonement,\" captured by Seamus McGarvey, garnered attention for their beauty and" +
                    " storytelling significance.\r\n\r\nBest Director - Musical or Comedy: \"Anna Karenina\"\r\nWright's" +
                    " bold and innovative take on Leo Tolstoy's classic novel was recognized for its artistic vision " +
                    "and unique approach to storytelling.\r\n\r\nBest Foreign Language Film: \"Atonement\"\r\nWhile not " +
                    "in a foreign language, the international scope and themes of \"Atonement\" resonated with audiences " +
                    "and showcased Wright's ability to tell universal stories.",
                    IsPopular = true
                },
                new Director
                {
                    Id = 4,
                    Name = "Brian Percival",
                    Biography = "Brian Percival is a British film and television director known for his work in both" +
                    " mediums. He was born on June 19, 1962, in Liverpool, England. Percival gained recognition for" +
                    " his skill in storytelling and his ability to capture emotional depth in his projects.\r\n\r\nHe " +
                    "began his career working in television, directing episodes of various British TV shows. However, " +
                    "he achieved widespread acclaim when he directed the pilot episode of the critically acclaimed " +
                    "series \"Downton Abbey\" in 2010. His direction of the pilot set the tone for the show's visual " +
                    "style and character dynamics, contributing to its success.\r\n\r\nPercival continued to work on " +
                    "notable television projects, including episodes of popular series like \"North & South\" and " +
                    "\"The Book Thief.\" His work often showcases his talent for creating intimate and compelling " +
                    "narratives that resonate with audiences.\r\n\r\nIn addition to television, Percival has directed " +
                    "feature films as well. One of his notable works is the film adaptation of Markus Zusak's novel \"The " +
                    "Book Thief,\" released in 2013. The film, which explores the power of storytelling during World War " +
                    "II, highlights Percival's ability to handle complex themes with sensitivity.\r\n\r\nBrian Percival's " +
                    "filmography and television work demonstrate his proficiency in eliciting strong performances from " +
                    "actors, his attention to visual storytelling, and his knack for capturing emotional moments on screen." +
                    " His contributions to both mediums have earned him a reputation as a director with a keen eye for " +
                    "storytelling and a skillful approach to his craft.",
                    Country = "UK",
                    MovieAwards = "/",
                    IsPopular = false
                },
                new Director
                {
                    Id= 5,
                    Name = "Mike Johnson",
                    Biography = "\r\nMike Johnson hails from Austin, Texas where he spent a large part of his childhood " +
                    "bending and breaking plastic dinosaurs in a futile attempt to re-create scenes from his favorite Ray " +
                    "Harryhausen films.\r\n\r\nMany years later, Johnson graduated from Rhode Island School of Design in " +
                    "Film/Animation/Video and moved to San Francisco where he got his big break as a rigging assistant on" +
                    " Tim Burton's animated classic The Nightmare Before Christmas. After Nightmare, Johnson went on to" +
                    " animate for various stop-motion productions such as James and the Giant Peach and the Emmy Awa" +
                    "rd-winning" +
                    " children's series Bump in the Night.\r\n\r\nIn 1996, Johnson set up his own animation company," +
                    " Fat Cactus Films, and over the next few years produced and directed an eclectic and critically" +
                    " acclaimed mix of stop-motion projects including commercials, music videos and short films. His" +
                    " award winning animated short The Devil Went Down to Georgia has been screened in film festivals around " +
                    "the world.\r\n\r\nIn 1998, Johnson moved to Portland, Oregon to direct three episodes of Eddie Murphy's" +
                    " Emmy Award winning television series, The P.J's.\r\n\r\nIn 2002 things came full circle when Tim Burton" +
                    " asked Johnson to join him in directing the stop-motion feature, Corpse Bride.",
                    Country ="USA",
                    MovieAwards ="/",
                    IsPopular = false
                },
               
     new Director
     {
         Id = 6,
         Name = "Joe Wright",
         Biography = " Joe Wright, born on August 25, 1972, in London, England,+" +
         " is a British film director known for his distinct visual style and +" +
         "his ability to elicit powerful emotions from his audiences. With a +" +
         "knack for storytelling and a unique approach to filmmaking, Wright +" +
         "has left an indelible mark on the cinematic landscape.\r\n\r\nWright's+" +
         " directorial debut came with \"Pride & Prejudice\" (2005), a film+" +
         " adaptation of Jane Austen's classic novel. His innovative +" +
         "interpretation breathed new life into the story, earning him critical+" +
         " acclaim and setting the tone for his future work.",
         Country = "Ireland",
         MovieAwards = "\"Pride & Prejudice\" (2005):\r\n\r\n+" +
         "Academy Awards (Oscars): Nominated for Best Achievement in Art Direction+" +
         "\r\nBAFTA Awards: Nominated for Best British Film, Best Adapted+" +
         " Screenplay\r\n\"Atonement\" (2007):\r\n\r\nAcademy Awards (Oscars):+" +
         " Nominated for Best Motion Picture, Best Original Score, Best Supporting+" +
         " Actress (Saoirse Ronan)\r\nBAFTA Awards: Nominated for Best Film,+" +
         " Best Director, Best Adapted Screenplay\r\n\"Anna Karenina\" (2012):+" +
         "\r\n\r\nBAFTA Awards: Nominated for Best British Film, Best Production +" +
         "Design, Best Costume Design\r\n\"Darkest Hour\" (2017):\r\n\r\nAcademy " +
         "Awards (Oscars): Gary Oldman won Best Actor for his role as Winston+" +
         " Churchill",
         IsPopular = true
     }
    
              );
            #endregion

            #region Screen Writer Seed Data
            builder.Entity<ScreenWriter>().HasData(
                new ScreenWriter
                {
                    Id= 1,
                    Name= "John August",
                    Biography= "John August's screenwriting credits include Go (1999), Big Fish (2003), Titan A.E. " +
                    "(2000), Charlie's Angels (2000), and Charlie's Angels: Full Throttle (2003).\r\n\r\nBorn and " +
                    "raised in Boulder, Colorado, John earned a degree in journalism from Drake University in Iowa" +
                    " and an MFA in film from the Peter Stark program at the University of Southern California. He " +
                    "lives in Los Angeles. John has a weekly screenwriting column on Internet Movie Database, in" +
                    " the \"Ask a Filmmaker\" section of indie.imdb.com.",
                    Country ="USA",
                    MovieAwards= "/",
                    IsPopular = false
                },
                new ScreenWriter
                {
                    Id = 2,
                    Name = "Caroline Thompson",
                    Biography = "Caroline Thompson was born on April 23, 1956 in Washington, District of Columbia," +
                    " USA. She is a writer and producer, known for Edward Scissorhands (1990), The Addams Family " +
                    "(1991) and The Nightmare Before Christmas (1993). She is married to Steve Nicolaides." +
                    " She was previously married to Henry Bromell.",
                    Country = "USA",
                    MovieAwards = "/",
                    IsPopular = true
                },
                new ScreenWriter
                {
                    Id = 3,
                    Name = "Pamela Pettler",
                    Biography = "Pamela Pettler is a highly regarded screenwriter known for her notable " +
                    "contributions to the animation and film industry. She gained widespread recognition" +
                    " for her work on several acclaimed projects. Notably, she penned the screenplay for" +
                    " the enchanting stop-motion film \"Corpse Bride,\" released in 2005. Her talent for" +
                    " crafting imaginative and emotionally resonant stories also shone through in her" +
                    " work on \"9,\" a 2009 animated film that captured audiences with its unique " +
                    "post-apocalyptic narrative. Additionally, Pettler made her mark as the writer " +
                    "for \"Monster House,\" a 2006 animated horror-comedy that showcased her ability" +
                    " to blend humor and suspense seamlessly. Through her creative storytelling and " +
                    "commitment to bringing captivating characters and worlds to life, Pamela Pettler" +
                    " has left an indelible mark on the world of animation and film.",
                    Country = "USA",
                    MovieAwards = "/",
                    IsPopular = false
                },
                new ScreenWriter
                {
                    Id = 4,
                    Name = "Carlos Grange",
                    Biography = "Carlos Grangel is a Spanish artist and character designer, born on September" +
                    " 14, 1963, in Barcelona, Spain. He is renowned for his exceptional work in the animation and " +
                    "entertainment industry. Grangel is particularly recognized for his distinctive and whimsical " +
                    "character designs, which have left a significant mark on various animated films and projects." +
                    "\r\n\r\nHe began his career working as an illustrator and graphic designer before transitioning " +
                    "into character design. Grangel's unique and imaginative style has led him to collaborate with " +
                    "some of the most prominent names in the animation world. He has contributed his artistic talents " +
                    "to numerous acclaimed animated films, creating memorable characters that have captured the hearts" +
                    " of audiences worldwide.\r\n\r\nCarlos Grangel's work often features exaggerated proportions," +
                    " quirky expressions, and a strong sense of personality that brings his characters to life. " +
                    "His contributions have enhanced the visual appeal and storytelling of various animated movies, " +
                    "making him a sought-after talent in the industry.Grangel's portfolio includes collaborations with" +
                    " renowned animation studios such as Pixar, DreamWorks, and Tim Burton Productions. His work has" +
                    " been featured in films like \"Corpse Bride,\" \"Hotel Transylvania,\" \"Despicable Me,\" and" +
                    " \"Finding Nemo,\" among others.\r\n\r\nThroughout his career, Carlos Grangel has showcased " +
                    "his exceptional ability to translate concepts and ideas into visually compelling characters." +
                    " His innovative and whimsical designs have contributed to the success of numerous animated projects, " +
                    "making him a respected figure in the world of character design and animation.",
                    Country = "Spain",
                    MovieAwards = "/",
                    IsPopular = true
                },
                new ScreenWriter
                {
                    Id = 5,
                    Name = "Tim Burton",
                    Biography = "Tim Burton is an American filmmaker, artist, and animator. He is" +
                    " known for his unique and darkly imaginative style in films such as Beetlejuice, " +
                    "Edward Scissorhands, The Nightmare Before Christmas, and more recently, " +
                    "Alice in Wonderland. His films have earned him both critical and commercial" +
                    " success, and he has become one of the most recognizable directors in the industry.",
                    Country = "America",
                    MovieAwards = "Best Art Direction: \"The Nightmare Before Christmas\"\r\nThe " +
                    "meticulously crafted stop-motion sets and characters in this dark fantasy musical " +
                    "create a visually stunning and immersive world.\n Best Director:" +
                    " \"Edward Scissorhands\"\r\nTim Burton's distinctive vision and direction" +
                    " bring out the poignant and bittersweet aspects of the story, turning a modern " +
                    "fairy tale into a cinematic masterpiece.\n Best Original Score:" +
                    " \"Edward Scissorhands\"\r\nComposer Danny Elfman's hauntingly beautiful " +
                    "score perfectly captures the whimsical and melancholic tone of the film," +
                    " enhancing its emotional impact.\n Best Art Direction: \"The Nightmare Before " +
                    "Christmas\"\r\nThe meticulously crafted stop-motion sets and characters in" +
                    " this dark fantasy musical create a visually stunning and immersive world." +
                    "\r\n\r\nBest Makeup and Hairstyling: \"Beetlejuice\"\r\nThe unique and " +
                    "imaginative character designs, especially for the supernatural entities," +
                    " showcase exceptional makeup and hairstyling creativity.\n Best Visual Effects:" +
                    " \"Corpse Bride\"\r\nThe seamless integration of stop-motion animation with visual " +
                    "effects in the realm of the living and the dead contributes to the film's macabre and enchanting atmosphere.",
                    IsPopular = true
                },
                new ScreenWriter
                {
                    Id=6,
                    Name = "Linda Woolverton",
                    Biography= "Linda Woolverton was born in Long Beach, California, graduating from high school in 1969 and" +
                    " having been an honors student in her schools theater program. She enrolled at California State " +
                    "University, Long Beach, graduating with a BFA in Theater Arts in 1973. She worked full-time for a" +
                    " year in the entertainment division at Disneyland, and began working toward her Masters Degree in" +
                    " Theater for Children at California State Fullerton, while working as a substitute teacher.\r\n\r\nUpon " +
                    "the completion of her Masters Degree in 1976, she formed her own children's theater company. She " +
                    "wrote, directed and performed all over California in churches, malls, schools, and local theaters." +
                    " She also began in 1979, to work as a coach to children acting in commercials. In 1980 she began" +
                    " working as a development executive for CBS, concentrating on both children's and late-night" +
                    " programming.\r\n\r\nIn 1984 she began working as a children's television writer, penning" +
                    " scripts for shows such as Ewoks (1985), The Real Ghostbusters (1986), Alvin & the Chipmunks" +
                    " (1983) and DuckTales (2017). She also had two young adult novels published: Starwind and Running" +
                    " Before the Wind.\r\n\r\nWhen one of her novels caught the attention of a Disney executive, she" +
                    " was hired to write the script for the animated motion picture Beauty and the Beast (1991). " +
                    "Upon its release in 1991, Beauty and the Beast (1991) became the first animated film to be nominated" +
                    " for Best Picture at the Academy Awards.\r\n\r\nWoolverton also co-wrote the script for The Lion" +
                    " King (1994) and Homeward Bound: The Incredible Journey (1993). She also adapted the script of " +
                    "Beauty and the Beast for the stage, which opened to critical acclaim on Broadway in Spring 1994, " +
                    "and was later nominated for a Tony Award for Best Book in a Musical. She also wrote the book for " +
                    "Disney's third Broadway production 'Aida.",
                    Country="USA",
                    MovieAwards= "She was awarded the 1998 Laurence Olivier Theatre Award for Beauty and Beast" +
                    " performed at the Dominion Theatre for Best New Musical of 1997.",
                    IsPopular = true
                },
                  new ScreenWriter
                  {
                      Id = 7,
                      Name = "Lewis Carroll",
                      Biography = "Lewis Carroll was the pen name of Charles L. Dodgson, author of the children's classics" +
                      " \"Alice's Adventures in Wonderland\" and \"Through the Looking-Glass.\"\r\n\r\nBorn on January " +
                      "27, 1832 in Daresbury, Cheshire, England, Charles Dodgson wrote and created games as a child. At " +
                      "age 20 he received a studentship at Christ Church and was appointed a lecturer in mathematics. " +
                      "Dodgson was shy but enjoyed creating stories for children. His books including \"Alice's Adventures " +
                      "in Wonderland\" were published under the pen name Lewis Carroll. Dodgson died in " +
                      "1898.\r\n\r\nEarly Life, Charles Lutwidge Dodgson, best known by his pseudonym, Lewis Carroll," +
                      " was born in the village of Daresbury, England, on January 27, 1832. The eldest boy in a family" +
                      " of 11 children, Carroll was rather adept at entertaining himself and his siblings. His father," +
                      " a clergyman, raised them in the rectory. As a boy, Carroll excelled in mathematics and won many " +
                      "academic prizes. At age 20, he was awarded a studentship (called a scholarship in other colleges) " +
                      "to Christ College. Apart from serving as a lecturer in mathematics, he was an avid photographer " +
                      "and wrote essays, political pamphlets and poetry. \"The Hunting of the Snark\" displays his wonderful " +
                      "ability in the genre of literary nonsense.\r\n\r\nAlice and Literary Success, Carroll suffered from " +
                      "a bad stammer, but he found himself vocally fluent when speaking with children. The relationships he" +
                      " had with young people in his adult years are of great interest, as they undoubtedly inspired his" +
                      " best-known writings and have been a point of disturbed speculation over the years. Carroll loved" +
                      " to entertain children, and it was Alice, the daughter of Henry George Liddell, who can be credited" +
                      " with his pinnacle inspiration. Alice Liddell remembers spending many hours with Carroll, sitting" +
                      " on his couch while he told fantastic tales of dream worlds. During an afternoon picnic with Alice" +
                      " and her two sisters, Carroll told the first iteration of what would later become Alice's Adventures" +
                      " in Wonderland. When Alice arrived home, she exclaimed that he must write the story down for her." +
                      "\r\n\r\nHe fulfilled the small girl's request, and through a series of coincidences, the story " +
                      "fell into the hands of the novelist Henry Kingsley, who urged Carroll to publish it. The book Alice's " +
                      "Adventures in Wonderland was released in 1865. It gained steady popularity, and as a result, Carroll" +
                      " wrote the sequel, Through the Looking-Glass and What Alice Found There (1871). By the time of his" +
                      " death, Alice had become the most popular children's book in England, and by 1932 it was one of the" +
                      " most popular in the world.\r\n\r\nPhotography and Legacy, besides writing, Carroll created a number" +
                      " of fine photographs. His notable portraits include those of the actress Ellen Terry and the poet " +
                      "Alfred Tennyson. He also photographed children in every possible costume and situation, eventually" +
                      " making nude studies of them. Despite conjecture, little real evidence of child abuse can be " +
                      "brought against him. Shortly before his 66th birthday, Lewis Carroll caught a severe case of " +
                      "influenza, which led to pneumonia. He died on January 14, 1898, leaving an enigma behind him.",
                      Country = "UK",
                      MovieAwards = "/",
                      IsPopular = true
                  },
                  new ScreenWriter
                    {
                        Id = 8,
                        Name = "Roald Dahl",
                        Biography = "Dahl was born in Wales in 1916. He served as a fighter pilot in the Royal Air Force " +
                        "during World War II. He made a forced landing in the Libyan Desert and was severely injured. As a " +
                        "result, he spent five months in a Royal Navy hospital in Alexandria. Dahl is noted for how he relates" +
                        " suspenseful and sometimes horrific events in a simple tone.\r\n " +
                        "\r\nRoald Dahl was a famous short story writer who became one of the most successful and" +
                        " beloved children's writers of all time. He also wrote several screenplays. Born in Wales to" +
                        " Norwegian parents, he attended British schools, but never went to university, opting to go work " +
                        "for the Shell Oil Company instead. He worked there for a few years, but when World War II started," +
                        " he joined the RAF. While assistant air attaché in Washington DC, he began writing, which after the" +
                        " war became his life-long vocation. He wrote two novels, two autobiographies, nineteen children's" +
                        " books, and many short story collections, the most notable being Kiss Kiss (1959) and Switch Bitch " +
                        "(1974). He died of leukemia in 1990.",
                        Country = "UK",
                        MovieAwards = "/",
                        IsPopular = false
                    },
                  new ScreenWriter
                  {
                      Id = 9,
                      Name = "Chris Weitz",
                      Biography = "Chris Weitz, born on November 30, 1969, is an American filmmaker, screenwriter, and producer known +" +
                    "for his versatile talents in both directing and writing across various genres. With a career spanning film and+" +
                    " television, Weitz has proven himself as a creative force capable of tackling diverse stories and capturing+" +
                    " audiences' imaginations.",
                      Country = "USA",
                      MovieAwards = "\"About a Boy\" (2002):\r\n\r\nAcademy Awards+" +
                    " (Oscars): Nominated for Best Adapted Screenplay (shared+" +
                    " nomination with his brother, Paul Weitz)\r\nBAFTA Awards:+" +
                    " Nominated for Best Adapted Screenplay (shared nomination+" +
                    " with Paul Weitz)\r\n\"A Better Life\" (2011):\r\n\r\nAcademy Awards (Oscars): Nominated for +" +
                    "Best Original Screenplay",
                      IsPopular = false
                  },
                new ScreenWriter
                {
                    Id = 10,
                    Name = "Charles Perrault",
                    Biography = "Charles Perrault, born on January 12, 1628, in Paris, France, was a French author and+" +
                    " member of the Académie Française who made an indelible mark on literature with his enchanting fairy+" +
                    " tales and contributions to storytelling. His imaginative works continue to captivate readers and serve+" +
                    " as the foundation for many beloved stories.\r\n\r\nPerrault's most enduring legacy lies in his creation+" +
                    " and popularization of some of the world's most iconic fairy tales, including+" +
                    " \"Cinderella,\" \"Sleeping Beauty,\" \"Little Red Riding Hood,\" and \"Puss in Boots.+" +
                    "\" His innovative approach of adapting folklore into literary narratives marked a pivotal moment +" +
                    "in literature, as he played a significant role in shaping the fairy tale genre as we know it today.",
                    Country = "France",
                    MovieAwards = "/",
                    IsPopular = false
                },
                new ScreenWriter
                {
                    Id = 11,
                    Name = "Tom Stoppard",
                    Biography = "Tom Stoppard, born Tomáš Straussler on July 3, 1937, in Zlín, Czechoslovakia+" +
                    " (now the Czech Republic), is a British playwright and screenwriter celebrated for his wit,+" +
                    " intellectual depth, and unparalleled ability to craft intricate narratives. His contributions+" +
                    " to theater and film have earned him a place among the most influential and innovative writers of +" +
                    "his generation.",
                    Country = "Czech Republic",
                    MovieAwards = "\"Shakespeare in Love\" (1998):\r\n\r\n+" +
                    "Academy Awards (Oscars): Won for Best Original Screenplay+" +
                    " (shared with Marc Norman)\r\nBAFTA Awards: Won for Best Original +" +
                    "Screenplay (shared with Marc Norman)\r\nWriters Guild of America +" +
                    "Awards: Won for Best Original Screenplay (shared with Marc Norman)",
                    IsPopular = true
                },
                new ScreenWriter
                {
                    Id = 12,
                    Name = "Lev Tolstoy",
                    Biography = "Leo Tolstoy, born Lev Nikolayevich Tolstoy on September 9, 1828, +" +
                    "in Yasnaya Polyana, Russia, was a Russian writer, philosopher, and social+" +
                    " reformer of immense influence. His literary works, including +" +
                    "\"War and Peace\" and \"Anna Karenina,\" have left an indelible mark on+" +
                    " world literature, while his philosophical and ethical beliefs have had +" +
                    " lasting impact on society.\r\n\r\nTolstoy's early life was marked by privilege+" +
                    " and intellectual curiosity. His experiences as a young officer in the Russian+" +
                    " Army during the Crimean War shaped his perspective on human suffering and+" +
                    " the futility of violence, themes that would later appear in his writing.",
                    Country = "Russia",
                    MovieAwards = "/",
                    IsPopular = true
                },
                new ScreenWriter
                {
                    Id = 13,
                    Name = "Markus Zusak",
                    Biography = "Markus Zusak, born on June 23, 1975, in Sydney, Australia,+" +
                    " is an Australian author known for his ability to create powerful and +" +
                    "emotionally resonant narratives that touch the hearts of readers around+" +
                    " the world. His storytelling skills and unique perspectives have earned+" +
                    " him acclaim in the literary world.\r\n\r\nZusak's breakthrough novel, +" +
                    "\"The Book Thief\" (2005), catapulted him to international fame. +" +
                    "This poignant story set in Nazi Germany, narrated by Death and centered +" +
                    "around a young girl's love for books, captured readers' imaginations with +" +
                    "its moving exploration of human resilience and compassion amidst the darkest+" +
                    " of times.",
                    Country = "Australia",
                    MovieAwards = "/",
                    IsPopular = false
                },
                new ScreenWriter
                {
                    Id = 14,
                    Name = "Michael Petroni",
                    Biography = "Michael Petroni is an Australian screenwriter, director, and producer known for his work+" +
                    " in film and television. Born on August 28, 1964, in Hobart, Tasmania, Petroni has made his mark through+" +
                    " his ability to create stories that explore complex emotions, human relationships,+" +
                    " and the intersection of reality and the supernatural.\r\n\r\nPetroni's career began with writing+" +
                    " and directing short films before transitioning to feature-length projects. He gained recognition+" +
                    " for his screenplay for the supernatural drama \"The Rite\" (2011), which starred Anthony Hopkins+" +
                    " The film delved into themes of faith and skepticism, marking Petroni's exploration of spiritual and +" +
                    "philosophical concepts.",
                    Country = "Tasmania",
                    MovieAwards = "/",
                    IsPopular = false
                }

                );

            #endregion

            #region Producer Seed Data
            builder.Entity<Producer>().HasData(
                new Producer
                {
                    Id = 1,
                    Name = "Tim Burton",
                    Biography = "Tim Burton is an American filmmaker, artist, and animator. He is" +
                    " known for his unique and darkly imaginative style in films such as Beetlejuice, " +
                    "Edward Scissorhands, The Nightmare Before Christmas, and more recently, " +
                    "Alice in Wonderland. His films have earned him both critical and commercial" +
                    " success, and he has become one of the most recognizable directors in the industry.",
                    Country = "America",
                    MovieAwards = "Best Art Direction: \"The Nightmare Before Christmas\"\r\nThe " +
                    "meticulously crafted stop-motion sets and characters in this dark fantasy musical " +
                    "create a visually stunning and immersive world.\n Best Director:" +
                    " \"Edward Scissorhands\"\r\nTim Burton's distinctive vision and direction" +
                    " bring out the poignant and bittersweet aspects of the story, turning a modern " +
                    "fairy tale into a cinematic masterpiece.\n Best Original Score:" +
                    " \"Edward Scissorhands\"\r\nComposer Danny Elfman's hauntingly beautiful " +
                    "score perfectly captures the whimsical and melancholic tone of the film," +
                    " enhancing its emotional impact.\n Best Art Direction: \"The Nightmare Before " +
                    "Christmas\"\r\nThe meticulously crafted stop-motion sets and characters in" +
                    " this dark fantasy musical create a visually stunning and immersive world." +
                    "\r\n\r\nBest Makeup and Hairstyling: \"Beetlejuice\"\r\nThe unique and " +
                    "imaginative character designs, especially for the supernatural entities," +
                    " showcase exceptional makeup and hairstyling creativity.\n Best Visual Effects:" +
                    " \"Corpse Bride\"\r\nThe seamless integration of stop-motion animation with visual " +
                    "effects in the realm of the living and the dead contributes to the film's macabre and enchanting atmosphere.",
                    IsPopular = true
                },
                 new Producer
                 {
                     Id = 2,
                     Name = "Allison Abbate",
                     Biography = "Allison Abbate (Producer) is the BAFTA-Award winning producer of Iron Giant and Tim " +
                     "Burton's Corpse Bride.\r\n\r\nAllison has made a career of working on some of the most innovative " +
                     "animated features in the business. A native of New York, Abbate relocated to Hollywood in 1989 where " +
                     "she started at Disney and served as an artistic coordinator on Tim Burton's cult classic The" +
                     " Nightmare Before Christmas.\r\n\r\nAbbate then moved to Paris for The Walt Disney Company to" +
                     " set-up their satellite animation studio and co-produce the Academy Award-nominated Mickey" +
                     " Mouse short Runaway Brain.\r\n\r\nIn 1996, Abbate joined Warner Bros. where she co-produced " +
                     "the international hit feature Space Jam which combined classic animated Warner Bros. " +
                     "characters with live action sequences. This film, headlined by Bugs Bunny, Michael Jordan " +
                     "and Bill Murray, broke new ground in animated features.\r\n\r\nShe then went on to earn a" +
                     " BAFTA award in 1999, as producer of Brad Bird's internationally acclaimed Iron Giant, an " +
                     "adaptation of British Poet Laureate Ted Hughes' acclaimed children's' book, The Iron Man.\r\n\r\n" +
                     "She followed up her success on Iron Giant producing Looney Tunes Back in Action, another family " +
                     "comedy which teamed Bugs Bunny and Daffy Duck with Brendan Fraser and Steve Martin. Abbate then " +
                     "moved to London in 2004 to produce the haunting musical feature, Corpse Bride with Johnny Depp " +
                     "and Helena Bonham Carter with director Tim Burton. Corpse Bride was also nominated for an Oscar " +
                     "in 2005.\r\n\r\nIn 2006 she joined forces with acclaimed filmmaker Wes Anderson to produce the " +
                     "Fantastic Mr Fox, a stop motion adaptation of Roald Dahl's beloved children's story featuring " +
                     "the voices of George Clooney and Meryl Streep.\r\n\r\nPresently, Allison has reunited with Tim " +
                     "Burton yet again, and is producing Frankenweenie, a stop motion animated feature based on a live " +
                     "action short from Tim's early career.",
                     Country = "USA",
                     MovieAwards = "Annie Awards:\r\n\r\nAbbate has received several Annie Awards for her work on " +
                     "different animated films, including titles like \"Fantastic Mr. Fox\" and \"Frankenweenie.\"\r\n" +
                     "Academy Awards (Oscars):\r\n\r\nShe has been associated with films that have received nominations" +
                     " and won Oscars in the Animated Feature category, such as \"The Fantastic Mr. Fox.\"\r\nProducers " +
                     "Guild of America Awards (PGA Awards):\r\n\r\nAbbate's producing efforts on certain films might have" +
                     " earned her recognition from the Producers Guild of America.",
                     IsPopular = true
                 },
                  new Producer
                  {
                      Id = 3,
                      Name = "Richard D. Zanuck",
                      Biography = "Richard D. Zanuck was born on December 13, 1934 in Los Angeles, California, USA. He " +
                      "was a producer and production manager, known for Driving Miss Daisy (1989), Deep Impact (1998) " +
                      "and Cocoon (1985). He was previously married to Lili Fini Zanuck, Linda Harrison and Lili Gentle. " +
                      "He died on July 13, 2012 in Beverly Hills, California, USA.",
                      Country = "USA",
                      MovieAwards = "Academy Awards (Oscars):\r\n\r\nZanuck won the Academy Award for Best Picture for " +
                      "the film \"Driving Miss Daisy\" (1989), which he produced alongside his wife, Lili Fini Zanuck.\r\n" +
                      "Producers Guild of America Awards (PGA Awards):\r\n\r\nHe received the Producers Guild of America's " +
                      "Milestone Award in 1991.\r\nBAFTA Awards:\r\n\r\nZanuck was honored with the BAFTA Academy Fellowship" +
                      " Award in 2001.\r\nGolden Globe Awards:\r\n\r\nHe won a Golden Globe Award for Best Motion Picture - " +
                      "Musical or Comedy for \"Driving Miss Daisy\" (1989).\r\nIrving G. Thalberg Memorial Award:\r\n\r\nZanuck" +
                      " was presented with the Irving G. Thalberg Memorial Award at the Academy Awards ceremony in 1991. " +
                      "This award is given to producers for their consistent high-quality work in the film industry.\r\n" +
                      "David O. Selznick Achievement Award in Theatrical Motion Pictures:\r\n\r\nHe received this award " +
                      "from the Producers Guild of America in 1993.\r\n",
                      IsPopular = true
                  },
                   new Producer
                   {
                       Id = 4,
                       Name = "Jennifer Todd",
                       Biography = "Jennifer Todd was born on October 3, 1969 in Los Angeles, California, USA. She is a " +
                       "producer, known for Memento (2000), Across the Universe (2007) and Boiler Room (2000). She is" +
                       " married to Chris Messina. They have two children.",
                       Country = "USA",
                       MovieAwards = "Emmy Awards:\r\n\r\nJennifer Todd won an Emmy Award for Outstanding Variety, Music," +
                       " or Comedy Special as a producer of \"The 86th Annual Academy Awards\" in 2014.\r\nProducers " +
                       "Guild of America Awards (PGA Awards):\r\n\r\nShe has received multiple nominations and won " +
                       "awards at the PGA Awards for her work on films like \"Alice in Wonderland\" and \"Inception." +
                       "\"\r\nGolden Globe Awards:\r\n\r\nTodd received a Golden Globe nomination for Best Motion Picture " +
                       "- Musical or Comedy for \"Alice in Wonderland\" (2010), which she produced.\r\nCritics' Choice " +
                       "Movie Awards:\r\n\r\nShe won the Critics' Choice Movie Award for Best Comedy for \"Alice in" +
                       " Wonderland\" (2010).\r\nWomen in Film Crystal + Lucy Awards:\r\n\r\nTodd received the Independent " +
                       "Producer Award at the Women in Film Crystal + Lucy Awards in 2018.\r\nHollywood Film Awards:\r\n\r\n" +
                       "Jennifer Todd was honored with the Hollywood Producer Award at the Hollywood Film Awards in 2016.\r\n" +
                       "Environmental Media Awards:\r\n\r\nShe won the EMA Green Production Award in 2019.",
                       IsPopular = true
                   },
                    new Producer
                    {
                        Id = 5,
                        Name = "Mark Kaufman",
                        Biography = "Mark Kaufman serves as Executive Vice President, Warner Bros. Theatre Ventures. In this " +
                        "role, Kaufman has creative and operational oversight on all live stage endeavors based on the Studio's" +
                        " vast library of iconic film and television properties.\r\n\r\nWarner Bros. Theatre Ventures is " +
                        "currently represented on Broadway with the eight-time Tony Award-nominated hit musical " +
                        "\"Beetlejuice,\" based on Tim Burton's cult movie classic. Kaufman also produced the West End, " +
                        "Broadway, First National Tour and Australian productions of the Olivier Award-winning musical " +
                        "\"Charlie and the Chocolate Factory\"; the Tony-nominated Broadway stage adaptation of Stephen" +
                        " King's \"Misery\"; the Tony Award-winning Best Play \"The Curious Incident of the Dog in the" +
                        " Night-Time\"; the Tony-winning original musical \"The Bridges of Madison County\"; and the " +
                        "record-breaking hit holiday musical \"Elf,\" based on the beloved New Line Cinema film. Kaufman " +
                        "additionally served as executive producer on NBC's acclaimed animated television adaptation of " +
                        "\"Elf,\" \"Elf: Buddy's Musical Christmas.\" Under Kaufman's leadership, the division co-produced " +
                        "the original musical \"Secondhand Lions\" at Seattle's 5th Avenue Theatre and handled global stage" +
                        " licenses for recent productions of \"42nd Street,\" \"August Rush,\" \"The Bodyguard,\" \"A" +
                        " Christmas Story,\" \"Hairspray,\" \"The Color Purple,\" \"Diner,\" \"Honeymoon in Vegas,\" \"Singin'" +
                        " in the Rain,\" \"Top Hat,\" \"The Wizard of Oz,\" \"Charlie and the Chocolate Factory\" and " +
                        "\"Beetlejuice.\"\r\n\r\nUpcoming, a musical adaptation of \"Dave\" is currently in development " +
                        "for Broadway following a successful summer 2018 debut at the Arena Theatre in Washington, DC. " +
                        "Other projects in development include a stage version of the movie musical \"A Star is Born,\" a " +
                        "musical adaptation of \"17 Again\" (which premiered at NAMT in fall 2018), and a dramatic staging of" +
                        " \"Dog Day Afternoon.\"\r\n\r\nKaufman's career spans stage, cinema, music and television. He joined" +
                        " Warner Bros. Theatre Ventures from Unique Features in 2011, following a 16-year tenure at New Line " +
                        "Cinema, where he served as a senior executive in the music, feature development and theatrical stage" +
                        " departments. During his tenure, Kaufman oversaw both the Broadway productions of the Tony " +
                        "Award-winning musical \"Hairspray\" and the Tony-nominated musical \"The Wedding Singer\" for" +
                        " New Line. He also oversaw development and served as executive producer on such feature films as" +
                        " \"Hairspray,\" \"Secondhand Lions,\" \"Four Christmases,\" \"17 Again,\" \"My Sister's Keeper," +
                        "\" \"Valentine's Day,\" \"Take the Lead\" and \"Raise Your Voice.\" Kaufman was additionally" +
                        " behind the music licensing on multiple platinum and gold soundtracks, including the blockbuster" +
                        " \"Rush Hour\" and \"Austin Powers\" film franchises, \"The Wedding Singer,\" \"Boogie Nights\"" +
                        " and \"Don Juan Demarco,\" the last of which featured the Academy Award-nominated original song " +
                        "\"Have You Ever Really Loved a Woman\" by Bryan Adams.\r\n\r\nAs a writer, Kaufman created" +
                        " \"Toothless\" for ABC's The Wonderful World of Disney, and \"Just a Walk in the Park\" for ABC" +
                        " Family.",
                        Country = "USA",
                        MovieAwards = "/",
                        IsPopular = false
                    }

                );
            #endregion

            #region Movie Data Seed

            builder.Entity<Movie>().HasData
                (
                
                 new Movie
                 {
                    
                     Id = 1,
                     MovieTitle = "Corpse Bride",
                     ActorId = 1&2&3,                  
                     ActorName = "Johnny Depp,Helena Bonham Carter,Emily Watson",
                     DirectorId = 1,
                     DirectorName = "Tim Burton",
                     ProducerId = 1&2,
                     ProducerName = "Tim Burton, Allison Abbate",
                     ScreenWriterId = 1&5,
                     ScreenWriterName = "John August,Tim Burton",
                     CategoryId = 1&7,
                     CategoryName = "Animation, Drama",
                     Description = "\"Corpse Bride\" is a stop-motion animated fantasy film directed by Tim Burton and " +
                     "Mike Johnson, released in 2005. The story follows Victor, a young man from a Victorian-era village, " +
                     "who accidentally proposes to a deceased bride while rehearsing his wedding vows in the woods. " +
                     "The bride, Emily, takes him to the Land of the Dead, where Victor learns about life, death, and love. " +
                     "The film combines dark humor, enchanting visuals, and musical elements to explore themes of acceptance, " +
                     "identity, and the afterlife, all in the distinctive and whimsical style that Tim Burton is known for.",
                     Genre = "Drama",
                     Subtitles = "English",
                     YearOfRelease = new DateTime(2005, 9, 7),
                     MovieDuration = "1h 17m",
                     PhotoUrl = "https://th.bing.com/th/id/R.5530e30fa7db7ed3f5e71b64676a3e2c?rik=nPjUifwSoXIplg&pid=ImgRaw&r=0",
                     VideoUrl = "https://www.imdb.com/title/tt0121164/?ref_=tt_mv_close",
                     VideoResolution = "4k",
                     Price = 150,
                     Currency= "MKD",
                     Language = "English",
                     IsPremier = false,
                     TrailerUrl = "https://www.youtube.com/watch?v=AGACeWVdFqo",
                 },
                  new Movie
                  {
                    
                      Id = 2,
                      MovieTitle = "Alice in Wonderland",
                      ActorId = 1&2&4,
                      ActorName = "Johnny Depp,Helena Bonham Carter,Mia Wasikowska",
                      DirectorId = 1,
                      DirectorName = "Tim Burton",
                      ProducerId = 3&4,
                      ProducerName = "Richard D. Zanuck,Jennifer Todd",
                      ScreenWriterId = 6&7,
                      ScreenWriterName = "Linda Woolverton,Lewis Carroll",
                      CategoryId = 5,
                      CategoryName = "Adventure",
                      Description = "\"Alice in Wonderland,\" directed by Tim Burton and released in 2010, is a whimsical " +
                      "and fantastical adaptation of Lewis Carroll's classic tale. This visually stunning film stars Johnny " +
                      "Depp as the Mad Hatter, a quirky and eccentric character who guides Alice (played by Mia Wasikowska)" +
                      " through the strange and enchanting world of Wonderland. Depp's portrayal adds his signature blend of" +
                      " eccentricity and charm to the Mad Hatter, creating a captivating and memorable performance that " +
                      "complements the film's surreal and imaginative atmosphere.\"",
                      Genre = "Fantasy",
                      Subtitles = "English&Macedonian",
                      YearOfRelease = new DateTime(2010, 2, 25),
                      MovieDuration = "1h 48m",
                      PhotoUrl = "https://th.bing.com/th/id/OIP.FGgGOvJ69NC3Uw5xaNSHdgHaNM?pid=ImgDet&rs=1",
                      VideoUrl = "https://www.imdb.com/title/tt1014759/",
                      VideoResolution = "1440p",
                      Price = 300,
                      Currency = "MKD",
                      Language = "English",
                      IsPremier = false,
                      TrailerUrl = "https://www.youtube.com/watch?v=9POCgSRVvf0",

                  },
                   new Movie
                   {
                       Id = 3,
                       MovieTitle = "Charlie and the Chocolate Factory",
                       ActorId = 1&5&6,
                       ActorName = "Johnny Depp,Freddie Highmore,David Kelly",
                       DirectorId = 1,
                       DirectorName = "Tim Burton",
                       ProducerId = 1,
                       ProducerName = "",
                       ScreenWriterId = 1,
                       ScreenWriterName = "",
                       CategoryId = 5&10,
                       CategoryName = "Adventure, Comedy",
                       Description = "",
                       Genre = "",
                       Subtitles = "English, Macedonian",
                       YearOfRelease = new DateTime(2005, 7, 10),
                       MovieDuration = "1h 55m",
                       PhotoUrl = "https://th.bing.com/th/id/R.3141e306beaf4e8f3f923832a4af3975?rik=D9F2E7KYAwBzWQ&pid=ImgRaw&r=0",
                       VideoUrl = "https://www.imdb.com/title/tt0367594/",
                       VideoResolution = "4k",
                       Price = 250,
                       Currency = "MKD",
                       Language = "English",
                       IsPremier = false,
                       TrailerUrl = "https://www.youtube.com/watch?v=OFVGCUIXJls",
                   },
                    new Movie
                    {
                        Id = 4,
                        MovieTitle = "",
                        ActorId = 1,
                        ActorName = "",
                        DirectorId = 1,
                        DirectorName = "",
                        ProducerId = 1,
                        ProducerName = "",
                        ScreenWriterId = 1,
                        ScreenWriterName = "",
                        CategoryId = 1,
                        CategoryName = "",
                        Description = "",
                        Genre = "",
                        Subtitles = "",
                        YearOfRelease = new DateTime(),
                        MovieDuration = "",
                        PhotoUrl = "",
                        VideoUrl = "",
                        VideoResolution = "",
                        Price = 0,
                        Currency = "MKD",
                        Language = "",
                        IsPremier = false,
                        TrailerUrl = "",

                    },
                     new Movie
                     {
                         Id = 5,
                         MovieTitle = "",
                         ActorId = 1,
                         ActorName = "",
                         DirectorId = 1,
                         DirectorName = "",
                         ProducerId = 1,
                         ProducerName = "",
                         ScreenWriterId = 1,
                         ScreenWriterName = "",
                         CategoryId = 1,
                         CategoryName = "",
                         Description = "",
                         Genre = "",
                         Subtitles = "",
                         YearOfRelease = new DateTime(),
                         MovieDuration = "",
                         PhotoUrl = "",
                         VideoUrl = "",
                         VideoResolution = "",
                         Price = 0,
                         Currency = "MKD",
                         Language = "",
                         IsPremier = false,
                         TrailerUrl = "",

                     },
                      new Movie
                      {
                          Id = 6,
                          MovieTitle = "",
                          ActorId = 1,
                          ActorName = "",
                          DirectorId = 1,
                          DirectorName = "",
                          ProducerId = 1,
                          ProducerName = "",
                          ScreenWriterId = 1,
                          ScreenWriterName = "",
                          CategoryId = 1,
                          CategoryName = "",
                          Description = "",
                          Genre = "",
                          Subtitles = "",
                          YearOfRelease = new DateTime(),
                          MovieDuration = "",
                          PhotoUrl = "",
                          VideoUrl = "",
                          VideoResolution = "",
                          Price = 0,
                          Currency = "MKD",
                          Language = "",
                          IsPremier = false,
                          TrailerUrl = "",
                      }
                );

            #endregion
        }

        #endregion
    }
}
