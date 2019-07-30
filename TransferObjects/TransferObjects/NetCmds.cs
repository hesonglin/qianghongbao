using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.AppGameServer.TransferObjects
{
    /// <summary>
    /// 消息码
    /// </summary>
    public enum NetCmds
    {
        #region 通用消息
        /// <summary>
        /// 操作成功
        /// </summary>
        [EnumMember]
        [Description("操作成功")]
        CMD_SuccessResponse = 0,          // 
        /// <summary>
        /// 操作失败
        /// </summary>
        [EnumMember]
        [Description("操作失败")]
        CMD_ErrorResponse = 1,
        /// <summary>
        /// 查询版本号请求
        /// </summary>
        [EnumMember]
        [Description("查询版本号请求")]
        CMD_QueryVersionRequest = 2,
        /// <summary>
        /// 查询版本号返回
        /// </summary>
        [EnumMember]
        [Description("查询版本号返回")]
        CMD_QueryVersionResponse = 3,
        /// <summary>
        ///  心跳包请求
        /// </summary>
        [EnumMember]
        [Description("心跳包请求")]
        CMD_XingTiaoBaoRequest = 4,
        /// <summary>
        /// 心跳包返回
        /// </summary>
        [EnumMember]
        [Description("心跳包返回")]
        CMD_XingTiaoBaoResponse = 5,
        /// <summary>
        /// 服务器初始化完成通知
        /// </summary>
        [EnumMember]
        [Description("服务器初始化完成通知")]
        CMD_InitCompleteNotify = 6,         // 服务器初始化完成通知
        /// <summary>
        /// 进入房间请求
        /// </summary>
        [EnumMember]
        [Description("进入房间请求")]
        CMD_EnterRoomRequest = 100,         // 进入房间请求
        /// <summary>
        /// 进入房间返回
        /// </summary>
        [EnumMember]
        [Description("进入房间返回")]
        CMD_EnterRoomResponse = 101,
        /// <summary>
        /// 进入房间通知
        /// </summary>
        [EnumMember]
        [Description("进入房间通知")]
        CMD_EnterRoomNotify = 102,
        /// <summary>
        /// 等待房主同意
        /// </summary>
        [EnumMember]
        [Description("等待房主同意")]
        CMD_WaitEnterRoomResponse = 103,   // 等待房主同意
        /// <summary>
        /// 离开房间请求
        /// </summary>
        [EnumMember]
        [Description("离开房间请求")]
        CMD_LeaveRoomRequest = 104,         // 离开房间请求
        /// <summary>
        /// 离开房间通知
        /// </summary>
        [EnumMember]
        [Description("离开房间通知")]
        CMD_LeaveRoomNotify = 105,          // 离开房间通知
        /// <summary>
        /// 玩家掉线通知
        /// </summary>
        [EnumMember]
        [Description("玩家掉线通知")]
        CMD_PlayerOfflineNotify = 106,      // 玩家掉线通知
        /// <summary>
        /// 游戏准备请求
        /// </summary>
        [EnumMember]
        [Description("游戏准备请求")]
        CMD_ReadyRequest = 107,             // 游戏准备请求
        /// <summary>
        /// 游戏准备通知
        /// </summary>
        [EnumMember]
        [Description("游戏准备通知")]
        CMD_ReadyNotify = 108,
        /// <summary>
        /// 游戏开始通知
        /// </summary>
        [EnumMember]
        [Description("游戏开始通知")]
        CMD_StartGameNotify = 109,          // 游戏开始
        /// <summary>
        /// 创建房间请求
        /// </summary>
        [EnumMember]
        [Description("创建房间请求")]
        CMD_CreateRoomRequest = 112,        // 创建房间
        /// <summary>
        /// 创建房间返回
        /// </summary>
        [EnumMember]
        [Description("创建房间返回")]
        CMD_CreateRoomResponse = 113,
        /// <summary>
        /// 邮件通知
        /// </summary>
        [EnumMember]
        [Description("邮件通知")]
        CMD_EmailNotify = 114,              // 邮件通知
        /// <summary>
        /// 播放语音请求
        /// </summary>
        [EnumMember]
        [Description("播放语音请求")]
        CMD_PlayerVoiceRequest = 118,         // 语音
        /// <summary>
        /// 播放语音通知
        /// </summary>
        [EnumMember]
        [Description("播放语音通知")]
        CMD_PlayerVoiceNotify = 119,
        /// <summary>
        /// 用户财富改变返回
        /// </summary>
        [EnumMember]
        [Description("用户财富改变返回")]
        CMD_UserAssetsChangedResponse = 120,  // 用户财富改变
        /// <summary>
        /// 发送表情请求
        /// </summary>
        [EnumMember]
        [Description("发送表情请求")]
        CMD_SendBiaoQingRequest = 123,        // 发送表情
        /// <summary>
        /// 发送表情通知
        /// </summary>
        [EnumMember]
        [Description("发送表情通知")]
        CMD_SendBiaoQingNotify = 124,
        /// <summary>
        /// 用户自定义消息请求
        /// </summary>
        [EnumMember]
        [Description("用户自定义消息请求")]
        CMD_UserCustomMsgRequest = 127,       // 用户自定义消息
        /// <summary>
        /// 用户自定义消息返回
        /// </summary>
        [EnumMember]
        [Description("用户自定义消息返回")]
        CMD_UserCustomMsgNotify = 128,
        /// <summary>
        /// 被另外的人重新登录踢下线返回
        /// </summary>
        [EnumMember]
        [Description("被另外的人重新登录踢下线返回")]
        CMD_OtherLoginInKillOutResponse = 130,  // 被另外的人重新登录踢下线
        /// <summary>
        /// 加入俱乐部请求
        /// </summary>
        [EnumMember]
        [Description("加入俱乐部请求")]
        CMD_LinkRoomRequest = 131,              // 加入俱乐部请求
        /// <summary>
        /// 加入俱乐部返回
        /// </summary>
        [EnumMember]
        [Description("加入俱乐部返回")]
        CMD_LinkRoomResponse = 132,
        /// <summary>
        /// 房主是否同意用户加入俱乐部请求
        /// </summary>
        [EnumMember]
        [Description("房主是否同意用户加入俱乐部请求")]
        CMD_LinkRoomResultRequest = 133,        // 房主是否同意用户加入俱乐部
        /// <summary>
        /// 房主是否同意用户加入俱乐部返回
        /// </summary>
        [EnumMember]
        [Description("房主是否同意用户加入俱乐部返回")]
        CMD_LinkRoomResultResponse = 134,
        /// <summary>
        /// 获取申请加入俱乐部的用户请求
        /// </summary>
        [EnumMember]
        [Description("获取申请加入俱乐部的用户请求")]
        CMD_GetLRReqUsersRequest = 135,         // 获取申请加入俱乐部的用户
        /// <summary>
        /// 获取申请加入俱乐部的用户返回
        /// </summary>
        [EnumMember]
        [Description("获取申请加入俱乐部的用户返回")]
        CMD_GetLRReqUsersResponse = 136,
        /// <summary>
        /// 查询指定房间有哪些用户关联了的请求
        /// </summary>
        [EnumMember]
        [Description("查询指定房间有哪些用户关联了的请求")]
        CMD_GetLinkRoomUsersRequest = 137,      // 查询指定房间有哪些用户关联了的
        /// <summary>
        /// 查询指定房间有哪些用户关联了的返回
        /// </summary>
        [EnumMember]
        [Description("查询指定房间有哪些用户关联了的返回")]
        CMD_GetLinkRoomUsersResponse = 138,
        /// <summary>
        /// 玩家上庄请求
        /// </summary>
        [EnumMember]
        [Description("玩家上庄请求 ")]
        CMD_UpBankerRequest = 139,    // 玩家上庄请求 (游戏服务器)
        /// <summary>
        /// 玩家上庄通知
        /// </summary>
        [EnumMember]
        [Description("玩家上庄通知")]
        CMD_UpBankerNotify = 140,
        /// <summary>
        /// 庄家改变通知
        /// </summary>
        [EnumMember]
        [Description("庄家改变通知")]
        CMD_BankerChangeNotify = 141,   // 庄家改变通知 (游戏服务器)
        /// <summary>
        /// 下庄请求
        /// </summary>
        [EnumMember]
        [Description("下庄请求")]
        CMD_DownBankerRequest = 143,    // 下庄请求   (游戏服务器)
        /// <summary>
        /// 下庄请求返回
        /// </summary>
        [EnumMember]
        [Description("下庄请求返回")]
        CMD_DownBankerResponse = 144,
        /// <summary>
        /// 下庄通知
        /// </summary>
        [EnumMember]
        [Description("下庄通知")]
        CMD_DownBankerNotify = 145,
        /// <summary>
        /// 添加押注请求
        /// </summary>
        [EnumMember]
        [Description("添加押注请求")]
        CMD_AddStakeRequest = 146,      // 添加押注信息 (游戏服务器)
        /// <summary>
        /// 添加押注通知
        /// </summary>
        [EnumMember]
        [Description("添加押注通知")]
        CMD_AddStakeNotify = 147,
        /// <summary>
        /// 开始押注通知
        /// </summary>
        [EnumMember]
        [Description("开始押注通知")]
        CMD_StartStakeNotify = 148,      // 开始押注通知 (游戏服务器)
        /// <summary>
        /// 生成色子
        /// </summary>
        [EnumMember]
        [Description("生成色子")]
        CMD_RandDiceNotify = 149,        // 生成色子 (游戏服务器)
        /// <summary>
        /// 输赢结算
        /// </summary>
        [EnumMember]
        [Description("输赢结算")]
        CMD_JieShuanNotify = 150,        // 输赢结算 (游戏服务器)
        /// <summary>
        /// 庄家分数改变
        /// </summary>
        [EnumMember]
        [Description("庄家分数改变")]
        CMD_BankerJFChangeNotify = 151,   // 庄家分数改变    (游戏服务器)
        /// <summary>
        /// 下分请求
        /// </summary>
        [EnumMember]
        [Description("下分请求")]
        CMD_XiaFenRequest = 152,          // 下分请求
        /// <summary>
        /// 下分请求返回
        /// </summary>
        [EnumMember]
        [Description("下分请求返回")]
        CMD_XiaFenResponse = 153,
        /// <summary>
        /// 下分通知
        /// </summary>
        [EnumMember]
        [Description("下分通知")]
        CMD_XiaFenNotify = 154,
        /// <summary>
        /// 玩家坐位置请求
        /// </summary>
        [EnumMember]
        [Description("玩家坐位置请求")]
        CMD_SitdownRequest = 155,         // 玩家坐位置请求   (游戏服务器)
        /// <summary>
        /// 玩家坐位置通知
        /// </summary>
        [EnumMember]
        [Description("玩家坐位置通知")]
        CMD_SitdownNotify = 156,
        /// <summary>
        /// 开始摇色子
        /// </summary>
        [EnumMember]
        [Description("开始摇色子")]
        CMD_StartDiceNotify = 157,        // 开始摇色子
        /// <summary>
        /// 获取上庄列表信息
        /// </summary>
        [EnumMember]
        [Description("获取上庄列表信息")]
        CMD_GetUpBankerListRequest = 158, // 获取上庄列表信息
        /// <summary>
        /// 获取上庄列表信息返回
        /// </summary>
        [EnumMember]
        [Description("获取上庄列表信息返回")]
        CMD_GetUpBankerListReponse = 159,
        /// <summary>
        /// 获取当前房间用户列表
        /// </summary>
        [EnumMember]
        [Description("获取当前房间用户列表")]
        CMD_GetRoomPlayersRequest = 160,    // 获取当前房间用户列表
        /// <summary>
        /// 获取当前房间用户列表返回
        /// </summary>
        [EnumMember]
        [Description("获取当前房间用户列表返回")]
        CMD_GetRoomPlayersResponse = 161,
        /// <summary>
        /// 站起来
        /// </summary>
        [EnumMember]
        [Description("站起来")]
        CMD_SitupRequest = 162,     // 站起来
        /// <summary>
        /// 站起来通知
        /// </summary>
        [EnumMember]
        [Description("站起来通知")]
        CMD_SitupNotify = 163,
        /// <summary>
        /// 同步数据
        /// </summary>
        [EnumMember]
        [Description("同步数据")]
        CMD_GetSyncDataRequest = 164,   // 同步数据
        /// <summary>
        /// 同步数据返回
        /// </summary>
        [EnumMember]
        [Description("同步数据返回")]
        CMD_GetSyncDataResponse = 165,
        /// <summary>
        /// 获取输赢走势
        /// </summary>
        [EnumMember]
        [Description("获取输赢走势")]
        CMD_GetWinValueRequest = 166,   // 获取输赢走势
        /// <summary>
        /// 获取输赢走势返回
        /// </summary>
        [EnumMember]
        [Description("获取输赢走势返回")]
        CMD_GetWinValueResponse = 167,
        /// <summary>
        /// 该俱乐部已解散
        /// </summary>
        [EnumMember]
        [Description("该俱乐部已解散")]
        CMD_TheRoomIsDelNotify = 168,   // 该俱乐部已解散
        /// <summary>
        /// 取消下注
        /// </summary>
        [EnumMember]
        [Description("取消下注")]
        CMD_CancelStakeRequest = 169,   // 取消下注
        /// <summary>
        /// 取消下注返回
        /// </summary>
        [EnumMember]
        [Description("取消下注返回")]
        CMD_CancelStakeNotify = 170,
        /// <summary>
        /// 已经在其它房间了
        /// </summary>
        [EnumMember]
        [Description("已经在其它房间了")]
        CMD_InOtherRoomResponse = 171,  // 已经在其它房间了
        /// <summary>
        /// 位置上的玩家变动
        /// </summary>
        [EnumMember]
        [Description("位置上的玩家变动")]
        CMD_SeatPlayersChangedNotify = 172, // 位置上的玩家变动
        /// <summary>
        /// 查询版本号
        /// </summary>
        [EnumMember]
        [Description("查询版本号")]
        CMD_QueryGameVersionRequest = 173,        // 查询版本号
        /// <summary>
        /// 查询版本号返回
        /// </summary>
        [EnumMember]
        [Description("查询版本号返回")]
        CMD_QueryGameVersionResponse = 174,
        /// <summary>
        /// 服务器公告消息
        /// </summary>
        [EnumMember]
        [Description("服务器公告消息")]
        CMD_TextMessageNotify = 175,        // 服务器公告消息
        /// <summary>
        /// 获取冲值地址
        /// </summary>
        [EnumMember]
        [Description("获取冲值地址")]
        CMD_GetQZRequest = 176,   // 获取冲值地址
        /// <summary>
        /// 获取冲值地址返回
        /// </summary>
        [EnumMember]
        [Description("获取冲值地址返回")]
        CMD_GetQZResponse = 177,
        /// <summary>
        /// 控制开奖结果
        /// </summary>
        [EnumMember]
        [Description("控制开奖结果")]
        CMD_CtrlResultRequest = 178,    // 控制开奖结果
        /// <summary>
        /// 控制开奖结果返回
        /// </summary>
        [EnumMember]
        [Description("控制开奖结果返回")]
        CMD_CtrlResultResponse = 179,
        /// <summary>
        /// 查询每个位置真人下注金币总合
        /// </summary>
        [EnumMember]
        [Description("查询每个位置真人下注金币总合")]
        CMD_QueryZRStakeInfoRequest = 180,  // 查询每个位置真人下注金币总合
        /// <summary>
        /// 查询每个位置真人下注金币总合返回
        /// </summary>
        [EnumMember]
        [Description("查询每个位置真人下注金币总合返回")]
        CMD_QueryZRStakeInfoResponse = 181,
        /// <summary>
        /// 玩家金币不够，被踢出房间
        /// </summary>
        [EnumMember]
        [Description("玩家金币不够，被踢出房间")]
        CMD_KillOutWithUserGENNotify = 182,  // 玩家金币不够，被踢出房间

        /// <summary>
        /// 抢彩金押注请求
        /// </summary>
        [EnumMember]
        [Description("抢彩金押注请求")]
        CMD_CaiJinStakeRequest = 183,
        /// <summary>
        /// 抢彩金押注返回
        /// </summary>
        [EnumMember]
        [Description("抢彩金押注返回")]
        CMD_CaiJinStakeResponse = 184,
        /// <summary>
        /// 抢彩金结果
        /// </summary>
        [EnumMember]
        [Description("抢彩金结果")]
        CMD_CaiJinResponse = 185,  // 抢彩金结果
        /// <summary>
        /// 查询奖池中奖历史
        /// </summary>
        [EnumMember]
        [Description("查询奖池中奖历史")]
        CMD_CaiJinGetLogsRequest = 186,   // 查询奖池中奖历史
        /// <summary>
        /// 查询奖池中奖历史返回
        /// </summary>
        [EnumMember]
        [Description("查询奖池中奖历史返回")]
        CMD_CaiJinGetLogsResponse = 187,
        /// <summary>
        /// 掉彩金了
        /// </summary>
        [EnumMember]
        [Description("掉彩金了")]
        CMD_CaiJinStartNotify = 188,    // 掉彩金了
        /// <summary>
        /// 获取奖池金币
        /// </summary>
        [EnumMember]
        [Description("获取奖池金币")]
        CMD_GetCaiJinGoldsRequest = 189,  // 获取奖池金币
        /// <summary>
        /// 奖池金币改变通知
        /// </summary>
        [EnumMember]
        [Description("奖池金币改变通知")]
        CMD_CaiJinChangedNotify = 190,    // 奖池金币改变通知
        /// <summary>
        /// 自定义消息
        /// </summary>
        [EnumMember]
        [Description("自定义消息")]
        CMD_CustomMsgNotify = 191,    // 自定义消息
        /// <summary>
        /// 抢彩金请求
        /// </summary>
        [EnumMember]
        [Description("抢彩金请求")]
        CMD_CaiJinQiangRequest = 192,   // 抢彩金消息
        /// <summary>
        /// 抢彩金返回
        /// </summary>
        [EnumMember]
        [Description("抢彩金返回")]
        CMD_CaiJinQiangResponse = 193,
        /// <summary>
        /// 抢彩金通知
        /// </summary>
        [EnumMember]
        [Description("抢彩金通知")]
        CMD_CaiJinQiangNotify = 194,


        /// <summary>
        /// 发红包请求
        /// </summary>
        [EnumMember]
        [Description("发红包请求")]
        CMD_SendRedRequest = 195,
        /// <summary>
        /// 获取房间上庄列表
        /// </summary>
        [EnumMember]
        [Description("获取房间上庄列表")]
        CMD_GetUpBankersRequest = 196,
        #endregion

        #region 中心服务器网络消息
        /// <summary>
        /// 用户注册请求
        /// </summary>
        [EnumMember]
        [Description("用户注册请求")]
        CMD_UserRegisterRequest = 1000,         // 用户注册请求
        /// <summary>
        /// 用户注册应答
        /// </summary>
        [EnumMember]
        [Description("用户注册应答")]
        CMD_UserRegisterResponse = 1001,        // 用户注册应答
        /// <summary>
        /// 用户登录请求
        /// </summary>
        [EnumMember]
        [Description("用户登录请求")]
        CMD_UserLoginRequest = 1002,            // 用户登录请求
        /// <summary>
        /// 用户登录应答
        /// </summary>
        [EnumMember]
        [Description("用户登录应答")]
        CMD_UserLoginResponse = 1003,           // 用户登录应答
        /// <summary>
        /// 查询游戏服务器地址
        /// </summary>
        [EnumMember]
        [Description("查询游戏服务器地址")]
        CMD_QueryGameServerAddrRequest = 1004,  // 查询游戏服务器地址
        /// <summary>
        /// 查询游戏服务器地址返回
        /// </summary>
        [EnumMember]
        [Description("查询游戏服务器地址返回")]
        CMD_QueryGameServerAddrResponse = 1005,
        /// <summary>
        /// 查询指定房间参数
        /// </summary>
        [EnumMember]
        [Description("查询指定房间参数")]
        CMD_QueryRoomArgsRequest = 1014,        // 查询指定房间参数
        /// <summary>
        /// 查询指定房间参数返回
        /// </summary>
        [EnumMember]
        [Description("查询指定房间参数返回")]
        CMD_QueryRoomArgsResponse = 1015,
        /// <summary>
        /// 查询用户创建的房间
        /// </summary>
        [EnumMember]
        [Description("查询用户创建的房间")]
        CMD_QueryUserRoomRequest = 1016,        // 查询用户创建的房间
        /// <summary>
        /// 查询用户创建的房间返回
        /// </summary>
        [EnumMember]
        [Description("查询用户创建的房间返回")]
        CMD_QueryUserRoomResponse = 1017,
        /// <summary>
        /// 修改个人密码
        /// </summary>
        [EnumMember]
        [Description("修改个人密码")]
        CMD_ChangeBankPasswordRequest = 1019,   // 修改个人密码
        /// <summary>
        /// 修改个人密码返回
        /// </summary>
        [EnumMember]
        [Description("修改个人密码返回")]
        CMD_ChangeBankPasswordResponse = 1020,
        /// <summary>
        /// 存取金币
        /// </summary>
        [EnumMember]
        [Description("存取金币")]
        CMD_CQBankGoldsRequest = 1021,    // 存取金币
        /// <summary>
        /// 存取金币返回
        /// </summary>
        [EnumMember]
        [Description("存取金币返回")]
        CMD_CQBankGoldsResponse = 1022,
        /// <summary>
        /// 获取个人财富
        /// </summary>
        [EnumMember]
        [Description("获取个人财富")]
        CMD_GetWealthRequest = 1023,   // 获取个人财富
        /// <summary>
        /// 获取个人财富返回
        /// </summary>
        [EnumMember]
        [Description("获取个人财富返回")]
        CMD_GetWealthResponse = 1024,
        /// <summary>
        /// 查询个人信息
        /// </summary>
        [EnumMember]
        [Description("查询个人信息")]
        CMD_GetUserInfoRequest = 1027,  // 查询个人信息
        /// <summary>
        /// 查询个人信息返回
        /// </summary>
        [EnumMember]
        [Description("查询个人信息返回")]
        CMD_GetUserInfoResponse = 1028,
        /// <summary>
        /// 修改用户名
        /// </summary>
        [EnumMember]
        [Description("修改用户名")]
        CMD_ChangeAliasRequest = 1100,   // 修改用户名
        /// <summary>
        /// 修改用户名返回
        /// </summary>
        [EnumMember]
        [Description("修改用户名返回")]
        CMD_ChangeAliasResponse = 1101,
        /// <summary>
        /// 查询用户可以加入的所有房间
        /// </summary>
        [EnumMember]
        [Description("查询用户可以加入的所有房间")]
        CMD_QueryUserLinkRoomRequest = 1102,   // 查询用户可以加入的所有房间
        /// <summary>
        /// 查询用户可以加入的所有房间返回
        /// </summary>
        [EnumMember]
        [Description("查询用户可以加入的所有房间返回")]
        CMD_QueryUserLinkRoomResponse = 1103,
        /// <summary>
        /// 获取哪些用户发出了进入房间申请
        /// </summary>
        [EnumMember]
        [Description("获取哪些用户发出了进入房间申请")]
        CMD_GetERoomReqUsersRequest = 1104,   // 获取哪些用户发出了进入房间申请
        /// <summary>
        /// 获取哪些用户发出了进入房间申请返回
        /// </summary>
        [EnumMember]
        [Description("获取哪些用户发出了进入房间申请返回")]
        CMD_GetERoomReqUsersResponse = 1105,
        /// <summary>
        /// 是否允许玩家进入房间
        /// </summary>
        [EnumMember]
        [Description("是否允许玩家进入房间")]
        CMD_SetERoomReqStateRequest = 1106,   // 是否允许玩家进入房间
        /// <summary>
        /// 是否允许玩家进入房间返回
        /// </summary>
        [EnumMember]
        [Description("是否允许玩家进入房间返回")]
        CMD_SetERoomReqStateResponse = 1107,
        /// <summary>
        /// 房间中玩家信息
        /// </summary>
        [EnumMember]
        [Description("房间中玩家信息")]
        CMD_RoomPlayersNotify = 1108,   // 房间中玩家信息
        /// <summary>
        /// 获取用户在指定房间中的积分
        /// </summary>
        [EnumMember]
        [Description("获取用户在指定房间中的积分")]
        CMD_GetUserRoomJiFenRequest = 1109,    // 获取用户在指定房间中的积分
        /// <summary>
        /// 获取用户在指定房间中的积分返回
        /// </summary>
        [EnumMember]
        [Description("获取用户在指定房间中的积分返回")]
        CMD_GetUserRoomJiFenResponse = 1110,

        /// <summary>
        /// 申请绑定群主
        /// </summary>
        [EnumMember]
        [Description("申请绑定群主")]
        CMD_BindUpAgentRequest = 1035,      // 申请绑定群主
        /// <summary>
        /// 申请绑定群主返回
        /// </summary>
        [EnumMember]
        [Description("申请绑定群主返回")]
        CMD_BindUpAgentResponse = 1036,
        /// <summary>
        /// 取消绑定群主申请
        /// </summary>
        [EnumMember]
        [Description("取消绑定群主申请")]
        CMD_BindUpAgentCancelRequest = 1037, // 取消绑定群主申请
        /// <summary>
        /// 取消绑定群主申请返回
        /// </summary>
        [EnumMember]
        [Description("取消绑定群主申请返回")]
        CMD_BindUpAgentCancelResponse = 1038,
        /// <summary>
        /// 有新用户提出了绑定群主申请
        /// </summary>
        [EnumMember]
        [Description("有新用户提出了绑定群主申请")]
        CMD_NewUserReqBindResponse = 1039,  // 有新用户提出了绑定群主申请
        /// <summary>
        /// 是否同意申请绑定群主
        /// </summary>
        [EnumMember]
        [Description("是否同意申请绑定群主")]
        CMD_BindUpAgentNotify = 1040,       // 是否同意申请绑定群主
        /// <summary>
        /// 获取申请绑定群主
        /// </summary>
        [EnumMember]
        [Description("获取申请绑定群主")]
        CMD_GetReqBindUpAgentsRequest = 1041, // 获取申请绑定群主
        /// <summary>
        /// 获取申请绑定群主返回
        /// </summary>
        [EnumMember]
        [Description("获取申请绑定群主返回")]
        CMD_GetReqBindUpAgentsResponse = 1042, // UserBaseInfoItems
        /// <summary>
        /// 获取哪些用户提出了绑定群主申请
        /// </summary>
        [EnumMember]
        [Description("获取哪些用户提出了绑定群主申请")]
        CMD_GetReqBindUsersRequest = 1043,    // 获取哪些用户提出了绑定群主申请
        /// <summary>
        /// 获取哪些用户提出了绑定群主申请返回
        /// </summary>
        [EnumMember]
        [Description("获取哪些用户提出了绑定群主申请返回")]
        CMD_GetReqBindUsersResponse = 1044,   // 循环发送 UserBaseInfoItems
        /// <summary>
        /// 获取下分列表
        /// </summary>
        [EnumMember]
        [Description("获取下分列表")]
        CMD_GetXiaFenReqListRequest = 1111,   // 获取下分列表
        /// <summary>
        /// 获取下分列表返回
        /// </summary>
        [EnumMember]
        [Description("获取下分列表返回")]
        CMD_GetXiaFenReqResponse = 1112,
        /// <summary>
        /// 是否同意用户下分
        /// </summary>
        [EnumMember]
        [Description("是否同意用户下分")]
        CMD_ReviewXiaFenRequest = 1113,     // 是否同意用户下分
        /// <summary>
        /// 是否同意用户下分返回
        /// </summary>
        [EnumMember]
        [Description("是否同意用户下分返回")]
        CMD_ReviewXiaFenResponse = 1114,
        /// <summary>
        /// 修改房间参数
        /// </summary>
        [EnumMember]
        [Description("修改房间参数")]
        CMD_ChangeRoomArgsRequest = 1115,   // 修改房间参数
        /// <summary>
        /// 修改房间参数返回
        /// </summary>
        [EnumMember]
        [Description("修改房间参数返回")]
        CMD_ChangeRoomArgsResponse = 1116,
        /// <summary>
        /// 修改房间参数通知
        /// </summary>
        [EnumMember]
        [Description("修改房间参数通知")]
        CMD_ChangeRoomArgsNotify = 1117,
        /// <summary>
        /// 查询房间在线人数
        /// </summary>
        [EnumMember]
        [Description("查询房间在线人数")]
        CMD_QueryRoomOnlineNumRequest = 1118,   // 查询房间在线人数
        /// <summary>
        /// 查询房间在线人数返回
        /// </summary>
        [EnumMember]
        [Description("查询房间在线人数返回")]
        CMD_QueryRoomOnlineNumResponse = 1119,
        /// <summary>
        /// 查询个人信息
        /// </summary>
        [EnumMember]
        [Description("查询个人信息")]
        CMD_QueryUserInfoRequest = 1120,  // 查询个人信息
        /// <summary>
        /// 查询个人信息返回
        /// </summary>
        [EnumMember]
        [Description("查询个人信息返回")]
        CMD_QueryUserInfoResponse = 1121,
        /// <summary>
        /// 金币赠送
        /// </summary>
        [EnumMember]
        [Description("金币赠送")]
        CMD_ZSGoldsRequest = 1122,        // 金币赠送
        /// <summary>
        /// 金币赠送返回
        /// </summary>
        [EnumMember]
        [Description("金币赠送返回")]
        CMD_ZSGoldsResponse = 1123,
        /// <summary>
        /// 金币赠送通知
        /// </summary>
        [EnumMember]
        [Description("金币赠送通知")]
        CMD_ZSGoldsNotify = 1124,
        /// <summary>
        /// 申请提现
        /// </summary>
        [EnumMember]
        [Description("申请提现")]
        CMD_TiXianRequest = 1125,         // 申请提现
        /// <summary>
        /// 申请提现返回
        /// </summary>
        [EnumMember]
        [Description("申请提现返回")]
        CMD_TiXianResponse = 1126,
        /// <summary>
        /// 留言
        /// </summary>
        [EnumMember]
        [Description("留言")]
        CMD_LiuYanRequest = 1127,         // 留言
        /// <summary>
        /// 留言返回
        /// </summary>
        [EnumMember]
        [Description("留言返回")]
        CMD_LiuYanResponse = 1128,
        /// <summary>
        /// 修改用户头像
        /// </summary>
        [EnumMember]
        [Description("修改用户头像")]
        CMD_ChangeHeadIcoRequest = 1129,   // 修改用户头像
        /// <summary>
        /// 修改用户头像返回
        /// </summary>
        [EnumMember]
        [Description("修改用户头像返回")]
        CMD_ChangeHeadIcoResponse = 1130,
        /// <summary>
        /// 绑定银行卡
        /// </summary>
        [EnumMember]
        [Description("绑定银行卡")]
        CMD_BindBankCardRequest = 1131,   //  绑定银行卡
        /// <summary>
        /// 绑定银行卡返回
        /// </summary>
        [EnumMember]
        [Description("绑定银行卡返回")]
        CMD_BindBankCardResponse = 1132,
        /// <summary>
        /// 绑定支付宝
        /// </summary>
        [EnumMember]
        [Description("绑定支付宝")]
        CMD_BindZFBRequest = 1133,        //  绑定支付宝
        /// <summary>
        /// 绑定支付宝返回
        /// </summary>
        [EnumMember]
        [Description("绑定支付宝返回")]
        CMD_BindZFBResponse = 1134,
        /// <summary>
        /// 获取排行榜
        /// </summary>
        [EnumMember]
        [Description("获取排行榜")]
        CMD_GetPHBDataRequest = 1135,     // 获取排行榜
        /// <summary>
        /// 获取排行榜返回
        /// </summary>
        [EnumMember]
        [Description("获取排行榜返回")]
        CMD_GetPHBDataResponse = 1136,
        /// <summary>
        /// 查询邀请人返水
        /// </summary>
        [EnumMember]
        [Description("查询邀请人返水")]
        CMD_QueryReturnWaterRequest = 1137, // 查询邀请人返水
        /// <summary>
        /// 查询邀请人返水返回
        /// </summary>
        [EnumMember]
        [Description("查询邀请人返水返回")]
        CMD_QueryReturnWaterResponse = 1138,
        /// <summary>
        /// 查询游戏记录
        /// </summary>
        [EnumMember]
        [Description("查询游戏记录")]
        CMD_QueryGameLogsRequest = 1139,    // 查询游戏记录
        /// <summary>
        /// 查询游戏记录返回
        /// </summary>
        [EnumMember]
        [Description("查询游戏记录返回")]
        CMD_QueryGameLogsResponse = 1140,
        /// <summary>
        /// 绑定手机号
        /// </summary>
        [EnumMember]
        [Description("绑定手机号")]
        CMD_BindPhoneRequest = 1141,     // 绑定手机号
        /// <summary>
        /// 绑定手机号返回
        /// </summary>
        [EnumMember]
        [Description("绑定手机号返回")]
        CMD_BindPhoneResponse = 1142,
        /// <summary>
        /// 获取用户金币
        /// </summary>
        [EnumMember]
        [Description("获取用户金币")]
        CMD_GetUserGoldsRequest = 1143,  // 获取用户金币
        /// <summary>
        ///获取用户金币返回
        /// </summary>
        [EnumMember]
        [Description("获取用户金币返回")]
        CMD_GetUserGoldsResponse = 1144,
        /// <summary>
        ///申请成为代理
        /// </summary>
        [EnumMember]
        [Description("申请成为代理")]
        CMD_DaiLiRequest = 1145,    // 申请成为代理
        /// <summary>
        ///申请成为代理返回
        /// </summary>
        [EnumMember]
        [Description("申请成为代理返回")]
        CMD_DaiLiResponse = 1146,
        /// <summary>
        ///代理转账
        /// </summary>
        [EnumMember]
        [Description("代理转账")]
        CMD_DaiLiZZRequest = 1147,  // 代理转账
        /// <summary>
        ///代理转账返回
        /// </summary>
        [EnumMember]
        [Description("代理转账返回")]
        CMD_DaiLiZZResponse = 1148,
        /// <summary>
        ///获取验证码
        /// </summary>
        [EnumMember]
        [Description("获取验证码")]
        CMD_GetSMSCodeRequest = 1149, // 获取验证码
        /// <summary>
        ///获取验证码返回
        /// </summary>
        [EnumMember]
        [Description("获取验证码返回")]
        CMD_GetSMSCodeResponse = 1150,
        /// <summary>
        ///修改登录密码
        /// </summary>
        [EnumMember]
        [Description("修改登录密码")]
        CMD_ChgPhonePwdResponse = 1151, // 修改登录密码

        #endregion

        #region 干子宝

        #endregion

        #region 蚕豆

        #endregion

        #region 龙虎斗        
        /// <summary>
        ///最大押注用户改变通知
        /// </summary>
        [EnumMember]
        [Description("最大押注用户改变通知")]
        CMD_LHD_MaxStakeNotify = 8001,
        /// <summary>
        ///最大赢家用户改变通知
        /// </summary>
        [EnumMember]
        [Description("最大赢家用户改变通知")]
        CMD_LHD_MaxWinNotify = 8002,       // 最大赢家用户改变
        #endregion
    }
}
