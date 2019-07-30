using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 红包扫雷 结算通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct HBSLJieSuanNotify
    {
        /// <summary>
        /// 所有用户抢红包金额
        /// </summary>       
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = PubUtils.PubConfig.BonusCount)]
        public HBSLJieShuanLItem[] UserBonusAmount;
        /// <summary>
        ///当前用户位置（用来对应取用户发红包的金额，跟用户抢红包的顺序一致,庄家和旁观者为0）
        /// </summary>        
        public byte iPos;
        /// <summary>
        ///当前用户是输还是赢
        /// </summary>        
        public byte iWinMode;
        /// <summary>
        /// 庄家(0)和抢红包的用户输赢情况
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = PubUtils.PubConfig.BonusCount + 1)]
        public PlayerJSInfo[] pPlayers;
        /// <summary>
        /// 旁观者是否飞金币
        /// </summary>
        public byte iWinSP;
    }
}
