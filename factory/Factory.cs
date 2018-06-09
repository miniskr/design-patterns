using System;

namespace Factory
{
    public interface ICommunication
    {
        bool Send(object data);
    }

    public class Serial:ICommunication
    {
        public bool Send(object data)
        {
            Console.WriteLine("通过串口发送一个数据");
            return true;
        }
    }

    public class Lan:ICommunication
    {
        public bool Send(object data)
        {
            Console.WriteLine("通过网口发送一个数据");
            return true;
        }
    }

    public class CommunicationFactory
    {
        public ICommunication CreateCommunicationFactory(string style)
        {
            switch(style)
            {
                case "Serial":
                    return new Serial();
                case "Lan":
                    return new Lan();
            }
            return null;
        }
    }
    class Porgram
    {
        static void Main(string[] args)
        {
            CommunicationFactory factory = new CommunicationFactory();
            
            Console.WriteLine("请输入通讯类型:Lan/Serial");
            string input = Console.ReadLine();
            object data = new object();
            factory.CreateCommunicationFactory(input).Send(data);
            Console.ReadKey();
        }
        
    }
}
