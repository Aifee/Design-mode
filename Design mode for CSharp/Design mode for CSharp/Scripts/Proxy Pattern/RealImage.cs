/**************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:33:45
 * Created by：liuaf
 * Contact information：329737941@qq.com
 ***************************************************************/

using System;

namespace Design_mode_for_CSharp.Scripts.Proxy_Pattern
{
    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }

        public void display()
        {
            Console.WriteLine("Displaying " + fileName);
        }

        private void loadFromDisk(string fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }
}