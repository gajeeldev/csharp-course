partial class Program
{
  static void ManageDateTime()
  {
    DateTime now = DateTime.Now;
    DateTime today = DateTime.Today;
    DateTime oneWeekAgo = DateTime.Now.AddDays(-7);
    DateTime customDate = new DateTime(2025, 6, 1);
    DayOfWeek weekday = now.DayOfWeek;

    Console.WriteLine($"Now: {now} \nToday: {today} \nOne week ago: {oneWeekAgo} \nCustom date: {customDate} \nDay of the week: {weekday}");

  }
}