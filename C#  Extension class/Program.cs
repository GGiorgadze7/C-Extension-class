//სავარჯიშო 1: პალინდრომის შემმოწმებელი
//1.შექმენით სტატიკური კლასი სახელად StringExtensions.
//2. დაამატეთ Extension მეთოდი IsPalindrome, რომელიც ამოწმებს, არის თუ არა
//სტრიქონი პალინდრომი.
//3. გამოიყენეთ მეთოდი სხვადასხვა სტრიქონებზე კონსოლ აპლიკაციაში.
//მაგალითი:
//Console.WriteLine("madam".IsPalindrome()); // True
//Console.WriteLine("hello".IsPalindrome()); // False

//using C___Extension_class.Models;

//namespace PalindromeExercise
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("1001".IsPalindrom());
//            Console.WriteLine("11002".IsPalindrom());
//        }
//    }
//}


//სავარჯიშო 2: სიტყვების დათვლა
//1.დაამატეთ Extension მეთოდი WordCount სტრიქონის ტიპზე, რომელიც ითვლის
//სიტყვების რაოდენობას სტრიქონში.
//2. გამოსცადეთ მეთოდი სხვადასხვა წინადადებებზე.
//მაგალითი:
//Console.WriteLine("This is a test sentence.".WordCount()); // 5
//Console.WriteLine("C# is awesome!".WordCount()); // 3

//using C___Extension_class.Models;

//namespace PalindromeExercise
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("erti ori sami otxi".WordCount());
//            Console.WriteLine("ramdenime sityva".WordCount());           
//        }
//    }
//}


//სავარჯიშო 3: Enumerable ფილტრი
//1.შექმენით Extension მეთოდი WhereNotNull ტიპისთვის IEnumerable<T>, რომელიც
//ფილტრავს null მნიშვნელობებს.
//2. გამოიყენეთ მეთოდი სტრიქონების კოლექციასთან.
//მაგალითი:
//var items = new List<string> { "apple", null, "banana", null, "cherry" };
//var filtered = items.WhereNotNull();
//Console.WriteLine(string.Join(", ", filtered)); // apple, banana, cherry

//using C___Extension_class.Models;

//namespace PalindromeExercise
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var items = new List<string> { "apple", null, "banana", null, "cherry" };
//            var filtered = items.WhereNotNull();

//            Console.WriteLine(string.Join(", ", filtered)); 
//        }
//    }
//}


//სავარჯიშო 4: DateTime ფორმატირება
//1.დაამატეთ Extension მეთოდი ToFriendlyDate ტიპისთვის DateTime.
//2. მეთოდი უნდა დააბრუნოს თარიღი მომხმარებლისთვის მოსახერხებელ ფორმატში
//(მაგ., '23 იანვარი, 2025' ან 'დღეს', 'გუშინ').
//მაგალითი:
//DateTime today = DateTime.Now;
//Console.WriteLine(today.ToFriendlyDate());

//using C___Extension_class.Models;

//DateTime  today = DateTime.Now;
//Console.WriteLine(today.ToFriendlyDate());

//DateTime yesterday = DateTime.Now.AddDays(-1);
//Console.WriteLine(yesterday.ToFriendlyDate());

//DateTime someOldDate = new DateTime(2025, 1, 23);
//Console.WriteLine(someOldDate.ToFriendlyDate());



//სავარჯიშო 5: რიცხვების დიაპაზონის შემმოწმებელი
//1. შექმენით კლასი NumericExtensions და დაამატეთ გაფართოების მეთოდი
//IsInRange რიცხვითი ტიპებისთვის.
//2. მეთოდი იღებს ორ პარამეტრს (მინიმალური და მაქსიმალური) და აბრუნებს true-ს,
//თუ რიცხვი არის მითითებულ დიაპაზონში.
//მაგალითი:
//int number = 10;
//Console.WriteLine(number.IsInRange(5, 15)); // True
//Console.WriteLine(number.IsInRange(15, 20)); // False

//using C___Extension_class.Models;

//int number = 10;
//Console.WriteLine(number.IsInRange(5, 15));  
//Console.WriteLine(number.IsInRange(15, 20));


//using C___Extension_class.Models;

//სავარჯიშო 6: სიების შებრუნება
//1.დაამატეთ Extension მეთოდი ReverseList ტიპისთვის List<T>, რომელიც შებრუნებს
//სიას ადგილზე.
//2. გამოიყენეთ მეთოდი სხვადასხვა სიებზე.
//მაგალითი:
//var numbers = new List<int> { 1, 2, 3, 4, 5 };
//numbers.ReverseList();
//Console.WriteLine(string.Join(", ", numbers)); // 5, 4, 3, 2, 1

using C___Extension_class.Models;

var numbers = new List<int> { 1, 2, 3, 4, 5 };
numbers.ReverseList();
Console.WriteLine(string.Join(", ", numbers));