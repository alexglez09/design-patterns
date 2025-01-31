using Visitor.Models;

namespace Visitor.Visitor
{
    public interface IVisitor
    {
        public void VisitBook(Book book);

        public void VisitVinyl(Vinyl vinyl);

        public string CreateReport();
    }
}
