using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class Control
    {
        private List<Book> books = new List<Book>();
        private List<Reader> reader = new List<Reader>();

        public Control() 
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LibraryWindow(this));
        }
    }
}
