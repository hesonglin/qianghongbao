using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 座位上玩家位置改变通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct SeatPlayersChangedNotify
    {
        /// <summary>
        ///  1:左边, 2:右边
        /// </summary>
        public byte iDirVal;
        /// <summary>
        /// 位置顺序信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public SeatPlayerItem[] pSeats;
    }
}
