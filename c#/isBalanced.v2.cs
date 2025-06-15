    public bool isBalanced(string s) {
        Dictionary<char, char> par = new Dictionary<char, char> {
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };
        Stack<char> t = new Stack<char>();
        foreach(char c in s){
            if(par.ContainsKey(c)){
               t.Push(par[c]);
            }
            else if(t.Count == 0 || t.Pop() != c){
                return false;
            }
        }
        return t.Count == 0;
    }