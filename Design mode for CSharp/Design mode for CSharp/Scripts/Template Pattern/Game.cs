/*
 *************************************************************
 * Copyright (c) 2017 - 2019 liuaf
 * Create time：2017/11/8 14:35:32
 * Created by：liuaf
 * Contact information：329737941@qq.com
 **************************************************************
 */

namespace Design_mode_for_CSharp.Scripts.Template_Pattern
{
    public abstract class Game
    {
        protected abstract void initialize();

        protected abstract void startPlay();

        protected abstract void endPlay();

        //模板
        public void play()
        {
            //初始化游戏
            initialize();

            //开始游戏
            startPlay();

            //结束游戏
            endPlay();
        }
    }
}