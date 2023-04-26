using System;
public class Program
{
    static void Main(string[] args)
    {
        bool check = true;
        Console.Write("Input number of stalls : ");
        int nos = int.Parse(Console.ReadLine());
        string[] stalls = new string[nos];
        if (nos > 1) {
            for (int i = 0; i <= nos - 1; i++) {
                stalls[i] = "_";
                Console.Write(stalls[i]);
            }
            Console.WriteLine();
        while(check) {
            Console.Write("Book a stall 1 : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Book a stall 2 : ");
            int n2 = int.Parse(Console.ReadLine());
            if (n1 < 1 && n2 >= 1) {
                if (repeat(stalls[n2 - 1])) {
                    Console.WriteLine("The stall is reserved.");
                }
                else {
                    stalls[n2 - 1] = "X";
                }
            }
            else if (n1 >= 1 && n2 < 1) {
                if (repeat(stalls[n1 - 1])) {
                    Console.WriteLine("The stall is reserved.");
                }
                else {
                    stalls[n1 - 1] = "X";
                }
            }
            else if (n1 < 1 && n2 < 1) {
                check = false;
            }
            else if (n1 == n2) {
                if (repeat(stalls[n1 - 1])) {
                    Console.WriteLine("The stall is reserved.");
                }
                else {
                    stalls[n1 - 1] = "X";
                }
            }
            else if (n1 >= 1 && n2 >= 1) {
                int a = 0;
                for (int j = 0; j <= nos -1; j++) {
                    if (checkA(stalls[j])) {
                        a++;
                    }
                }
                if (repeat(stalls[n1 - 1]) || repeat(stalls[n2 - 1])) {
                    Console.WriteLine("The stall is reserved.");
                }
                else if (nos - a == 2) {
                    Console.WriteLine("The entrance can’t be reserved.");
                }
                else {
                    stalls[n1 - 1] = "X";
                    stalls[n2 - 1] = "X";
                }
            }
            for (int i = 0; i <= nos - 1; i++) {
                int a = 0;
                for (int j = 0; j <= nos -1; j++) {
                    if (checkA(stalls[j])) {
                        a++;
                    }
                }
                if ( nos - a == 1) {
                    check = false;
                }
                Console.Write(stalls[i]);
                /* check = check(stalls[i]); */
            }
            Console.WriteLine();
        }
        Console.WriteLine("All stall are reserved.");
        }
    }
    static bool checkA(string x) {
        if (x == "X") return true;
        return false;
    }

    static bool repeat(string x) {
        if (x == "_") return false;
        return true;
    }
}