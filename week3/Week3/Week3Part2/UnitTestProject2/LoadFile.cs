using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public class LoadFile
    {
        private readonly string _directory;

        public LoadFile(string directory)
        {
            _directory = directory;
        }

        public bool FoundFile()
        {
            try
            {
                string file = File.ReadAllText(_directory);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loadfile error {0}", ex.Message);
                throw;
            }

            return true;
        }
    }
}
