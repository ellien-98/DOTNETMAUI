namespace Exercise1_16
{
    public class Pizza : IFood
    {
        public string FoodTitle => "Pizza";
        public int OptionNumber => 3;
        public override string ToString()
        {
            return FoodTitle; 
        }
    }
}

