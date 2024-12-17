namespace Exercise3_8
{
    public class CheddarPotatoes : IFood
    {
        public string FoodTitle => "CheddarPotatoes";
        public int OptionNumber => 2;
        public override string ToString()
        {
            return FoodTitle; 
        }
    }
}

