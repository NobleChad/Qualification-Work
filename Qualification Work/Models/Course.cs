using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qualification_Work.Models
{
    public class Course
    {
        private static Random random = new Random();

        public int Id { get; set; }

        public string Name { get; set; }

        public int PublicKey { get; set; }

        public Course()
        {
            PublicKey = random.Next(1000, 9999); 
        }
    }
}
