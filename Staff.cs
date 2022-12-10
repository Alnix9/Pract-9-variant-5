using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Генеральский_практическая_9
{
    struct Staff
    {
        public string FIO { get; set; }
        public string Gender { get; set; }
        public string Post { get; set; }
        public int WorkExperience { get; set; }
        public int Salary { get; set; }
        public Staff(string fio,string gender,string post,int workexperience,int salary)
        {
            FIO = fio;
            Gender = gender;
            Post = post;
            WorkExperience = workexperience;
            Salary = salary;
        }
        public override string ToString()
        {
            return $" {FIO}, {Gender}, {Post}, {WorkExperience}, {Salary}"; ;
        }
    }
}
