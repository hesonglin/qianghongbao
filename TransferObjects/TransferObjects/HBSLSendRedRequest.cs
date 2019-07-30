using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 庄家 申请发红包命令
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct HBSLSendRedRequest
    {
        /// <summary>
        ///  红包金额
        /// </summary>
        public ushort BonusAmount;
        /// <summary>
        ///  雷的数字
        /// </summary>
        public byte RayNumber;
    }
}
