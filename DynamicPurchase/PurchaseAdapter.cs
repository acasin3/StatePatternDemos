using System;

namespace DynamicPurchase
{
    public class PurchaseAdapter
    {
        Purchase _currentPurchase = null;
        Purchase _nonVATPurchase = new NonVATPurchase();
        Purchase _vatPurchase = new VATPurchase();

        internal void Load()
        {
            //_currentPurchase.Load();

            throw new NotImplementedException();
        }
    }
}
