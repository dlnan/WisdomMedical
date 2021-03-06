﻿namespace KMHC.SLTC.Business.Interface
{
    using KMHC.SLTC.Business.Entity.Base;
    using KMHC.SLTC.Business.Entity.Filter;
    using KMHC.SLTC.Business.Entity.Model;
    using System.Collections.Generic;

    public interface IGroupActivityCategoryService : IBaseService
    {
        #region DC_GroupActivityCategory
        /// <summary>
        /// 获取DC_ServiceGroup列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<IList<GroupActivityCategory>> QueryGroupActivity(BaseRequest<GroupActivityCategoryFilter> request);
        /// <summary>
        /// 获取DC_ServiceGroup
        /// </summary>
        /// <param name="serviceGroupID"></param>
        /// <returns></returns>
        //BaseResponse<ServiceGroupModel> GetServiceGroup(int serviceGroupID);
        /// <summary>
        /// 保存DC_ServiceGroup
        /// </summary>
        /// <param name="request"></param>
        //BaseResponse<ServiceGroupModel> SaveServiceGroup(ServiceGroupModel request);
        /// <summary>
        /// 删除DC_ServiceGroup
        /// </summary>
        /// <param name="serviceGroupID"></param>
        BaseResponse DeleteGroupActivityCategory(int serviceGroupID);
        #endregion
    }
}
