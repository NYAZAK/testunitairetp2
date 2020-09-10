using System;

namespace dark_place_game
{

    [System.Serializable]
    /// Une Exeption Custom
    public class NotEnoughtSpaceInCurrencyHolderExeption : System.Exception {}

    public class CantWithDrawNegativeCurrencyAmountExeption : System.Exception {}
    public class CurrencyHolder
    {
        public static readonly string CURRENCY_DEFAULT_NAME = "Unnamed";

        /// Le nom de la monnaie
        public string CurrencyName {
            get {return currencyName;}
            private set {
                currencyName = value;
            }
        }
        // Le champs interne de la property
        private string currencyName = CURRENCY_DEFAULT_NAME;

        /// Le montant actuel
        public int CurrentAmount {
            get {return currentAmount;}
            private set {
                currentAmount = value;
            }
        }
        // Le champs interne de la property
        private int currentAmount = 0;

        /// La contenance maximum du conteneur
        public int Capacity {
            get {return capacity;}
            private set {
                capacity = value;
            }
        }
        // Le champs interne de la property
        private int capacity = 0;

        public CurrencyHolder(string name,int capacity, int amount) {
            Capacity = capacity;
            CurrencyName = name;
            CurrentAmount = amount;


            if(CurrencyName == null || CurrencyName == ""){
                throw new System.ArgumentException("Le nom ne peut pas être null", CurrencyName);
            }

            if(amount < 0){
                throw new ArgumentException("le porte monnaie ne peut pas être initialisé négativement");
            }

            if(CurrentAmount > Capacity){
                throw new NotEnoughtSpaceInCurrencyHolderExeption();
            }

            
            
        }

        public bool IsEmpty() {
            return true;
        }

        public bool IsFull() { 
            if(CurrentAmount == Capacity){
                return true;
            } else {
                return false;
            }    
        }

        public int Store(int amount) {
          return CurrentAmount + amount;
        }

        public int Withdraw(int amount) {
            if(amount < 0 ){
                throw new CantWithDrawNegativeCurrencyAmountExeption();
            } 
           return CurrentAmount - amount;
        }
    }
}
