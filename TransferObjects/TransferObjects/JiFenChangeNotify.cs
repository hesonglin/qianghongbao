using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 积分改变 通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct JiFenChangeNotify
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int iUserId;       
        /// <summary>
        /// 输赢金币
        /// </summary>
        public double fGoldsSY;
        /// <summary>
        /// 当前金币
        /// </summary>
        public double fNewGolds;        
    }
}
