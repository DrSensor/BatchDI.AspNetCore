using System;

namespace Example.Services
{
    public class ScopedService
    {
        private int counter = 0;
        public int count
        {
            get
            {
                return counter;
            }
        }

        public ScopedService()
        {
            counter += 1;
        }
    }
}