using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YouTooAPI_V2.Models;

namespace YouTooAPI_V2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupMembersController : ControllerBase
    {
        public GroupMembersController()
        {
        }

        /// <summary>
        /// Delete groupMember by id
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpDelete("{eventId:int}")]
        public IEnumerable<IActionResult> Delete(int eventId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get All groupMembers
        /// </summary>
        /// <returns>Base response GroupMember dto</returns>
        [HttpGet]
        public IEnumerable<BaseResponseList<GroupMemberOutputModel>> Get([FromBody] BaseRequest<GroupMemberFilter> request)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update groupMember information
        /// </summary>
        /// <param name="model"></param>
        /// <returns>GroupMember ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public Task<BaseResponse<Guid>> Update([FromBody] GroupMemberInputModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create groupMember 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>GroupMember ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut]
        public Task<BaseResponse<Guid>> Create([FromBody] GroupMemberInputModel model)
        {
            throw new NotImplementedException();
        }
        
    }

    public class GroupMemberFilter
    {
        public int GroupId { get; set; }
        public MemberStatus? MemberStatus { get; set; }
        public MemberRole? MemberRole { get; set; }
    }

    /// <summary>
    /// Base groupMember input model
    /// </summary>
    public class GroupMemberInputModel
    {
        public int GroupId { get; set; }
        public int? GroupMemberId { get; set; }
        public string Email { get; set; }
        public MemberStatus MemberStatus { get; set; }
        public MemberRole MemberRole { get; set; }
    }

    public enum MemberRole
    {
        Member,
        Administrator,
        Owner
    }


    public class GroupMemberOutputModel
    {
        public int GroupId { get; set; }
        public int? GroupMemberId { get; set; }
        public string FullName { get; set; }
        public int ProfilePictureId { get; set; }
        public MemberStatus MemberStatus { get; set; }
        public MemberRole MemberRole { get; set; }
    }

    public enum MemberStatus
    {
        Active,
        Invited,
        Declined,
        Deleted
    }
}