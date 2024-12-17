namespace Exercise3_8
{
    public class Catalog
    {
        public static IFood[] GetMenuItems() {
            return new IFood[] {
                new MushroomRisotto(),
                new CheddarPotatoes(),
                new Pizza() };
        }
    }
    
}
