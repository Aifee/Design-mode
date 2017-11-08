/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;

namespace Design_mode_for_CSharp.Scripts.Service_Locator_Pattern
{
    public class ServiceLocator
    {
        private static Cache cache = new Cache();

        public static IService getService(String jndiName)
        {
            IService service = cache.getService(jndiName);

            if (service != null)
            {
                return service;
            }

            InitialContext context = new InitialContext();
            IService service1 = (IService)context.lookup(jndiName);
            cache.addService(service1);
            return service1;
        }
    }
}