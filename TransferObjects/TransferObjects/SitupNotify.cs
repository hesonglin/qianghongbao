using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 玩家起立通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct SitupNotify
    {
        /// <summary>
        ///  用户ID
        /// </summary>
        public int iUserId;
        /// <summary>
        /// 位置
        /// </summary>
        public byte iSeatIndex;
    }
}
