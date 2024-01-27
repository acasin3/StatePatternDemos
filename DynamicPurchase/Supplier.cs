namespace DynamicPurchase
{
    public class Supplier
    {
        private string _registrationType;

        public Supplier(string RegistrationType)
        {
            _registrationType = RegistrationType;
        }

        public string RegistrationType
        {
            get { return _registrationType; }
        }
    }
}