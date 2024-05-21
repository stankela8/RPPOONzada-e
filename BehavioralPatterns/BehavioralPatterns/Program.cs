using System.Diagnostics;
using System.Threading.Channels;

namespace BehvaioralPatterns
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            //Klijentski kod 1
            RunZ1.Test();

            //Klijentski kod 2
            RunZ2.Test();

            //Klijentski kod 3
            RunZ3.Test();
        }
    }

    /*1. zadatak */
    //Radi se o obrascu ponašanja Observer

    public interface INotifiable 
    {
        public void PushNotification(string message);
    }
    public interface IChannel
    {
        public void Add(INotifiable notifiable);
        public void Remove(INotifiable notifiable);
        public void Notify(string message);
    }

    public class User : INotifiable
    {
        public void PushNotification(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Creator : IChannel
    {
        List<INotifiable> notifiables;
        public Creator()
        {
            notifiables = new List<INotifiable>();
        }
        public void Add(INotifiable notifiable)
        {
            notifiables.Add(notifiable);
        }
        public void Remove(INotifiable notifiable)
        {
            notifiables.Remove(notifiable);
        }
        public void Notify(string message)
        {
            notifiables.ForEach(notifiable =>
            {
                notifiable.PushNotification(message);
            });
        }
    }
    public class RunZ1
    {
        public static void Test()
        {
            IChannel creator = new Creator();
            creator.Add(new User());
            creator.Add(new User());
            creator.Notify("Uploadan je novi video.");
        }
       
    }
    /*2. zadatak */
    //Radi se o obrascu ponašanja memento.
    public class VacationConfigurator
    {
        public string Destination { get; private set; }
        private List<Activity> additionalActivities = new List<Activity>();

        public void SetDestination(string destination)
        {
            Destination = destination;
        }
        public decimal CalculateTotal()
        {
            return additionalActivities.Sum(it => it.Price);
        }

        public void AddExtra(Activity activity)
        {
            additionalActivities.Add(activity);
        }

        public void Remove(Activity activity)
        {
            additionalActivities.Remove(activity);
        }

        public void LoadPrevious(VacationConfiguration configuration)
        {
            Destination = configuration.GetDestination();
            additionalActivities.Clear();
            additionalActivities.AddRange(configuration.GetAdditionalActivities());
        }

        public VacationConfiguration Store()
        {
            return new VacationConfiguration(Destination, additionalActivities);
        }
    }

    public class VacationConfiguration
    {
        private string destination;
        private List<Activity> additionalActivities;
        public VacationConfiguration(string destination, List<Activity> additionalActivities)
        {
            this.destination = destination;
            this.additionalActivities = new List<Activity>(additionalActivities);
        }
        public string GetDestination()
        {
            return destination;
        }

        public List<Activity> GetAdditionalActivities()
        {
            return new List<Activity>(additionalActivities);
        }
    }

    public class ConfigurationManager
    {
        private List<VacationConfiguration> configurations = new List<VacationConfiguration>();

        public void AddConfiguration(VacationConfiguration configuration)
        {
            configurations.Add(configuration);
        }

        public void DeleteConfiguration(VacationConfiguration configuration)
        {
            configurations.Remove(configuration);
        }

        public VacationConfiguration GetConfiguration(int index)
        {
            return configurations[index];
        }
    }
    public class Activity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Activity(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
    public class RunZ2
    {
        public static void Test()
        {
            VacationConfigurator configurator = new VacationConfigurator();
            ConfigurationManager manager = new ConfigurationManager();
            configurator.AddExtra(new Activity("Edukos instrukcije", 110));
            configurator.AddExtra(new Activity("Edukos instrukcije2", 5));
            configurator.SetDestination("Osijek");

            VacationConfiguration savedConfiguration = configurator.Store();
            manager.AddConfiguration(savedConfiguration);


            Console.WriteLine("\nTrentuna ukupna cijena: " + configurator.CalculateTotal());
            configurator.AddExtra(new Activity("Napustanje instrukcija", 1));
            Console.WriteLine("Trentuna ukupna cijena nakon nove aktivnosti: " + configurator.CalculateTotal());

            VacationConfiguration previousConfiguration = manager.GetConfiguration(0);
            configurator.LoadPrevious(previousConfiguration);
            Console.WriteLine("Ukupna cijena nakon vraćanja na prošlu aktivnost: " + configurator.CalculateTotal());
        }
    }
    /* 3. zadatak */
    //Radi se o obrascu ponašanja lanac odgovornosti.
    public abstract class Handler
    {
        public Handler NextHandler;

        public void SetNextHandler(Handler NextHandler)
        {
            this.NextHandler = NextHandler;
        }
        public abstract void DispatchNote(long requestedAmount);
    }

    public class HundredHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 100;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by HundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by HundredHandler");
                }
            }
        }
    }
    public class TwoHunderedHandler : Handler 
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 200;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by TwoHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by TwoHundredHandler");
                }
            }
            long remainingMoney = requestedAmount % 200;
            if (remainingMoney>0)
            {
                NextHandler.DispatchNote(remainingMoney);
            }
        }
    }
    public class FiveHunderedHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 500;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by FiveHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by FiveHundredHandler");
                }
            }
            long remainingMoney = requestedAmount % 500;
            if (remainingMoney > 0)
            {
                NextHandler.DispatchNote(remainingMoney);
            }
        }
    }
    public class RunZ3
    {
        public static void Test()
        {
            Handler hundredHandler = new HundredHandler();
            Handler twoHundredHandler = new TwoHunderedHandler();
            Handler fiveHundredHandler = new FiveHunderedHandler();

            fiveHundredHandler.SetNextHandler(twoHundredHandler);
            twoHundredHandler.SetNextHandler(hundredHandler);

            long amount1 = 1500;
            long amount2 = 700;
            long amount3 = 50;

            Console.WriteLine("\n");
            fiveHundredHandler.DispatchNote(amount1);
            fiveHundredHandler.DispatchNote(amount2);
            fiveHundredHandler.DispatchNote(amount3);
        }
    }
}
