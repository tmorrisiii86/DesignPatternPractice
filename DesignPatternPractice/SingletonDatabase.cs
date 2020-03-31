using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPractice
{
    class SingletonDatabase
    {
        //have both public and private version of property
        //property is static so it belongs to class itself

        private static SingletonDatabase _instance = null;
        public static SingletonDatabase instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SingletonDatabase();
                    //when class asked for public property, the constructor is called
                }
                return _instance;
            }
        }
        private SingletonDatabase()
        {
            //constructor is private, so no other class can use it

        }
    }
}
