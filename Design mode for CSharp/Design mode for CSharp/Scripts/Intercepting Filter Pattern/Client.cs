/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;

namespace Design_mode_for_CSharp.Scripts.Intercepting_Filter_Pattern
{
    public class Client
    {
        private FilterManager filterManager;

        public void setFilterManager(FilterManager filterManager)
        {
            this.filterManager = filterManager;
        }

        public void sendRequest(String request)
        {
            filterManager.filterRequest(request);
        }
    }
}