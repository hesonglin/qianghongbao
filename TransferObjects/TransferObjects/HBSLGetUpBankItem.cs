using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 红包扫雷 上庄列表 
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct HBSLGetUpBankItem
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int iUserId; 
        /// <summary>
        /// 红包金额
        /// </summary>
        public double userBonusAmount;
        /// <summary>
        /// 雷值
        /// </summary>
        public byte RayNumber;        
    }
}
