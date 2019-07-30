using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 离开房间通知
    /// </summary>
     [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct LeaveRoomNotify
    {
        /// <summary>
        /// 用户ID
        /// </summary>
         public int iUserId;
    }
}
