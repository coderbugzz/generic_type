using System;
using System.Collections.Generic;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataRepository<string> repository = new DataRepository<string>();
            repository.Data = "This is a freecode Zone!";

            string[] lists = { "list 1", "list 2","list 3", "list 4" };
            List<string> mylist = new List<string>(lists);
            DataRepository<List<string>> list = new DataRepository<List<string>>();
            list.Data = mylist;

            List<myModel> modelList = new List<myModel>();
            modelList.Add(new myModel
            {
                name = "freecodespot.com"
            });
            DataRepository<List<myModel>> mymodel = new DataRepository<List<myModel>>();
            mymodel.Data = modelList;
            //Console.WriteLine(mymodel.Data[0].name);

            //generic field class
            TestClass<string> testClass = new TestClass<string>("freecodespot.com");
            //testClass.Write();

            string value = generic_method<string>("freecodespot");
            int intVal = generic_method<int>(123);
            decimal decVal = generic_method<decimal>(123.02M);
            Console.WriteLine(value);

            string gen_return = generic_method2<string,int>("freecodespot",123);

        }

        public static T generic_method<T>(T val)
        {
            return val;
        }

        public static T generic_method2<T,U>(T val,U val2)
        {
            return val;
        }
    }


    class TestClass<T>
    {
        T _value;

        public TestClass(T t)
        {
            this._value = t;
        }   

        public void Write()
        {
            Console.WriteLine(this._value);
        }
    }

    public class DataRepository<T>
    {
        public T Data { get; set; }
    }

    public class UserSession<TUser, TSession>
    {
        public TUser userid { get; set; }
        public TSession session { get; set; }
    }

    public class myModel {
        public string name { get; set; }
    }
}
