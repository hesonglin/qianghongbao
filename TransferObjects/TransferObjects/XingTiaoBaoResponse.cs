using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 心跳包返回
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct XingTiaoBaoResponse
    {
        /// <summary>
        /// 记录ID
        /// </summary>
        public ushort uKeyId;
        /// <summary>
        /// 记录时间
        /// </summary>
        public ushort uTime;

    }
}
