using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 龙虎斗结算通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct LHDJieSuanNotify
    {
        /// <summary>
        /// 牌1
        /// </summary>
        public ushort iPai1;
        /// <summary>
        /// 牌2
        /// </summary>
        public ushort iPai2;
        /// <summary>
        /// 1:龙大, 2:虎大, 3:平
        /// </summary>
        public byte iWinMode;
        /// <summary>
        /// 自己(0)和位置上的用户输赢情况
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public PlayerJSInfo[] pPlayers;
        /// <summary>
        /// 旁观者是否飞金币
        /// </summary>
        public byte iWinSP;
    }
}
