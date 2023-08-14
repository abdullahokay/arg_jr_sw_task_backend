using System.ComponentModel.DataAnnotations;

namespace Task.Entities
{
    public class User
    {
        [Key, Required]
        public int Id { get; set; }
        public String name {  get; set; }
        public String eMail { get; set; }
        public String lastName { get; set; }
        public String birthDay { get; set; }
    }
}