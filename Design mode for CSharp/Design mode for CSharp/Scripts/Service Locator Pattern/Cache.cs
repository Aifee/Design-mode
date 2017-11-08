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

namespace Design_mode_for_CSharp.Scripts.Service_Locator_Pattern
{
    public class Cache
    {
        private List<IService> services;

        public Cache()
        {
            services = new List<IService>();
        }

        public IService getService(String serviceName)
        {
            foreach (IService service in services)
            {
                if (service.getName().ToUpper().Equals(serviceName.ToUpper()))
                {
                    Console.WriteLine("Returning cached  " + serviceName + " object");
                    return service;
                }
            }
            return null;
        }

        public void addService(IService newService)
        {
            bool exists = false;
            foreach (IService service in services)
            {
                if (service.getName().ToUpper().Equals(newService.getName().ToUpper()))
                {
                    exists = true;
                }
            }
            if (!exists)
            {
                services.Add(newService);
            }
        }
    }
}