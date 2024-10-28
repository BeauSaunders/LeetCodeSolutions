/*
Last Solved: 28.10.24
Topics Utilised: Binary Search, Hash Table
Link: https://leetcode.com/problems/time-based-key-value-store/
Time Complexity: 
  Set - O(1)
  Get - O(log m) (where m is the number of timestamp entries related to the given key in the Hash Table)
Space Complexity:
  Set - O(n)
  Get - O(1)
*/

public class TimeMap {

    Dictionary<string, List<TimeMapValue>> dict = new Dictionary<string, List<TimeMapValue>>();

    public TimeMap() {
        dict.Clear();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!dict.ContainsKey(key)){
            dict[key] = new List<TimeMapValue>();
        }

        dict[key].Add(new TimeMapValue(value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        string res = "";

        if (!dict.ContainsKey(key))
            return res;

        var list = dict[key];

        int l = 0;
        int r = list.Count - 1;
        int mid;
        while (l <= r){
            mid = l + ((r - l) / 2);

            //Valid option
            if (list[mid].Timestamp <= timestamp){
                //Could be this one or one closer
                res = list[mid].Value;
                l = mid + 1;
            }
            //Too big
            else{
                r = mid - 1;
            }
        }

        return res;
    }

    private class TimeMapValue{
        public string Value;
        public int Timestamp;

        public TimeMapValue(string val, int time){
            Value = val;
            Timestamp = time;
        }
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */
