using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Product
{
   public class Category
    {

        private string _Name;
        private int ID;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value.Length >= 2 && value.Length >= 50)
                {
                    value = _Name;
                }
            }
        }

    }
}
