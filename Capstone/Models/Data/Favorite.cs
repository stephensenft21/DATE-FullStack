using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models.Data
{
    public class Favorite
    {

        
        public int FavoriteId { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
