        string s = Console.ReadLine();
            int[] arr = Array.ConvertAll(s.Split(' '), int.Parse);
            int first = -1;
            int second = -1;
            foreach(int i in arr){
                if(i > first){
                    second = first;
                    first = i;
                }else if(i > second && i != first){
                    second = i;
                }
            }
            Console.WriteLine($"first: {first}, second: {second}");