namespace Exercise1_16
{
    public class Catalog
    {
        public static IFood[] GetMenuItems()
        {
            return new IFood[] {
                new MushroomRisotto(),
                new CheddarPotatoes(),
                new Pizza() };
        }
    }
    
}
