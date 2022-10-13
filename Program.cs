namespace Hw6;

//Q1
class Professor{
    public string profName;
    public string classTeach;
    public double salary;
    public string order;

    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
        return salary;
    }
    public void PrintInfo(){
        Console.WriteLine($"The {order} professor is called {profName}, they teach {classTeach}, her salary is {salary};");
    }
    public void PrintInfo2(){
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary}");
    }

    


}

class Student{
    public string studentName;
    public string classEnroll;
    public double studentGrade;
    public string order;

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }
    public void PrintInfo(){
        Console.WriteLine($"The {order} student is called {studentName}, they are enrolled in {classEnroll}, and their grade is {studentGrade};");
    }
    public void PrintInfo2(){
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}; and the grade is: {studentGrade}");
    }
}

class program{
    static void Main(string[] args){
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.salary = 9000;
        p1.order = "first";
        p1.PrintInfo();

        
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.salary = 8000;
        p2.order = "second";
        p2.PrintInfo();
        
        
        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.studentGrade = 90;
        s1.order = "first";
        s1.PrintInfo();

        

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.studentGrade = 80;
        s2.order = "second";
        s2.PrintInfo();

        //Q2

        p1.PrintInfo2();
        p2.PrintInfo2();
        s1.PrintInfo2();
        s2.PrintInfo2();

        double diff = 0;

        if(p1.salary > p2.salary){
            double D = p1.salary - p2.salary;
            diff += D;
            Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: {diff}");
        }else{
            double P = p1.salary =- p2.salary;
            diff += P;
            Console.WriteLine($"The salary difference between {p2.profName} and {p1.profName} is : {diff}");
        }

        double GradeTotal;

        GradeTotal = s1.studentGrade + s2.studentGrade;

        Console.WriteLine($"The total grade of Lisa and Tom is: {GradeTotal}");



    }
}


