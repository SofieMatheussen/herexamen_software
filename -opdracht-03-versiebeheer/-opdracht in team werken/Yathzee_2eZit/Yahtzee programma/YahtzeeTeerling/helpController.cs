using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class helpController
    {

        //member die view opvangt
        public helpView _view;
        

        //member die model opvangt public zodat ook view aan kan
        public helpModel _model;

        public helpController()
        {
            _view = new helpView(this);

           _model = new helpModel();
        }

        public helpView getView()
        {
            return _view;
        }
        
    }
}
