using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{    
    /// <summary>
    /// 操作失败消息
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct ErrorResponse
    {
        /// <summary>
        /// 失败消息ID
        /// </summary>
        public ushort wErrorNo;
    }
}
