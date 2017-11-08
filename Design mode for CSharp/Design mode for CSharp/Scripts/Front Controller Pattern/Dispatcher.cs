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
    public class Dispatcher
    {
        private StudentView studentView;
        private HomeView homeView;

        public Dispatcher()
        {
            studentView = new StudentView();
            homeView = new HomeView();
        }

        public void dispatch(String request)
        {
            if (request.ToUpper().Equals("STUDENT"))
            {
                studentView.show();
            }
            else
            {
                homeView.show();
            }
        }
    }
}