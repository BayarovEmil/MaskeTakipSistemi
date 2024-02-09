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
    public class SmsManager : IPermitService,ICommonService
    {
        private IApplicantService _applicantService;
        public SmsManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void ControlFile(Person person)
        {
            
        }

        public void GivePermit(Person person)
        {
            string dosyaAdi = "CoronaBase.txt";
            if (_applicantService.CheckPerson(person))
            {
                FileWriter.DosyayaYaz(person.FirstName, dosyaAdi);
                Console.WriteLine(person.FirstName + " ucun icaze verildi!");
            }
            else
            {
                Console.WriteLine(person.FirstName + " tapilmadi!");
            }
        }
    }
}
