using Source.Models;

namespace Source.Repository;

public class FakeRepo
{
    public static List<Student> GetStudents()
    {
        return new()
        {
            new(1, @"avatar1.png", "Vasif", "Babazade", "Asif", new DateTime(2022, 10, 4), ParticipationStatus.Unknown, null, null, null, null),
            new(2, @"", "Royal", "Beledli", "Qudret", new DateTime(2022, 10, 5), ParticipationStatus.Absent, null, null, null, null),
            new(3, @"avatar1.png", "Emin", "Novruz", "Zaur", new DateTime(2022, 10, 5), ParticipationStatus.Present, null, null, null, null),
            new(4, @"", "Huseyn", "Hemidov", "Reshadet", new DateTime(2022, 10, 6), ParticipationStatus.Late, null, null, null, null),
        };
    }
}