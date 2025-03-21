using Factory;

class Program
{
    static void Main(string[] args)
    {
        // Robot list
        List<Robot> robotList = new List<Robot>();
        // Person list
        List<Person> personList = new List<Person>();
        //Internet needers list
        List<IInternetConnection> internetList = new List<IInternetConnection>();

        //New Robots
        Computer comp1 = new Computer("Dell", "Computer", true);
        Computer comp2 = new Computer("HP", "Computer", false);
        MechanicalRobot mech1 = new MechanicalRobot("Kerfus", "Mechanical");
        MechanicalRobot mech2 = new MechanicalRobot("Dron", "Mechanical");

        robotList.Add(comp1);
        robotList.Add(comp2);
        robotList.Add(mech1);
        robotList.Add(mech2);

        // Adding only when InternetConnection in Computer is true
        if (comp1.InternetConnection)
            internetList.Add(comp1);
        if (comp2.InternetConnection)
            internetList.Add(comp2);

        //Persons
        PhysicalWorker fiz1 = new PhysicalWorker("Adam","Nowak");
        PhysicalWorker fiz2 = new PhysicalWorker("Pawel","Jumper");
        OfficeWorker biur1 = new OfficeWorker("Pablo","Picasso",true);
        OfficeWorker biur2 = new OfficeWorker("Dirk","Nowicki",false);

        personList.Add(fiz1);
        personList.Add(fiz2);
        personList.Add(biur1);
        personList.Add(biur2);

        //Adding Persons which need internet to list 
        foreach (var person in personList)
        {
            if (person is IInternetConnection ic && ic.InternetConnection)
            {
                internetList.Add(ic);
            }
        }

        // Counting year cost of all robots in company 
        int totalRobotCost = 0;
        foreach (var robot in robotList)
        {
            totalRobotCost += robot.AnnualCost();
        }
        Console.WriteLine("Yearly cost of all robots is: " + totalRobotCost);

        // Yearly cost of all human workers combained
        int totalPeopleCost = 0;
        int months = 12;
        foreach (var person in personList)
        {
            totalPeopleCost += person.Cost(months);
        }
        Console.WriteLine("Yearly cost of all human workers is " + months + " months: " + totalPeopleCost);

        // Checking Internet connection
        Console.WriteLine("Internet is connected with/to:"); //if u has internet connection u need it i guess
        foreach (var worker in internetList)
        {
            Console.WriteLine(worker.ToString());
        }

        Console.WriteLine("Type any key to finish...");
        Console.ReadKey();
    }
}
