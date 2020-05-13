using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    [DataContract]
    public partial class PostDTO
    {
        public PostDTO()
        {
            this.Comments = new List<CommentDTO>();
        }
        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public virtual List<CommentDTO> Comments { get; set; }
        public string Domain { get; internal set; }
        public string Description { get; internal set; }
        public string Date { get; internal set; }
    }

}
