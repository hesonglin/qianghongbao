using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 上庄通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct UpBankerNotify
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int iUserId;        
        /// <summary>
        /// 上庄前金币
        /// </summary>
        public double iGolds;
        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string szAlias;
        /// <summary>
        /// 头像
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string szHeadIco;
    }
}
