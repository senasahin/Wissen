using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wissen.Model
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Posts = new HashSet<Post>();
        }
<<<<<<< HEAD
        [Display(Name ="Ad")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        [Required]
=======
        [Display(Name = "Ad")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
        public string Description { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
