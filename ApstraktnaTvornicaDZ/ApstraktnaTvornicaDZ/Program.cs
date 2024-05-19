using ApstraktnaTvornicaDZ;
using static ApstraktnaTvornicaDZ.Interfaces;
using static ApstraktnaTvornicaDZ.KonkretniLikovi_Tvornice;

public class Program
{
    public static void Main(string[] args)
    {
        IFactory fireFactory = new FireLevelFactory();
        GameManager fireGameManager = new GameManager(fireFactory);
        fireGameManager.PlayLevel();


        IFactory waterFactory = new WaterLevelFactory();
        GameManager waterGameManager = new GameManager(waterFactory);
        waterGameManager.PlayLevel();
    }
}