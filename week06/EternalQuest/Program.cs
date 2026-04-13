using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        while (true)
        {
            Console.WriteLine("\n==== Eternal Quest ====");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    goals.Add(new SimpleGoal(name, desc, points));
                }
                else if (type == "2")
                {
                    goals.Add(new EternalGoal(name, desc, points));
                }
                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }

            else if (choice == "2")
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i}. {goals[i].GetDetails()}");
                }

                Console.Write("Select goal: ");
                int index = int.Parse(Console.ReadLine());

                score += goals[index].RecordEvent();

                Console.WriteLine("Event recorded!");
            }

            else if (choice == "3")
            {
                foreach (Goal g in goals)
                {
                    Console.WriteLine(g.GetDetails());
                }
            }

            else if (choice == "4")
            {
                using (StreamWriter outputFile = new StreamWriter("goals.txt"))
                {
                    outputFile.WriteLine(score);

                    foreach (Goal g in goals)
                    {
                        outputFile.WriteLine(g.GetSaveString());
                    }
                }

                Console.WriteLine("Goals saved!");
            }

            else if (choice == "5")
            {
                if (File.Exists("goals.txt"))
                {
                    string[] lines = File.ReadAllLines("goals.txt");

                    goals.Clear();
                    score = int.Parse(lines[0]);

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split("|");

                        if (parts[0] == "Simple")
                        {
                            goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                        }
                        else if (parts[0] == "Eternal")
                        {
                            goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        }
                        else if (parts[0] == "Checklist")
                        {
                            goals.Add(new ChecklistGoal(
                                parts[1],
                                parts[2],
                                int.Parse(parts[3]),
                                int.Parse(parts[5]),
                                int.Parse(parts[6]),
                                int.Parse(parts[4])
                            ));
                        }
                    }

                    Console.WriteLine("Goals loaded!");
                }
                else
                {
                    Console.WriteLine("No file found.");
                }
            }

            else if (choice == "6")
            {
                break;
            }
        }
    }
}