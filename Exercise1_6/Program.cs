// See https://aka.ms/new-console-template for more information
using System;

namespace CustomDataTypesApp
{
    // Define the CustomDataTypes class
    public class CustomDataTypes
    {
        // Properties for all primitive types
        public bool BoolProperty { get; set; } = false; 
        public byte ByteProperty { get; set; } = 255;  
        public sbyte SByteProperty { get; set; } = -128;
        public char CharProperty { get; set; } = 'e';
        public decimal DecimalProperty { get; set; } = -7.9228m;
        public double DoubleProperty { get; set; } = -4999.99999d;
        public float FloatProperty { get; set; } = 330457.87923f;
        public int IntProperty { get; set; } = -2147483648;
        public uint UIntProperty { get; set; } = 4294967295;
        public nint NIntProperty { get; set; } = -2147483645;
        public nuint NuintProperty { get; set; } = 4294967293;
        public long LongProperty { get; set; } = -9223372036854775808;
        public ulong ULongProperty { get; set; } = 18446744073709551615;
        public short ShortProperty { get; set; } = -32768;
        public ushort UShortProperty { get; set; } = 65535;
        
       public int SumMethod(int x, int y)
        {
            return x+y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // creating an instance of CustomDataTypes
            CustomDataTypes dataTypes = new CustomDataTypes();
            Console.WriteLine($"Bool Property --> {dataTypes.BoolProperty} - Represents a boolean value (true or false).");
            Console.WriteLine($"Byte Property --> {dataTypes.ByteProperty} - Represents an 8-bit unsigned integer (0 to 255).");
            Console.WriteLine($"SByte Property --> {dataTypes.SByteProperty} - Represents an 8-bit signed integer (-128 to 127).");
            Console.WriteLine($"Char Property --> {dataTypes.CharProperty} - Represents a single 16-bit Unicode character.");
            Console.WriteLine($"Short Property --> { dataTypes.ShortProperty} - Represents a signed 16-bit integer (-32,768 to 32,767).");
            Console.WriteLine($"UShort Property --> {dataTypes.UShortProperty} - Represents an unsigned 16-bit integer (0 to 65,535).");
            Console.WriteLine($"Int Property --> {dataTypes.IntProperty} - Represents a signed 32-bit integer (-2,147,483,648 to 2,147,483,647).");
            Console.WriteLine($"UInt Property --> {dataTypes.UIntProperty} - Represents an unsigned 32-bit integer (0 to 4,294,967,295).");
            Console.WriteLine($"NInt Property --> {dataTypes.NIntProperty} - Signed 32-bit or 64-bit integer | Depends on platform (computed at runtime)");
            Console.WriteLine($"Nuint Property --> {dataTypes.NuintProperty} - Unsigned 32-bit or 64-bit integer | Depends on platform (computed at runtime)");
            Console.WriteLine($"Long Property --> {dataTypes.LongProperty} - Represents a signed 64-bit integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807).");
            Console.WriteLine($"ULong Property --> {dataTypes.ULongProperty} - Represents an unsigned 64-bit integer (0 to 18,446,744,073,709,551,615).");
            Console.WriteLine($"Float Property --> {dataTypes.FloatProperty} - Represents a single-precision 32-bit floating point.");
            Console.WriteLine($"Double Property --> {dataTypes.DoubleProperty} - Represents a double-precision 64-bit floating point.");
            Console.WriteLine($"Decimal Property --> {dataTypes.DecimalProperty} - Represents a 128-bit precise decimal value, suitable for financial calculations.");
            int result = dataTypes.SumMethod(2,4); 
            Console.WriteLine($"Output of SumMethod(2,4):  {result} ");
        }
    }
}