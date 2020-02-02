using System;

namespace lesson_01
{
    class MainHandler
    {
        static void Main(string[] args)
        {
            int exercise_number = int.Parse(Console.ReadLine());
            if (exercise_number == 1)
            {
                Exercises.Exercise1();
            }
            if (exercise_number == 2)
            {
                Exercises.Exercise2();
            }
            if (exercise_number == 3)
            {
                Exercises.Exercise3();
            }
            if (exercise_number == 4)
            {
                Exercises.Exercise4();
            }
            if (exercise_number == 5)
            {
                Exercises.Exercise5();
            }
            if (exercise_number == 6)
            {
                Exercises.Exercise6();
            }
            if (exercise_number == 7)
            {
                Exercises.Exercise7();
            }
            if (exercise_number == 8)
            {
                Exercises.Exercise8();
            }
            if (exercise_number == 9)
            {
                Exercises.Exercise9();
            }
            if (exercise_number == 10)
            {
                Exercises.Exercise10();
            }
            if (exercise_number == 11)
            {
                Exercises.Exercise11();
            }
            if (exercise_number == 12)
            {
                Exercises.Exercise12();
            }
        }
    }
    public class Exercises
    {
        public static void Exercise1()
        {
            Console.Write("Write the first number: ");
            int first_number = int.Parse(Console.ReadLine());
            Console.Write("Write the second number: ");
            int second_number = int.Parse(Console.ReadLine());
            if (first_number > second_number)
            {
                Console.Write($"The greather number is: {first_number}");
            }
            if (second_number > first_number)
            {
                Console.Write($"The greather number is: {second_number}");
            }
            if (second_number == first_number)
            {
                Console.Write("The numbers are equal");
            }
        }

        public static void Exercise2()
        {
            int first_number = int.Parse(Console.ReadLine());
            int second_number = int.Parse(Console.ReadLine());

            int sum = first_number + second_number;
            Console.WriteLine(sum);

            int subtraction = first_number - second_number;
            Console.WriteLine(subtraction);

            int multiplication = first_number * second_number;
            Console.WriteLine(multiplication);

            int division = first_number / second_number;
            Console.WriteLine(division);
        }

        public static void Exercise3()
        {
            Console.Write("Type the distance traveled: ");
            int distance_traveled = int.Parse(Console.ReadLine());

            Console.Write("Type the consumed fuel: ");
            int consumed_fuel = int.Parse(Console.ReadLine());

            int average_consuption = consumed_fuel / (distance_traveled / 100);
            Console.Write(average_consuption);
        }

        public static void Exercise4()
        {
            string salesman_name = Console.ReadLine();
            int salary = int.Parse(Console.ReadLine());
            int amount_of_sales_in_the_month = int.Parse(Console.ReadLine());

            int percentage_of_sales_comission = 15;
            int sales_comission

            sales_comission = percentage_of_sales_comission * amount_of_sales_in_the_month / 100;

            Console.WriteLine($"Name: {salesman_name}");
            Console.WriteLine($"Fixed salary: {salary}");
            Console.WriteLine($"Final salary (salary with comission): {salary + sales_comission}");
        }

        public static void Exercise5()
        {
            string student_name = int.Parse(Console.ReadLine());
            int test_grade_1 = int.Parse(Console.ReadLine());
            int test_grade_2 = int.Parse(Console.ReadLine());
            int test_grade_3 = int.Parse(Console.ReadLine());

            int test_grade_sum = (test_grade_1 + test_grade_2 + test_grade_3);
            int arithmetic_average = test_grade_sum / 3;

            Console.WriteLine($"Student name: {student_name}");
            Console.WriteLine($"Arithmetic average: {arithmetic_average}");
        }
        public static void Exercise6()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int a_backup = a;

            a = b;
            b = a_backup;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static void Exercise7()
        {
            int temperature_in_celcius = int.Parse(Console.ReadLine());
            int temperature_in_fahrenheit

            temperature_in_fahrenheit = (9 * temperature_in_celcius + 160) / 5;

            Console.WriteLine(temperature_in_fahrenheit);
        }
        public static void Exercise8()
        {
            int dolar_cotation = int.Parse(Console.ReadLine());
            int amount_of_dolars = int.Parse(Console.ReadLine());

            int amount_in_reais = dolar_cotation * amount_of_dolars;

            Console.WriteLine(amount_in_reais);
        }
        public static void Exercise9()
        {
            int interest_in_percentage = 0.70;
            int value_deposited = int.Parse(Console.ReadLine());
            int value_with_yeld

            value_with_yeld = value_deposited + (value_deposited + interest_in_percentage / 100);
            Console.WriteLine(value_with_yeld)

        }
        public static void Exercise10()
        {
            int purchase_value = int.Parse(Console.ReadLine());
            int value_in_installments = purchase_value / 5;
        }
        public static void Exercise11()
        {
            int cost_price = int.Parse(Console.ReadLine());
            int percentage_for_the_sale_price = int.Parse(Console.ReadLine());

            int sale_price

            sale_price = cost_price + (cost_price * percentage_for_the_sale_price / 100);

            Console.WriteLine(sale_price)

        }
        public static void Exercise12()
        {
            int factory_car_cost = int.Parse(Console.ReadLine());
            int taxes = 45 * factory_car_cost / 100

            int distributor_part = 28 * (factory_car_cost + taxes) / 100


            Console.Write(factory_car_cost + taxes + distributor_part)

        }
    }
}
