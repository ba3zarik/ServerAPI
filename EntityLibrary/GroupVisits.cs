using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    class GroupVisits
    {
        public int Id { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public string Purpose { get; set; }
        public int Division { get; set; }
        public string Employee { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Organization { get; set; }
        public string Note { get; set; }
        public DateTime Birthday { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public int ClientId { get; set; }
    }
}
