using System.ComponentModel.DataAnnotations.Schema;

namespace DSS1Assignment.Models
{
    public class Image
    {

        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
