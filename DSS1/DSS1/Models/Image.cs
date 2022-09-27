using System.ComponentModel.DataAnnotations.Schema;

namespace DSS1.Models
{
    public class Image
    {

        public string Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
