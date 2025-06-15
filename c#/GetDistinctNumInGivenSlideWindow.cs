    public List<int> countDistinct(int[] arr, int k) {
        int l = arr.Length - k;
        List<int> result = new List<int>();
        for(int i = 0; i <= l; i++){
         HashSet<int> s =
         new HashSet<int>(arr.Skip(i).Take(k));
         result.Add(s.Count);
        }
        return result;
    }