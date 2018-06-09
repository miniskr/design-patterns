//单线程单例模式
namespace Singleton
{
    class SingleThread_Singleton
    {
        private static SingleThread_Singleton instance = null;
        private SingleThread_Singleton(){}

        public static SingleThread_Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SingleThread_Singleton();
                }
                return instance;
            }
        }
    }

    //多线程单例模式
    class MultiThread_Singleton
    {
        private static volatile MultiThread_Singleton instance = null;
        private static object lockHelper = new object();
        private MultiThread_Singleton(){}
        public static MultiThread_Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(lockHelper)
                    {
                        if(instance == null)
                        {
                            instance = new MultiThread_Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }

    //静态Singleton实现
    class Static_Singleton
    {
        public static readonly Static_Singleton instance = new Static_Singleton();
        private Static_Singleton(){}
    }

    //以上代码等同于
    class Static_Singleton1
    {
        public static readonly Static_Singleton1 instance;
        static Static_Singleton1()
        {
            instance = new Static_Singleton1();
        }
        private Static_Singleton1(){}
    }
}



