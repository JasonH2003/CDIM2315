namespace HW_7;
class Customer{
    private int cus_id ;
    public string cus_name;
    public int cus_age;
    public Customer(int cus_id, string cus_name, int cus_age){
        this.cus_age = cus_age;
        this.cus_name = cus_name;
    }
    public void ChangeID(int new_id){
        cus_id = new_id;
    }
    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age:{cus_age}");
    }
    public void CompareAge(Customer objCustomer){
        if(this.cus_age > objCustomer.cus_age){
            Console.WriteLine($"{this.cus_name} is older");
        }else{
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }
}
class Program{
    public static void Main(string[] arg){
        Customer Alice = new Customer(110, "Alice", 28);
        Alice.ChangeID(110);
        Alice.PrintCusInfo();
        Customer Bob = new Customer(111, "Bob", 30);
        Bob.ChangeID(111);
        Bob.PrintCusInfo();
        Alice.ChangeID(220);
        Alice.PrintCusInfo();
        Bob.ChangeID(221);
        Bob.PrintCusInfo();
        Bob.CompareAge(Alice);

    }
}