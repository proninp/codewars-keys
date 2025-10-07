﻿using System.Linq;

namespace Kata._6_kyu.Create_Phone_Number.src
{
    public class CreatePhoneNumberTask
    {
        public static string CreatePhoneNumber(int[] n) =>
            string.Format(
                "({0}) {1}-{2}",
                string.Join("", n.Take(3)),
                string.Join("", n.Skip(3).Take(3)),
                string.Join("", n.Skip(6))
                );
    }
}