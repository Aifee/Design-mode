/**************************************************************
 * Copyright (c) 2017 - 2019 liuaf              
 * Create time：2017/11/8 14:34:53
 * Created by：liuaf
 * Contact information：329737941@qq.com
 ***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Proxy_Pattern
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }
        public void display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.display();
        }
    }
}
