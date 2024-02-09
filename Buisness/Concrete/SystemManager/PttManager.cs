using Buisness.Abstract;
using Buisness.Abstract.SystemService;
using Buisness.Abstract.SystemService.AdminService;
using Buisness.Concrete.DataBaseManager.FileManager;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete.SystemManager
{
    public class PttManager : ISuplierService,ICommonService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void ControlFile(Person person)
        {
            throw new NotImplementedException();
        }

        public void GiveMask(Person person)
        {
            string dosyaAdi = "CoronaBase.txt";
            if (_applicantService.CheckPerson(person))
            {
                FileWriter.DosyayaYaz(person.FirstName, dosyaAdi);
                Console.WriteLine(person.FirstName + " ucun maska verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " ucun maska verile bilmez!");
            }
        }
    }
}
