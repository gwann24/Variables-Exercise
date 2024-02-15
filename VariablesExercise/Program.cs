namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string clientName = "William";
            int clientAge = 18;
            char salaryCurrency = '$';
            bool highSchoolGrad = true;
            double gpa = 2.97;
            decimal currentSalary = 13.25m;

            Console.WriteLine($"{clientName} is {clientAge} years old.  His high school GPA was {gpa}.  His high school graduation status is {highSchoolGrad}.  He currently makes {salaryCurrency}{currentSalary} per hour working at a local store.");
        }
    }
}
