using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 自定义消息通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct CustomMsgNotify
    {
        /// <summary>
        /// 自定义消息内容
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public byte[] pData;
    }
}
