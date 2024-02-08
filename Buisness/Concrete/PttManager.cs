using Buisness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete
{
    public class PttManager : ISuplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            PttManager pttManager = new PttManager(new PersonManager());
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " ucun maska verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " ucun maska verile bilmez!");
            }
        }

    }
}
