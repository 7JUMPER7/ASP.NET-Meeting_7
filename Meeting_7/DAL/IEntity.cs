using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_7.DAL
{
    public interface IEntity
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string ImageUrl { get; set; }
        int Difficulty { get; set; }
        string Size { get; set; }
        int Time { get; set; }
        string LongDescriptionHeader { get; set; }
        string LongDescription { get; set; }
    }
}
