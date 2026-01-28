using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH_RU.Models
{
    public class Dul
    {
        public Guid DudlId { get; set; }
		public required string PersonId { get; set; }
        public string? DudlSer { get; set; }
        public required string DudlNum { get; set; }
        public DateTime? DudlDateB { get; set; }
        public DateTime? DudlDateE { get; set; }
        public int DudlType { get; set; }
        public string? Lastname { get; set; }
        public string? Firstname { get; set; }
        public string? Patronymic { get; set; }
        public string? Issuer { get; set; }
        public string? IssuerOksm { get; set; }
        public required string CtznOksm { get; set; }
        public int? NoCitizenship { get; set; }
        public DateTime Birthday { get; set; }
        public string? BirthOksm { get; set; }
        public string? Birthplace { get; set; }
        public int Sex { get; set; }
		public int? IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatorId { get; set; }
        public DateTime? EditDate { get; set; }
        public int? EditorId { get; set; }
        public string? ReasonEdit { get; set; }
        public string? CodeUnit { get; set; }
        public string? DefaultcodeUnit { get; set; }
    }
}
