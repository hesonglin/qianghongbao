using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 获取房间用户列表 返回
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct GetRoomPlayersResponse
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int iUserId;
        /// <summary>
        /// 昵称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string szAlias;
        /// <summary>
        /// 头像
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string szHeadIco;
        /// <summary>
        /// 性别
        /// </summary>
        public byte iSex;        
        /// <summary>
        /// 金币
        /// </summary>
        public double iGolds;
        /// <summary>
        /// 座位
        /// </summary>
        public double iSeatIndex;
        /// <summary>
        /// 近20局游戏数据统计信息-押注金币
        /// </summary>
        public double iGoldsYZ;
        /// <summary>
        /// 局游戏数据统计信息-赢的次数
        /// </summary>
        public int iWinTimes;
        /// <summary>
        /// 玩家等级
        /// </summary>
        public byte iLevel;
    }    
}
