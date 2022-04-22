using MB.Application.Contracts.Comment;
using System.Collections.Generic;

using _01_Framework.Infrastructure;

namespace MB.Domain.CommentAgg
{
    public interface ICommentRepository: IRepository<long,Comment>
    {
        List<CommentViewModel> GetList();
    }
}
