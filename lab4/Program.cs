namespace lab4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //      --Task 1--
            //Test test = new Test();
            //test.TestTextBookCreation();
            //test.TestMagazineCreation();

            //PolymorphismTest polymorphismTest = new PolymorphismTest();
            //polymorphismTest.TestPolymorphism();
        }
    }
}