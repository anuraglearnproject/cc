static List<int> CountDistinctInWindow(int[] arr, int k)
    {
        List<int> result = new List<int>();
        HashSet<int> windowSet = new HashSet<int>();

        // Initialize the first window
        for (int i = 0; i < k; i++)
        {
            windowSet.Add(arr[i]);
        }
        result.Add(windowSet.Count);

        // Slide the window across the array
        for (int i = k; i < arr.Length; i++)
        {
            // Remove the element that is sliding out of the window
            windowSet.Remove(arr[i - k]);
            
            // Add the new element that is sliding into the window
            windowSet.Add(arr[i]);
            
            // Add the distinct element count in the current window
            result.Add(windowSet.Count);
        }

        return result;
    }