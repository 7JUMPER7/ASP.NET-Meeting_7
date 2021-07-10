using Meeting_7.DAL;
using Meeting_7.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meeting_7.Utils
{
    public class NinjectReg : NinjectModule
    {
        public override void Load()
        {
            Bind<IQuestList<Quest>>().To<QuestsList>().InSingletonScope();
        }
    }
}