using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Code.AppGameServer.TransferObjects
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct GameServerAddress // 查询游戏服务器地址
    {
        /// <summary>
        /// IP地址
        /// </summary>
        public uint uIpAddr;
        /// <summary>
        /// 端口号
        /// </summary>
        public ushort wPort;
        /// <summary>
        /// 游戏ID
        /// </summary>
        public byte iGameId;
    }
}
