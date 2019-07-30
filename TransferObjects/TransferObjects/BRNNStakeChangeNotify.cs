using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    ///百人牛牛 押注位置改变通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct BRNNStakeChangeNotify
    {
        /// <summary>
        /// 用户ID
        /// </summary>      
        public int iUserId;
        /// <summary>
        /// 押注位置 
        /// </summary>      
        public byte iPosYZ;
        /// <summary>
        /// 押注金币
        /// </summary>      
        public double iGoldsYZ;
        /// <summary>
        /// 当前金币
        /// </summary>     
        public double iGolds;        
        /// <summary>
        /// 各个押注位置的金币
        /// </summary>       
         [MarshalAs(UnmanagedType.ByValArray, SizeConst = PubUtils.PubConfig.MaxStakeWz)]
        public double[] pGoldsYZ;
        /// <summary>
        /// 房间各个押注位置的总金币
        /// </summary>       
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = PubUtils.PubConfig.MaxStakeWz)]
        public double[] pGoldsSumYZ;
    }
}
