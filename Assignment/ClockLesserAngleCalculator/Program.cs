int hour;
int minute;  

try
{
    Console.WriteLine("Enter hour: ");
    hour = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter minute: ");
    minute = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Angle between {hour} and {minute} is {ClockLesserAngleCalculator.Calculate(hour, minute)} degrees");

}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
