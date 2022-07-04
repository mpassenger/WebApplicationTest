﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public class ContentViewModel
    {
        /// <summary>
        /// 内容列表
        /// </summary>
        public List<Content> Contents { get; set; }
    }
    public class Content
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string InContent { get; set; }
        /// <summary>
        /// 状态 1正常 0删除
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Add_time { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime Modify_time { get; set; }
    }
}
