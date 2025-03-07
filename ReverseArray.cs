      string s = Console.ReadLine();
      int[] arr = Array.ConvertAll(s.Split(' '), int.Parse);
      if(arr.Length > 1){
      int n = arr.Length;
        for(int i = 0; i < n / 2; i++) {
          int temp = arr[i];
          arr[i] = arr[n - i - 1];
          arr[n - i - 1] = temp;
        }
      }
      Console.WriteLine($"{string.Join(',', arr)}");