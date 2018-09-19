using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
    class Car : IMachine
    {
        // Abstruct'da ezmek zorundasın. İçerisini doldurmak zorundasın
        // Interface'de içi boş olucak. Ama çağırdığımızda doldurmalıyız. Ve hepsini getirmek zorundayız.
        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        private string _brand;
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

      
    }
}
