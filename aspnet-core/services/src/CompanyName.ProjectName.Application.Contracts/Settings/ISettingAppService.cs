﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EasyAbp.Abp.SettingUi.Dto;
using Volo.Abp.Application.Services;

namespace CompanyName.ProjectName.Settings
{
    public interface ISettingAppService : IApplicationService
    {
        /// <summary>
        /// 获取setting信息
        /// </summary>
        /// <returns></returns>
        Task<List<SettingGroup>> GetAsync();
        
        /// <summary>
        /// 更新setting
        /// </summary>
        /// <returns></returns>
        Task UpdateAsync(UpdateSettingInput input);
    }
}