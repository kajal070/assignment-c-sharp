using System;
interface IPrintable
{
    void details_of_Employee();
}
public class Employee :IPrintable 
{
    protected int EmpNo;
    protected string EmpName;
	protected double Salary;
	protected double HRA;
	protected double TA;
	protected double DA;
	protected double PF;
	protected double TDS;
	protected double NetSalary;
    protected double  GrossSalary;
    protected double grossSalary;
     public void EAdd ()
      {
        Console.WriteLine("...Adding new employee details...");
      }
     public void Add ()
      {
        Console.WriteLine("\nEnter employee Name:");
         EmpName= Console.ReadLine();
         Console.WriteLine("\nEnter employeeid:");
         EmpNo=int.Parse(Console.ReadLine());
         Console.WriteLine("\nEnter employee Salary:");
         Salary=double.Parse(Console.ReadLine()); 
              if(Salary<5000)
          {
              HRA=10*Salary/100;
              TA=5*Salary/100;
              DA=15*Salary/100;
              GrossSalary = Salary + HRA + TA + DA;
              grossSalary = Salary + HRA + TA + DA;
          }
          else if(Salary<10000&&Salary>=5000)
          {
              HRA=15*Salary/100;
              TA=10*Salary/100;
              DA=20*Salary/100;
              GrossSalary = Salary + HRA + TA + DA;
              grossSalary = Salary + HRA + TA + DA;
          }
          else if(Salary<15000&&Salary>=10000)
          {
              HRA=20*Salary/100;
              TA=15*Salary/100;
              DA=25*Salary/100;
              GrossSalary = Salary + HRA + TA + DA;
              grossSalary = Salary + HRA + TA + DA;
          }
          else if(Salary<20000&&Salary>=15000)
          {
              HRA=25*Salary/100;
              TA=20*Salary/100;
              DA=30*Salary/100;
              GrossSalary = Salary + HRA + TA + DA;
              grossSalary = Salary + HRA + TA + DA;
          }
          else if(Salary>=20000)
          {
              HRA=30*Salary/100;
              TA=25*Salary/100;
              DA=35*Salary/100;
              GrossSalary = Salary + HRA + TA + DA;
              grossSalary = Salary + HRA + TA + DA;
          }
      }
      public virtual void CalculateSalary()
      {
          PF = 10 * GrossSalary/100;
           Console.WriteLine(PF);
          TDS = 18 * GrossSalary/100;
          NetSalary = (GrossSalary-(PF + TDS));
      }
      public void details_of_Employee()
      {
         Console.WriteLine("\nEmployee Details") ;
         Console.WriteLine("\nEmployee ID:"+EmpNo) ;
          Console.WriteLine("\nEmployee Name:"+EmpName) ;
           Console.WriteLine("\nEmployee Salary:"+Salary) ;
            Console.WriteLine("\nEmployee GrossSalary:"+grossSalary) ;
             Console.WriteLine("\nEmployee NetSalary:"+NetSalary) ;
      }
}
    public class Manager:Employee
    {
        private double	PetrolAllowance;
        private double FoodAllowance; 
        private double OtherAllowances;
         public void MAdd ()
      {
        Console.WriteLine("... Manager details...");
      }
        public void calgs()
        {
            PetrolAllowance=8*Salary/100;
            FoodAllowance=13*Salary/100;
            OtherAllowances=3*Salary/100;
            GrossSalary=Salary+PetrolAllowance+FoodAllowance+OtherAllowances;
             Console.WriteLine(GrossSalary);
        }
        public override void CalculateSalary()
        {
          PF = (10 * grossSalary/100);
          Console.WriteLine(PF);
          TDS = 18 * GrossSalary/100;
           Console.WriteLine(TDS);
          NetSalary = (GrossSalary-(PF + TDS));
        }
    }
    public class MarketingExecutive:Employee
    {
        private double	Kilometertravel;
	    private double TourAllowances ;
         private double	TelephoneAllowances ;
          public double tp
         {
             get
             {
                 return TelephoneAllowances;
             }
             set
             {
                 TelephoneAllowances=1000;
             }
         }
          public void MEAdd ()
      {
        Console.WriteLine("...MarketExecutive details...");
      }
         public void gss()
         {
           Console.WriteLine("\nEnter kilometer Travel:"); 
           Kilometertravel=double.Parse(Console.ReadLine());
           TourAllowances= 5*Kilometertravel;
           GrossSalary=GrossSalary+ TourAllowances +TelephoneAllowances;
         }
          public override void CalculateSalary()
        {
          PF = (10 *grossSalary/100);
          NetSalary = (grossSalary-(PF + TDS));
        }
    }
      class EmployeeManagementSystem
      {
           public static void Main(string[] args)
    {
        int num;
         Console.WriteLine("...Enter your choice...");
        Console.WriteLine(" Enter 1 for Add new employee details:\n");
        Console.WriteLine(" Enter 2 for get Manager details:\n");
        Console.WriteLine(" Enter 3 for get Market Executive details:\n");
        num=int.Parse(Console.ReadLine());
        switch(num)
        {
            case 1:
            Employee em=new Employee();
            em.EAdd();
            em.Add();
            em.CalculateSalary();
            em.details_of_Employee();
            break;
            case 2:
            Manager Mg= new Manager();
            Mg.MAdd();
            Mg.Add();
            Mg.calgs();
            Mg.CalculateSalary();
            Mg.details_of_Employee();
             break;
             case 3:
             MarketingExecutive ME=new MarketingExecutive();
             ME.MEAdd();
             ME.Add();
             ME.gss();
             ME.CalculateSalary();
             ME.details_of_Employee();
             break;
             default:
             Console.WriteLine("You have entered invalid number");
             break;
        }
    }
}