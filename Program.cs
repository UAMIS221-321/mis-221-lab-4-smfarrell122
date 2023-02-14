//start main
 int userChoice = GetUserChoice();
RouteEm(userChoice);

//end main



 static int GetUserChoice(){
    DisplayMenu();
     string userChoice = Console.ReadLine();
         if(IsValidChoice(userChoice)){
          

            
             return int.Parse(userChoice);
         }
         else return 0;
         
 }


    static void DisplayMenu(){
      System.Console.WriteLine("Enter 1 to display full triangle\n Enter 2 to display partial triangle\n Enter 3 to exit");
  }

 static bool IsValidChoice(string userInput){
     if(userInput == "1" || userInput == "2" || userInput=="3"){
        return true;
     }
     return false;
 }

static void GetFull()
{
    for(int i = 0; i < 4; i++){
        for(int j = 0; j <= i; j++){
                System.Console.Write("0");
                
                
        }
        Console.WriteLine();
    }
}


 static void GetPartial()
 {
    Random rnd = new Random();
    int number = rnd.Next(2);
    //Console.WriteLine(number);
    for(int i = 0; i < 4; i++){
        for(int j = 0; j<= i; j++){
            number = rnd.Next(2);
            
            if(number == 0){
                Console.Write(" ");
                
            }
            if(number == 1){
                Console.Write(0);
            }
            
            
        }
        Console.WriteLine();
    }
        

     
    
    }
 


static void SayInvalid(){
    System.Console.WriteLine("input is invalid");
            int userChoice = GetUserChoice();
            RouteEm(userChoice);
}


 static void RouteEm(int menuChoice){
    if(menuChoice == 1){
        GetFull();
        
    }
     else if(menuChoice == 2){
        GetPartial();
        
    }
    else if(menuChoice != 3){
        SayInvalid();
    }
    
}

