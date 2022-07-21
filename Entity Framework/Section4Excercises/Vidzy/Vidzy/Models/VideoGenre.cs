using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidzy
{
    public class VideoGenre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column(Order = 0), ForeignKey("Video")]
        public int Video_Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column(Order = 1), ForeignKey("Genre")]
        public int Genre_Id { get; set; }
        public Video Video { get; set; }
        public Genre Genre { get; set; }
    }
}
