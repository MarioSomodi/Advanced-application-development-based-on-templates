using System.Collections;

namespace ObserverDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvailableStoreSuppliments availableStoreSuppliments = new AvailableStoreSuppliments();

            ISubscriber subscriber1 = new Subscriber("UK store");
            ISubscriber subscriber2 = new Subscriber("US store");


            availableStoreSuppliments.Subscribe(subscriber1);
            availableStoreSuppliments.Subscribe(subscriber2);


            availableStoreSuppliments.Add("Creatine");
            availableStoreSuppliments.Add("Protein");
            availableStoreSuppliments.Add("Vitamin C");
            availableStoreSuppliments.Remove("Vitamin C");
            ArrayList suppliments = availableStoreSuppliments.Update("Protein Isolate", 1);

            Console.WriteLine("Underlying arraylist after all actions contains: ");
            for (int index = 0; index < suppliments.Count; index++)
            {
                Console.WriteLine($"At index: {index} \nValue:{suppliments[index].ToString()}");
            }

            availableStoreSuppliments.Unsubscribe(subscriber1);
            availableStoreSuppliments.Unsubscribe(subscriber2);

        }
    }
}