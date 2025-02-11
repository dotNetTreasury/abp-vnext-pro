﻿using System.Threading.Tasks;
using CompanyName.ProjectName.DataDictionaryManagement.DataDictionaries.Dtos;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CompanyName.ProjectName.DataDictionaryManagement.DataDictionaries
{
    [Route("DataDictionary")]
    public class DataDictionaryController : DataDictionaryManagementController, IApplicationService
    {
        private readonly IDataDictionaryAppService _dataDictionaryAppService;

        public DataDictionaryController(IDataDictionaryAppService dataDictionaryAppService)
        {
            _dataDictionaryAppService = dataDictionaryAppService;
        }

        [HttpPost("page")]
        [SwaggerOperation(summary: "分页字典类型", Tags = new[] { "DataDictionary" })]
        public  Task<PagedResultDto<PagingDataDictionaryOutput>> GetPagingListAsync(
            PagingDataDictionaryInput input)
        {
            return _dataDictionaryAppService.GetPagingListAsync(input);
        }

        [HttpPost("page/detail")]
        [SwaggerOperation(summary: "分页字典明细", Tags = new[] { "DataDictionary" })]
        public  Task<PagedResultDto<PagingDataDictionaryDetailOutput>> GetPagingDetailListAsync(
            PagingDataDictionaryDetailInput input)
        {
            return _dataDictionaryAppService.GetPagingDetailListAsync(input);
        }

        [HttpPost("create")]
        [SwaggerOperation(summary: "创建字典类型", Tags = new[] { "DataDictionary" })]
        public Task CreateAsync(CreateDataDictinaryInput input)
        {
            return _dataDictionaryAppService.CreateAsync(input);
        }

        [HttpPost("createDetail")]
        [SwaggerOperation(summary: "创建字典明细", Tags = new[] { "DataDictionary" })]
        public  Task CreateDetailAsync(CreateDataDictinaryDetailInput input)
        {
            return _dataDictionaryAppService.CreateDetailAsync(input);
        }
        
        [HttpPost("status")]
        [SwaggerOperation(summary: "设置字典明细状态", Tags = new[] { "DataDictionary" })]
        public Task SetStatus(SetDataDictinaryDetailInput input)
        {
            return _dataDictionaryAppService.SetStatus(input);
        }
    }
}