/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;

namespace Design_mode_for_CSharp.Scripts.Front_Controller_Pattern
{
    public class FrontController
    {
        private Dispatcher dispatcher;

        public FrontController()
        {
            dispatcher = new Dispatcher();
        }

        private bool isAuthenticUser()
        {
            Console.WriteLine("User is authenticated successfully.");
            return true;
        }

        private void trackRequest(String request)
        {
            Console.WriteLine("Page requested: " + request);
        }

        public void dispatchRequest(String request)
        {
            //记录每一个请求
            trackRequest(request);
            //对用户进行身份验证
            if (isAuthenticUser())
            {
                dispatcher.dispatch(request);
            }
        }
    }
}