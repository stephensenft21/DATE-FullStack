using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models.Data
{
    public class Comment
    {
        public int CommentId { get; set; }
        [Key]
        [Required(ErrorMessage = "Please Add Your Comment")]
        public string Text { get; set; }
      /*  [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime TimeStamp { get; set; }
        [Required]*/
        public int FavoriteId { get; set; }
        public string ApplicationUserId { get; set; }


    }
}
