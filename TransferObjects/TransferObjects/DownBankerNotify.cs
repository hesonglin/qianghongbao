using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 下庄通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct DownBankerNotify
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int iUserId;
        /// <summary>
        /// 上庄前金币
        /// </summary>
        public double iGolds;
    }
}
