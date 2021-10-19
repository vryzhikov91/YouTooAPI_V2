using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YouTooAPI_V2.Models;

namespace YouTooAPI_V2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        public PostsController()
        {
        }

        /// <summary>
        /// Get delete by id
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpGet("{deleteId}")]
        public IEnumerable<BaseResponse<PostOutputModel>> Get(int deleteId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete delete by id
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpDelete("{eventId:int}")]
        public IEnumerable<IActionResult> Delete(int eventId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get All deletes
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpGet]
        public IEnumerable<BaseResponseList<PostOutputModel>> Get()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update delete information
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Post ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public Task<IActionResult> Update([FromBody] PostInputModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create delete 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Post ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut]
        public Task<IActionResult> Create([FromBody] PostInputModel model)
        {
            throw new NotImplementedException();
        }
    }

    public class PostQuestionInput
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }

    public class PostQuestionOutput
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        /// <summary>
        /// asked member Id
        /// </summary>
        public int AskedBy { get; set; }

        /// <summary>
        /// asked member id
        /// </summary>
        public int AnsweredBy { get; set; }
    }

    /// <summary>
    /// Base delete input model
    /// </summary>
    public class PostInputModel
    {
        public int PostId { get; set; }
        public int GroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PostStatus PostStatus { get; set; }
        public DateTime? PostStatusUpdatedOnUtc { get; set; }
    }

    public enum PostStatus
    {
        Draft,
        Active,
        Canceled
    }

    /// <summary>
    /// 
    /// </summary>
    public class PostOutputModel
    {
        public int PostId { get; set; }
        public int GroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PostStatus PostStatus { get; set; }
        public DateTime? PostStatusUpdatedOnUtc { get; set; }
    }
}