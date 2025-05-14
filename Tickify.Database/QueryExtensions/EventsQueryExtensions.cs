using Microsoft.IdentityModel.Tokens;
using Tickify.Database.Dtos;
using Tickify.Database.Entities;
using Tickify.Database.Enums;

namespace Tickify.Database.QueryExtensions
{
    public static class EventsQueryExtensions
    {

        public static IQueryable<Event> FilterByEventStartDate(this IQueryable<Event> query, DateRangeDto dateRange)
        {
            if (dateRange == null)
                return query;

            return query
                .Where(e => e.StartDate >= dateRange.StartDate)
                .Where(e => e.StartDate <= dateRange.EndDate);
        }

        public static IQueryable<Event> SearchBy(this IQueryable<Event> query, string searchValue)
        {
            if (searchValue.IsNullOrEmpty())
                return query;

            return query
                .Where(e => e.Name.Contains(searchValue));
        }

        public static IQueryable<Event> SortBy(this IQueryable<Event> query, EventsSortingDto sortingOption)
        {
            if (sortingOption == null)
                return query;

            if (sortingOption.Criterion == EventsSortingCriteria.EventName)
            {
                if (sortingOption.Order == SortingOrder.Ascending)
                    return query.OrderBy(e => e.Name);
                else if (sortingOption.Order == SortingOrder.Descending)
                    return query.OrderByDescending(e => e.Name);
            }
            else if (sortingOption.Criterion == EventsSortingCriteria.EventStartDate)
            {
                if (sortingOption.Order == SortingOrder.Ascending)
                    return query.OrderBy(e => e.StartDate);
                else if (sortingOption.Order == SortingOrder.Descending)
                    return query.OrderByDescending(e => e.StartDate);
            }

            return query;
        }
    }
}
