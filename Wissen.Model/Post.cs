using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wissen.Model
{
    public class Post:BaseEntity
    {
      
        
        public string Title { get; set; }
<<<<<<< HEAD
       
        [DataType(DataType.MultilineText)]
   
        public string Description { get; set; }

=======
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
