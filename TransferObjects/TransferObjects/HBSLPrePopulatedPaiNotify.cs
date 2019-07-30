using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 红包打雷 预生成的信息通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct HBSLPrePopulatedPaiNotify
    {
        /// <summary>
        /// 当前局红包金额（10的倍数）
        /// </summary>       
        public ushort BonusAmount;
        /// <summary>
        /// 当前局雷的数字（1-9）
        /// </summary>       
        public byte RayNumber;
    }
}
