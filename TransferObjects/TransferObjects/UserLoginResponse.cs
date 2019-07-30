using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 用户登录返回
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct UserLoginResponse
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szAccount;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPassword;
        /// <summary>
        /// 用户ID
        /// </summary>
        public int iUserId;
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public int iGems;
        /// <summary>
        /// 
        /// </summary>
        public double iGolds;
        /// <summary>
        /// 
        /// </summary>
        public double iBankGolds;
        /// <summary>
        /// 
        /// </summary>
        public byte iGameId;
        /// <summary>
        /// 
        /// </summary>
        public uint uRoomId;
        /// <summary>
        ///  代理ID (0:普通用户, 大于0为代理)
        /// </summary>
        public int iDailiId;   
        /// <summary>
        /// 代理级别
        /// </summary>
        public int iDailiLevel;     
        /// <summary>
        /// 群主1
        /// </summary>
        public int iUpAgent1; 
        /// <summary>
        /// 群主2
        /// </summary>
        public int iUpAgent2;
        /// <summary>
        /// 群主3
        /// </summary>
        public int iUpAgent3;
        /// <summary>
        /// 群主4
        /// </summary>
        public int iUpAgent4;
        /// <summary>
        /// 群主5
        /// </summary>
        public int iUpAgent5;
        /// <summary>
        /// 
        /// </summary>
        public int iSpreaderId;
        /// <summary>
        /// 0:注册用户, 1:游客
        /// </summary>
        public byte iGuest;   
        /// <summary>
        /// 0:没有绑定手机, 1:绑定了手机
        /// </summary>
        public byte iBandPhone;   
        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 18)]
        public string szYZCards;
        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szZFBCards;
        /// <summary>
        /// 
        /// </summary>
        public byte iCount;
        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [DynamicArrayLength("iCount")]
        public GameServerAddress[] pGSAddrs;
    }
}
