using Postgrest.Attributes;
using Postgrest.Models;

namespace api.Controllers
{
    [Table("test")]
    public class TestModel : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
        
        public Test AsTest()
        {
            return new Test()
            {
                Id = Id,
                Name = Name
            };
        }
    }

    public class Test
    {
        public int Id { get; init; }
        public string Name { get; init; }
    }
}
