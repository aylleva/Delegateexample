namespace DelegateTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Exam> exams = new List<Exam> {

              new Exam {Subject="English",ExamDuration=1,StartDate=new DateTime(2024, 9, 5, 2,30,00) },
              new Exam {Subject = "Programming", ExamDuration = 2, StartDate = new DateTime(2024, 10, 13, 1, 30, 15) } ,
              new Exam {Subject="Math",ExamDuration=3,StartDate=new DateTime(2024, 10, 21, 2,00,30) },
              new Exam {Subject="AI",ExamDuration=7,StartDate=new DateTime(2024, 10, 24, 12,30,00) },
              new Exam {Subject="Physics",ExamDuration=4,StartDate=new DateTime(2024, 10, 29, 22,00,15) }

            };


            List<Exam> time=exams.FindAll(times => times.StartDate >new DateTime(2024, 10, 22, 00, 00, 00));
            time.ForEach(day => Console.WriteLine(day.Subject + " " + day.ExamDuration));

            Console.WriteLine("\n");

            List<Exam> hours=exams.FindAll(hour=>hour.ExamDuration>2);
            hours.ForEach(h => Console.WriteLine(h.Subject+" :"+h.StartDate+"- Time: "+h.ExamDuration));

            Console.WriteLine("\n");

            List<Exam> exams1 = exams.FindAll(exam=>exam.EndDate>DateTime.Now);
            exams1.ForEach(exam => Console.WriteLine(exam.Subject + " " + exam.ExamDuration + "-- ends:" + exam.EndDate));
        }

    }
}