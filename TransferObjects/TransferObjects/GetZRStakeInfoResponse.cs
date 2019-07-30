using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 获取真人押注信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct GetZRStakeInfoResponse
    {       
        /// <summary>
        /// 押注位置的金币
        /// </summary>       
         [MarshalAs(UnmanagedType.ByValArray, SizeConst = PubUtils.PubConfig.MaxStakeWz)]
        public double[] pGolds;      
    }
}
