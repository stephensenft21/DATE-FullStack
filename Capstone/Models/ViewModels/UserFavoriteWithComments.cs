using Capstone.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models.ViewModels
{
    public class UserFavoriteWithComments
    {
        public int FavoriteId { get; set; }
        public string Text { get; set; }
    

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
