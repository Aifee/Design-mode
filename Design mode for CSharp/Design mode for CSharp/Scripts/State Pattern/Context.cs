/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

namespace Design_mode_for_CSharp.Scripts.State_Pattern
{
    public class Context
    {
        private IState state;

        public Context()
        {
            state = null;
        }

        public void setState(IState state)
        {
            this.state = state;
        }

        public IState getState()
        {
            return state;
        }
        public override string ToString()
        {
            return state.ToString();
        }
    }
}