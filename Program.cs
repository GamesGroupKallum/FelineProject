using System;
using System.Reflection;

namespace FelineProjecr
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.Name == "Program")
                    continue;
                if (type.IsAbstract)
                    continue;
                
                Feline feline = (Feline)Activator.CreateInstance(type);

                foreach (MethodInfo method in type.GetMethods())
                {
                    if (method.Name == "Equals" || method.Name == "GetHashCode" || method.Name == "GetType" || method.Name == "ToString")
                        continue;

                    method.Invoke(feline, null);
                }
                
            }
        }
    }
}
