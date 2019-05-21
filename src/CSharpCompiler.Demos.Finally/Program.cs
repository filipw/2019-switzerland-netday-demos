using System;

namespace CSharpCompiler.Demos.Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            ProvisionAzureResourcesForALotOfMoney();

            try
            {
                DoStuff();
            } 
            finally
            {
                DeprovisionAzureResources();
            }
        }

        static void ProvisionAzureResourcesForALotOfMoney()
        {
            Console.WriteLine("Provisioned resources costing 10 000$ per minute.");
        }

        static void DeprovisionAzureResources()
        {
            Console.WriteLine("Deprovisioned Azure resources. Saved you money.");
        }

        static void DoStuff()
        {
            throw new Exception("Do Stuff failed");
        }

        static void DoStuffEvil()
        {
            Environment.FailFast(null);
        }
    }
}
