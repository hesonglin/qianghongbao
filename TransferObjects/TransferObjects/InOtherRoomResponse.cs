using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 用户在其它房间消息
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct InOtherRoomResponse
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public byte iGameId;
        /// <summary>
        /// 房间ID
        /// </summary>
        public uint uRoomId;
    }
}
