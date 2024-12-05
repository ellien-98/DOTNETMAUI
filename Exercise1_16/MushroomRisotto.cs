namespace Exercise1_16
{
    public class MushroomRisotto : IFood
    {
        public string FoodTitle => "MushroomRisotto";

        public int OptionNumber => 1; 
        public override string ToString() {
            return "Mushroom Risotto";  
        }
    }
}

