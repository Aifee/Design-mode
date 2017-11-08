/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System;

namespace Design_mode_for_CSharp.Scripts.Business_Delegate_Pattern
{
    public class BusinessDelegate
    {
        private BusinessLookUp lookupService = new BusinessLookUp();
        private IBusinessService businessService;
        private string serviceType;

        public void setServiceType(String serviceType)
        {
            this.serviceType = serviceType;
        }

        public void doTask()
        {
            businessService = lookupService.getBusinessService(serviceType);
            businessService.doProcessing();
        }
    }
}