using Code.AppGameServer.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 红包扫雷 获取房间同步信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct HBSLGetSyncDataResponse
    {
        /// <summary>
        /// 房间状态
        /// </summary>
        public byte iState;
        /// <summary>
        /// 剩余多少秒
        /// </summary>
        public byte iTimes;
        /// <summary>
        /// 摇色子总时间
        /// </summary>
        public byte iTime1;
        /// <summary>
        /// 押注总时间
        /// </summary>
        public byte iTime2;
        /// <summary>
        /// 结算总时间
        /// </summary>
        public byte iTime3;
        /// <summary>
        ///  红包金额
        /// </summary>
        public ushort BonusAmount;
        /// <summary>
        ///  雷的数字
        /// </summary>
        public byte RayNumber;
        /// <summary>
        ///结算信息
        /// </summary>       
        public HBSLJieSuanNotify pJieSuan;
    }
}
