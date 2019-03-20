﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace MM.Common
{
    /// <summary>
    /// 公共配置
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 信息
        /// </summary>
        [JsonProperty("info")]
        public Info Info = new Info();

        /// <summary>
        /// 脚本
        /// </summary>
        [JsonProperty("script")]
        public Script Script { get; set; }

        /// <summary>
        /// 改变配置
        /// </summary>
        public void Change()
        {
            Info.App = Info.App.ToLower();
            Info.Type = Info.Type.ToLower();
            Info.Name = Info.Name.ToLower();
            if (Info.Dir == null && Script != null)
            {
                Info.Dir = Script.File.ToStr();
            }
        }
    }
}

