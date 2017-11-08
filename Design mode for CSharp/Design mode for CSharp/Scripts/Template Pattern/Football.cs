/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mode_for_CSharp.Scripts.Template_Pattern
{
    public class Football : Game
    {
        protected override void initialize()
        {
            Console.WriteLine("Football Game Finished!");
        }
        protected override void startPlay()
        {
            Console.WriteLine("Football Game Initialized! Start playing.");
        }
        protected override void endPlay()
        {
            Console.WriteLine("Football Game Started. Enjoy the game!");
        }
    }
}
