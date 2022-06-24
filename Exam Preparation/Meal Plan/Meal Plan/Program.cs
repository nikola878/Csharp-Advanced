using System;
using System.Collections.Generic;
using System.Linq;

namespace Meal_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meals = Console.ReadLine().Split(' ');
            int[] calories = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            Queue<string> queue = new Queue<string>();
            Stack<int> stack = new Stack<int>();
            Dictionary<string, int> caloriesTable = new Dictionary<string, int>()
            {
                { "salad", 350 },
                { "soup", 490 },
                { "pasta", 680 },
                { "steak", 790 }
            };
            for (int i = 0; i < meals.Length; i++)
            {
                queue.Enqueue(meals[i]);
            }
            for (int i = 0; i < calories.Length; i++)
            {
                stack.Push(calories[i]);
            }
            int numOfMeals = 0;
            int day = calories.Length - 1;
            for (int i = 0; i < meals.Length; i++)
            {
                if (meals[i] == "salad")
                {
                    if (caloriesTable["salad"] > calories[day])
                    {
                        int change = caloriesTable["salad"] - calories[day];
                        stack.Pop();
                        day--;
                        if (day < 0)
                        {
                            break;
                        }
                        calories[day] -= change;
                        stack.Pop();
                        stack.Push(calories[day]);
                    }
                    else if (caloriesTable["salad"] < calories[day])
                    {
                        calories[day] -= caloriesTable["salad"];
                        stack.Pop();
                        stack.Push(calories[day]);
                    }
                    queue.Dequeue();
                    numOfMeals++;
                }
                else if (meals[i] == "soup")
                {
                    if (caloriesTable["soup"] > calories[day])
                    {
                        int change = caloriesTable["soup"] - calories[day];
                        stack.Pop();
                        day--;
                        if (day < 0)
                        {
                            break;
                        }
                        calories[day] -= change;
                        stack.Pop();
                        stack.Push(calories[day]);
                    }
                    else if (caloriesTable["soup"] < calories[day])
                    {
                        calories[day] -= caloriesTable["soup"];
                        stack.Pop();
                        stack.Push(calories[day]);
                    }
                    queue.Dequeue();
                    numOfMeals++;
                }
                else if (meals[i] == "pasta")
                {
                    if(caloriesTable["pasta"] > calories[day])
                    {
                        int change = caloriesTable["pasta"] - calories[day];
                        stack.Pop();
                        day--;
                        if (day < 0)
                        {
                            break;
                        }
                        calories[day] -= change;
                        stack.Pop();
                        stack.Push(calories[day]);
                    }
                    else if (caloriesTable["pasta"] < calories[day])
                    {
                        calories[day] -= caloriesTable["pasta"];
                        stack.Pop();
                        stack.Push(calories[day]);
                    }
                    queue.Dequeue();
                    numOfMeals++;
                }
                else if (meals[i] == "steak")
                {
                    if (caloriesTable["steak"] > calories[day])
                    {
                        int change = caloriesTable["steak"] - calories[day];
                        stack.Pop();
                        day--;
                        if (day < 0)
                        {
                            break;
                        }
                        calories[day] -= change;
                        stack.Pop();
                        stack.Push(calories[day]);
                    }
                    else if (caloriesTable["steak"] < calories[day])
                    {
                        calories[day] -= caloriesTable["steak"];
                        stack.Pop();
                        stack.Push(calories[day]);
                    }
                    queue.Dequeue();
                    numOfMeals++;
                }
            }
            if (day >= 0)
            {
                Console.WriteLine($"John had {numOfMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", stack)} calories.");
            }
            else
            {
                queue.Dequeue();
                numOfMeals++;
                Console.WriteLine($"John ate enough, he had {numOfMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", queue)}.");
            }
        }
    }
}
