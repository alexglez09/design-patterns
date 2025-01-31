using Visitor.Models;

namespace Visitor.Visitor.Visitors
{
    public class DiscountVisitor : IVisitor
    {
        private decimal savings;

        public void VisitBook(Book book)
        {
            var discount = 0.10m;

            savings += discount * book.Price;
        }

        public void VisitVinyl(Vinyl vinyl)
        {
            var discount = 0.25m;

            savings += discount * vinyl.Price;
        }

        public string CreateReport()
        {
            return $"You saved a total of ${savings} on today's order.";
        }
    }
}
