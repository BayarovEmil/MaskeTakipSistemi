using Buisness.Abstract.SystemService.AdminService;
using Buisness.Concrete.HumanManager;
using Buisness.Concrete.SystemManager;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAround2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "ENGİN";
            person.LastName = "DEMİROĞ";
            person.DateOfBirth = 1985;
            person.NationalIdentity = 28861499108; 

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);

            
            //Sistemə yeni dəyişiklik gəlir.Artıq SmsManager Yaradilir
            //her kes disariya gunluk bir kez cika bilir
            //bunun icinde mernis dogrulamasi kullanilmalidir
            SmsManager smsManager = new SmsManager(new PersonManager());
            smsManager.GivePermit(person);

            

            Console.ReadLine();
        }
    }
}
