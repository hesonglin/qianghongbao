using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 百人牛牛 预生成的牌通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct BRNNPrePopulatedPaiNotify
    {
        /// <summary>
        /// 位置1的牌（这个默认是庄家的）
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] iPai1;
        /// <summary>
        /// 位置2的牌
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] iPai2;
        /// <summary>
        /// 位置3的牌
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] iPai3;
        /// <summary>
        /// 位置4的牌
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] iPai4;
        /// <summary>
        /// 位置5的牌
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] iPai5;
    }
}
