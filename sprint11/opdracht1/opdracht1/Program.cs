using System;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            variabelen();
            HoeveelCentimeter(152);
            numeric();
            var btw = HoeveelBTW(440, BTWpercentage.laag);
            string[,] whiskys = new string[5,3];
            whiskys[0, 0] = "Caol Ila";
            whiskys[1, 0] = "MacAllan ";
            whiskys[2, 0] = "Arran";
            whiskys[3, 0] = "Maltman";
            whiskys[4, 0] = "Nikka";

            whiskys[0, 1] = "12 jaar";
            whiskys[1, 1] = "10 jaar";
            whiskys[2, 1] = "14 jaar";
            whiskys[3, 1] = "12 jaar";
            whiskys[4, 1] = "blended";

            whiskys[0, 2] = "43%";
            whiskys[1, 2] = "40%";
            whiskys[2, 2] = "46%";
            whiskys[3, 2] = "46%";
            whiskys[4, 2] = "43%";




            //oefening 8 
            Console.WriteLine("voer een getal in: ");
            string invoer = Console.ReadLine();
            float inch = 0;
            var gelukt = Single.TryParse(invoer, out inch);
            HoeveelCentimeter(inch);
            //oefening 9
            var centimeter = HoeveelCentimeter2(inch);


            //oefening 12
           /* Console.WriteLine("kies btw of inch");
            string btw1 = Console.ReadLine().ToLower();
            string inch2 = Console.ReadLine().ToLower();
            if ( btw1 == "btw" ) 
            {
                Console.WriteLine("voer het bedrag in");
                int percentage = Convert.ToInt32(Console.ReadLine()); 
                switch (percentage)
                {
                   case BTWpercentage.verlegd:
                        //iets
                        break;
                   case BTWpercentage.hoog:            
                        //iets
                        break;
                    case BTWpercentage.laag:
                        //iets
                        break;
                }
            }
            if (inch2 == "inch")
            {
                Console.WriteLine("voer het aantal inch in");
                Console.ReadLine();
            } */
        }
        static void variabelen()
        {
            //oefening 6
            int getal = 1;
            long langGetal = 4294967295;
            string tekst = "saai stukje tekst";
            Console.WriteLine($"het getal heeft de waarde {getal} en de tekst is '{tekst}' het lange getal is {langGetal}");
        }
        static void HoeveelCentimeter(float inch)
        {
            //oefening 7
            const float centimeterPerInch = 2.54F;
            var centimeter = inch * centimeterPerInch;
            Console.WriteLine($"Er gaat {centimeter} cm in {inch} inch");
        }
        static void numeric()
        {
            //oefening 9
            Console.WriteLine("type a number");
            string number = Console.ReadLine();
            Convert.ToInt32(number);
            Console.WriteLine("converted number: " + number);

        }
        static float HoeveelCentimeter2(float inch)
        {
            //oefening 10

            //de conversiefactor coor inch naar centimeter
            //zal nooit veranderen
            const float centimeterPerInch2 = 2.54F;
            var centimeter = inch = centimeterPerInch2;
            return centimeter;
        }
        
        // oefening 11
        public enum BTWpercentage { verlegd, laag, hoog }
        static float HoeveelBTW(float bedrag, BTWpercentage percentage)
        {
            float btw = bedrag / 100 * (int) percentage;
    
            return btw;
        }
    }
}
