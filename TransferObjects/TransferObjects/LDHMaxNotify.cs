using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 最大赢家改变通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct LDHMaxNotify
    {
        /// <summary>
        ///
        /// </summary>     
         [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public TLDHMaxItem[] pItems;
    }
}
