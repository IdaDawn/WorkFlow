using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using OneWorkFlow.ComponentDemo;
using OneWorkFlow.Controllers;
using OneWorkFlow.Web.Models.Components;

namespace OneWorkFlow.Web.Mvc.Controllers
{
    public class ComponentsController : OneWorkFlowControllerBase
    {
        private readonly IComponentInfoAppService _componentInfoAppService;
        public ComponentsController(IComponentInfoAppService componentInfoAppService)
        {
            _componentInfoAppService = componentInfoAppService;
        }
        public async Task<IActionResult> Index()
        {
            var componentInfos = (await _componentInfoAppService.GetAll(new PagedAndSortedResultRequestDto())).Items;
            var model = new ComponentsListViewModel
            {
                ComponentInfos = componentInfos
            };
            return View(model);
        }

        public async Task<IActionResult> EditComponentModal(int cId)
        {
            var output = await _componentInfoAppService.Get(new EntityDto(cId));
            var model = new EditComponentModalViewModel(output);
            return View("_EditComponentModal", model);
        }
    }
}