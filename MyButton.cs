using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FullKeyBoard
{
    internal class MyButton
    {
        String upValue;
        String downValue;
        TextBlock TextBlock;

        public MyButton(String upValue, String downValue, TextBlock textBlock)
        {
            this.upValue = upValue;
            this.downValue = downValue;
            this.TextBlock = textBlock;
        }
    }
}
