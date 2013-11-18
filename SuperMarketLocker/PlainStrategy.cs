﻿using System.Linq;

namespace SuperMarketLocker
{
    public class PlainStrategy : IStrategy
    {
        public Locker GetLocker(Locker[] lockers)
        {
            var first = lockers.FirstOrDefault(l => l.AvailableCount > 0);
            if (first == null)
            {
                throw new LockerFullException();
            }
            return first;
        }
    }
}