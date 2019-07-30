using Code.AppGameServer.PubUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.GameObjects
{
    /// <summary>
    /// 用户结算对象
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct PlayerJSInfo
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int iUserId;
        /// <summary>
        ///输赢金币
        /// </summary>
        public double fGoldsSY;
        /// <summary>
        ///用户增加的金币
        /// </summary>
        public double fAddGolds;
        /// <summary>
        ///当前金币
        /// </summary>
        public double fNewGolds;
        /// <summary>
        ///抽水金币
        /// </summary>
        public double fWater;
        /// <summary>
        ///流水
        /// </summary>
        public double fLiuShui;
        /// <summary>
        ///用户押注信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = PubConfig.MaxStakeWz)]
        public double[] pStakes;
        /// <summary>
        ///押注位置 赢的位置
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = PubConfig.MaxStakeWz)]
        public byte[] pWinPos;
        /// <summary>
        ///押注位置 赢的金币
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = PubConfig.MaxStakeWz)]
        public double[] pWinGolds;

        public PlayerJSInfo(int userId=-1)
        {
            iUserId = userId;
            fGoldsSY = 0;
            fAddGolds = 0;
            fNewGolds = 0;
            fWater = 0;
            fLiuShui = 0;
            pStakes = new double[PubConfig.MaxStakeWz];
            pWinGolds = new double[PubConfig.MaxStakeWz];
            pWinPos = new byte[PubConfig.MaxStakeWz];
        }

        public void Clear()
        {
            iUserId = -1;
            fGoldsSY = 0;
            fAddGolds = 0;
            fNewGolds = 0;
            fWater = 0;
            fLiuShui = 0;           
            Array.Clear(pStakes, 0, pStakes.Length);
            Array.Clear(pWinGolds, 0, pWinGolds.Length);
            Array.Clear(pWinPos, 0, pWinPos.Length);
        }
    }
}
