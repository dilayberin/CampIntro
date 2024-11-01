using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class ApplyManager
    {
        public void Apply(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Compute();
            foreach (var loggerService in loggerServices) {
                loggerService.Log();
            
            }
        }

        public void CreditInformation(List<ICreditManager> credits)
        {//kredi için ön bilgilendirme. bir kredi seçilirse ne kadar
         //ücret ödenecek ön bilgisi

            //liste gelen her bir kredinin hesabını yapar.
            foreach (ICreditManager credit in credits)
            {
                credit.Compute();
            }
        }
    }
}
