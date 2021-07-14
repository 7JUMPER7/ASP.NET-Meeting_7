using Meeting_7.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meeting_7.Models
{
    public class QuestEFRepository : IQuestList<Quest>
    {
        private readonly QuestsContext context;
        public QuestEFRepository(QuestsContext context)
        {
            this.context = context;
        }

        public void Create(Quest item)
        {
            context.Quests.Add(item);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            if (context.Quests.Remove(context.Quests.Find(id)) != null)
            {
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Quest> GetAll()
        {
            return context.Quests;
        }

        public Quest GetItem(int id)
        {
            return context.Quests.Find(id);
        }

        public Quest Update(Quest item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return item;
        }
    }
}