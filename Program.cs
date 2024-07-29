namespace switchMenu
{
    internal class Program
    {



        static bool IsNumeric(string card)
        {
           
            return int.TryParse(card, out _);
        }

        private static void Main(string[] args) 
        {
            Console.WriteLine("Cake  Studio");
            Console.WriteLine();
            Console.WriteLine("Please select Cake your want:");
            Console.WriteLine("1.Chocolate");
            Console.WriteLine("2.Caramel");
            Console.WriteLine("3.Velvet");
            Console.WriteLine("4.Carrot");
            Console.WriteLine("5.Combo");
            int cake = Convert.ToInt32(Console.ReadLine());

            switch (cake)
            {
                case 1:

                    {
                        Console.WriteLine("Select the size of Chocolate cake");
                        Console.WriteLine("1. Large");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Small");
                        int size = Convert.ToInt32(Console.ReadLine());
                        if (size == 1)
                        {
                            Console.WriteLine("How many Large chocolate cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 Large cake");
                            Console.WriteLine("2. 2 Large cakes");
                            Console.WriteLine("3. 3 Large cakes");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            switch (quantity)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R500");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if(payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();
                                            
                                            if(card != null && IsNumeric(card))  //check if the value is not null before calling the function IsNumeric
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R1000");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice2 = Convert.ToInt32(Console.ReadLine());
                                    if (choice2 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if(payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();
                                            
                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice2 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R1450");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice3 = Convert.ToInt32(Console.ReadLine());
                                    if (choice3 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1 )
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }

                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice3 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;

                            }
                        }
                        else if (size == 2)
                        {
                            Console.WriteLine("How many medium  chocolate cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 Medium cake");
                            Console.WriteLine("2. 2 Medium cakes");
                            Console.WriteLine("3. 3 Medium cakes");
                            int quantity2 = Convert.ToInt32(Console.ReadLine());

                            switch (quantity2)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R300");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1 )
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R600");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    if (choice1 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice1 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R850");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice2 = Convert.ToInt32(Console.ReadLine());
                                    if (choice2 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice2 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;
                            }

                        }
                        else if (size == 3)
                        {
                            Console.WriteLine("How many small chocolate cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 small cake");
                            Console.WriteLine("2. 2 small cakes");
                            Console.WriteLine("3. 3 small cakes");
                            int quantity3 = Convert.ToInt32(Console.ReadLine());

                            switch (quantity3)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R200");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R400");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    if (choice1 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice1 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R580");
                                    Console.WriteLine("would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice2 = Convert.ToInt32(Console.ReadLine());
                                    if (choice2 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice2 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("invalid Chocolate cake size");
                        }

                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Select the size of Caramel cake");
                        Console.WriteLine("1. Large");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Small");
                        int size2 = Convert.ToInt32(Console.ReadLine());
                        if (size2 == 1)
                        {
                            Console.WriteLine("How many Large caramel cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 Large caramel cake");
                            Console.WriteLine("2. 2 Large caramel cakes");
                            Console.WriteLine("3. 3 Large caramel cakes");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            switch (quantity)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R490");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R980");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    if (choice1 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice1 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R1400");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice2 = Convert.ToInt32(Console.ReadLine());
                                    if (choice2 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice2 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;


                            }

                        }
                        else if (size2 == 2)
                        {
                            Console.WriteLine("How many medium caramel cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 Medium  caramel cake");
                            Console.WriteLine("2. 2 Medium caramel cakes");
                            Console.WriteLine("3. 3 Medium caramel cakes");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            switch (quantity)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R300");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R580");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    if (choice1 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice1 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R950");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice2 = Convert.ToInt32(Console.ReadLine());
                                    if (choice2 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice2 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;


                            }

                        }
                        else if (size2 == 3)
                        {
                            Console.WriteLine("How many small caramel cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 Small caramel cake");
                            Console.WriteLine("2. 2 Small caramel cakes");
                            Console.WriteLine("3. 3 Small caramel cakes");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            switch (quantity)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R190");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1 )
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R380");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice2 = Convert.ToInt32(Console.ReadLine());
                                    if (choice2 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice2 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R700");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice3 = Convert.ToInt32(Console.ReadLine());
                                    if (choice3 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice3 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;


                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid Caramel cake size");
                        }



                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Select the size of Velvet cake");
                        Console.WriteLine("1. Large");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. small");
                        int size3 = Convert.ToInt32(Console.ReadLine());
                        if (size3 == 1)
                        {
                            Console.WriteLine("How many Large velvet cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 Large velvet cake");
                            Console.WriteLine("2. 2 Large velvet cakes");
                            Console.WriteLine("3. 3 Large velvet cakes");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            switch (quantity)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R480");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R970");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    if (choice1 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1 )
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice1 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R1300");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice2 = Convert.ToInt32(Console.ReadLine());
                                    if (choice2 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1 )
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice2 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;


                            }
                        }
                        else if (size3 == 2)
                        {
                            Console.WriteLine("How many Medium velvet cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 Medium velvet cake");
                            Console.WriteLine("2. 2 Medium velvet cakes");
                            Console.WriteLine("3. 3 Medium velvet cakes");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            switch (quantity)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R180");
                                    Console.WriteLine("would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1 )
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R380");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    if (choice1 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice1 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R770");
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;


                            }
                        }
                        else if (size3 == 3)
                        {
                            Console.WriteLine("How many Small velvet cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 Small velvet cake");
                            Console.WriteLine("2. 2 Small velvet cakes");
                            Console.WriteLine("3. 3 Small velvet cakes");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            switch (quantity)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R150");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R300");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    if (choice1 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice1 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R440");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice2 = Convert.ToInt32(Console.ReadLine());
                                    if (choice2 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1 )
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice2 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;


                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid velvet cake size");
                        }

                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Select the size");
                        Console.WriteLine("1. Large");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Small");
                        int size4 = Convert.ToInt32(Console.ReadLine());
                        if (size4 == 1)
                        {
                            Console.WriteLine("How many Large carrot cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 Large carrot cake");
                            Console.WriteLine("2. 2 Large carrot cakes");
                            Console.WriteLine("3. 3 Large carrot cakes");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            switch (quantity)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R510");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1 )
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R1010");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    if (choice1 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1 )
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice1 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R1500");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice2 = Convert.ToInt32(Console.ReadLine());
                                    if (choice2 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice2 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;


                            }

                        }
                        else if (size4 == 2)
                        {
                            Console.WriteLine("How many medium carrot cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 Medium carrot cake");
                            Console.WriteLine("2. 2 Medium carrot cakes");
                            Console.WriteLine("3. 3 Medium carrot cakes");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            switch (quantity)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R260");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R510");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    if (choice1 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice1 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R1000");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice2 = Convert.ToInt32(Console.ReadLine());
                                    if (choice2 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1 )
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice2 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;


                            }
                        }
                        else if (size4 == 3)
                        {
                            Console.WriteLine("How many smalll carrot cakes do you want ");
                            Console.WriteLine("You can select up to 3 ");
                            Console.WriteLine("1. 1 Small carrot cake");
                            Console.WriteLine("2. 2 Small carrot  cakes");
                            Console.WriteLine("3. 3 Small carrot  cakes");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            switch (quantity)
                            {
                                case 1:
                                    Console.WriteLine("Total amount to pay is R160");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1 )
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }   
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Total amount to pay is R320");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice1 = Convert.ToInt32(Console.ReadLine());
                                    if (choice1 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice1 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Total amount to pay is R610");
                                    Console.WriteLine("Would you like to proceed with the payment?");
                                    Console.WriteLine("1.Yes");
                                    Console.WriteLine("2.No");
                                    int choice2 = Convert.ToInt32(Console.ReadLine());
                                    if (choice2 == 1)
                                    {
                                        Console.WriteLine("Pay with card or cash?");
                                        Console.WriteLine("1.Cash");
                                        Console.WriteLine("2.Card");
                                        int payment = Convert.ToInt32(Console.ReadLine());
                                        if (payment == 1)
                                        {
                                            Console.WriteLine("Thank you for choosing us");
                                        }
                                        else if (payment == 2)
                                        {
                                            Console.WriteLine("Please enter card number");
                                            string? card = Console.ReadLine();

                                            if (card != null && IsNumeric(card))
                                            {
                                                Console.WriteLine("Verifying your card(Accept/Decline)");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid card number");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid payment type");
                                        }

                                    }
                                    else if (choice2 == 2)
                                    {
                                        Console.WriteLine("Payment canceled");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ïnvalid selection");
                                    }
                                    break;
                                default: Console.WriteLine("invalid quantity"); break;


                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid carrot cake size");
                        }

                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Select 2 the flavors");
                        Console.WriteLine("1. Chocolate");
                        Console.WriteLine("2. Velvet");
                        Console.WriteLine("3. Caramel");
                        int flavor1 = Convert.ToInt32(Console.ReadLine());
                        int flavor2 = Convert.ToInt32(Console.ReadLine());
                        if (flavor1 == 1 && flavor2 == 2 || flavor1 == 2 && flavor2 == 1)
                        {
                            Console.WriteLine("Select the size of (Chocolate/Velvet)");
                            Console.WriteLine("1. Large");
                            Console.WriteLine("2. Medium");
                            Console.WriteLine("3. Small");
                            int size5 = Convert.ToInt32(Console.ReadLine());

                            if (size5 == 1)
                            {
                                Console.WriteLine("How many Large(Chocolate/Velvet)  cakes do you want ");
                                Console.WriteLine("You can select up to 3 ");
                                Console.WriteLine("1. 1 Large combo cake");
                                Console.WriteLine("2. 2 Large combo cakes");
                                Console.WriteLine("3. 3 Large cakes");
                                int quantity = Convert.ToInt32(Console.ReadLine());

                                switch (quantity)
                                {
                                    case 1:
                                        Console.WriteLine("Total amount to pay is R600");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }

                                        break;
                                    case 2:
                                        Console.WriteLine("Total amount to pay is R1200");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice1 = Convert.ToInt32(Console.ReadLine());
                                        if (choice1 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice1 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Total amount to pay is R1700");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice2 = Convert.ToInt32(Console.ReadLine());
                                        if (choice2 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1 )
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice2 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    default: Console.WriteLine("invalid quantity"); break;
                                }
                            }
                            else if (size5 == 2)
                            {
                                Console.WriteLine("How many medium(Chocolate/Velvet)  cakes do you want ");
                                Console.WriteLine("You can select up to 3 ");
                                Console.WriteLine("1. 1 Medium combo cake");
                                Console.WriteLine("2. 2 Medium combo cakes");
                                Console.WriteLine("3. 3 Medium combo cakes");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                switch (quantity)
                                {
                                    case 1:
                                        Console.WriteLine("Total amount to pay is R350");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1 )
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }

                                        break;
                                    case 2:
                                        Console.WriteLine("Total amount to pay is R700");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice1 = Convert.ToInt32(Console.ReadLine());
                                        if (choice1 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1 )
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice1 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Total amount to pay is R1000");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice2 = Convert.ToInt32(Console.ReadLine());
                                        if (choice2 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1 )
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice2 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    default: Console.WriteLine("invalid quantity"); break;
                                }

                            }
                            else if (size5 == 3)
                            {
                                Console.WriteLine("How many small (Chocolate/velvet)  cakes do you want ");
                                Console.WriteLine("You can select up to 3 ");
                                Console.WriteLine("1. 1 Small combo cake");
                                Console.WriteLine("2. 2 Small combo cakes");
                                Console.WriteLine("3. 3 Small combo  cakes");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                switch (quantity)
                                {
                                    case 1:
                                        Console.WriteLine("Total amount to pay is R200");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }

                                        break;
                                    case 2:
                                        Console.WriteLine("Total amount to pay is R400");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice1 = Convert.ToInt32(Console.ReadLine());
                                        if (choice1 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice1 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Total amount to pay is R600");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice2 = Convert.ToInt32(Console.ReadLine());
                                        if (choice2 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice2 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    default: Console.WriteLine("invalid quantity"); break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid cake size");
                            }

                        }
                        else if (flavor1 == 2 && flavor2 == 3 || flavor1 == 3 && flavor2 == 2)
                        {
                            Console.WriteLine("Select the size of cake(Velvet/Caramel)");
                            Console.WriteLine("1. Large");
                            Console.WriteLine("2. Medium");
                            Console.WriteLine("3. small");
                            int size6 = Convert.ToInt32(Console.ReadLine());
                            if (size6 == 1)
                            {
                                Console.WriteLine("How many Large (velvet/caramel) cakes do you want ");
                                Console.WriteLine("You can select up to 3 ");
                                Console.WriteLine("1. 1 Large cake");
                                Console.WriteLine("2. 2 Large cakes");
                                Console.WriteLine("3. 3 Large cakes");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                switch (quantity)
                                {
                                    case 1:
                                        Console.WriteLine("Total amount to pay is R650");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1 )
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }

                                        break;
                                    case 2:
                                        Console.WriteLine("Total amount to pay is R1300");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice1 = Convert.ToInt32(Console.ReadLine());
                                        if (choice1 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1 )
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice1 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Total amount to pay is R1900");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice2 = Convert.ToInt32(Console.ReadLine());
                                        if (choice2 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice2 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    default: Console.WriteLine("invalid quantity"); break;
                                }
                            }
                            else if (size6 == 2)
                            {
                                Console.WriteLine("How many medium (velvet/caramel) cakes do you want ");
                                Console.WriteLine("You can select up to 3 ");
                                Console.WriteLine("1. 1 Medium cake");
                                Console.WriteLine("2. 2 Medium cakes");
                                Console.WriteLine("3. 3 Medium cakes");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                switch (quantity)
                                {
                                    case 1:
                                        Console.WriteLine("Total amount to pay is R300");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }

                                        break;
                                    case 2:
                                        Console.WriteLine("Total amount to pay is R600");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice1 = Convert.ToInt32(Console.ReadLine());
                                        if (choice1 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice1 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Total amount to pay is R870");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice2 = Convert.ToInt32(Console.ReadLine());
                                        if (choice2 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice2 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    default: Console.WriteLine("invalid quantity"); break;
                                }
                            }
                            else if (size6 == 3)
                            {
                                Console.WriteLine("How many small (velvet/caramel) cakes do you want ");
                                Console.WriteLine("You can select up to 3 ");
                                Console.WriteLine("1. 1 Small cake");
                                Console.WriteLine("2. 2 Small cakes");
                                Console.WriteLine("3. 3 Small cakes");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                switch (quantity)
                                {
                                    case 1:
                                        Console.WriteLine("Total amount to pay is R200");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1 )
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }

                                        break;
                                    case 2:
                                        Console.WriteLine("Total amount to pay is R400");
                                        Console.WriteLine("would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice1 = Convert.ToInt32(Console.ReadLine());
                                        if (choice1 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1 )
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice1 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Total amount to pay is R550");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice2 = Convert.ToInt32(Console.ReadLine());
                                        if (choice2 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice2 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    default: Console.WriteLine("invalid quantity"); break;
                                }
                            }

                        }
                        else if (flavor1 == 1 && flavor2 == 3 || flavor1 == 3 && flavor2 == 1)
                        {
                            Console.WriteLine("Select the size of (Chocolate/caramel) cake");
                            Console.WriteLine("1. Large");
                            Console.WriteLine("2. Medium");
                            Console.WriteLine("3. Small");
                            int size7 = Convert.ToInt32(Console.ReadLine());
                            if (size7 == 1)
                            {
                                Console.WriteLine("How many Large (Chocolate/caramel) cakes do you want ");
                                Console.WriteLine("You can select up to 3 ");
                                Console.WriteLine("1. 1 Large cake");
                                Console.WriteLine("2. 2 Large cakes");
                                Console.WriteLine("3. 3 Large cakes");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                switch (quantity)
                                {
                                    case 1:
                                        Console.WriteLine("Total amount to pay is R620");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }

                                        break;
                                    case 2:
                                        Console.WriteLine("Total amount to pay is R1240");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice1 = Convert.ToInt32(Console.ReadLine());
                                        if (choice1 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice1 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Total amount to pay is R1800");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice2 = Convert.ToInt32(Console.ReadLine());
                                        if (choice2 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice2 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    default: Console.WriteLine("invalid quantity"); break;
                                }
                            }
                            else if (size7 == 2)
                            {
                                Console.WriteLine("How many medium (Chocolate/Caramel) cakes do you want ");
                                Console.WriteLine("You can select up to 3 ");
                                Console.WriteLine("1. 1 Medium cake");
                                Console.WriteLine("2. 2 Medium cakes");
                                Console.WriteLine("3. 3 Medium cakes");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                switch (quantity)
                                {
                                    case 1:
                                        Console.WriteLine("Total amount to pay is R310");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1 )
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }

                                        break;
                                    case 2:
                                        Console.WriteLine("Total amount to pay is R620");
                                        Console.WriteLine("would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice1 = Convert.ToInt32(Console.ReadLine());
                                        if (choice1 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1 )
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice1 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Total amount to pay is R900");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice2 = Convert.ToInt32(Console.ReadLine());
                                        if (choice2 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1 )
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice2 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    default: Console.WriteLine("invalid quantity"); break;
                                }
                            }
                            else if (size7 == 3)
                            {
                                Console.WriteLine("How many small (Chocolate/Caramel) cakes do you want ");
                                Console.WriteLine("You can select up to 3 ");
                                Console.WriteLine("1. 1 Small cake");
                                Console.WriteLine("2. 2 Small cakes");
                                Console.WriteLine("3. 3 Small cakes");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                switch (quantity)
                                {
                                    case 1:
                                        Console.WriteLine("Total amount to pay is R200");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }

                                        break;
                                    case 2:
                                        Console.WriteLine("Total amount to pay is R400");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice1 = Convert.ToInt32(Console.ReadLine());
                                        if (choice1 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice1 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Total amount to pay is R600");
                                        Console.WriteLine("Would you like to proceed with the payment?");
                                        Console.WriteLine("1.Yes");
                                        Console.WriteLine("2.No");
                                        int choice2 = Convert.ToInt32(Console.ReadLine());
                                        if (choice2 == 1)
                                        {
                                            Console.WriteLine("Pay with card or cash?");
                                            Console.WriteLine("1.Cash");
                                            Console.WriteLine("2.Card");
                                            int payment = Convert.ToInt32(Console.ReadLine());
                                            if (payment == 1)
                                            {
                                                Console.WriteLine("Thank you for choosing us");
                                            }
                                            else if (payment == 2)
                                            {
                                                Console.WriteLine("Please enter card number");
                                                string? card = Console.ReadLine();

                                                if (card != null && IsNumeric(card))
                                                {
                                                    Console.WriteLine("Verifying your card(Accept/Decline)");

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid card number");
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid payment type");
                                            }

                                        }
                                        else if (choice2 == 2)
                                        {
                                            Console.WriteLine("Payment canceled");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ïnvalid selection");
                                        }
                                        break;
                                    default: Console.WriteLine("invalid quantity"); break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid quantity");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid flavor choice");
                        }

                    }
                    break;
                default: Console.WriteLine("Invalid cake flavor"); break;
            }
        }
    }
}
 
