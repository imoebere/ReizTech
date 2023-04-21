namespace Clock_Angle
{

    public class Program
    {

        public static void Main(string[] args)
        {

            var _clock = new Clock();
            Console.WriteLine("Enter hours (0-12): ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter minutes (0-59): ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            double angle = _clock.CalculateClockAngle(hours, minutes);
            Console.WriteLine($"The lesser angle between the hour and minute hands is: {angle} degrees");
        }

    }
}
