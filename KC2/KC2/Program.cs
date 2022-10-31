namespace KC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Corvette>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myCorvette = new Corvette();

                Console.WriteLine("Enter the color for your Corvette: ");
                myCorvette.Color = Console.ReadLine();
                Console.WriteLine("Enter the top speed for your Corvette");
                myCorvette.TopSpeed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the model type of your Corvette");
                myCorvette.ModelType = Console.ReadLine();



                recordList.Add(myCorvette);
            }

            // Print out the list of records using Console.WriteLine()
            foreach(var record in recordList)
                Console.WriteLine(record.ToString());

        }
    }
}