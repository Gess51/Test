using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH_RU.Models
{
    public class Person
    {
        public required string PersonId { get; set; }
		public int? PEOPLE_CODE { get; set; }
        public required string Lastname { get; set; }
        public required string Firstname { get; set; }
        public string? Patronymic { get; set; }
        public string? Dost { get; set; }
        public int Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string? Birthplace { get; set; }
        public string? BirthOksm { get; set; }
        public string? Snils { get; set; }
        public string? ContactTel { get; set; }
        public string? ContactMobtel { get; set; }
        public string? Email { get; set; }
        public DateTime? DeathDate { get; set; }
        public int IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatorId { get; set; }
        public DateTime EditDate { get; set; }
        public int EditorId { get; set; }
        public int? Tezka { get; set; }
        public int Kl { get; set; }
        public required string CtznOksm { get; set; }
        public int NoCitizenship { get; set; }


    }
}
