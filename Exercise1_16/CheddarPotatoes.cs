namespace Exercise1_16
{
    public class CheddarPotatoes : IFood
    {
        public string FoodTitle => "Cheddar Potatoes";
        public int OptionNumber => 2;
        public override string ToString()
        {
            return FoodTitle; 
        }
    }
}

