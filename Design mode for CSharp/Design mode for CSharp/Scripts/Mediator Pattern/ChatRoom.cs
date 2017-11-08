/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;

namespace Design_mode_for_CSharp.Scripts.Mediator_Pattern
{
    public class ChatRoom
    {
        public static void showMessage(User user, string message)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("HH:mm:ss:ffff") + " [" + user.getName() + "] : " + message);
        }
    }
}