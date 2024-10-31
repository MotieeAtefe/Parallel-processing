namespace Thread
{
    internal class Program
    {
      
        static List<Students> GetStudentData() =>
            Enumerable.Range(1,10).Select(i => new Students
            {
                    Id = i,
                    Name = $"Student-{i}"
            }).ToList();
        static async Task<int> ProcessStudentAsync(Students student)
        {
            await Task.Delay(100);
            Console.WriteLine($"Processing data for {student.Name}");
            return student.Id * 2;
        }
        static async Task Main()
        {
            var students = GetStudentData();
        }

    }
}
