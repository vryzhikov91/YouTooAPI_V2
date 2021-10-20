using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YouTooAPI_V2.Models;

namespace YouTooAPI_V2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupsController : ControllerBase
    {
        public GroupsController()
        {
        }

        /// <summary>
        /// Get group by id
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpGet("{id}")]
        public IEnumerable<BaseResponse<GroupOutputModel>> Get(int Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete group by id
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpDelete("{eventId:int}")]
        public IEnumerable<BaseResponse<Guid>> Delete(int eventId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get All groups
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpGet]
        public IEnumerable<BaseResponseList<GroupOutputModel>> Get()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update group information
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Group ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public Task<BaseResponse<Guid>> Update([FromBody] GroupInputModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create group 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Group ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut]
        public Task<BaseResponse<Guid>> Create([FromBody] GroupInputModel model)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Base group input model
    /// </summary>
    public class GroupInputModel
    {
        public int? GroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Administrators { get; set; }
        public int MembersCount { get; set; }
        public int PhotoId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class GroupOutputModel
    {
        public int? GroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Administrators { get; set; }
        public int MembersCount { get; set; }
        public int PhotoId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }
}