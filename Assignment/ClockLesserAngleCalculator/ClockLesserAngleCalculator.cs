/// <summary>
/// Calculates the lesser angle between the hour and minute hands of a clock.
/// </summary>
internal class ClockLesserAngleCalculator
{
    /// <summary>
    /// Calculates the lesser angle between the hour and minute hands of a clock.
    /// </summary>
    /// <param name="hour">The hour to input.</param>
    /// <param name="minute">The minute to input.</param>
    /// <returns>The degree of the lesser angle as an integer data type.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static int Calculate(int hour, int minute)
    {
        int angle;
        int hourAngle;
        int minuteAngle;

        if (hour < 0 || hour > 12)
        {
            throw new ArgumentException("Hour must be between 0 and 12");
        }

        if (minute < 0 || minute > 60)
        {
            throw new ArgumentException("Minute must be between 0 and 60");
        }

        hourAngle = (hour * 360) / 12;
        minuteAngle = (minute * 360) / 60;

        angle = Math.Abs(hourAngle - minuteAngle);

        if (angle > 180)
        {
            angle = 360 - angle;
        }

        return angle;
    }
}