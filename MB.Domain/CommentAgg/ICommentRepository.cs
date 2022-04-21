using MB.Application.Contracts.Comment;
using System.Collections.Generic;

namespace MB.Domain.CommentAgg
{
    public interface ICommentRepository
    {
        void CreateAndSave(Comment comment);
        List<CommentViewModel> GetList();
        Comment Get(long id);
        void Save();
    }
}
