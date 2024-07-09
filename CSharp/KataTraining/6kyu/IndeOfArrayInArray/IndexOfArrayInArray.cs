﻿using System;
using System.Linq;

namespace _6kyu.IndeOfArrayInArray
{
    public class IndexOfArrayInArray
    {
        public static int SearchArray(object[][] arrayToSearch, object[] query)
        {
            if (query is null || query.Length != 2)
                throw new Exception();
            if (arrayToSearch.Any(x => x is null || x is not object[] || x.Length != 2))
                throw new Exception();
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                if (arrayToSearch[i].SequenceEqual(query))
                    return i;
            }
            return -1;
        }
    }
}