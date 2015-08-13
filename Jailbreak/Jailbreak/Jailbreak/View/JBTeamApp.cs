using System;
using Xamarin.Forms;
using System.Collections.Generic;
using Jailbreak.Model;

namespace Jailbreak.View
{
    public class JBTeamApp : Application
    {
        public Page GetTeamMembers()
        {

            var jbt = new List<JBTeam>() {
                new JBTeam () {
                    Name = "Clay Baines",
                    Title = "Brewer",
                    Desc = "Clay is our head brewer that can often be  seen from the tasting room in his home away from home, the brewhouse.",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/clay-300x300.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "clay@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Taylor Bee",
                    Title = "Beer Evangelist",
                    Desc = "Bee is for brewing!",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/taylor_cropped.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "taylor@jailbreakbrewing.com"
                },
                new  JBTeam() {
                    Name = "Justin Bonner",
                    Title = "Founder & CEO",
                    Desc = "Justin is what’s known as the “wild  card”. He’s opinionated, politically incorrect and likely in need of  therapy.",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/justin_new2-e1430598019884-300x300.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "justin@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Jessica Collins",
                    Title = "Brand Ambassador",
                    Desc = "Jessica, a Jailbreak Brand  Ambassador who also holds a degree in Nursing, has learned that good  beer can be the best medicine.",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/jessica2_cropped-300x300.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "jessica@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Jennifer Degele",
                    Title = "Territory Sales Manager",
                    Desc = "Jailbreak's first territory sales manager and resident brewery sweetheart. Always the first and sometimes the only person to laugh at her own jokes.",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/jen3-300x300.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "jennifer@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Ryan Harvey",
                    Title = "Brewmaster",
                    Desc = "Ryan is the mastermind behind our delicious brews.",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/ryan-300x300.jpeg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "ryan@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Jake Henry",
                    Title = "Beer Evangelist",
                    Desc = "As the \"Jake of all trades\" this guy has  conquered everything from Bartender to Sales Rep. He does it all! & Navy Vet.",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/jake2-e1430694851995-300x300.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "jake@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Jesse Kaiss",
                    Title = "Brewer",
                    Desc = "Project manager turned professional brewer, soon to be barley and hops farmer when not working at the brewery, and Dad to 1 year old Audrey.",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/jesse_cropped.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "jesse@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Tom McGuire",
                    Title = "Beer Evangelist",
                    Desc = "tmac is the nerd of the group making sure  everyone enjoys their awesome beers responsibly!",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/tom-e1430598497766.png",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "tom@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Ross Miller",
                    Title = "Brand Ambassador",
                    Desc = "Idolizes Fitzgerald, Hemingway, and Bukowski for their iconic drinking careers.",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/ross_cropped.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "ross@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Michael Navas",
                    Title = "Brewer",
                    Desc = "Michael is a man of few words.  Any questions?",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/michael_cropped.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "michael@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Johnny Roye",
                    Title = "Beer Evangelist",
                    Desc = "Johnny is the strong one, the bearded  muscle behind the beer.",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/johnny-300x300.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "johnny@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Elizabeth Shear",
                    Title = "Brand Ambassador",
                    Desc = "Liz is our social media liaison by  day and outspoken beer consultant by night. Bring her a cookie. She  loves cookies - #allthecookies",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/liz-300x300.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "elizabeth@jailbreakbrewing.com"

                },
                new JBTeam () {
                    Name = "Erica Turner",
                    Title = "Industrial Engineer",
                    Desc = "One of our original brewers, Erica  now utilizes her OCD to wrangle the process and paperwork sides of our  brewing operations.",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/erica2-e1430599142154-300x300.png",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "erica@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Kasey Turner",
                    Title = "Founder & COO",
                    Desc = "Kasey is the pragmatic engineer of the  group and lives his life one spreadsheet at a time.",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/kasey2-300x300.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "kasey@jailbreakbrewing.com"
                },
                new JBTeam () {
                    Name = "Gina Mattera",
                    Title = "Escape Mastermind",
                    Desc = "A mastermind in the kitchen and in event planning, Gina will plan your perfect escape",
                    PicURL = "https://jailbreakbrewing.com/wp-content/uploads/2013/01/gina_cropped.jpg",
                    OPhone = "443-345-9699",
                    MPhone = "",
                    OEmail = "gina@jailbreakbrewing.com"
                },
            };

            return new CarouselPage
            {
                Title = "Our Team",
                Icon = "Contacts-30.png",
                Children = {
                    new MeetOurFolks (jbt [0]),
                    new MeetOurFolks (jbt [1]),
                    new MeetOurFolks (jbt [2]),
                    new MeetOurFolks (jbt [3]),
                    new MeetOurFolks (jbt [4]),
                    new MeetOurFolks (jbt [5]),
                    new MeetOurFolks (jbt [6]),
                    new MeetOurFolks (jbt [7]),
                    new MeetOurFolks (jbt [8]),
                    new MeetOurFolks (jbt [9]),
                    new MeetOurFolks (jbt [10]),
                    new MeetOurFolks (jbt [11]),
                    new MeetOurFolks (jbt [12]),
                    new MeetOurFolks (jbt [13]),
                    new MeetOurFolks (jbt [14]),
                    new MeetOurFolks (jbt [15])
                }
            };
        }

    }
}
