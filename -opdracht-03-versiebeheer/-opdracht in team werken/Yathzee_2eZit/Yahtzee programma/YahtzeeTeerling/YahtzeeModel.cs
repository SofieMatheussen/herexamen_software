 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class YahtzeeModel
    {
        int aantalWorpen;



        //waarde voor aantal worpen ophalen
        public int AantalWorpen
        {
            get
            {
                return aantalWorpen;
            }
            set
            {
                aantalWorpen = value;
            }
        }
    }
}
