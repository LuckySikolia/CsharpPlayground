using System;

namespace Check_ipv4_addresses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables 
            string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
            string[] address;
            bool validLength;
            bool validZeros;
            bool validRange;

            foreach (string ip in ipv4Input)
            {
                // Split the IP address into parts
                address = ip.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                // Initialize validation flags
                validLength = ValidateLength(address);
                ValidateZeros(address, out validZeros);
                ValidateRange(address, out validRange);

                // Validate the IP address
                if (validLength && validZeros && validRange)
                {
                    Console.WriteLine($"{ip} is a valid IPv4 address");
                }
                else
                {
                    Console.WriteLine($"{ip} is an invalid IPv4 address");
                }
            }
        }

        // Validate if the length of the IP address parts is exactly 4
        static bool ValidateLength(string[] address)
        {
            return address.Length == 4;
        }

        // Validate that there are no leading zeros in any part of the IP address
        static void ValidateZeros(string[] address, out bool validZeros)
        {
            validZeros = true;
            foreach (string number in address)
            {
                if (number.Length > 1 && number.StartsWith("0"))
                {
                    validZeros = false;
                    return;
                }
            }
        }

        // Validate that each number is in the range 0-255
        static void ValidateRange(string[] address, out bool validRange)
        {
            validRange = true;
            foreach (string number in address)
            {
                if (int.TryParse(number, out int value))
                {
                    if (value < 0 || value > 255)
                    {
                        validRange = false;
                        return;
                    }
                }
                else
                {
                    validRange = false;
                    return;
                }
            }
        }
    }
}
