﻿using System;
using System.Collections.Generic;
using System.Text;
using Ketchup.Zero.Application.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace Ketchup.Zero.Application.Seed
{
    public class SeedMenu : IEntityTypeConfiguration<SysMenu>
    {
        public void Configure(EntityTypeBuilder<SysMenu> builder)
        {
            builder.HasData(new SysMenu
            {
                Id = 1,
                ParentId = 99999,
                Level = 1,
                Name = "基础数据管理",
                Operates = JsonConvert.SerializeObject(new List<int>()),
                Sort = 0,
                Url = "/"
            }, new SysMenu()
            {
                Id = 2,
                ParentId = 1,
                Level = 2,
                Name = "按钮管理",
                Url = "operate",
                Operates = JsonConvert.SerializeObject(new List<int> { 1, 2, 3, 4 }),
                Sort = 1,
            }, new SysMenu()
            {
                Id = 3,
                ParentId = 1,
                Level = 2,
                Name = "角色管理",
                Url = "role",
                Operates = JsonConvert.SerializeObject(new List<int> { 1, 2, 3, 4 }),
                Sort = 2,
            }, new SysMenu()
            {
                Id = 4,
                ParentId = 1,
                Level = 2,
                Name = "菜单管理",
                Url = "menu",
                Operates = JsonConvert.SerializeObject(new List<int> { 1, 2, 3, 4 }),
                Sort = 3,
            }, new SysMenu()
            {
                Id = 5,
                ParentId = 1,
                Level = 2,
                Name = "系统用户",
                Url = "sysUser",
                Operates = JsonConvert.SerializeObject(new List<int> { 1, 2, 3, 4 }),
                Sort = 4,
            });
        }
    }
}
