﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI
{
    public abstract class BaseTestParameter
    {
        /// <summary>
        /// ipv4.fiddler地址是针对Fidder捕获本机http请求所设置的特殊地址，
        /// 相关知识:http://stackoverflow.com/questions/826134/how-to-display-localhost-traffic-in-fiddler-while-debugging-an-asp-net-applicati
        /// 若没有使用Fidder捕获需求可替换为localhost。
        /// </summary>
        public abstract string URL { get; }//end property

        /// <summary>
        /// 数据中心主键。
        /// 主键获取通过查询管理中心T_BAS_DATACENTER_L表获得。
        /// SELECT * FROM T_BAS_DATACENTER_L
        /// </summary>
        public abstract string DBId { get; }//end property

        /// <summary>
        /// 用户名。
        /// </summary>
        public abstract string UserName { get; }//end property

        /// <summary>
        /// 用户密码。
        /// </summary>
        public abstract string Password { get; }//end property

        /// <summary>
        /// 应用主键。
        /// </summary>
        public abstract string AppId { get; }//end property

        /// <summary>
        /// 应用密钥。
        /// </summary>
        public abstract string AppSecret { get; }//end property

    }
}
