using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 百人牛牛 结算通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct BRNNJieSuanNotify
    {
        /// <summary>
        /// 位置1的牌（这个默认是庄家的）
        /// </summary>       
        public NNItem iPai1;
        /// <summary>
        /// 位置2的牌
        /// </summary>       
        public NNItem iPai2;
        /// <summary>
        /// 位置3的牌
        /// </summary>       
        public NNItem iPai3;
        /// <summary>
        /// 位置4的牌
        /// </summary>      
        public NNItem iPai4;
        /// <summary>
        /// 位置5的牌
        /// </summary>     
        public NNItem iPai5;
        /// <summary>
        /// 哪些押注位置赢,共4个押注位置(置1表示赢，0表示输)
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = PubUtils.PubConfig.MaxStakeWz)]
        public byte[] iWinMode;        
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
