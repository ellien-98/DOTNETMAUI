namespace Exercise3_8
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

