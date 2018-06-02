using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Product
{
   public class Product
    {

        private string _Name;
        private double _Weight;
        private double _Price;
        private string _Date;
        public Category category;
        private int ID;

        public Product()
        {
            ID = 0;
        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                {
                    value = _Name;
                }

            }
        }

        public double Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                if (value > 0)
                {
                    value = _Weight;
                }

            }
        }
        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (value > 0)
                {
                    value = _Price;
                }
            }
        }
        public string Date
        {
            get
            {
                return _Date;
            }
            set
            {
                if (value.Length == 6)
                {
                    value = _Date;
                }

            }
        }

    }
}
