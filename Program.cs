//name: Ulises Ortega
//Date: 09.17.22
//Program Name: Guess It
/*

*/


Console.Clear();
string userChoice = "";

do{
Console.Clear();
Console.WriteLine("Are you hungry");
Console.WriteLine("---------------------------");
Console.WriteLine("1 - American Food");
Console.WriteLine("---------------------------");
Console.WriteLine("2 - Japanese Food");
Console.WriteLine("---------------------------");
Console.WriteLine("3 - Mediterranian Food");
Console.WriteLine("---------------------------");


int option ;
bool isNumber = false;


isNumber = Int32.TryParse(Console.ReadLine(), out option);

while (option != 1 &&  option != 2 && option !=3)
{
    Console.WriteLine("Please enter 1, 2, or 3");
    isNumber = Int32.TryParse(Console.ReadLine(), out option);    
}

//--------------------------------------------------------------------------------------------------------------------------------------------------//
 
if (option == 1){
Console.WriteLine("Let's Pick Random American Food Restaurant");
 
string[] Afood = {"Cast Iron", "Cracker Barrel", "American Waffle", "Black Bear", "Country Boys", "Bob's at the marina", "Denny's", "LumberJack's Restaurant", "BBC Eat's", "Top Flight Grill & Cathering"};
Random random = new Random();
int resPicker = random.Next(0,11);
Console.WriteLine("Your Restaurant will be " + Afood[resPicker]);
}  
//---------------------------------------------------------------------------------------------------------------------------------------------------//

else if(option ==2){
Console.WriteLine("Let's Pick Random Japanese Restaurant");
 
string[] Jfood = {"Misaki Sushi & Bar", "Cocoro Bistro Sushi & Bar", "Icchiban Teppanyanki & Sushi", "Mikasa Japanese Bistro", "Hana Sushi", "ShoMi Japanese Cusisine", "Shogun Japanese Restaurant", "Shogun Japanese Restaurant", "Matsuyama Restaurant", "Sakana Japanese Bistro"};
Random random = new Random();
int resPicker = random.Next(0,11);
Console.WriteLine("Your Restaurant will be " + Jfood[resPicker]);


}
//---------------------------------------------------------------------------------------------------------------------------------------------------//
 
else if (option ==3)
{
string[] Mfood = {"Kabob & Gyro House", "Go Falafel Greek Food", "Yasoo Yani Restaurant", "Yasoo Yani Restaurant", "Super Mediterranean Bistro", "Kabob & Gyro Grill", "Yafa Hummus", "Zanga Mediterranean Cuisine", "Skewers Kabob House", "Mazaa Kabob House"};
Random random = new Random();
int resPicker = random.Next(0,11);
Console.WriteLine("Your Restaurant will be " + Mfood[resPicker]);
}

//---------------------------------------------------------------------------------------------------------------------------------------------------//
do
{
   Console.WriteLine("Do you want to Run the program again, Yes or No?");
   userChoice = Console.ReadLine().ToUpper();
   if(userChoice != "Yes" && userChoice != "NO")
   {
       Console.WriteLine("Invalid Choice, Please type Yes or No");
   }
}while (userChoice !="YES" && userChoice != "NO");
}while(userChoice == "YES");
