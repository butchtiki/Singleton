using System;
namespace Singleton
{
    public class DbManager
    {
        private static DbManager singletonObj;

        private DbManager()
        {

        }

        public static DbManager GetInstance()
        {
            if(singletonObj == null)
            {
                singletonObj = new DbManager();
            }

            return singletonObj;
        }
    }
}
