      string s = Console.ReadLine();
      int[] arr = Array.ConvertAll(s.Split(' '), int.Parse);
      int prevLocation = 0;
      for(int i = 0; i < arr.Length; i++){
          if(arr[i]!=0){
            int temp = arr[prevLocation];
            arr[prevLocation] = arr[i];
            arr[i] = temp;
            prevLocation++;
          }
      }
      Console.Write($"{string.Join(',', arr)}");