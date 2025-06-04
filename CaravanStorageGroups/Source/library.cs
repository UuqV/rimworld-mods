using RimWorld;
using Verse;

namespace CaravanScanner
{
    [StaticConstructorOnStartup]
    public static class CaravanScanner
    {
        static CaravanScanner() //our constructor
        {
            Log.Message($"Storage groups: {Current.Game.CurrentMap.storageGroups.HasGroupWithName("Caravan")}"); //Outputs "Hello World!" to the dev console.
        }
    }
}