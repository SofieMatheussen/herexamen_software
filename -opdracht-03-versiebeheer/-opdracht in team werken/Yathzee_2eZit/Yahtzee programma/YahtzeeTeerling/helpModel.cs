using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
   public class helpModel
    {
        //onthoud de true of false van help
        Boolean isclicked = true;

        public Boolean isClicked
        {
            //waarde bool opvragen
            get
            {
                return isclicked; 
            }
            set
            {
                isclicked = value;
            }
        }
    }
}
