
using System.Text;

class Program
{
    class Solution
    {
        public string countAndSay(int n)
        {
            if(n == 1)  return "1"; 

            string orignalString = "1";
            for(int i = 1;i < n; i++)
            {
                int sum = 1;
                StringBuilder newSeq = new StringBuilder(50);
                char current = orignalString[0];
                for(int j=1;j < orignalString.Length;j++)
                {
                    if (current == orignalString[j])
                    {
                        sum ++;
                    }
                    else
                    {
                        newSeq.Append(sum.ToString());
                        newSeq.Append(current);
                        sum = 1;
                        current = orignalString[j];
                    }
                }

                newSeq.Append(sum.ToString());
                newSeq.Append(current);
                orignalString = newSeq.ToString();
            }
            return orignalString;
        }
    }

    public static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine("Enter Number");
        var number = int.Parse(Console.ReadLine());
        string value = s.countAndSay(number);
        Console.WriteLine($"The Result of {number} is : ");
        Console.WriteLine(value);
        Console.WriteLine(s.countAndSay(5));
        Console.WriteLine(s.countAndSay(6));
    }
}