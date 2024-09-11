namespace Main_Task {
    internal class Program {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            List<int> list = new List<int>() ;
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("A - add a number");
            Console.WriteLine("M - Display mean of numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("C - Clear the list");
            Console.WriteLine("O - Search a number");
            Console.WriteLine("U - Sort your numbers");
            Console.WriteLine("Q -Quit");
            Console.WriteLine();
            char choise = char.Parse(Console.ReadLine());
            do {
               switch(choise) {
                    case 'P':
                    case 'p':
                        if(0 == list.Count) {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else {
                            Console.WriteLine("Your numbers in the list is:");
                            Console.Write('[');
                            for (int i = 0; i < list.Count; i++) {
                                Console.Write($" {list[i]} ");
                            }
                            Console.WriteLine(']');
                        }
                        break;
                    case 'A':
                    case 'a':
                        Console.WriteLine("Enter a number to add");
                        int num = int.Parse(Console.ReadLine());
                        bool is_exists = false;
                        if(0 == list.Count) {
                            list.Add(num);
                            list.TrimExcess();
                            Console.WriteLine($"{num} added");
                        }
                        else {
                            for (int i = 0; i < list.Count; i++) {
                                if (num == list[i]) {
                                    Console.WriteLine("Not allow");
                                    is_exists = true;
                                    break;
                                } 
                                else
                                    is_exists = false;
                            }
                            if (false == is_exists) {
                                list.Add(num);
                                list.TrimExcess();
                                Console.WriteLine($"{num} added");
                            }
                        }
                            break;
                    case 'M':
                    case 'm':
                        if (0 == list.Count)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else {
                            int sum = 0;
                            for (int i = 0; i < list.Count; i++) {
                                sum += list[i];
                            }
                            int main = sum / list.Count;
                            Console.WriteLine($"The main is {main}");
                        }
                        break;
                    case 'S':
                    case 's':
                        if (0 == list.Count) {
                            Console.WriteLine("Unable to determine smallest number - list is empty");
                        }
                        else {
                            int min = list[0];
                            for (int i = 0; i < list.Count; i++) {
                                if (min > list[i])
                                    min = list[i];
                            }
                            Console.WriteLine($"The smallest number is: {min}");
                        }
                        break;
                    case 'L':
                    case 'l':
                        if(0 == list.Count) {
                            Console.WriteLine("Unable to determine largest number - list is empty");
                        }
                        else{
                            int max = list[0];
                            for (int i = 0; i < list.Count; i++) {
                                if (max < list[i])
                                    max = list[i];
                            }
                            Console.WriteLine($"The largest number is: {max}");
                        }
                        break;
                    case 'C':
                    case 'c':
                        list.Clear();
                        Console.WriteLine("the list is cleared");
                        break;
                    case 'O':
                    case 'o':
                        if(0 == list.Count) {
                            Console.WriteLine("The list is empty");
                        }
                        else {
                            Console.WriteLine("Enter a number to find");
                            int founded = int.Parse(Console.ReadLine());
                            bool is_founded = false;
                            for (int i = 0; i < list.Count; i++) {
                                if (founded == list[i]) {
                                    is_founded = true;
                                    founded = i;
                                }
                                else {
                                    Console.WriteLine("The number you entered is not in the list");
                                    is_founded = false;
                                    break;
                                }
                            }
                            if(is_founded)
                            Console.WriteLine($"The index of number is {founded}");
                        }
                        break;
                    case 'U':
                    case 'u':
                        List<int> sortedList = new List<int> ();
                        for(int i = 0; i < list.Count; i++) {
                            sortedList.Add(list[i]);
                            sortedList.TrimExcess();
                        }
                        for (int i = 0; i < sortedList.Count - 1; i++) {
                            for (int j = 0; j < sortedList.Count - i - 1; j++) {
                                if (sortedList[j] > sortedList[j + 1]) {
                                    int temp = sortedList[j];
                                    sortedList[j] = sortedList[j + 1];
                                    sortedList[j + 1] = temp;
                                }

                            }
                        }
                        Console.Write("Your sorted list is : ");
                        Console.Write('[');
                        for (int i = 0; i < sortedList.Count; i++) {
                            Console.Write($" {sortedList[i]} ");
                        }
                        
                        Console.WriteLine(']');
                        break;
                        case 'Q': 
                        case'q':
                        Console.WriteLine("Goodbye");
                        choise = 'q';
                        break;
                    default:
                        Console.WriteLine("invalid choise");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - add a number");
                Console.WriteLine("M - Display mean of numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("O - Search a number");
                Console.WriteLine("U - Sort your numbers");
                Console.WriteLine("Q -Quit");
                Console.WriteLine("Enter a new choise");
                Console.WriteLine();
                choise = char.Parse(Console.ReadLine());
            } while (choise != 'Q' && choise != 'q');
        }
    }
}
