using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 公共消息头
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct CommonMessageHeader  
    {
        /// <summary>
        /// 长度
        /// </summary>
        public ushort wSize;
        /// <summary>
        /// 命令字
        /// </summary>
        public ushort wCommand;
        /// <summary>
        /// 服务ID
        /// </summary>
        public ushort wServerId;
        /// <summary>
        /// 
        /// </summary>
        public Int64 lExtData;
        ///// <summary>
        ///// 消息体起始位置
        ///// </summary>
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        //public byte[] contents;
    }
}
