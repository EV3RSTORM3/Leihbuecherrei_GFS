using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class Control
    {
        public Control() 
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LibraryWindow(this));
        }
    }
}
