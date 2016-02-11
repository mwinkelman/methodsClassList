using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;

namespace methodsClassList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine( SobrietyTest() );  

            //HouseBuilder(5);

            //string[] userInfo = Username("Mary Winkelman", "216-258-1607");
            //foreach(string item in userInfo)
            //{
            //    Console.WriteLine(item);
            //}

            //FamilyGuy();

            //NameAgeState("Mary", 27, "Ohio");

            //LostMyTeeth(2016, 2036);

            //Console.WriteLine(CircleArea(1));

            //string[] words = { "you","hamburger","grasshopper"};
            //PrintArray(words);

            //TopStudent("Mary", 89.9, 50.44, 100, "Jumpy", 77, 98.4, 80);

            //NumberCheck("h");

            //ValidName("Mary", "Winkelm9n");

            //ProperName("Mary winkelman");
            //AlphaSplitter("Skeletons are scary, but we all have them.");
           
        }
        
        static void AlphaSplitter(string sentence)
        {           
            string[] sentenceArray = sentence.Split();
            Array.Sort(sentenceArray);
            foreach(string word in sentenceArray)
            {
                Console.WriteLine(word);
            }
        }
        
        static void ProperName(string name)
        {
            string[] nameArray = name.Split();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < nameArray.Length; i++)
            {
                char[] nameAsCharArray = new char[nameArray[i].Length-1];
                nameAsCharArray = nameArray[i].ToCharArray();
                nameAsCharArray[0] = char.ToUpper(nameAsCharArray[0]);
                
                foreach (char letter in nameAsCharArray)
                    sb.Append(letter);
                if (i == nameArray.Length - 1)
                    continue;
                sb.Append(" ");
            }
            string capitalizedName = sb.ToString();
            Console.WriteLine(capitalizedName + " is a proper name.");
        }
        static void ValidName(string firstname, string lastname)
        {
            bool validFirstName = false;
            bool validLastName = false;
            Regex pattern = new Regex(@"^[a-z,A-Z,.'-]+$");

            if (pattern.IsMatch(firstname))
                validFirstName = true;
            if (pattern.IsMatch(lastname))
                validLastName = true;
            string error = "Error: Not a valid name";
            string fullName = firstname + " " + lastname;

            if (validFirstName == false || validLastName == false)
                Console.WriteLine(error);
            else
                Console.WriteLine(fullName);
            
        }
        static int NumberCheck(string number)
        {
            int n;
            bool validNumber = int.TryParse(number, out n);
            if(!validNumber)
                Console.WriteLine("not a valid number");
            return n;
        }
        static void TopStudent(string student1Name, double student1_grade1, double student1_grade2, double student1_grade3, string student2Name, double student2_grade1, double student2_grade2, double student2_grade3)
        {
            double student1Average = (student1_grade1 + student1_grade2 + student1_grade3) / 3;
            double student2Average = (student2_grade1 + student2_grade2 + student2_grade3) / 3;
            string winner;
            if(student1Average>student2Average)
            {
                winner = student1Name;
                Console.WriteLine("{0} has a higher average: {1} %",student1Name,student1Average);
            }
            if (student2Average > student1Average)
            {
                winner = student2Name;
                Console.WriteLine("{0} has a higher average: {1} % ",student2Name,student2Average);
            }
        }
        static void PrintArray(string[] strings)
        {
            foreach(string item in strings)
                Console.WriteLine(item);
        }
        static double CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
        static void LostMyTeeth(int currentYear, int futureYear)
        {
            int yearsPassed = futureYear - currentYear;
            int teethLost = yearsPassed/4;
            Console.WriteLine("{0} teeth lost by {1}",teethLost, futureYear);
        }
        static void NameAgeState(string name, int age, string state)
        {
            Console.WriteLine("{0}, from {1}, is {2} years old.", name, state, age);
        }
        static void FamilyGuy()
        {
            string[] characters = { "Stewie Griffin", "Peter Griffin", "Lois Griffin", "Meg Griffin", "Brian Griffin", "Chris Griffin", "Glenn Quagmire", "Cleveland Brown", "Loretta Brown", "Herbert", "Joe Swanson", "Kevin Swanson" };
            foreach (string character in characters)
            {
                Console.WriteLine(character);
            }
        }
        
        static string[] Username(string name, string phoneNumber)
        {
            string[] nameNumber = new string[2];
            nameNumber[0] = name;
            nameNumber[1] = phoneNumber;
            return nameNumber;
        }
        static void HouseBuilder(int scale)
        {           
            StringBuilder sb = new StringBuilder();
            //roof peak:
            for (int i = 0; i < scale; i++)
            {
                sb.Append(" "); //spaces before peak of roof
            }
            sb.Append("/\\\n"); // peak
            //roof:
            for (int i = scale; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                     sb.Append(" "); //space from side of window to roof
                }
                sb.Append("/"); // left side of roof
                for (int j = 2 * scale + 2; j > 2 * i; j--)
                {
                    sb.Append("v"); //shingles
                }
                sb.Append("\\"); // right side of roof
                sb.Append("\n"); // new line
            }
            //roof-house dividing line:
            for (int i = 0; i < 2 * scale + 2; i++)
            {
                sb.Append("-"); //line between roof and house
            }
            sb.Append("\n");
            //house body:
            for (int i = 0; i <= scale; i++)
            {
                sb.Append("|"); //left side of house
                for (int j = 0; j < 2 * scale; j++)
                {
                    sb.Append(" "); //space between sides of house
                }
                sb.Append("|\n"); //right side of house, new line
            }

            //ground line:
            sb.Append("-");
            for (int i = 0; i < 2 * scale; i++)
            {
                sb.Append("-");
            }
            sb.Append("-");
            
            string house = sb.ToString();
            Console.WriteLine(house);
        }

        static string SobrietyTest()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder alphabetSB = new StringBuilder();
            for(int i=alphabet.Length-1; i>=0; i--)
            {
                alphabetSB.Append(alphabet[i]);
                if (i == 0)
                    continue;

                alphabetSB.Append(' ');
            }

            string backwardsAlphabet = alphabetSB.ToString();
            return backwardsAlphabet;
        }
    }
}
