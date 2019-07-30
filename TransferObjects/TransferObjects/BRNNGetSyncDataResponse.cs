using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 百人牛牛 获取房间同步信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct BRNNGetSyncDataResponse
    {
        /// <summary>
        /// 房间状态
        /// </summary>
        public byte iState;
        /// <summary>
        /// 剩余多少秒
        /// </summary>
        public byte iTimes;
        /// <summary>
        /// 摇色子总时间
        /// </summary>
        public byte iTime1;
        /// <summary>
        /// 押注总时间
        /// </summary>
        public byte iTime2;
        /// <summary>
        /// 结算总时间
        /// </summary>
        public byte iTime3;       
        /// <summary>
        ///各位置押注金币
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = PubUtils.PubConfig.MaxStakeWz)]
        public double[] pStakes;
        /// <summary>
        ///最大押注玩家
        /// </summary>      
        public MaxStakeItem pMaxStake;
        /// <summary>
        /// 庄家连庄次数
        /// </summary>
        public byte iTimesLZ;
        /// <summary>
        /// 庄家总输赢
        /// </summary>
        public double fGoldsSY;
        /// <summary>
        /// 本局庄家输赢
        /// </summary>
        public double fGoldsSYThisTime;
        /// <summary>
        ///结算信息
        /// </summary>       
        public BRNNJieSuanNotify pJieSuan;
    }
}
