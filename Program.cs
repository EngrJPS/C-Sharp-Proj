class Names
{
    
    public void nums(){
        int[] num = {10,20,30};
        for(int i = 0; i < num.Length; i++){
            Console.WriteLine(num[i]);
        }
    }

    String[] names = {"Jimson", "Paul", "Serafin"};

    static void Main (String[] args){
        Names name = new Names();
        
        for(int i = 0; i < name.names.Length; i ++){
            Console.WriteLine(name.names[i]);
        }
        name.nums();

        Console.WriteLine("Hello! What's your name? ");
        string s = Console.ReadLine();
        Console.WriteLine("Hello!\t"+ s);
        Console.ReadKey(); 
    }

}