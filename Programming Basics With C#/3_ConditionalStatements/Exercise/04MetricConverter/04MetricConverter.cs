    using System;

    namespace MetricConverter
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                double value = double.Parse(Console.ReadLine());
                double output = 0;
                var inUnut = Console.ReadLine();
                var outUnit = Console.ReadLine();

                //1 meter(m) 1000 millimeters(mm)
                //1 meter(m) 100 centimeters(cm)
                //1 meter(m) 0.000621371192 miles(mi)
                //1 meter(m) 39.3700787 inches(in)
                //1 meter(m) 0.001 kilometers(km)
                //1 meter(m) 3.2808399 feet(ft)
                //1 meter(m) 1.0936133 yards(yd)

                string meters = "m";
                string millimeters = "mm";
                string centimeters = "cm";
                string miles = "mi";
                string inches = "in";
                string kilometers = "km";
                string feet = "ft";
                string yards = "yd";

                if (inUnut == meters)
                {
                    if (outUnit == millimeters)
                    {
                        output = value * 1000;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == centimeters)
                    {
                        output = value * 100;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == miles)
                    {
                        output = value * 0.000621371192;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == inches)
                    {
                        output = value * 39.3700787;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == kilometers)
                    {
                        output = value * 0.001;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == feet)
                    {
                        output = value * 3.2808399;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == yards)
                    {
                        output = value * 1.0936133;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == meters)
                    {
                        output = value;
                        Console.WriteLine($"{output:F8}");
                    }
                }
                else if (inUnut == millimeters)
                {
                    if (outUnit == centimeters)
                    {
                        output = value * 100 / 1000;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == miles)
                    {
                        output = value * 0.000621371192 / 1000;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == inches)
                    {
                        output = value * 39.3700787 / 1000;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == kilometers)
                    {
                        output = value * 0.001 / 1000;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == feet)
                    {
                        output = value * 3.2808399 / 1000;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == yards)
                    {
                        output = value * 1.0936133 / 1000;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == meters)
                    {
                        output = value / 1000;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == millimeters)
                    {
                        output = value;
                        Console.WriteLine($"{output:F8}");
                    }
                }
                else if (inUnut == centimeters)
                {
                    if (outUnit == millimeters)
                    {
                        output = value * 1000 / 100;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == miles)
                    {
                        output = value * 0.000621371192 / 100;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == inches)
                    {
                        output = value * 39.3700787 / 100;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == kilometers)
                    {
                        output = value * 0.001 / 100;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == feet)
                    {
                        output = value * 3.2808399 / 100;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == yards)
                    {
                        output = value * 1.0936133 / 100;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == meters)
                    {
                        output = value / 100;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == centimeters)
                    {
                        output = value;
                        Console.WriteLine($"{output:F8}");
                    }
                }
                else if (inUnut == miles)
                {
                    if (outUnit == millimeters)
                    {
                        output = value * 1000 / 0.000621371192;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == centimeters)
                    {
                        output = value * 100 / 0.000621371192;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == inches)
                    {
                        output = value * 39.3700787 / 0.000621371192;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == kilometers)
                    {
                        output = value * 0.001 / 0.000621371192;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == feet)
                    {
                        output = value * 3.2808399 / 0.000621371192;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == yards)
                    {
                        output = value * 1.0936133 / 0.000621371192;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == meters)
                    {
                        output = value / 0.000621371192;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == miles)
                    {
                        output = value;
                        Console.WriteLine($"{output:F8}");
                    }
                }
                else if (inUnut == inches)
                {
                    if (outUnit == millimeters)
                    {
                        output = value * 1000 / 39.3700787;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == centimeters)
                    {
                        output = value * 100 / 39.3700787;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == miles)
                    {
                        output = value * 0.000621371192 / 39.3700787;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == kilometers)
                    {
                        output = value * 0.001 / 39.3700787;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == feet)
                    {
                        output = value * 3.2808399 / 39.3700787;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == yards)
                    {
                        output = value * 1.0936133 / 39.3700787;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == meters)
                    {
                        output = value / 39.3700787;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == inches)
                    {
                        output = value;
                        Console.WriteLine($"{output:F8}");
                    }
                }
                else if (inUnut == kilometers)
                {
                    if (outUnit == millimeters)
                    {
                        output = value * 1000 / 0.001;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == centimeters)
                    {
                        output = value * 100 / 0.001;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == miles)
                    {
                        output = value * 0.000621371192 / 0.001;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == inches)
                    {
                        output = value * 39.3700787 / 0.001;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == feet)
                    {
                        output = value * 3.2808399 / 0.001;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == yards)
                    {
                        output = value * 1.0936133 / 0.001;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == meters)
                    {
                        output = value / 0.001;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == kilometers)
                    {
                        output = value;
                        Console.WriteLine($"{output:F8}");
                    }
                }            
                else if (inUnut == feet )
                {
                    if (outUnit == millimeters)
                    {
                        output = value * 1000 / 3.2808399;
                        Console.WriteLine($"{output:F11}");
                    }
                    else if (outUnit == centimeters)
                    {
                        output = value * 100 / 3.2808399;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == miles)
                    {
                        output = value * 0.000621371192 / 3.2808399;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == inches)
                    {
                        output = value * 39.3700787 / 3.2808399;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == kilometers)
                    {
                        output = value * 0.001 / 3.2808399 ;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == yards)
                    {
                        output = value * 1.0936133 / 3.2808399;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == meters)
                    {
                        output = value / 3.2808399;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == feet)
                    {
                        output = value;
                        Console.WriteLine($"{output:F8}");
                    }
                }
                else if (inUnut == yards )
                {
                    if (outUnit == millimeters)
                    {
                        output = value * 1000 / 1.0936133;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == centimeters)
                    {
                        output = value * 100 / 1.0936133;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == miles)
                    {
                        output = value * 0.000621371192 / 1.0936133;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == inches)
                    {
                        output = value * 39.3700787 / 1.0936133;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == kilometers)
                    {
                        output = value * 0.001 / 1.0936133;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == feet)
                    {
                        output = value * 3.280839 / 1.0936133 ;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == meters)
                    {
                        output = value / 1.0936133;
                        Console.WriteLine($"{output:F8}");
                    }
                    else if (outUnit == yards)
                    {
                        output = value;
                        Console.WriteLine($"{output:F8}");
                    }
                }
            }
        }
    }
