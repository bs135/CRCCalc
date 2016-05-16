using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CRCCalc
{
    public static class HexUtils
    {
        private static Regex regexHex16bit = new Regex(@"^0[xX][A-Fa-f0-9]{4}$");
        //private static regexHex1 regexHex = new Regex(@"^0x([A-Fa-f0-9]{2}){1,}$");
        public static Regex regexHex1 = new Regex(@"^0[xX][A-Fa-f0-9]{1,}$");
        public static Regex regexHex2 = new Regex(@"^(\$[A-Fa-f0-9]{2}){1,}$");
        public static Regex regexHex3 = new Regex(@"^[A-Fa-f0-9]{1,}$");

        public static bool IsHex16Bit(string hexString)
        {
            if (regexHex16bit.IsMatch(hexString))
            {
                return true;
            }
            return false;
        }

        public static bool IsHex(string hexString)
        {
            if (regexHex1.IsMatch(hexString) || regexHex2.IsMatch(hexString) || regexHex3.IsMatch(hexString))
            {
                return true;
            }
            return false;
        }

        public static byte[] ParseHexToBytes(this string hexString)
        {
            string hexStringTemp = "";
            if (regexHex1.IsMatch(hexString))
            {
                hexStringTemp = hexString.Replace("x", "").Replace("X", "");
            }
            else if(regexHex2.IsMatch(hexString))
            {
                hexStringTemp = hexString.Replace("$", "");
            }
            else if (regexHex3.IsMatch(hexString))
            {
                hexStringTemp = "0" + hexString;
            }
            else
            {
                return null;
            }

            if (hexStringTemp.Length % 2 != 0)
            {
                hexStringTemp = hexStringTemp.Substring(1, hexStringTemp.Length - 1);
            }

            return Enumerable.Range(0, hexStringTemp.Length)
                                 .Where(x => x % 2 == 0)
                                 .Select(x => Convert.ToByte(hexStringTemp.Substring(x, 2), 16))
                                 .ToArray();
        }

        public static byte[] ParseStringToBytes(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            return Encoding.ASCII.GetBytes(str);
        }

    }
}
