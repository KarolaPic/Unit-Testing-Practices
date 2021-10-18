using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace tdd
{
    public class Conversor
    {
        public string Conver(string bInit, string bConvert, string value)
        {
            switch (bConvert)
            {
                case "2":
                    if(bInit == "10")
                        return ConvertDecimalToBinary(value);
                    if (bInit == "16")
                        return ConvertHexToBinary(value);
                    break;
                case "10":
                    if (bInit == "2")
                        return ConvertBinaryToDecimal(value);
                    if (bInit == "16")
                        return ConvertHexToDecimal(value);
                    break;
                case "16":
                    if (bInit == "10")
                        return ConvertDecimalToHex(value);
                    if (bInit == "2")
                        return ConvertBinaryToHex(value);
                    break;
            }
            return String.Empty;
        }

        private string ConvertDecimalToBinary(string value)
        { 
            // se convierte valor a entero
            var castedValue = System.Convert.ToInt32(value);
            var bynaryResult = System.Convert.ToString(castedValue, 2);
            var result = "";

            while(castedValue > 0)
            {
                result += (castedValue % 2).ToString();
                castedValue = castedValue / 2;
            }
            var charResult = result.ToCharArray();
            Array.Reverse(charResult);
            //return new String(charResult); 
            return bynaryResult;
        }

        private string ConvertHexToBinary(string value)
        {
            // se debe mandar el numero en hexa
            var bin = Convert.ToString(Convert.ToSByte(value, 16), 2);
            return bin;
        }

        private string ConvertBinaryToDecimal(string value)
        {
            var dec = Convert.ToInt32(value, 2);
            return dec.ToString();
        }

        private string ConvertHexToDecimal(string value)
        {
            var dec = Convert.ToString(Convert.ToSByte(value, 16), 10);
            return dec;
        }

        private string ConvertDecimalToHex(string value)
        {
            var castedValue = System.Convert.ToInt32(value);
            var hex = Convert.ToString(castedValue, 16);
            return hex;
        }

        private string ConvertBinaryToHex(string value)
        {
            var hex = Convert.ToString(Convert.ToSByte(value, 2), 16);
            return hex;
        }
    }
}
