/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

using System.Collections.Generic;

namespace Design_mode_for_CSharp.Scripts.Command_Pattern
{
    public class Broker
    {
        private List<IOrder> orderList = new List<IOrder>();

        public void takeOrder(IOrder order)
        {
            orderList.Add(order);
        }

        public void placeOrders()
        {
            foreach (IOrder order in orderList)
            {
                order.execute();
            }
            orderList.Clear();
        }
    }
}