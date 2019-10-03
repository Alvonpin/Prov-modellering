using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_rundläggande_modellering
{
    class Customers
    {
        
        private string name; 
        private string intrest; //I syfte att spelaren skall kunna sälja böcker till kunder till högre priser har är kunderna intreserade av särkillda bokkategorier
        private int money; //Kunder har pengar för att betala spelaren för de böcker hen köper
        private List<string> Books; //Om kunden redan äger böcker är intresset för boken i fråga mycket låg
        private bool collector; // Beroende på kundens typ kan vara intresserad av att köpa samma bok igen om hen är sammlare 

    }
}
