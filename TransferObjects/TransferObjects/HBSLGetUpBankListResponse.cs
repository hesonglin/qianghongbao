using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 红包扫雷 获取上庄列表返回 
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct HBSLGetUpBankListResponse
    {
        /// <summary>
        /// 当前最新的10位上庄玩家列表
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public HBSLGetUpBankItem[] upBankerPlayers;
    }
}
