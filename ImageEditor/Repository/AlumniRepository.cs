using AlumniDigitalIDCreator.Model;
using AlumniDigitalIDTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static AlumniDigitalIDCreator.Model.Alumni_model;

namespace AlumniDigitalIDCreator.Repository
{
    public class AlumniRepository
    {
        public static ModelDataContext modeldb;

        public AlumniRepository()
        {
            modeldb = new ModelDataContext();
        }

        public List<AlumniList_model> Get(string _process)
        {
            return (from d in modeldb.USP_I_ALUMNI(_process)                        
                    select d).AsEnumerable()
                    .Select(x => new AlumniList_model()
                    {
                        StudenId = int.Parse( x.student_id.ToString()),
                        UserId   = int.Parse(x.user_id.ToString()),
                        AlumniGroupId = int.Parse( x.alumni_group_id.ToString()),
                        AlumniNo = x.alumni_no,
                        AlumniName = x.alumni_name,
                        Degree = x.course_name,
                        Batch = x.year_graduated,
                        MemberType = x.member_type,
                        Expiration = x.member_type == "Lifetime Member" ? "" : x.expiration_date,
                        StudentGUID = x.student_guid,
                        Id = int.Parse(x.id.ToString())
                    }).ToList();

        }


        public void LogProcess(int _id, string _process, int _userid)
        {
            modeldb.USP_SYSTEM_LOG_PROCESS(_id, _process, _userid);
        }

        public string EmailUser(int _userid)
        {
            string _result = "";
            modeldb.CommandTimeout = 0;

            modeldb.USP_SYS_EMAIL_USER_ACCOUT(_userid,
                ref _result);

            return _result.ToString();
        }


        public bool HashPassword(int _userid, string _password, string _pin)
        {
            try
            {
                modeldb.USP_SYSTEM_HASH_PASSWORD(_userid, _password, _pin);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string PasswordHasher(string _keyword)
        {
            UnicodeEncoding Ue = new UnicodeEncoding();

            byte[] ByteSourceText = Ue.GetBytes(_keyword);
            MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
            byte[] ByteHash = Md5.ComputeHash(ByteSourceText);
            return Convert.ToBase64String(ByteHash);
        }
    }
}
