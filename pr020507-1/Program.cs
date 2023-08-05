using System.Linq.Expressions;

namespace pr020507_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input: ");
            Console.WriteLine("Entered Input Validation is: "+IsValid(Console.ReadLine()));


            
        }

        public static bool IsValid(string input)
        {
            Stack<char> stack = new();
            bool flag=false;

            foreach (char c in input)
            {
                if(c == '{' || c == '(' || c == '[' || c == '<')
                {
                    stack.Push(c);
                    flag = true;
                }
                else if(stack.Count>0 && flag) //if (c == '}' || c == ')' || c == ']' || c == '>')
                {
                    
                        char buf = stack.Pop();
                        switch (c)
                        {
                            case '}':
                                if (buf != '{') flag = false;
                                
                                break;
                            case ')':
                                if (buf != '(') flag = false;
                                break;
                            case ']':
                                if (buf != '[') flag = false;
                                break;
                            case '>':
                                if (buf != '<') flag = false;
                                break;

                            default:
                                flag = false;
                                break;
                        }
                    
                    
                    
                        

                    
                    

                }
            }

            if (stack.Count > 0) flag = false;

            return flag;
        }
    }
}