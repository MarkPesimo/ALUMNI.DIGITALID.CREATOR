using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniDigitalIDCreator.Model
{
    public class Alumni_model
    {
        public class AlumniList_model
        {
            public int StudenId { get; set; }
            public int UserId { get; set; }
            public int AlumniGroupId { get; set; }
            public string AlumniNo { get; set; }
            public string AlumniName { get; set; }
            public string Degree { get; set; }
            public string Batch { get; set; }
            public string MemberType{ get; set; }
            public string Expiration { get; set; }
            public string StudentGUID { get; set; }
            public int Id { get; set; }
        }
    }
}
