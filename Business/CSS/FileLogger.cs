using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CSS
{
    public class FileLoger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
