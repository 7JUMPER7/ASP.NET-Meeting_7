using Meeting_7.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meeting_7.Models
{
    public class QuestsList : IQuestList<Quest>
    {
        private List<Quest> quests;
        public QuestsList()
        {
            quests = new List<Quest>() 
            { 
                new Quest() 
                { 
                    Id = 1, 
                    Title = "DIAMOND HEIST",
                    Description = "Think you’ve got what it takes to be the world’s greatest thief?",
                    ImageUrl = "https://www.mastermindroomescape.com/wp-content/uploads/2019/09/diamond-heist-escape-room-640x0-c-default.jpg",
                    Difficulty = 3,
                    Size = "2-10",
                    Time = 60,
                    LongDescriptionHeader = "The largest diamond in the world is almost in your reach. Do you have what it takes to grab the treasure and get out before the police arrive in this heist escape room?",
                    LongDescription = "**On Saturdays, this room has a minimum initial purchase of at least 4 spots (even if you will only have 2-3 actually playing).  All rooms are private (your group only). Call if you need to add more people after you've made a booking. You can see more about booking and our safety procedures HERE!** Being a person of (devious) action, you’ve pulled together a team of the best thieves around. You have a plan, and it’s time to pull off the biggest diamond heist in history in this heist escape room! Working with your team of 2 - 10 crooks, you have 60 heart-pumping minutes to get the diamond before the police arrive. Execute the plan flawlessly, and you’ll be rich beyond your wildest dreams. Fail, and you’ll all be spending the rest of your life in jail."
                },
                new Quest()
                {
                    Id = 2,
                    Title = "CURSED CASTLE",
                    Description = "Can you save the kingdom from eternal darkness?",
                    ImageUrl = "https://www.mastermindroomescape.com/wp-content/uploads/2019/10/the-castle-escape-room-640x0-c-default.jpg",
                    Difficulty = 3,
                    Size = "2-10",
                    Time = 60,
                    LongDescriptionHeader = "Trouble is afoot in the Cursed Castle escape room! Can you lift the curse and save the kingdom from eternal darkness?",
                    LongDescription = "**On Saturdays, this room has a minimum initial purchase of at least 4 spots (even if you will only have 2-3 actually playing).  All rooms are private (your group only). Call if you need to add more people after you've made a booking. You can see more about booking and our safety procedures HERE!** You all are loyal knights of a benevolent kingdom returning from a faraway journey. As you approach your town, you see dark, ominous clouds. You arrive to find your castle eerily dark, quiet and sealed shut.Local villagers have told you that no one has been seen going in or out for days.Recognizing the classic signs of an evil curse, you decide it is your duty to do whatever you can to lift it, but you won’t be able to survive inside the curse for more than an hour so you must move quickly.If you can lift the curse, you will save your kingdom, BUT if your kingdom will be plunged into darkness and you will be sealed inside the castle forever.You have 60 minutes – Good luck!"
                },
                new Quest()
                {
                    Id = 3,
                    Title = "SECRET SOCIETY",
                    Description = "Will you survive the trials of a Secret Society’s",
                    ImageUrl = "https://www.mastermindroomescape.com/wp-content/uploads/2019/10/secret-society-escape-room-640x0-c-default.jpg",
                    Difficulty = 5,
                    Size = "2-8",
                    Time = 60,
                    LongDescriptionHeader = "You poked your nose where it doesn’t belong and got more than you bargained for. Now, will you be initiated, or eliminated in this suspenseful escape room?",
                    LongDescription = "**All rooms are private (your group only). Call if you need to add more people after you've made a booking. ** You and your friends have been researching an ancient secret society, only to make the startling discovery that they’ve been researching YOU! Soon after making your discovery, you find yourself kidnapped and locked in a room deep within the walls of a medieval castle in this suspenseful escape room. Your only chance for escape is to complete the Initiation Trial successfully.Work together with your group of 2 - 8 initiates to find the clues and solve the puzzles.You’ve got 60 minutes to escape the room. This challenging escape room is full of twists and turns to keep your adrenaline pumping the entire time.Escape and everyone gains membership in the secret society.Can’t complete the Initiation Trial ? Face elimination."
                },
                new Quest()
                {
                    Id = 4,
                    Title = "DAVINCI’S WORKSHOP",
                    Description = "Can you save the Mona Lisa from burglars?",
                    ImageUrl = "https://www.mastermindroomescape.com/wp-content/uploads/2019/10/davinci-escape-room-640x0-c-default.jpg",
                    Difficulty = 2,
                    Size = "2-8",
                    Time = 60,
                    LongDescriptionHeader = "Thieves are on their way to steal the Mona Lisa right now! Can you get to the painting first and save DaVinci’s greatest work of art in this St. Charles escape room?",
                    LongDescription = "**All rooms are private (your group only). Call if you need to add more people after you've made a booking. ** The year is 1519. Leonardo DaVinci has just received word via carrier pigeon that thieves are en route to ransack his workshop and steal the Mona Lisa in this St. Charles escape room. On hearing the shocking news, the artist is pleading for somebody…anybody…to save his famous painting.Working with your team of 2 - 8 heroes, you have 60 exhilarating minutes to get the masterpiece to safety before the thieves arrive. Complete this beginner - level escape room to save the painting, and DaVinci will reward you handsomely.Arrive after the thieves and the Mona Lisa will be lost forever."
                },
            };
        }

        public void Create(Quest item)
        {
            quests.Add(item);
        }

        public bool Delete(int id)
        {
            return quests.Remove(GetItem(id));
        }

        public IEnumerable<Quest> GetAll()
        {
            return quests;
        }

        public Quest GetItem(int id)
        {
            return quests.Find(q => q.Id == id);
        }
    }
}