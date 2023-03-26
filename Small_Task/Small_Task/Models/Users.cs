using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Small_Task.Models
{
    public class Users
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name does not exist")]
        public string UserName { set; get; }
    }
}
