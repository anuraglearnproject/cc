public string findLargest(int n, int s) {
    // If sum 's' is impossible (greater than the max possible sum for 'n' digits)
    // or if sum s is 0 and n > 1, return -1.
    if (s > 9 * n || s < 0 || (s == 0 && n > 1)) {
        return "-1";  
    }

    // Calculate how many 9's we can use from the sum 's'
    int fullNines = s / 9;
    int remainder = s % 9;

    StringBuilder sb = new StringBuilder();

    // Append '9's first
    sb.Append("".PadLeft(fullNines, '9'));

    // If there's a remainder, append it as the next digit
    if (remainder > 0) {
        sb.Append((char)('0' + remainder));
    }

    // Pad the remaining positions with '0's to ensure the result has exactly 'n' digits
    sb.Append("".PadLeft(n - sb.Length, '0'));

    return sb.ToString();
}
