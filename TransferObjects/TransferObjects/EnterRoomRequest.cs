using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 进入房间
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct EnterRoomRequest  // CMD_EnterRoomRequest
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int iUserId;
        /// <summary>
        /// 
        /// </summary>
        public int iHallId;
        /// <summary>
        /// 房间ID
        /// </summary>
        public uint uRoomId;
        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPassword;
        /// <summary>
        /// 经度
        /// </summary>
        public double fLon;
        /// <summary>
        /// 纬度
        /// </summary>
        public double fLat;
    }
}
