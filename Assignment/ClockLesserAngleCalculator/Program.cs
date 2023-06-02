try
{
    Console.WriteLine("Enter hour: ");
    int hour = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter minute: ");
    int minute = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Angle between {hour} and {minute} is {ClockLesserAngleCalculator.Calculate(hour, minute)} degrees");

}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
