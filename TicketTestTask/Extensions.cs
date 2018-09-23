using System.Linq;

namespace TicketTestTask
{
    public static class Extensions
    {
        public static bool IsEmptyOrWhiteSpace(this string value) => value.All(char.IsWhiteSpace);
    }
}
