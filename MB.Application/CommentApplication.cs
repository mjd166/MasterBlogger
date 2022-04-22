using _01_Framework.Infrastructure;
using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;
using System.Collections.Generic;

namespace MB.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICommentRepository _commentRepository;

        public CommentApplication(ICommentRepository commentRepository, IUnitOfWork unitOfWork)
        {
            _commentRepository = commentRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Add(AddComment command)
        {
            unitOfWork.BeginTran();
            var comment = new Comment(command.Name, command.Email, command.Message, command.ArticleId);
            _commentRepository.Create(comment);
            unitOfWork.CommitTran();
        }

        public void Cancel(long id)
        {
            unitOfWork.BeginTran();
            var comment = _commentRepository.Get(id);
            comment.Cancel();
            unitOfWork.CommitTran();
        }

        public void Confirm(long id)
        {
            unitOfWork.BeginTran();
            var comment = _commentRepository.Get(id);
            comment.Confirm();
            unitOfWork.CommitTran();
        }

        public List<CommentViewModel> GetList()
        {
            return _commentRepository.GetList();
        }
    }
}
