using System.Text;

namespace Base62
{
    public static class Base62Converter
    {
        private const string BASE62 = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Encode the long <see cref="value"/> to a Base62 string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Encode(long value)
        {
            return Encode(value, BASE62);
        }

        /// <summary>
        /// Decode the Base62 string <see cref="value"/> to a long number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long Decode(string value)
        {
            return Decode(value, BASE62);
        }

        private static string Encode(long value, string table)
        {
            var baseLength = table.Length;

            StringBuilder sb = new();

            var reminder = (int)(value % baseLength);

            sb.Insert(0, table[reminder]);

            var q = Math.Floor((double)value / baseLength);
            while (q > 0)
            {
                reminder = (int)(q % baseLength);

                sb.Insert(0, table[reminder]);

                q = Math.Floor(q / baseLength);
            }

            return sb.ToString();
        }

        private static long Decode(string value, string table)
        {
            var baseLength = table.Length;

            long result = 0;

            for(var i = 0; i < value.Length; i++)
            {
                var position = value.Length - i - 1;

                result += table.IndexOf(value[i]) * (long)Math.Pow(baseLength, position);
            }

            return result;
        }
    }
}