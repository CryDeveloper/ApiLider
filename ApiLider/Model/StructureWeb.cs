using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLider.Model
{
    [Table ("web")]
    public class StructureWeb
    {
        [Column ("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Imy { get; set; }
        [Column("age")]
        public int Age { get; set; }
    }
}
