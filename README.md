# C-2.

  Console.WriteLine("Please enter comma separated numbers");
            string input = Console.ReadLine();
            #region array example
            //// comma separated input to find even numbers

            string[] numbers = input.Split(',');
            //Console.WriteLine("Please enter comma separated numbers");
            //string input = Console.ReadLine();

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i]) % 2 == 0)
                {
                    Console.Write($"{numbers[i]} ");
                    counter++;
                }
            }
            Console.WriteLine($"\nNumber of Even Numbers : {counter}");
            //string[] numbers = input.Split(',');

            Console.WriteLine("Please enter a target number to find even numbers");
            int target = int.Parse(Console.ReadLine());
            //int counter = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (int.Parse(numbers[i]) % 2 == 0)
            //    {
            //        Console.Write($"{numbers[i]} ");
            //        counter++;
            //    }
            //}
            //Console.WriteLine($"\nNumber of Even Numbers : {counter}");

            int[] evens = new int[target / 2]; // array size = half
            int c = 0;
            for (int i = 0, j = 0; j <= target; i += 2, j++)
            {
                evens[i] = i + 2;
                //if (i % 2 == 0)
                //{
                //    evens[i] = i;
                //}
            }
            // int[] evens = new int[c];
            Console.WriteLine("All Even Number");
            for (int i = 0; i < evens.Length; i++)
            #endregion array example

            #region even number till given target

            //Console.WriteLine("Please enter a target number");
            //int target = int.Parse(Console.ReadLine());

            //int evenCount = target / 2;
            //int[] evens = new int[evenCount];
            //// int counter = 2;

            //for (int i = 0, counter = 2; i < evenCount; i++, counter+=2)
            //{
            //    evens[i] = counter;
            //    //if(i % 2 == 0)
            //    //{
            //    //    evens[i] = i;
            //    //}
            //}

            //for (int i = 0; i < evens.Length; i++)
            //{
            //    Console.Write($"{evens[i]} ");
            //}

            ////for (int i = 1; i <= target; i++)
            ////{
            ////    if(i % 2 == 0)
            ////    {
            ////        Console.Write($"{i} ");
            ////    }
            ////}
            //Console.WriteLine(); // new line

            #endregion even number till given target

            // multi dimensional array
            // array of arrays

            // int[] numbers = new int[2];
            int[,] numbers = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{evens[i]} ");
                for (int j = 0; j < 3; j++)
                {
                    // Console.Write($"{i}{j} ");
                    if (i == j)
                    {
                        Console.Write($"*\t");
                    }
                    else
                    {
                        Console.Write($"\t");
                    }
                }
                Console.WriteLine(); // new line
            }
