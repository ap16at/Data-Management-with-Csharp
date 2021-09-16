//Assignment 1 - Data Management
//Due: 2-1-21
// Written by: Andrew Perez-Napan


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> strings = new List<string>();

            bool conditional = true;
            bool listConditional = true;
            int currentSize = strings.Count();
            int currentSizeTemp = 0;
            int pages = 1;


            do
            {

                Console.WriteLine("Welcome to Assignment 1!");
                Console.WriteLine("Please");
                Console.WriteLine("1. Create an Item");
                Console.WriteLine("2. List all Items");
                Console.WriteLine("3. Update an Item");
                Console.WriteLine("4. Delete an Item");
                Console.WriteLine("5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 1)
                {

                    Console.WriteLine("Please enter a string to add it to the list of items.");
                    string newItem = Console.ReadLine();
                    strings.Add(newItem);
                    currentSize++;
                    currentSizeTemp = currentSize;

                    pages = 1;
                    
                    for(int i = 0; i < currentSize; i++)
                    {

                        currentSizeTemp -= 5;
                        if(currentSizeTemp > 0)
                        {

                            pages++;

                        }
                        else
                        {

                            break;

                        }

                    }

                    Console.WriteLine("\n\n");

                    continue;

                }
                else if(choice == 2)
                {

                    Console.WriteLine("Current Items:");

                    if(currentSize == 0)
                    {

                        Console.WriteLine("List is currently empty.");

                    }
                    
                    int currentPage = 1;
                    int items = strings.Count();
                    int lastPageItems = items - ((pages - 1) * 5);
                    int lastPageStart = ((pages - 1) * 5) + 1;

                    if(pages > 1)
                    {

                        do
                        {

                            if (currentPage == pages)
                            {

                                for (int j = lastPageStart; j < items + 1; j++)
                                {

                                    Console.WriteLine(j + " - " + strings[j - 1]);

                                }

                                Console.WriteLine("p - Previous");

                            }
                            else if (currentPage == 1)
                            {

                                for (int j = 1; j < 6; j++)
                                {

                                    Console.WriteLine(j + " - " + strings[j - 1]);

                                }

                                Console.WriteLine("n - Next");

                            }
                            else
                            {

                                for (int j = (currentPage * 5) - 4; j < (currentPage * 5) + 1; j++)
                                {

                                    Console.WriteLine(j + " - " + strings[j - 1]);

                                }

                                Console.WriteLine("p - Previous");
                                Console.WriteLine("n - Next");

                            }

                            string setPage = Console.ReadLine();
                            if (setPage == "p" && currentPage > 1)
                            {

                                currentPage--;
                                continue;

                            }
                            else if (setPage == "n" && currentPage < pages)
                            {

                                currentPage++;
                                continue;

                            }
                            else
                            {

                                break;

                            }

                        } while (listConditional);

                    }
                    else
                    {

                        for (int j = 1; j < currentSize + 1; j++)
                        {

                            Console.WriteLine(j + " - " + strings[j - 1]);

                        }

                    }

                    Console.WriteLine("\n\n");

                    continue;

                }else if(choice == 3)
                {

                    Console.WriteLine("Please enter the id of an item to update.");
                    int id = Convert.ToInt32(Console.ReadLine());

                    if(id < 0 || id > currentSize)
                    {

                        Console.WriteLine("Item id is invalid.");
                        Console.WriteLine("\n\n");
                        continue;

                    }

                    Console.WriteLine("What is the new string?");
                    string update = Console.ReadLine();

                    strings.RemoveAt(id-1);
                    strings.Insert(id-1, update);

                    Console.WriteLine("\n\n");

                    continue;


                }else if(choice == 4)
                {

                    Console.WriteLine("Please enter the id of an item to delete.");
                    int id = Convert.ToInt32(Console.ReadLine());

                    if (id < 0 || id > currentSize)
                    {

                        Console.WriteLine("Item id is invalid.");
                        Console.WriteLine("\n\n");
                        continue;

                    }

                    strings.RemoveAt(id-1);

                    currentSize--;
                    currentSizeTemp = currentSize;
                    pages = 1;

                    for (int i = 0; i < currentSize; i++)
                    {

                        currentSizeTemp -= 5;
                        if (currentSizeTemp > 0)
                        {

                            pages++;

                        }
                        else
                        {

                            break;

                        }

                    }

                    Console.WriteLine("\n\n");

                    continue;

                }else if (choice == 5)
                {
                    conditional = false;
                    continue;
                }
                else
                {

                    Console.WriteLine("Input Invalid.");
                    Console.WriteLine("\n\n");
                    continue;

                }


            } while (conditional);

        }
    }
}
