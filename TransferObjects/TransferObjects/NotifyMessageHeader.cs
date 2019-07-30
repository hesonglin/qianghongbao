using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 通知消息
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]  
    public struct NotifyMessageHeader  
    {
        /// <summary>
        /// 长度
        /// </summary>
        public ushort wSize;
        /// <summary>
        /// 命令字
        /// </summary>
        public ushort wNotifyCommand;        
        /// <summary>
        /// 
        /// </summary>
        public Int64 lExtData;        
    }
}
