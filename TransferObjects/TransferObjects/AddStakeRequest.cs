using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 添加押注
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct AddStakeRequest
    {
        /// <summary>
        /// 押注位置
        /// </summary>
        public byte iPosYZ;
        /// <summary>
        /// 押注金币
        /// </summary>
        public double iGolds;
    }
}
