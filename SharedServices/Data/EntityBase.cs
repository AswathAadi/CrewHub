using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SharedServices.Data
{
    [Serializable]
    [StreamSqlChanges]
    public class EntityBase<TEntityKey> : IEntity<TEntityKey>
    {
        public EntityBase()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            IsActive = true;
        }

        [Key]
        [Required]
        [Column("id")]
        public TEntityKey Id { get; set; }

        [Required]
        [Column("created_by")]
        public string CreatedBy { get; set; }

        [Required]
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Column("updated_by")]
        public string UpdatedBy { get; set; }

        [Required]
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }

        [Required]
        [Column("is_active")]
        public bool? IsActive { get; set; }
    }
}
