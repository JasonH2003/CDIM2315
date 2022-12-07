namespace Final_Project;

class Program
{
    
    
    
    static void Main(string[] args)
    {
        
        //Opener
        Console.WriteLine("------CIDM2315 Final Project: Jason Harris-----");
        Console.WriteLine("------Welcome to Buff Kitchen-----");

        //UI
        bool is_user = User_reader();
        while(is_user==true){
            Console.WriteLine("*******************");
            Console.WriteLine("Please select and option: ");
            Console.WriteLine("1. Start new order");
            Console.WriteLine("2. Check submitted orders");
            Console.WriteLine("3. Remove Finished orders");
            Console.WriteLine("4. Log out");
            Console.WriteLine("*******************");

//////////////////////////////////////////////////////////////////////////////    

        //Navigator
        string options = Console.ReadLine();
            if(options=="1"){
               place_order();
            }
            else if(options == "2"){
               submitted_orders();
               
            }
            else if(options =="3"){
                take_off_order();
            }
            else if(options == "4"){
                Console.WriteLine("->Logging out");
                break;
            }
            else{
                Console.WriteLine("Not valid option, please try again");
            }
            }
        }
////////////////////////////////////////////////////////////////
     //Login function
        public static bool User_reader(){

            string correct_user = "Alice";
            int correct_pass =  123;
            int loginAttempts = 0;

                 
                for (int i = 0; i < 3; i++){
                 Console.WriteLine("Enter username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    int password = Convert.ToInt16(Console.ReadLine());

                if (username != correct_user || password != correct_pass)
                    loginAttempts++;
                    else
                    break;
                    }
                    
                if (loginAttempts > 2){
                Console.WriteLine("Login failure");
                return false;
                }
                 else{
                 Console.WriteLine("Login successful");
                 return true;
                 }
            }
 //////////////////////////////////////////////////////////////////////////////             
            //place order
            Dictionary<string, double> chosen_items = new Dictionary<string, double>();
            
           public static void place_order(){
            Console.WriteLine("-->Customer Name: ");
            string C_name = Console.ReadLine();
          
            
            Dictionary<string, double> chosen_items = new Dictionary<string, double>();
            //entree menu
        Dictionary<string, double> dict_entree = new Dictionary<string, double>();
        dict_entree.Add("Chicken Sandwich", 5.99);
        dict_entree.Add("Chicken Nuggets", 8.99);
        dict_entree.Add("Chicken Strips", 9.99);
        dict_entree.Add("Beef Burger", 6.99);
            //display menu
        int entree_index = 0;
        foreach(var item in dict_entree){
            Console.WriteLine($"{entree_index} - {item.Key} - {item.Value}");
            entree_index++;
        }
            //Select an entree
        Console.WriteLine("-->Select Entree: ");
        int selected_entree_index = Convert.ToInt16(Console.ReadLine());
        string entree_name = dict_entree.ElementAt(selected_entree_index).Key;
        double entree_price = dict_entree.ElementAt(selected_entree_index).Value;
        chosen_items.Add(entree_name,entree_price);
        Console.WriteLine($"Selected Item: {entree_name} - {entree_price}");


            //drink menu
        Dictionary<string, double> dict_drink = new Dictionary<string, double>();
        dict_drink.Add("Iced Tea", 2.99);
        dict_drink.Add("Soda", 1.99);
        dict_drink.Add("Lemonade", 2.99);
        dict_drink.Add("Coffee", 3.99);
        //display drinks 
        int drink_index = 0;
        foreach(var item in dict_drink){
            Console.WriteLine($"{drink_index} - {item.Key} - {item.Value}");
            drink_index++;
        }
        //select drinks
        Console.WriteLine("-->Select Drink: ");
        int selected_drink_index = Convert.ToInt16(Console.ReadLine());
        string drink_name = dict_drink.ElementAt(selected_drink_index).Key;
        double drink_price = dict_drink.ElementAt(selected_drink_index).Value;
       chosen_items.Add(drink_name,drink_price);
        Console.WriteLine($"Selected Item: {drink_name} - {drink_price}");



        //side menu
        Dictionary<string, double> dict_side = new Dictionary<string, double>();
        dict_side.Add("Potato Fries", 3.99);
        dict_side.Add("Salad", 4.99);
        dict_side.Add("Fruit Cup", 9.99);
        dict_side.Add("Potato Chips", 2.99);
        //display sides
        int side_index = 0;
        foreach(var item in dict_side){
            Console.WriteLine($"{side_index} - {item.Key} - {item.Value}");
            side_index++;
        }
        //select side
        Console.WriteLine("-->Select Side: ");
        int selected_side_index = Convert.ToInt16(Console.ReadLine());
        string side_name = dict_side.ElementAt(selected_side_index).Key;
        double side_price = dict_side.ElementAt(selected_side_index).Value;
        chosen_items.Add(side_name,side_price);
        Console.WriteLine($"Selected Item: {side_name} - {side_price}");
           
           //Order summary
            double sum = 0;
            Console.WriteLine("-----Order Summary-----");
            foreach(var x in chosen_items){
            Console.WriteLine($"Food: {x.Key} \t Price:{x.Value}");
            sum += x.Value;
            } 
            if(sum>0){
            order_record(C_name, sum);
           }
             Console.WriteLine($"-----Total: {sum}-----");
           }

            //List of all orders
    private static List<KeyValuePair<string, double>> placed_orders = new List<KeyValuePair<string, double>> ();
   
       public static void order_record(string name, double sum){
        string cust_name = name;
        double total = sum;
        placed_orders.Add(new KeyValuePair<string, double>(cust_name, total));
        //add customer name and total bill to list of orders
     }  
        //displays list of orders
    public static void submitted_orders(){
        int z = 0;
        Console.WriteLine($"-----Number of orders: {placed_orders.Count}-----");

        foreach(var y in placed_orders){
            
            Console.WriteLine($"-> {z} - Customer: {y.Key} \t Total:{y.Value}");
            z++;
        }
        Console.WriteLine("-----------------------");
    }
    public static void take_off_order(){
         Console.WriteLine("-->Select order to remove: ");
        // displays order list
          int z = 0;
        foreach(var y in placed_orders){
            
            Console.WriteLine($"-> {z} - Customer: {y.Key} \t Total:{y.Value}");
            z++;
        }
        Console.WriteLine("-----------------------");
        //select order to remove
        int removed_order = Convert.ToInt16(Console.ReadLine());
        placed_orders.RemoveAt(removed_order);
        //display new order list
        Console.WriteLine($"-----Number of orders: {placed_orders.Count}-----");
        int x = 0;
        foreach(var y in placed_orders){
            
            Console.WriteLine($"-> {x} - Customer: {y.Key} \t Total:{y.Value}");
            z++;
        }
        Console.WriteLine("-----------------------");

        
    }
}
    
