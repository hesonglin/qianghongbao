using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 红包扫雷 抢红包信息 
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct HBSLJieShuanLItem
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int iUserId;   
        /// <summary>
        /// 红包顺序
        /// </summary>
        public byte iIndex;    
        /// <summary>
        /// 抢红包金额
        /// </summary>
        public double userBonusAmount;
        /// <summary>
        /// 是否中雷
        /// </summary>
        public byte isPay;
        /// <summary>
        /// 输赢情况
        /// </summary>
        public double userSY;
    }
}
