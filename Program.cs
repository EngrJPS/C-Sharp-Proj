class Names
{
    //Example of the class or object oriented programming (OOP)
    public void nums(){
        int[] num = {10,20,30};
        for(int i = 0; i < num.Length; i++){
            Console.WriteLine(num[i]);
        }
    }

    //One of the examples of Data Structure and Algorithm
    static int findSums(int sum){
        for(int i = 1; i <= 10; i++){
            sum += i;
        }
        return sum;
    }

    // Arrays
    String[] names = {"Jimson", "Paul", "Serafin"};

    static void Main (String[] args){
        // Names name = new Names();
        
        // for(int i = 0; i < name.names.Length; i ++){
        //     Console.WriteLine(name.names[i]);
        // }
        // name.nums();

        // Console.WriteLine("Hello! What's your name? ");
        // string s = Console.ReadLine();

        // Console.WriteLine("Hello!\t"+ s);
        // Console.WriteLine(findSums(0));

        bool t = false;

        if(t != true){
            Console.WriteLine("False");
        }else{
            Console.WriteLine("True");
        }
    }
}