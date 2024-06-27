using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class EncryptedStream : Stream
    {
        private Stream _stream;

        public EncryptedStream(Stream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            string encrypted = Encrypt(data);
            Console.WriteLine("Encrypted...");
            _stream.Write(encrypted);
        }

        public string Encrypt(string data)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
