using Visitor.Models;

namespace Visitor.Visitor.Visitors
{
    public class SalesVisitor : IVisitor
    {
        private int bookCount = 0;
        private int vinylCount = 0;

        public void VisitBook(Book book)
        {
            bookCount++;
        }

        public void VisitVinyl(Vinyl vinyl)
        {
            vinylCount++;
        }

        public string CreateReport()
        {
            return $"Books sold: {bookCount}. Vinyl sold: {vinylCount}.";
        }
    }
}
