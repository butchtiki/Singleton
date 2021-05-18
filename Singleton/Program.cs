using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DbManager databaseManager = DbManager.GetInstance();

        }
    }
}
