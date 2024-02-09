using Buisness.Abstract;
using Buisness.Concrete.DataBaseManager.FileManager;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete.HumanManager
{
    public class PersonManager : IApplicantService
    {
        public bool CheckPerson(Person person)
        {
            if(!(FileReader.IsContains(person.FirstName, "CoronaBase.txt")))
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                return client.TCKimlikNoDogrulaAsync(
                    new TCKimlikNoDogrulaRequest
                    (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirth)))
                    .Result.Body.TCKimlikNoDogrulaResult;
            }
            else
            {
                return false;
            }
        }

        public void ControlFile(Person person)
        {
            string dosyaAdi = "CoronaBase.txt";
            if (CheckPerson(person))
            {
                FileWriter.DosyayaYaz(person.FirstName, dosyaAdi);
            }

        }
    }
}
