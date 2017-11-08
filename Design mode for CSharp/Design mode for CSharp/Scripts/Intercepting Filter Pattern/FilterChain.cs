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

namespace Design_mode_for_CSharp.Scripts.Intercepting_Filter_Pattern
{
    public class FilterChain
    {
        private List<IFilter> filters = new List<IFilter>();
        private Target target;

        public void addFilter(IFilter filter)
        {
            filters.Add(filter);
        }

        public void execute(String request)
        {
            foreach (IFilter filter in filters)
            {
                filter.execute(request);
            }
            target.execute(request);
        }

        public void setTarget(Target target)
        {
            this.target = target;
        }
    }
}