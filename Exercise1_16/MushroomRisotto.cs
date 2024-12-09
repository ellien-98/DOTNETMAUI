namespace Exercise1_16
{
    public class MushroomRisotto : IFood
    {
        public string FoodTitle => "Mushroom Risotto";

        public int OptionNumber => 1; 
        public override string ToString()
        {
            return FoodTitle; 
        }
    }
}

