using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Accounts.Models
{
    public class MakeJournalHead
    {
        [Key]
        public int Id { get; set; }
        public int EntryJournalId { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        [StringLength(250)]
        public string? Description { get; set; }
        public int MakeJurnalBodyID { get; set; }
        [ForeignKey("MakeJurnalBodyID")]
        public MakeJournalBody MakeJournalBodys { get; set; }
        public int AccountID { get; set; }
        [ForeignKey("AccountID")]
        public Account? accounts { get; set; }

    }
}
