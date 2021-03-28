using System;

namespace PizzaRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select one day of week:");
            Console.WriteLine("Press 1 for Monday");
            Console.WriteLine("Press 2 for Tuesday");
            Console.WriteLine("Press 3 for Wednesday");
            Console.WriteLine("Press 4 for Thursday");
            Console.WriteLine("Press 5 for Friday");
            Console.WriteLine("Press 6 for Saturday");
            Console.WriteLine("Press 7 for Sunday");
            string dayOfWeek = Console.ReadLine();

            bool convertDayOfWeek = int.TryParse(dayOfWeek, out int day);

            if(convertDayOfWeek && day > 0 && day < 8)
            {
                Console.Write("Please enter number of order items:");
                string numOfOrderItems = Console.ReadLine();

                bool convertNumberOfOrderItems = int.TryParse(numOfOrderItems, out int orderItems);

                if(convertNumberOfOrderItems && orderItems > 0 && orderItems < 31)
                {
                    Console.WriteLine("The restaurant promotes two types of orders:");
                    Console.WriteLine("Press 1 for Regular order");
                    Console.WriteLine("Press 2 for Elite order");
                    string typeOfOrders = Console.ReadLine();

                    bool convertTypeOfOrders = int.TryParse(typeOfOrders, out int ordersType);

                    if(convertTypeOfOrders && ordersType > 0 && ordersType < 3)
                    {
                        int regularPizza;
                        int elitePizza;
                        double discount;
                        int totalPrice;

                        switch (dayOfWeek)
                        {
                            case "1":
                            case "2":
                            case "3":
                                regularPizza = 300;
                                elitePizza = 400;

                                    if (typeOfOrders == "1")
                                    { 
                                        totalPrice = regularPizza * orderItems;
                                        Console.WriteLine($"Congratulations, you have booked your regular order for {totalPrice} den.");
                                    }
                                    else if(typeOfOrders == "2" && orderItems > 6)
                                    {
                                        totalPrice = elitePizza * orderItems;
                                        discount = totalPrice * 0.20;
                                        Console.WriteLine($"Congratulations, you have booked your regular order for {totalPrice - discount} den.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Congratulations, you have booked your elite order for {elitePizza * orderItems} den.");
                                    }
                                break;

                            case "4":
                            case "5":
                                regularPizza = 350;
                                elitePizza = 500;

                                    if (typeOfOrders == "1" && orderItems <= 3)
                                    {
                                        totalPrice = regularPizza * orderItems;
                                        Console.WriteLine($"Congratulations, you have booked your regular order for {totalPrice} den.");
                                    }
                                    else if (typeOfOrders == "1" && orderItems > 3)
                                    {
                                        totalPrice = regularPizza * orderItems;
                                        discount = totalPrice * 0.30;
                                        Console.WriteLine($"Congratulations, you have booked your regular order for {totalPrice - discount} den.");
                                    }
                                    else if (typeOfOrders == "2" && orderItems > 6)
                                    {
                                        totalPrice = elitePizza * orderItems;
                                        discount = totalPrice * 0.20;
                                        Console.WriteLine($"Congratulations, you have booked your elite order for {totalPrice - discount} den.");
                                    }
                                    else
                                    {
                                        totalPrice = elitePizza * orderItems;
                                        Console.WriteLine($"Congratulations, you have booked your elite order for {totalPrice} den.");
                                    }
                                break;

                            case "6":
                            case "7":
                                regularPizza = 400;
                                elitePizza = 550;

                                    if(typeOfOrders == "1" && orderItems > 5)
                                    {
                                        totalPrice = regularPizza * orderItems;
                                        discount = totalPrice * 0.35;
                                        Console.WriteLine($"Congratulations, you have booked your regular order for {totalPrice - discount} den.");
                                    }
                                    else if (typeOfOrders == "1")
                                    {
                                        totalPrice = regularPizza * orderItems;
                                        Console.WriteLine($"Congratulations, you have booked your regular order for {totalPrice} den.");
                                    }
                                    else if (typeOfOrders == "2" && orderItems > 4)
                                    {
                                        totalPrice = elitePizza * orderItems;
                                        discount = totalPrice * 0.40;
                                        Console.WriteLine($"Congratulations, you have booked your elite order for {totalPrice - discount} den.");
                                    }
                                    else
                                    {
                                        totalPrice = elitePizza * orderItems;
                                        Console.WriteLine($"Congratulations, you have booked your elite order for {totalPrice} den.");
                                    }
                                break;
                            default:
                                Console.WriteLine("Error, Try again!");
                                break;                          
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input order types, try again!");
                    }

                }
                else
                {
                    Console.WriteLine("Wrong input, order items must be in range between 1 and 30!");
                }

            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }

        }

    }
}
