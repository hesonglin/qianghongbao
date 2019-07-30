using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 进入房间返回
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct EnterRoomResponse   // 进入房间应答 // CMD_EnterRoomResponse
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public byte iGameId;
        /// <summary>
        /// 房间ID
        /// </summary>
        public uint uRoomId;
        /// <summary>
        /// 当前金币
        /// </summary>
        public double iGolds;
        /// <summary>
        /// 用户房卡
        /// </summary>
        public int iGems;
        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]    // 每次最多发送8个用户
        public byte[] sRoomArgs;
    }
}
