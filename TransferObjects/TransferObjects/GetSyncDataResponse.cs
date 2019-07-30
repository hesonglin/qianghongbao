using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 获取房间同步消息
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct GetSyncDataResponse
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
        ///龙
        /// </summary>      
        public MaxStakeItem pMaxStakeL;
        /// <summary>
        ///虎
        /// </summary>      
        public MaxStakeItem pMaxStakeH;
        /// <summary>
        ///结算信息
        /// </summary>       
        public LHDJieSuanNotify pJieSuan;
    }
}
