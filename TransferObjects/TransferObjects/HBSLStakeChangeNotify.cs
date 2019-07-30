using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 押注位置改变通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct HBSLStakeChangeNotify
    {
        /// <summary>
        /// 当前抢红包用户ID
        /// </summary>      
        public int iUserId;        
        /// <summary>
        /// 当前金币
        /// </summary>     
        public double iGolds;
        /// <summary>
        /// 当前房间剩余红包数量
        /// </summary>      
        public byte iRemainBonusCount;
        /// <summary>
        /// 已经抢了红包的用户列表
        /// </summary>       
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = PubUtils.PubConfig.BonusCount)]
        public BonusUserItem[] pYzUserList;        
    }
}
