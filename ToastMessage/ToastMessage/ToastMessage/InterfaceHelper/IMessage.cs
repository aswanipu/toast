using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToastMessage.InterfaceHelper
{
   public  interface IMessage
    {
        
            void LongAlert(string message);
            void ShortAlert(string message);
        
    }
}
