using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Code.AppGameServer.GameObjects
{
    /// <summary>
    /// 游戏ID枚举
    /// </summary>
    public enum GameTypeEnum
    {
        /// <summary>
        /// 中心服务器
        /// </summary>
        [EnumMember]
        [Description("中心服务器")]
        gtCenterServer = 1,
        /// <summary>
        /// 干子宝
        /// </summary>
        [EnumMember]
        [Description("干子宝")]
        gtGanZiBao = 100,
        /// <summary>
        /// 蚕豆
        /// </summary>
        [EnumMember]
        [Description("蚕豆")]
        gtCanDou = 101,
        /// <summary>
        /// 坐庄三公
        /// </summary>
        [EnumMember]
        [Description("坐庄三公")]
        gtZZSG = 102,
        /// <summary>
        /// 通比三公
        /// </summary>
        [EnumMember]
        [Description("通比三公")]
        gtTBSG = 103,
        /// <summary>
        /// 百人干子宝
        /// </summary>
        [EnumMember]
        [Description("百人干子宝")]
        gtBRGZB = 111,
        /// <summary>
        /// 百人蚕豆
        /// </summary>
        [EnumMember]
        [Description("百人蚕豆")]
        gtBRCD = 112,
        /// <summary>
        /// 百人三公(坐庄)
        /// </summary>
        [EnumMember]
        [Description("百人三公(坐庄)")]
        gtBRSG = 113,
        /// <summary>
        /// 百人龙虎斗
        /// </summary>
        [EnumMember]
        [Description("百人龙虎斗")]
        gtBRLHD = 114,
        /// <summary>
        /// 红黑大战
        /// </summary>
        [EnumMember]
        [Description("红黑大战")]
        gtRBDZ = 115,
        /// <summary>
        /// 百人三公(通比)
        /// </summary>
        [EnumMember]
        [Description("百人三公(通比)")]
        gtBRSGTB = 116,
        /// <summary>
        ///百人牛牛(坐庄)
        /// </summary>
        [EnumMember]
        [Description("百人牛牛(坐庄)")]
        gtBRNN = 117,
        /// <summary>
        ///百人百家乐
        /// </summary>
        [EnumMember]
        [Description("百人百家乐")]
        gtBRBJL = 118,
        /// <summary>
        ///百人车行
        /// </summary>
        [EnumMember]
        [Description("百人车行")]
        gtBRCH = 119,
        /// <summary>
        ///赛马
        /// </summary>
        [EnumMember]
        [Description("赛马")]
        gtSAIMA = 120,
        /// <summary>
        ///红包埋雷
        /// </summary>
        [EnumMember]
        [Description("红包埋雷")]
        gtHBML = 121,
        /// <summary>
        ///抢庄牛牛
        /// </summary>
        [EnumMember]
        [Description("抢庄牛牛")]
        gtQZNIUNIU = 130,
        /// <summary>
        ///扯线(虎啸龙吟15线)
        /// </summary>
        [EnumMember]
        [Description("扯线(虎啸龙吟15线)")]
        gtCXHXLY15 = 140,
        /// <summary>
        ///扯线(金瓶梅50线)
        /// </summary>
        [EnumMember]
        [Description("扯线(金瓶梅50线)")]
        gtCXJPM50 = 141,
        /// <summary>
        ///飞禽走兽
        /// </summary>
        [EnumMember]
        [Description("飞禽走兽")]
        gtFQZS = 150,
        /// <summary>
        ///森林舞会
        /// </summary>
        [EnumMember]
        [Description("森林舞会")]
        gtSLWH = 151,

        /// <summary>
        ///百人三公(坐庄)
        /// </summary>
        [EnumMember]
        [Description("百人三公(坐庄)")]
        gtMF_BRSG = 162,
        /// <summary>
        ///百人三公(通比)
        /// </summary>
        [EnumMember]
        [Description("百人三公(通比)")]
        gtMF_BRTBSG = 163,
        /// <summary>
        ///龙虎斗
        /// </summary>
        [EnumMember]
        [Description("龙虎斗")]
        gtMF_BRLHD = 164,
        /// <summary>
        ///红黑大战
        /// </summary>
        [EnumMember]
        [Description("红黑大战")]
        gtMF_RBDZ = 165,
        /// <summary>
        ///百家乐
        /// </summary>
        [EnumMember]
        [Description("百家乐")]
        gtMF_BRBJL = 166,
        /// <summary>
        ///车行
        /// </summary>
        [EnumMember]
        [Description("车行")]
        gtMF_BRCH = 167,
        /// <summary>
        ///赛马
        /// </summary>
        [EnumMember]
        [Description("赛马")]
        gtMF_SAIMA = 168,
        /// <summary>
        ///飞禽走兽
        /// </summary>
        [EnumMember]
        [Description("飞禽走兽")]
        gtMF_FQZS = 169,
        /// <summary>
        ///森林舞会
        /// </summary>
        [EnumMember]
        [Description("森林舞会")]
        gtMF_SLWH = 170,
        /// <summary>
        ///扯线(虎啸龙吟15线)
        /// </summary>
        [EnumMember]
        [Description("扯线(虎啸龙吟15线)")]
        gtMF_CXHXLY15 = 171,
        /// <summary>
        ///扯线(金瓶梅50线)
        /// </summary>
        [EnumMember]
        [Description("扯线(金瓶梅50线)")]
        gtMF_CXJPM50 = 172,


        /// <summary>
        ///坐庄三公高级场
        /// </summary>
        [EnumMember]
        [Description("坐庄三公高级场")]
        gtSGZJ_GJ = 173,
        /// <summary>
        ///通比三公高级场
        /// </summary>
        [EnumMember]
        [Description("通比三公高级场")]
        gtSGTB_GJ = 174,
        /// <summary>
        ///龙虎斗高级场
        /// </summary>
        [EnumMember]
        [Description("龙虎斗高级场")]
        gtLHD_GJ = 175,
        /// <summary>
        ///红黑大战高级场
        /// </summary>
        [EnumMember]
        [Description("红黑大战高级场")]
        gtHHDZ_GJ = 176,
        /// <summary>
        ///百家乐高级场
        /// </summary>
        [EnumMember]
        [Description("百家乐高级场")]
        gtBJL_GJ = 177,
        /// <summary>
        ///奔驰宝马高级场
        /// </summary>
        [EnumMember]
        [Description("奔驰宝马高级场")]
        gtCH_GJ = 178,
        /// <summary>
        ///赛马高级场
        /// </summary>
        [EnumMember]
        [Description("赛马高级场")]
        gtPM_GJ = 179,
        /// <summary>
        ///飞禽走兽高级场
        /// </summary>
        [EnumMember]
        [Description("飞禽走兽高级场")]
        gtFQZS_GJ = 180,
        /// <summary>
        ///森林舞会高级场
        /// </summary>
        [EnumMember]
        [Description("森林舞会高级场")]
        gtSLWH_GJ = 181,
        /// <summary>
        ///虎啸龙吟高级场
        /// </summary>
        [EnumMember]
        [Description("虎啸龙吟高级场")]
        gtHXLY_GJ = 182,
        /// <summary>
        ///金瓶梅高级场
        /// </summary>
        [EnumMember]
        [Description("金瓶梅高级场")]
        gtJPM_GJ = 183,      

    }
}
