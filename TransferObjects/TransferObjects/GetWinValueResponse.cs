using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 获取押注位置输赢情况
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct GetWinValueResponse
    {
        /// <summary>
        /// 记录ID
        /// </summary>
        public ushort iCount;             
        /// <summary>
        ///押注位置输赢情况
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 336)]
        public ushort[] pValues;
        
    }
}
