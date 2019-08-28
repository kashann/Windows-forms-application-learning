using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar5
{
    internal delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

    class Stock
    {
        public event PriceChangedHandler PriceChanged; //modificatorul event pt a folosi += & -= in interactiunea cu acest delegate

        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price == value)
                    return; //old and new prices are equal
                var oldPrice = _price;
                _price = value;

                if(PriceChanged != null)
                    PriceChanged(oldPrice, _price);
            }
        }
    }
}
