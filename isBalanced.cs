    public bool isBalanced(string s) {
    List<char> openers = new List<char>(){ '(','{','[' };
    List<char> closers = new List<char>(){ ')','}',']' };
    List<char> open = new List<char>();
    foreach(var c in s){
        if(openers.Contains(c)){
            open.Add(c);
        }
        else if(closers.Contains(c)) { 
            int getIndex = closers.IndexOf(c);
            char getOpener = openers[getIndex];
            if(open.Count > 0
            && open[open.Count - 1] == getOpener){
                open.RemoveAt(open.Count - 1);
            } else {
                return false;
            }
        }
    }
    return open.Count == 0;
  }
