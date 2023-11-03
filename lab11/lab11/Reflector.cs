using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace lab11
{
    internal class Reflector
    {
        private static string fileName = "info.txt";
        private static Assembly assembly;
        public static void GetAssemblyName()
        {
            Console.WriteLine($"{Assembly.GetExecutingAssembly().GetName().Name}");
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                sw.WriteLine($"{Assembly.GetExecutingAssembly().GetName().Name}");
            }
        }
        public static bool HasPublicConstructor(Type type)
        {
            ConstructorInfo[] constructors = type.GetConstructors();
            bool hasPublicConstructor = constructors.Any(constructor => constructor.IsPublic);
            if (hasPublicConstructor)
            {
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine("\npublic constructor:");
                    foreach (ConstructorInfo constructor in constructors)
                    {
                        Console.WriteLine(constructor);
                        sw.WriteLine($"     {constructor}");
                    }
                }
                return true;
            }
            return false;
        }

        public static IEnumerable<string> PublciMetods(Type type)
        {
            IEnumerable<string> publicMethodNames = type.GetMethods(BindingFlags.Public | BindingFlags.Instance).Select(method => method.Name);
            Console.WriteLine($"Общедоступные публичные методы {type.Name}:");
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine($"\n{type.Name} public method");
                foreach (string methodName in publicMethodNames)
                {
                    sw.WriteLine($"     {methodName}");
                    Console.WriteLine(methodName);
                }
            }

            return publicMethodNames;
        }

        public static IEnumerable<string> GetFieldNames(Type type)
        {
            IEnumerable<string> fieldNames = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                .Select(field => field.Name);
            Console.WriteLine($"\nполя {type.Name}:");
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine($"\n{type.Name} Fields");
                foreach (string name in fieldNames)
                {
                    sw.WriteLine($"     {name}");
                    Console.WriteLine(name);
                }
            }
            return fieldNames;
        }
        public static IEnumerable<string> GetPropertyNames(Type type)
        {
            IEnumerable<string> propertyNames = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                .Select(property => property.Name);
            Console.WriteLine($"\nсвойства {type.Name}:");
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine($"\n{type.Name} property");
                foreach (string name in propertyNames)
                {
                    sw.WriteLine($"     {name}");
                    Console.WriteLine(name);
                }
            }
            return propertyNames;
        }

        public static IEnumerable<string> GetClassInterfaces(Type type)
        {
            IEnumerable<string> interfaces = type.GetInterfaces()
           .Select(interf => interf.Name);
            Console.WriteLine($"\nинтерфейсы {type.Name}:");
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine($"\n{type.Name} interfaces");
                foreach (string name in interfaces)
                {
                    sw.WriteLine($"     {name}");
                    Console.WriteLine(name);
                }
            }
            return interfaces;
        }
        public static IEnumerable<string> GetMetodByParm(Type type, string parm)
        {
            
            Type parmType = Type.GetType(parm);

            if (type != null && parmType != null)
            {
                IEnumerable<string> methodsParmType = type.GetMethods()
                    .Where(method => method.GetParameters().Any(param => param.ParameterType == parmType))
                    .Select(method => method.Name);
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    Console.WriteLine($"\nметоды с параметром {parm}");
                    sw.WriteLine($"\n{type.Name} metods with {parm}");
                    foreach (string name in methodsParmType)
                    {
                        sw.WriteLine($"     {name}");
                        Console.WriteLine(name);
                    }
                }
                return methodsParmType;
            }
            else
            {
                Console.WriteLine("Класс или тип параметра не найден.");
                return null;
            }

        }

        public static T Create<T>(params object[] args)
        {
            ConstructorInfo[] constructors = typeof(T).GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                ParameterInfo[] parameters = constructor.GetParameters();
                // Проверяем, совпадают ли параметры конструктора с переданными параметрами
                if (parameters.Length == args.Length)
                {
                    bool parametersMatch = true;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        if (parameters[i].ParameterType != args[i].GetType())
                        {
                            parametersMatch = false;
                            break;
                        }
                    }
                    if (parametersMatch)
                    {
                        return (T)constructor.Invoke(args);
                    }
                }
            }
            throw new ArgumentException("No matching constructor found");
        }
        public static void Invoke(object obj, string methodName, string paramsFilePath = "")
        {
            var method = obj.GetType().GetMethod(methodName);
            
            if (paramsFilePath == "")
            {
                Random rnd = new Random();
                object[] param = { rnd.Next(0, 100), rnd.Next(0, 100) };
                method?.Invoke(obj, param);
            }
            else
            {
                object[] param = new object[2];
                using (StreamReader read = new StreamReader(paramsFilePath))
                {
                    param = read.ReadToEnd().Split(new char[] { ' ' });
                    method?.Invoke(obj, param);
                }
            }
        }
    }
}
